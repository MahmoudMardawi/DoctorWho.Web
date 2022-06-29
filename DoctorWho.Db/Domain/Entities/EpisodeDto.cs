using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Entites
{
    public class EpisodeDto
    {

        public EpisodeDto(ICollection<DoctorDto> doctors, ICollection<AuthorDto> authors,
          ICollection<EpisodeEnemyDto> episodeEnemies, ICollection<EpisodeCompanionDto> episodeCompanions)
        {
            Doctors = doctors;
            Authors = authors;
            EpisodeEnemies = episodeEnemies;
            EpisodeCompanions = episodeCompanions;
        }
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime EpisodeDate { get; set; }
        public ICollection<DoctorDto> Doctors { get; set; }
        public ICollection<AuthorDto> Authors { get; set; }
        public ICollection<EpisodeEnemyDto> EpisodeEnemies { get; set; }
        public ICollection<EpisodeCompanionDto> EpisodeCompanions { get; set; }
      
    }
}
