using System;
using System.Collections.Generic;
using Shop_Yar.Data.Models;

namespace Shop_Yar.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<items> AllItems { get; }
    }
}
