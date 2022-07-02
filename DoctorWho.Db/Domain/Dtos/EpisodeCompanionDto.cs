using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Dtos
{
    public class EpisodeCompanionDto
    {
        public int EpisodeCompanionId { get; set; }
        public List<EpisodeDto> Episodes { get; set; }
        public List<CompanionDto> Companions { get; set; }

        public EpisodeCompanionDto()
        {
            Companions = new List<CompanionDto>();
            Episodes = new List<EpisodeDto>();
        }
    }
}
