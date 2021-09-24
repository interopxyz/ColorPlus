using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace ColorPlus.Components
{
    public abstract class GH_ColorBase : GH_Component
    {
        protected List<int> Indices = new List<int>();
        protected List<string> Names = new List<string>();
        protected List<Color> Colors = new List<Color>();

        /// <summary>
        /// Initializes a new instance of the GH_ColorBase class.
        /// </summary>
        public GH_ColorBase()
          : base("GH_ColorBase", "Nickname",
              "Description",
              "Category", "Subcategory")
        {
        }

        public GH_ColorBase(string Name, string Nickname, string Description, string Category, string Subcategory) : base(Name, Nickname, Description, Category, Subcategory)
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
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
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("1309728d-1954-46a3-8856-fe8d6a50272a"); }
        }

        protected void GetColours(Type type)
        {
            Indices = new List<int>();
            Names = new List<string>();
            Colors = new List<Color>();

            var flags = BindingFlags.Public | BindingFlags.Static;
            MemberInfo[] members = type.GetProperties(flags);
            foreach (MemberInfo mi in members)
            {
                Colour obj = (Colour)(((PropertyInfo)mi).GetValue(this));
                Indices.Add(obj.Index);
                Names.Add(obj.Name);
                Colors.Add(obj.Color);
            }
        }

        protected void GetKnownColors()
        {
            Indices = new List<int>();
            Names = new List<string>();
            Colors = new List<Color>();

            int i = 0;
            foreach (KnownColor obj in Enum.GetValues(typeof(KnownColor)))
            {
                Indices.Add(i);
                Names.Add(obj.ToString());
                Colors.Add(Color.FromKnownColor(obj));
                i++;
            }
        }

        protected void GetDrawingColors()
        {
            Indices = new List<int>();
            Names = new List<string>();
            Colors = new List<Color>();

            int i = 0;
            var flags = BindingFlags.Public | BindingFlags.Static;
            MemberInfo[] members = (typeof(System.Drawing.Color)).GetProperties(flags);
            foreach (MemberInfo mi in members)
            {
                System.Drawing.Color obj = (System.Drawing.Color)(((PropertyInfo)mi).GetValue(this));
                Indices.Add(i);
                Names.Add(obj.Name.ToString());
                Colors.Add(obj);
                i++;
            }
        }

        protected void GetMediaColors()
        {
            Indices = new List<int>();
            Names = new List<string>();
            Colors = new List<Color>();

            int i = 0;
            var flags = BindingFlags.Public | BindingFlags.Static;
            MemberInfo[] members = (typeof(System.Windows.Media.Colors)).GetProperties(flags);
            foreach (MemberInfo mi in members)
            {
                System.Windows.Media.Color obj = (System.Windows.Media.Color)(((PropertyInfo)mi).GetValue(this));
                Indices.Add(i);
                Names.Add(obj.ToString());
                Colors.Add(Color.FromArgb(obj.A, obj.R, obj.G, obj.B));
                i++;
            }
        }

        protected void GetSystemColors()
        {
            Indices = new List<int>();
            Names = new List<string>();
            Colors = new List<Color>();

            var flags = BindingFlags.Public | BindingFlags.Static;
            MemberInfo[] members = (typeof(SystemColors)).GetProperties(flags);
            int i = 0;
            foreach (MemberInfo mi in members)
            {
                Color obj = (Color)(((PropertyInfo)mi).GetValue(this));
                Indices.Add(i);
                Names.Add(obj.Name);
                Colors.Add(obj);
                i++;
            }
        }


    }
}