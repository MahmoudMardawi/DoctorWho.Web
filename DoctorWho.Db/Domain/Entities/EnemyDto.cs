using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Entites
{
    public class EnemyDto
    {
   

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string? Description { get; set; } 
    }
}
