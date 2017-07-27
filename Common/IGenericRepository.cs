using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
   public interface IGenericRepository<TEntity>: IDisposable where TEntity:class//泛型仓储接口
    {
        IEnumerable<TEntity> SelectList();
        TEntity SelectByID(object id);

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        void LogicDelete(object id);
    }
}
