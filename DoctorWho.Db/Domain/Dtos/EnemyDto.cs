using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Dtos
{
    public class EnemyDto
    {

        public EnemyDto()
        {
            EpisodeEnemies = new List<EpisodeEnemyDto>();
        }
        public int EnemyId { get; set; }
        public string EnemyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<EpisodeEnemyDto> EpisodeEnemies { get; set; }

    }
}
