using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class eType
    {
        public static eType microscope { get; } = new eType (0, "Microscope");
        public static eType lightsource { get; } = new eType(1, "Lightsource");

        public int Value;
        public string Name;

        private eType(int val, string name) {
            Value = val;
            Name = name;
        }
    }
}
