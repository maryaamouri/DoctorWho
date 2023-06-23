using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class EpisodeEnemy
    {
        public EpisodeEnemy() {
        Episodes = new List<Episode>();
        Enemies = new List<Enemy>();
        }
        public int EpisodeEnemyId { get; set; }
        public int EpisodeId { get; set; }
        public int EnemyId { get; set;}
        public IList<Episode> Episodes;
        public IList<Enemy> Enemies;
    }
}
