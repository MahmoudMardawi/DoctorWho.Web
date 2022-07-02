using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Dtos
{
    public class CompanionDto
    {
        public CompanionDto()
        {
            EpisodeCompanions = new List<EpisodeCompanionDto>();
        }
        public int CompanionId { get; set; }
        public string CompanionName { get; set; } = string.Empty;
        public string WhoPlayed { get; set; } = string.Empty;
        public List<EpisodeCompanionDto> EpisodeCompanions { get; set; } 
    }
}
