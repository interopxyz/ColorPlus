using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ColorPlus.Components.Conversions
{
    public class GH_ToHex : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GH_ToHex class.
        /// </summary>
        public GH_ToHex()
          : base("To Hex", "ToHex",
              "Gets the Hex value of a color",
              "Display", "Colour")
        {
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.secondary; }
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddColourParameter("Color", "C", "Input Color", GH_ParamAccess.item, Color.White);
            pManager[0].Optional = true;
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Hex", "H", "Hex string", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Color color = Color.White;
            if (!DA.GetData(0, ref color)) return;

            DA.SetData(0, ColorTranslator.ToHtml(color));
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
                return Properties.Resources.ColorPlus_ToHex_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("55665420-810f-4633-bc03-6b3ed45ead8a"); }
        }
    }
}