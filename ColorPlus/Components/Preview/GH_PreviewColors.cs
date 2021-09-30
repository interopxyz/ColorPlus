using System;
using System.Collections.Generic;
using Sd = System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using Grasshopper.Kernel.Types;
using Rhino.Geometry;
using System.Windows.Forms;
using System.Drawing;
using Grasshopper.Kernel.Parameters;
using Grasshopper.Kernel.Data;
using System.Linq;

namespace ColorPlus.Components
{
    public class GH_PreviewColors : GH_Component
    {
        public List<Sd.Color> backgrounds = new List<Sd.Color>();
        public int Width = 100;
        public int Height = 26;
        public bool HasBorder = true;
        public bool HasLabel = true;

        /// <summary>
        /// Initializes a new instance of the GH_PreviewColors class.
        /// </summary>
        public GH_PreviewColors()
          : base("Preview Colors", "PrevClr",
                "Previews a list of Colors as swatches",
                "Display", "Preview")
        {
        }

        public override void CreateAttributes()
        {
            backgrounds = new List<Sd.Color>();
            Width = 100;
            Height = 26;
            m_attributes = new ColorsAttr_Custom(this);
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.quarternary | GH_Exposure.obscure; }
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddColourParameter("Colors", " ", "Input Colors", GH_ParamAccess.list);
            pManager[0].Optional = true;
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<Sd.Color> colors = new List<Sd.Color>();
            DA.GetDataList(0, colors);
            if (colors.Count == 0) colors.Add(Color.Transparent);

            backgrounds = colors;
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            base.AppendAdditionalMenuItems(menu);
            Menu_AppendSeparator(menu);

            Menu_AppendItem(menu, "Label", SetLabel, true, HasLabel);
            Menu_AppendItem(menu, "Border", SetBorder, true, HasBorder);

            //Width Number Picker
            var labelA = new Label { Text = "Width" };
            labelA.Margin = new Padding(0, 5, 0, 0);

            var numCtrlA = new NumericUpDown();
            numCtrlA.Width = 50;
            numCtrlA.Minimum = 49;
            numCtrlA.Maximum = 5000;
            numCtrlA.Value = (Decimal)Width;
            numCtrlA.ValueChanged -= (o, e) => { SetWidthOffset((int)numCtrlA.Value); };
            numCtrlA.ValueChanged += (o, e) => { SetWidthOffset((int)numCtrlA.Value); };

            FlowLayoutPanel menuItemA = new FlowLayoutPanel();
            menuItemA.FlowDirection = FlowDirection.LeftToRight;
            menuItemA.Height = 30;
            menuItemA.Controls.Add(numCtrlA);
            menuItemA.Controls.Add(labelA);

            Menu_AppendCustomItem(menu, menuItemA);

            //Height Number Picker
            var labelB = new Label { Text = "Height" };
            labelB.Margin = new Padding(0, 5, 0, 0);

            var numCtrlB = new NumericUpDown();
            numCtrlB.Width = 50;
            numCtrlB.Minimum = 10;
            numCtrlB.Maximum = 500;
            numCtrlB.Value = (Decimal)Height;
            numCtrlB.ValueChanged -= (o, e) => { SetHeightOffset((int)numCtrlB.Value); };
            numCtrlB.ValueChanged += (o, e) => { SetHeightOffset((int)numCtrlB.Value); };

            FlowLayoutPanel menuItemB = new FlowLayoutPanel();
            menuItemB.FlowDirection = FlowDirection.LeftToRight;
            menuItemB.Height = 30;
            menuItemB.Controls.Add(numCtrlB);
            menuItemB.Controls.Add(labelB);

            Menu_AppendCustomItem(menu, menuItemB);

        }

        public void SetLabel(Object sender, EventArgs e)
        {
            HasLabel = !HasLabel;
            this.ExpireSolution(true);
        }

        public void SetBorder(Object sender, EventArgs e)
        {
            HasBorder = !HasBorder;
            this.ExpireSolution(true);
        }

        public void SetWidthOffset(int value)
        {
            Width = value;
            this.ExpireSolution(true);
        }

        public void SetHeightOffset(int value)
        {
            Height = value;
            this.ExpireSolution(true);
        }

