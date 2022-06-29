using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Domain.Dtos
{
    public class EpisodeEnemyDto
    {
        public int EpisodeEnemyId { get; set; }
        public ICollection<EpisodeDto> Episodes { get; set; }
        public ICollection<EnemyDto> Enemies { get; set; }
        public EpisodeEnemyDto(ICollection<EpisodeDto> episodes, ICollection<EnemyDto> enemies)
        {
              Enemies = enemies;
            Episodes = episodes;
        }

    }
}
