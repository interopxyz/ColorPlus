﻿using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ColorPlus.Components.Operations
{
    public class GH_TweenColors : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GH_TweenColors class.
        /// </summary>
        public GH_TweenColors()
          : base("Tween Colors", "TweenClr",
              "Get a tweened color between a two colors",
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
            pManager.AddColourParameter("Source", "S", "Input source color", GH_ParamAccess.item);
            pManager.AddColourParameter("Target", "T", "Input target color", GH_ParamAccess.item);
            pManager.AddNumberParameter("Parameter", "P", "Unitized parameter (0-1)", GH_ParamAccess.item, 0.5);
            pManager[2].Optional = true;
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
            Color source = Color.Empty;
            if (!DA.GetData(0,ref source)) return;

            Color target = Color.Empty;
            if (!DA.GetData(1, ref target)) return;

            double parameter = 0.5;
            DA.GetData(2, ref parameter);

            DA.SetData(0, source.Tween(target,parameter));

        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.CP_Tween_01;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("128d3307-c6ea-48fd-80da-653519f978df"); }
        }
    }
}