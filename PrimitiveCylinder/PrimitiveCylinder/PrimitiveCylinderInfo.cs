﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace PrimitiveCylinder
{
    public class PrimitiveCylinderInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "PrimitiveCylinder";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("7bca5c23-4ab4-4a7a-b486-d39f28eb2364");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
