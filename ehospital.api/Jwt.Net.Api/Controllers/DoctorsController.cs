using EHosiptalBusiness;
using EHosiptalBusiness.Entity;
using Jwt.Net.Api.Filter;
using System;
using System.Linq;
using System.Web.Http;

namespace Jwt.Net.Api.Controllers
{
    [AuthorizationFilter(Roles ="Admin")]
    public class DoctorsController : ApiController
    {
        private HospitalContext _dbContext;

        public DoctorsController()
        {
            _dbContext = new HospitalContext();
        }

        public IHttpActionResult Get()
        {
            var data = _dbContext.Doctors.Select(d=> new
            {
                d.Name,
                d.Qualification,
                d.DoctorId,
                d.Department.DepartmentName
            });

            return Ok(data);
        }

        public IHttpActionResult Get(int id)
        {
            var data = _dbContext.Doctors.FirstOrDefault(d => d.DoctorId == id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post(Doctors doctor)
        {
            try
            {
                _dbContext.Doctors.Add(doctor);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch(Exception)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Put(Doctors doctor)
        {
            try
            {
                var doctorUpdate = _dbContext.Doctors.FirstOrDefault(d => d.DoctorId == doctor.DoctorId);
                if(doctorUpdate != null)
                {
                    doctorUpdate = doctor;
                    _dbContext.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            var doctorToRemove = _dbContext.Doctors.FirstOrDefault(d => d.DoctorId == id);
            if(doctorToRemove != null)
            {
                _dbContext.Doctors.Remove(doctorToRemove);
                _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
