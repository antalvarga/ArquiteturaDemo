using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArquiteturaDemo.Domain.Interface;
using Microsoft.Practices.ServiceLocation;


namespace ArquiteturaDemo.Application
{
    public class ApplicationBase
    {
        private IUnitOfWork _unitOfWork;

        public void BeginTransation()
        {
            _unitOfWork = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _unitOfWork.BeginTransation();
        }
        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}
