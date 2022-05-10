using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// connection layer between WebAPI project and repositories 
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IAdressRepository Address
        {
            get;
        }
        IEmailRepository Email
        {
            get;
        }
        IPersonRepository Person
        {
            get;
        }
        int Save();
    }
}
