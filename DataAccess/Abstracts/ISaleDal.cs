using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities.Concretes;

namespace GameProject.DataAccess.Abstracts
{
    public interface ISaleDal
    {
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
