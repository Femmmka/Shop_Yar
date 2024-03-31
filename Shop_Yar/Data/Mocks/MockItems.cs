using Shop_Yar.Data.Interfaces;
using Shop_Yar.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Yar.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _categorys = new MockCategorys();

        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items()
                    {
                        Id=0,
                        Name="DEXP MS-70",
                        Description="Благодаря чёрному корпусу с лаконичным дизайном микроволновка.",
                        Img="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ozon.ru%2Fproduct%2Fmikrovolnovaya-pech-belaya-svch-pech-mikrovolnovka-mikrovolnovka-na-kuhnyu-dlya-doma-493491106%2F&psig=AOvVaw3yq7np4f4arhDBMGAuUTD2&ust=1711967763050000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDV-4SnnoUDFQAAAAAdAAAAABAE",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()
                    },
                    new Items(){},
                    new Items(){},
                    new Items(){},
                    new Items(){}
                };
            }
        }
    }
}