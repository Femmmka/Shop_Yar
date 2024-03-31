using System.Collections.Generic;
using Shop_Yar.Data.Models;


namespace Shop_Yar.Data.Interfaces
{
    public interface ICategorys
    {
        IEnumerable<ICategorys> AllCategorys { get; }
    }
}
