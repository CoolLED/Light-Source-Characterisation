using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class DB_Catalogue
    {
        public int unique_id { get; set; }
        public DateTime record_date { get; set; }
        public string data_Path { get; set; }
        public string backup_Data_Path { get; set; }
        public int microscope_Manufacturer { get; set; }
        public int microscope_Model { get; set; }
        public int microscope_Arm { get; set; }
        public int microscope_Optic { get; set; }
        public int lightsource_Manufacturer { get; set; }
        public int lightsource_Model { get; set; }
        public int lightsource_Wavelength { get; set; }
        public int attachment_Method { get; set; }
    }
}
