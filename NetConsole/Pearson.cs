﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NetConsole
{
    public class Wand
    {
        public string Wood { get; set; }
        public string Core { get; set; }
        public double? Length { get; set; }
    }

    public class RootObject
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string House { get; set; }
        public string DateOfBirth { get; set; }
        public object YearOfBirth { get; set; }
        public string Ancestry { get; set; }
        public string EyeColour { get; set; }
        public string HairColour { get; set; }
        public Wand Wand { get; set; }
        public string Patronus { get; set; }
        public bool HogwartsStudent { get; set; }
        public bool HogwartsStaff { get; set; }
        public string Actor { get; set; }
        public bool Alive { get; set; }
        public string Image { get; set; }
    }
}
