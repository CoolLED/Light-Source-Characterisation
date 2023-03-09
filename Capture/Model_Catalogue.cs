using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class Model_Catalogue
    {
        public int uniqueID { get; set; }
        public DateTime recordDate { get; set; }
        public String? lightSourceName { get; set; }
        public String? lightSourceManufacturer { get; set;}
        public String? microscope { get; set; }
        public String? microscopeObjective { get; set; }
    }
}
