using Shop_Yar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Yar.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Itmes { get; set; }
        public IEnumerable<Categorys> Categorys { get; set; }
        public int SelectCategory = 0;
    }
}