        public override bool Write(GH_IO.Serialization.GH_IWriter writer)
        {
            writer.SetInt32("Width", Width);
            writer.SetInt32("Height", Height);
            writer.SetBoolean("Border", HasBorder);
            writer.SetBoolean("Label", HasLabel);

            return base.Write(writer);
        }
        public override bool Read(GH_IO.Serialization.GH_IReader reader)
        {
            Width = reader.GetInt32("Width");
            Height = reader.GetInt32("Height");
            HasBorder = reader.GetBoolean("Border");
            HasLabel = reader.GetBoolean("Label");

            return base.Read(reader);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return Properties.Resources.ColorPlus_Preview_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("b87a9170-582b-4676-8afd-1c88a4de559d"); }
        }
    }


    public class ColorsAttr_Custom : GH_ComponentAttributes
    {
        public ColorsAttr_Custom(GH_Component owner) : base(owner) { }

        private Sd.Rectangle ButtonBounds { get; set; }
        protected override void Layout()
        {
            base.Layout();
            GH_PreviewColors comp = Owner as GH_PreviewColors;

            Sd.Rectangle rec0 = GH_Convert.ToRectangle(Bounds);

            int width = comp.Width;
            int height = comp.Height;
            if (comp.backgrounds.Count > 0) height = (int)(comp.Height - 6) * comp.backgrounds.Count + 6;

            rec0.Width = width;
            rec0.Height = height;

            Sd.Rectangle rec1 = rec0;
            rec1.X = rec1.Left + 3;
            rec1.Y = rec1.Bottom - height + 3;
            rec1.Height = height - 6;
            rec1.Width = width - 6;

            Bounds = rec0;
            ButtonBounds = rec1;

        }

        protected override void Render(GH_Canvas canvas, Sd.Graphics graphics, GH_CanvasChannel channel)
        {
            base.Render(canvas, graphics, channel);
            GH_PreviewColors comp = Owner as GH_PreviewColors;

            if (channel == GH_CanvasChannel.Objects)
            {
                GH_Capsule capsule = GH_Capsule.CreateCapsule(ButtonBounds, GH_Palette.Normal, 0, 0);
                capsule.Render(graphics, Selected, Owner.Locked, true);
                capsule.AddOutputGrip(comp.Width + this.OutputGrip.Y);
                capsule.Dispose();
                capsule = null;

                Sd.StringFormat format = new Sd.StringFormat();
                format.Alignment = Sd.StringAlignment.Center;
                format.LineAlignment = Sd.StringAlignment.Center;

                int count = comp.backgrounds.Count;
                if (count > 0)
                {
                    int height = (int)(comp.Height - 6);

                    for (int i = 0; i < count; i++)
                    {
                        float x = ButtonBounds.Left;
                        float y = ButtonBounds.Top + i * (comp.Height - 6);
                        Color solid = comp.backgrounds[i];

                        Sd.RectangleF fillRectangle = new Sd.RectangleF(x, y, ButtonBounds.Width, (comp.Height - 6));
                        Sd.Rectangle borderRectangle = new Sd.Rectangle((int)x, (int)y, ButtonBounds.Width, (comp.Height - 6));

                        graphics.FillRectangle(new Sd.SolidBrush(solid), fillRectangle);

                        if (comp.HasBorder)
                        {
                            graphics.DrawRectangle(new Sd.Pen(Sd.Color.Black, 1), borderRectangle);
                        }
                        else
                        {
                            graphics.DrawRectangle(new Sd.Pen(solid, 1), borderRectangle);
                        }

                        if (comp.HasLabel) { 
                        Color fontColor = Color.White;
                        if (solid.GetBrightness() > 0.5) fontColor = Color.Black;
                        Font font = new Font("Arial", (float)(comp.Height/3.0), FontStyle.Regular);
                        graphics.DrawString(ColorTranslator.ToHtml(comp.backgrounds[i]), font, new Sd.SolidBrush(fontColor), new PointF(x, y + 3));
                        }
                    }
                }
                else
                {
                    graphics.FillRectangle(new Sd.SolidBrush(Sd.Color.White), ButtonBounds);
                }

                format.Dispose();
            }
        }
    }
}