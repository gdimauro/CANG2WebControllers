using System;
using System.Collections.Generic;

namespace CANG2Shell.Services
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T Find(Guid key);
        void Add(T T);
        void Update(T T);
        T Remove(Guid key);
    }
}
