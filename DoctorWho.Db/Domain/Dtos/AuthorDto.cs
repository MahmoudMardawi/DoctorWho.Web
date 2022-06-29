using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Dtos
{
    public class AuthorDto
    {               
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = string.Empty;

    }
}
