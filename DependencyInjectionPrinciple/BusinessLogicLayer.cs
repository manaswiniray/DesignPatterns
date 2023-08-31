using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrinciple
{
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer _dal;

        public BusinessLogicLayer(IRepositoryLayer dal)
        {
            _dal = dal;
        }

        public void Save() 
        {
            _dal.Save(); 
        }
    }
}
