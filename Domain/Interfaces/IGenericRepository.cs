using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// interface decuples envirnoment 
    /// We need to use as much as possible interfaces and these 
    /// interfaces needs to be declared on Domain project
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository <T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression <Func<T, bool>> expression);
        void Add (T entity);
        void Remove (T entity);
        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);
    }
}
