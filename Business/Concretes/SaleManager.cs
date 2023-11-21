using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.DataAccess.Abstracts;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Concretes
{
    public class SaleManager:ISaleService
    {
        ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public void Add(Sale sale)
        {
            _saleDal.Add(sale);
        }
        
        public void Delete(Sale sale)
        {
            _saleDal.Delete(sale);
        }


        public void Update(Sale sale)
        {
            _saleDal.Update(sale);
        }
    }
}
