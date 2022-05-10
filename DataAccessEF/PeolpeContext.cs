using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessEF
{
    public class PeopleContext : DbContext
    {
        /// <summary>
        /// The context class is the link between Database and our C# code. 
        /// All the properties within this class will represent a table in our database
        /// </summary>
        /// <param name="options"></param>
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Person
        {
            get;
            set;
        }
        public DbSet<Address> Address
        {
            get;
            set;
        }
        public DbSet<Email> Email
        {
            get;
            set;
        }
    }
}
