using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IBaseRepository<TModel, TKey> where TModel : new()
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(TKey Id);
        bool Delete(TKey Id);
        TKey Insert(TModel model);
        bool Update(TModel model);
    }
}
