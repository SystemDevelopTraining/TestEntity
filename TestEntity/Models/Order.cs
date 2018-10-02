using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntity.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Kaiin_Id { get; set; }
        public DateTime OdDay{get; set; }
        public DateTime SeDay { get; set; }

        //参照するクラス
        public Kaiin Kaiin { get; set; }
    }
}
