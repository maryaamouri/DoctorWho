using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Doctor
    {
        public int DocotId { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
    }
}