using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// And now an interface for each model class. We keep them empty, for now
    /// </summary>
    public interface IEmailRepository:IGenericRepository<Email>
    {
        IEnumerable<Email> GetEmailAddress();
    }
}
