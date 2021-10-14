using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace ColorPlus
{
    public class ColorPlusInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "ColorPlus";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return Properties.Resources.ColorPlus_Logo_24;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "Extended color creation and editing plugin for Grasshopper 3d";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("b7fdb33c-84fd-4565-a62f-672fd385a87e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "David Mans";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "interopxyz@gmail.com";
            }
        }

        public override string AssemblyVersion
        {
            get
            {
                return "1.1.0.0";
            }
        }
    }
}
