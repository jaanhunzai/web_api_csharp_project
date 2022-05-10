using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// UnitOfWork class in ConfigureServices () method from Startup.cs class. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        [HttpGet]
        ///The person repository is inheriting Generic Repository which have implemented GetAll() method. 
        ///This is an example of the usage Unit of Work with a Generic Repository

        public IEnumerable<Person> GetAllPerson()
        {
            return unitOfWork.Person.GetAll();
        }
        [Route("[action]")]
        [HttpGet]
        public IEnumerable <Person> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Email> GetEmailAddress()
        {
            return unitOfWork.Email.GetEmailAddress();
        }


    }
}
