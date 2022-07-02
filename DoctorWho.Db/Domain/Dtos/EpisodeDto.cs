using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Dtos
{
    public class EpisodeDto
    {

        public EpisodeDto()
        {
            Doctors = new List<DoctorDto>();
            Authors = new List<AuthorDto>();
            EpisodeEnemies = new List<EpisodeEnemyDto>();
            EpisodeCompanions = new List<EpisodeCompanionDto>();
        }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime EpisodeDate { get; set; }
        public List<DoctorDto> Doctors { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public List<EpisodeEnemyDto> EpisodeEnemies { get; set; }
        public List<EpisodeCompanionDto> EpisodeCompanions { get; set; }
      
    }
}
