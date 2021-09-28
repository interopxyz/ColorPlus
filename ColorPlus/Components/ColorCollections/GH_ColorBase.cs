using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            pManager.AddIntegerParameter("Collection", "C", "The color collection", GH_ParamAccess.item, 0);
            pManager[0].Optional = true;

            pManager.AddIntegerParameter("Sub Collection", "S", "For Collections with an asterisk(*) there are sub options for color sets.", GH_ParamAccess.item, 0);
            pManager[1].Optional = true;

            Param_Integer paramA = (Param_Integer)pManager[0];
            paramA.AddNamedValue("Known", 0);
            paramA.AddNamedValue("System", 1);
            paramA.AddNamedValue("Windows", 2);

            paramA.AddNamedValue("Win8", 3);
            paramA.AddNamedValue("Metro", 4);
            paramA.AddNamedValue("Flat", 5);
            paramA.AddNamedValue("Fluent", 6);
            paramA.AddNamedValue("RAL", 7);

            paramA.AddNamedValue("*Material", 8);
            paramA.AddNamedValue("*Tailwind", 9);

            paramA.AddNamedValue("*D3 Categorical", 10);
            paramA.AddNamedValue("*D3 Seq. Single", 11);
            paramA.AddNamedValue("*D3 Seq. Multiple", 12);
            paramA.AddNamedValue("*D3 Seq. Spectrum", 13);
            paramA.AddNamedValue("*D3 Diverging", 14);
            paramA.AddNamedValue("*D3 Cyclical", 15);

            Param_Integer paramB = (Param_Integer)pManager[1];
            paramB.AddNamedValue("All", 0);
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

        protected void GetCollectionColors(int index, int subIndex)
        {
            Type type = SetParams(index, subIndex);
            switch (index)
            {
                default:
                    GetKnownColors();
                    break;
                case 1:
                    GetSystemColors();
                    break;
                case 2:
                    GetDrawingColors();
                    break;
                case 3:
                    GetColours(typeof(Standards.Win8));
                    break;
                case 4:
                    GetColours(typeof(Standards.Metro));
                    break;
                case 5:
                    GetColours(typeof(Standards.Flat));
                    break;
                case 6:
                    GetColours(typeof(Standards.Fluent));
                    break;
                case 7:
                    GetColours(typeof(Standards.RAL));
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    GetColours(type);
                    break;
            }
        }

        protected System.Type SetParams(int index, int subIndex)
        {
            Type sysType = null;
            Param_Integer param = (Param_Integer)Params.Input[1];
            param.ClearNamedValues();

            string type = "ColorPlus.Material";

            if (index < 8)
            {
                param.AddNamedValue("All", 0);
            }
            else
            {
                switch (index)
                {
                    default:
                        type = "ColorPlus.Material";
                        break;
                    case 9:
                        type = "ColorPlus.Tailwind";
                        break;
                    case 10:
                        type = "ColorPlus.D3.Categorical";
                        break;
                    case 11:
                        type = "ColorPlus.D3.SequentialSingle";
                        break;
                    case 12:
                        type = "ColorPlus.D3.SequentialMultiple";
                        break;
                    case 13:
                        type = "ColorPlus.D3.SequentialSpectrum";
                        break;
                    case 14:
                        type = "ColorPlus.D3.Diverging";
                        break;
                    case 15:
                        type = "ColorPlus.D3.Cyclical";
                        break;
                }
                var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith(type));
                List<string> names = new List<string>();
                List<int> indices = new List<int>();
                int i = 0;
                foreach (var t in types)
                {
                    names.Add(t.Name);
                    indices.Add(i);
                    i++;
                }
                List<Type> arrType = types.ToList();

                string[] arrNames = names.ToArray();
                int[] arrIndices = indices.ToArray();
                Array.Sort(arrNames, arrIndices);
                for(i = 0; i < arrType.Count; i++)
                {
                    param.AddNamedValue(arrNames[i], arrIndices[i]);
                }

                if (subIndex > (arrType.Count-1)) subIndex = arrType.Count - 1;
                sysType = types.ToList()[subIndex];
            }
            return sysType;
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