using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransation();

        void Commit();
    }
}
