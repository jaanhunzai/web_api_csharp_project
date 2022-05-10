using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    /// <summary>
    /// implementation for Address, Email and Person repositories.
    /// 
    /// </summary>
    public class PersonRepository:GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }

        //DataAccessEF project and add the implementation for the method
        public IEnumerable<Person> GetAdultPersons()
        {
            return context.Person.Where(p => p.Age >=18).ToList();
        }
    }

    public class AddressRepository : GenericRepository<Address>, IAdressRepository
    {
        public AddressRepository(PeopleContext context):base(context) { }
    }


    class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }

        public IEnumerable<Email> GetEmailAddress()
        {
            throw new NotImplementedException();
        }
    }
}
