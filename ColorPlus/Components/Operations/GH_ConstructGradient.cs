using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ColorPlus.Components.Operations
{
    public class GH_ConstructGradient : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GH_ConstructGradient class.
        /// </summary>
        public GH_ConstructGradient()
          : base("Construct Gradient", "ConstGrad",
              "Parametrically construct a gradient. ",
              "Display", "Colour")
        {
        }

        /// <summary>
        /// Set Exposure level for the component.
        /// </summary>
        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.quinary; }
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddColourParameter("Colors", "C", "Input Colors", GH_ParamAccess.list);
            pManager.AddNumberParameter("Parameter", "P", "Matching unitized parameters. If empty, the colors will be evenly distributed.", GH_ParamAccess.list);
            pManager[1].Optional = true;
            pManager.AddNumberParameter("Sample", "T", "Unitized sampling parameter 0-1", GH_ParamAccess.item,0.5);
            pManager[2].Optional = true;
            pManager.AddIntegerParameter("Interpolation Mode", "M", "Gradient interpolation mode", GH_ParamAccess.item, 0);
            pManager[3].Optional = true;

            Param_Integer param = (Param_Integer)pManager[3];
            param.AddNamedValue("Linear", 0);
            param.AddNamedValue("Blend", 1);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddColourParameter("Color", "C", "Resulting color", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<Color> colors = new List<Color>();
            if (!DA.GetDataList(0, colors)) return;

            List<double> parameters = new List<double>();
            DA.GetDataList(1, parameters);

            if (parameters.Count <1)
            {
                if (colors.Count == 1)
                {
                    colors.Add(colors[0]);
                }

                for(int i = 0; i < colors.Count; i++)
                {
                    parameters.Add(1.0 / (colors.Count-1) * i);
                }

            }

                if (colors.Count != parameters.Count)
                {
                    this.AddRuntimeMessage(GH_RuntimeMessageLevel.Warning, "The number of parameters must match the number of colors");
                    return;
                }



            Color[] arrColors = colors.ToArray();
            double[] arrParameters = parameters.ToArray();

            Array.Sort(arrParameters, arrColors);

            List<Color> sortedColors = arrColors.ToList();
            List<double> sortedParameters = arrParameters.ToList();

            if (sortedParameters[0] != 0)
            {
                sortedParameters.Insert(0,0);
                sortedColors.Insert(0, sortedColors[0]);
            }

            if (sortedParameters[sortedParameters.Count-1] != 1.0)
            {
                sortedParameters.Add(1.0);
                sortedColors.Add(sortedColors[sortedColors.Count - 1]);
            }

            double t = 0.5;
            DA.GetData(2, ref t);

            if (t >= 1)
            { 
                DA.SetData(0, sortedColors[sortedColors.Count-1]);
                return;
            }
            if (t <= 0)
            {
                DA.SetData(0, sortedColors[0]);
                return;
            }

            double closest = sortedParameters.Aggregate((x, y) => Math.Abs(x - t) < Math.Abs(y - t) ? x : y);

            int max = 1;
            int min = 0;
            if (closest >= t)
            {
                max = sortedParameters.IndexOf(closest);
                min = max - 1;
            }
            else
            {
                min = sortedParameters.IndexOf(closest);
                max = min + 1;
            }

            double param = (t - sortedParameters[min]) / (sortedParameters[max] - sortedParameters[min]);

            Color source = sortedColors[min];
            Color target = sortedColors[max];

            int type = 0;
            DA.GetData(3, ref type);

            switch (type)
            {
                default:
                    DA.SetData(0, source.Tween(target, param));
                    break;
                case 1:
                    DA.SetData(0, source.Blend(target, param));
                    break;
            }

            

        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.CP_GradientP_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("444bf971-da2c-45cb-b4df-b8d24de02e71"); }
        }
    }
}