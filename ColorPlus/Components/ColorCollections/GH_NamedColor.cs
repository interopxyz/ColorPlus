using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ColorPlus.Components
{
    public class GH_NamedColor : GH_ColorBase
    {

        /// <summary>
        /// Initializes a new instance of the RalColors class.
        /// </summary>
        public GH_NamedColor()
          : base("Colour Name", "Named Clr",
              "Select a Color from existing palettes by name or index",
              "Display", "Colour")
        {
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.primary | GH_Exposure.obscure; }
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            base.RegisterInputParams(pManager);

            pManager.AddTextParameter("Name", "N", "Name of the Color", GH_ParamAccess.item);

        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Name", "N", "Resulting color name", GH_ParamAccess.item);
            pManager.AddColourParameter("Color", "C", "Resulting color", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int index = 0;
            if (!DA.GetData(0, ref index)) return;

            int subIndex = 0;
            if (!DA.GetData(1, ref subIndex)) return;

            string name = string.Empty;
            if (!DA.GetData(2, ref name)) return;

            GetCollectionColors(index, subIndex);

            if (Names.Contains(name))
            {
                int i = Names.IndexOf(name);
                DA.SetData(0, Names[i]);
                DA.SetData(1, Colors[i]);
            }
            else
            {
                this.AddRuntimeMessage(GH_RuntimeMessageLevel.Warning, "The color set does not contain a color named " + name);
            }

        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.CP_ColorName_01_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("c48792ee-34f2-4728-9298-b6920c495a5a"); }
        }
    }
}