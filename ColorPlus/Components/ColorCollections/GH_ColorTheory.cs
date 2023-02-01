using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ColorPlus.Components
{
    public class GH_ColorSets : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GH_Triad class.
        /// </summary>
        public GH_ColorSets()
          : base("Color Sets", "ClrSets",
              "Generate a color palette from a varity of color theory based groupings including Complimentary, Triad, Tetradic, and many more.",
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
            pManager.AddColourParameter("Color", "C", "Input color", GH_ParamAccess.item);
            pManager.AddIntegerParameter("Mode", "M", "The Grouping mode", GH_ParamAccess.item, 0);
            pManager[1].Optional = true;

            Param_Integer param = (Param_Integer)pManager[1];
            foreach (Harmony.Harmony.Schemes value in Enum.GetValues(typeof(Harmony.Harmony.Schemes)))
            {
                param.AddNamedValue(value.ToString(), (int)value);
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddColourParameter("Colors", "C", "Resulting colors", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Color color = Color.Empty;
            if (!DA.GetData(0, ref color)) return;

            int type = 0;
            DA.GetData(1, ref type);

            Harmony.Harmony.Schemes mode = (Harmony.Harmony.Schemes)type;

            Harmony.Harmony harmony = new Harmony.Harmony();
            List<Color> colors = harmony.Harmonize(color, mode).ToList();
            DA.SetDataList(0, colors);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.CP_ColorTheory_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("8ec276e6-78c0-4208-b884-eb73c5669301"); }
        }
    }
}