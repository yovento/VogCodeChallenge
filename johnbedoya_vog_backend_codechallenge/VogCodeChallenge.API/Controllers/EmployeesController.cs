using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Domain;
using VogCodeChallenge.Repositories;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IList<Employee> GetAll()
        {   
            return _employeeRepository.ListAll();
        }

        [HttpGet]
        [Route("department/{departmentId}")]
        public IList<Employee> GetAll(int departmentId)
        {
            return _employeeRepository.GetAll().Where(e => e.departmentId == departmentId).ToList();
        }
    }
}
