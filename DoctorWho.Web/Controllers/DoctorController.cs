using AutoMapper;
using DoctorWho.Db.Domain.Dtos;
using DoctorWho.Db.Contexts;
using DoctorWho.Db.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DoctorWho.Db.Controllers
{
    [ApiController]
    [Route("api/doctors")]

    public class DoctorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly DoctorWhoCoreDbContext dbContext;
        public DoctorController(  IMapper mapper, DoctorWhoCoreDbContext dbContext)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(Mapper));
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var doctors =  dbContext.Doctors.Select(x =>x);

            
            return Ok(_mapper.Map<IEnumerable<DoctorDto>>(doctors));
        }
        [HttpGet]
        [Route("get-doctor-by-id")]
        public async Task<IActionResult> GetCakeByIdAsync(int id)
        {
            var doctor = await dbContext.Doctors.FindAsync(id);
            return Ok(doctor);
        }



    }
}
