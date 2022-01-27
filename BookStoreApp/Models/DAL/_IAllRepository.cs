using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models.DAL
{
    public interface _IAllRepository<T> where T:class
    {
        #region model
        IEnumerable<T> GetModel();
        bool AddModel(T book);
        T GetModelById(int id);
        bool UpdateModel(T book);
        bool DeleteModel(int id);
        #endregion
    }
}
