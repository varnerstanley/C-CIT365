﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskVarner
{
    class Desk
    {
        
        //this is shorter than C++
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public Material DeskMaterial { get; set; }
        public int surfaceArea { get; set; }


        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

    }

    public enum Material
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
