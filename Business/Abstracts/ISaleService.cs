using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstracts
{
    public interface ISaleService
    {
        public void Add(Sale sale);
        public void Update(Sale sale);
        public void Delete(Sale sale);
    }
}
