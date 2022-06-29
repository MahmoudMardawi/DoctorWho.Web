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
        public ICollection<EpisodeDto> Episodes { get; set; }
        public ICollection<CompanionDto> Companions { get; set; }

        public EpisodeCompanionDto(ICollection<EpisodeDto> episodes,ICollection<CompanionDto> companions)
        {
            Companions = companions;
            Episodes = episodes;
        }
    }
}
