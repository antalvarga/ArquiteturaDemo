using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Delete(TEntity obj);

        void Delete(int id);

        void Update(TEntity obj);

        TEntity Get(int id);

        IEnumerable<TEntity> Get();
    }
}
