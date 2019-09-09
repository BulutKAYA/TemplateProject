using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteraktifGrup.Interfaces
{
    public interface IGenericService<T>
    {
        T Get(int id);
        List<T> GetList();
        T Save(T entity);
        int Update(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
