using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class EpisodeCompanion
    {
        public EpisodeCompanion() {
            Episodes = new List<Episode>();
            Companions = new List<Companion>();
        }
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public int CompanionId { set; get; }
        public IList<Episode> Episodes;
        public IList<Companion> Companions;
    }
}
