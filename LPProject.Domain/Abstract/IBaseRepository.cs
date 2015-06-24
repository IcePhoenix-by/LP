using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Domain.Abstract
{
    public interface IBaseRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Find(int id);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
