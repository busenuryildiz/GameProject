using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.DataAccess.Abstracts;
using GameProject.Entities.Concretes;

namespace GameProject.DataAccess.Concretes
{
    public class EfSaleDal : ISaleDal

    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  eklendi.", sale.Id);

        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  silindi.", sale.Id);

        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  güncellendi.", sale.Id);

        }
    }
}
