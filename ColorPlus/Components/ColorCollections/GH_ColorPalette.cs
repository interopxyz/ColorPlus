using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace ColorPlus.Components
{
    public class GH_ColorPalettes : GH_ColorBase
    {
        /// <summary>
        /// Initializes a new instance of the GH_ColorCollections class.
        /// </summary>
        public GH_ColorPalettes()
          : base("Color Palettes", "Palette",
              "Get a list of colors from premade palettes from Windows, common web standards, and industry color sets.",
              "Display", "Colour")
        {
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.tertiary; }
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            base.RegisterInputParams(pManager);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Name", "N", "Resulting color names", GH_ParamAccess.list);
            pManager.AddColourParameter("Color", "C", "Resulting colors", GH_ParamAccess.list);
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

            GetCollectionColors(index, subIndex);

            DA.SetDataList(0, Names);
            DA.SetDataList(1, Colors);
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
                return Properties.Resources.ColorPlus_Palette_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("a487b0f7-1aaa-438c-b79e-6258ee5469a0"); }
        }
    }
}