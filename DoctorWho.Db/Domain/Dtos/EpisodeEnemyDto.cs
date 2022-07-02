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
        public List<EpisodeDto> Episodes { get; set; }
        public List<EnemyDto> Enemies { get; set; }
        public EpisodeEnemyDto()
        {
              Enemies = new List<EnemyDto>();
              Episodes = new List<EpisodeDto>();
        }

    }
}
