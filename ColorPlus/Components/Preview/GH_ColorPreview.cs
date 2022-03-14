using System;
using System.Collections.Generic;
using Sd = System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using System.Windows.Forms;
using System.Drawing;
using Grasshopper.Kernel.Parameters;
using Grasshopper.Kernel.Data;
using System.Linq;

namespace ColorPlus.Components.Preview
{

    public class GH_ColorPreview : GH_Component, IGH_VariableParameterComponent
    {
        public List<Sd.Color> backgrounds = new List<Sd.Color>();
        public int Width = 49;
        public int Height = 26;
        public bool HasBorder = true;

        /// <summary>
        /// Initializes a new instance of the GH_Ai_PreviewColor class.
        /// </summary>
        public GH_ColorPreview()
          : base("Preview Colors", "PrevClr",
                "Previews a list of Colors as swatches",
                "Display", "Preview")
        {
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.hidden; }
        }

        public override void CreateAttributes()
        {
            backgrounds = new List<Sd.Color>();
            Width = 49;
            Height = 26;
            m_attributes = new ColorsAttributes_Custom(this);
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddColourParameter("Colors", " ", "Input Colors", GH_ParamAccess.list);
            pManager[0].Optional = true;
        }
        public bool CanInsertParameter(GH_ParameterSide side, int index) { return false; }
        public bool CanRemoveParameter(GH_ParameterSide side, int index) { return false; }

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

        private void ClearOutputs()
        {
            int currentCount = Params.Output.Count;
            int newCount = backgrounds.Count;

            for (int i = 0; i < (currentCount - newCount); i++)
            {
                int index = currentCount - i - 1;
                List<IGH_Param> rec = Params.Output[index].Recipients.ToList();
                Params.Output[index].Recipients.Clear();
                Params.Output[index].ClearData();
                DestroyParameter(GH_ParameterSide.Output, index);
                Params.UnregisterOutputParameter(Params.Output[index]);
                for (int j =0;j<rec.Count;j++)
                {
                    rec[rec.Count-1-j].RemoveSource(Params.Output[index]);
                }
            }

        }

        private void AddColorParameters()
        {
            int currentCount = Params.Output.Count;
            int newCount = backgrounds.Count;

            for (int i = currentCount; i < newCount; i++)
            {
                Params.RegisterOutputParam(CreateParameter(GH_ParameterSide.Output, i));
            }

        }

        private void SetParamProperties()
        {
            if (backgrounds.Count > 0)
            {
                int currentCount = backgrounds.Count;
                GH_Path path = Params.Input[0].VolatileData.Paths[Params.Input[0].VolatileData.LongestPathIndex()];
                for (int i = 0; i < currentCount; i++)
                {
                    Color color = backgrounds[i];
                    Params.Output[i].Name = ColorTranslator.ToHtml(color);
                    Params.Output[i].NickName = " ";
                    Params.Output[i].Description = i + " | " + color.ToString();
                    Params.Output[i].Access = GH_ParamAccess.item;
                    Params.Output[i].AddVolatileData(path,0, color);
                }
            }
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            base.AppendAdditionalMenuItems(menu);
            Menu_AppendSeparator(menu);

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

        public override bool Write(GH_IO.Serialization.GH_IWriter writer)
        {
            writer.SetInt32("Width", Width);
            writer.SetBoolean("Border", HasBorder);

            return base.Write(writer);
        }
        public override bool Read(GH_IO.Serialization.GH_IReader reader)
        {
            Width = reader.GetInt32("Width");
            HasBorder = reader.GetBoolean("Border");

            return base.Read(reader);
        }

        public IGH_Param CreateParameter(GH_ParameterSide side, int index)
        {
            return new Param_Colour
            {
                Access = GH_ParamAccess.item
            };
        }

        public bool DestroyParameter(GH_ParameterSide side, int index)
        {
            return true;
        }

        public void VariableParameterMaintenance()
        {
            int currentCount = Params.Output.Count;
            int newCount = backgrounds.Count;

            ClearOutputs();
            AddColorParameters();
            SetParamProperties();
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.ColorPlus_Preview_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("3067fcfd-4f85-4af9-a412-41f00a93fd1e"); }
        }
    }


    public class ColorsAttributes_Custom : GH_ComponentAttributes
    {
        public ColorsAttributes_Custom(GH_Component owner) : base(owner) { }

        private Sd.Rectangle ButtonBounds { get; set; }
        protected override void Layout()
        {
            base.Layout();
            GH_ColorPreview comp = Owner as GH_ColorPreview;

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
            GH_ColorPreview comp = Owner as GH_ColorPreview;

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
                        Sd.RectangleF fillRectangle = new Sd.RectangleF(ButtonBounds.Left, ButtonBounds.Top + i * (comp.Height - 6), ButtonBounds.Width, (comp.Height - 6));
                        Sd.Rectangle borderRectangle = new Sd.Rectangle(ButtonBounds.Left, ButtonBounds.Top + i * (comp.Height - 6), ButtonBounds.Width, (comp.Height - 6));

                        graphics.FillRectangle(new Sd.SolidBrush(comp.backgrounds[i]), fillRectangle);

                        if (comp.HasBorder)
                        {
                            graphics.DrawRectangle(new Sd.Pen(Sd.Color.Black, 1), borderRectangle);
                        }
                        else
                        {
                            graphics.DrawRectangle(new Sd.Pen(comp.backgrounds[i], 1), borderRectangle);
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