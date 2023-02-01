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
          : base("Itemize Colors", "ClrItems",
                "Itemize a list of colors",
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
            pManager.AddColourParameter("Colors", "C", "Input Colors", GH_ParamAccess.list);
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
            if (!DA.GetDataList(0, colors)) return;
            backgrounds = colors;

            AddColorParameters();
            this.SetOutputs(DA);
        }

        private void AddColorParameters()
        {
            int currentCount = Params.Output.Count;
            int newCount = backgrounds.Count;

            for (int i = currentCount; i < newCount; i++)
            {
                Params.RegisterOutputParam(CreateParameter(GH_ParameterSide.Output, i));
            }

            for (int i = 0; i < currentCount; i++)
            {
                Color color = backgrounds[i];
                Params.Output[i].Name = ColorTranslator.ToHtml(color);
                Params.Output[i].NickName = ColorTranslator.ToHtml(color);
                Params.Output[i].Description = i + " | " + ColorTranslator.ToHtml(color);
            }

            for (int i = newCount; i < currentCount; i++)
            {
                //DestroyParameter(GH_ParameterSide.Output, this.Params.Output.Count-1);
                //this.Params.OnParametersChanged();
            }
        }

        private void SetParamProperties()
        {
            if (backgrounds.Count > 0)
            {
                for (int i = 0; i < backgrounds.Count; i++)
                {
                    Color color = backgrounds[i];
                    Params.Output[i].Name = ColorTranslator.ToHtml(color);
                    Params.Output[i].NickName = ColorTranslator.ToHtml(color);
                    Params.Output[i].Description = i + " | " + ColorTranslator.ToHtml(color);
                }
            }
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            base.AppendAdditionalMenuItems(menu);
            Menu_AppendSeparator(menu);

            Menu_AppendItem(menu, "Border", SetBorder, true, HasBorder);
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

        public void SetOutputs(IGH_DataAccess DA)
        {
                for (int i = 0; i < backgrounds.Count; i++)
                {
                    DA.SetData(i, backgrounds[i]);
                }
        }

        public IGH_Param CreateParameter(GH_ParameterSide side, int index)
        {
            IGH_Param outputParam = new Param_Colour
            {
                Access = GH_ParamAccess.item,
                Name = "Name",
                NickName = "N"
            };
            this.Params.RegisterOutputParam(outputParam, index);
            this.Params.OnParametersChanged();
            return outputParam;

        }

        public bool DestroyParameter(GH_ParameterSide side, int index)
        {
            this.Params.UnregisterOutputParameter(this.Params.Output[index]);
            this.Params.OnParametersChanged();
            return true;
        }

        public void VariableParameterMaintenance()
        {
            for (int i = 1; i < backgrounds.Count; i++)
            {
                IGH_Param outputParam = this.Params.Output[i];

                outputParam.Name = i.ToString();
                outputParam.NickName = i.ToString();
            }
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.CP_ColorItem_01;
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
            float inWidth = comp.Params.InputWidth;
            float outWidth = comp.Params.OutputWidth;
            int width = (int)(comp.Width + inWidth);
            int height = comp.Height;
            if (comp.backgrounds.Count > 0) height = (int)(comp.Height - 6) * comp.backgrounds.Count + 6;

            rec0.Width = width + 12;
            rec0.Height = height;

            Sd.Rectangle rec1 = rec0;
            rec1.X = rec1.Left + 3;
            rec1.Y = rec1.Bottom - height + 3;
            rec1.Height = height - 6;
            rec1.Width = width - 6;

            //Bounds = rec0;
            //ButtonBounds = rec1;
        }

        protected override void Render(GH_Canvas canvas, Sd.Graphics graphics, GH_CanvasChannel channel)
        {
            base.Render(canvas, graphics, channel);
            GH_ColorPreview comp = Owner as GH_ColorPreview;
            int inWidth = (int)comp.Params.InputWidth;
            int outWidth = (int)comp.Params.OutputWidth;

            if (channel == GH_CanvasChannel.Objects)
            {
                GH_Capsule capsule = GH_Capsule.CreateCapsule(ButtonBounds, GH_Palette.Normal, 0, 0);
                capsule.Render(graphics, Selected, Owner.Locked, true);
                capsule.Dispose();
                capsule = null;

                Sd.StringFormat format = new Sd.StringFormat();
                format.Alignment = Sd.StringAlignment.Center;
                format.LineAlignment = Sd.StringAlignment.Center;

                int count = comp.backgrounds.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Sd.RectangleF fillRectangle = new Sd.RectangleF((int)Bounds.Left + inWidth + 16, (int)Bounds.Top + i * (comp.Height - 6) + 6, 12, 12);
                        Sd.Rectangle borderRectangle = new Sd.Rectangle((int)Bounds.Left + inWidth + 16, (int)Bounds.Top + i * (comp.Height - 6) + 6, 12, 12);

                        graphics.FillEllipse(new Sd.SolidBrush(comp.backgrounds[i]), fillRectangle);

                        if (comp.HasBorder)
                        {
                            graphics.DrawEllipse(new Sd.Pen(Sd.Color.Black, 1), borderRectangle);
                        }
                        else
                        {
                            graphics.DrawEllipse(new Sd.Pen(comp.backgrounds[i], 1), borderRectangle);
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