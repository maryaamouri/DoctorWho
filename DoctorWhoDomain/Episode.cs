using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public string SeriesNumber { get; set; }
        public string EpisodeNumber { get; set; }
        public string EpisodeType  { get; set; }
        public string Title { set; get; }
        public DateTime EpisodeDate { set; get; }
        public int AuthorId { set; get; }
        public int DoctorId { set;get; }
        public string Notes { set;get; }

    }
}
