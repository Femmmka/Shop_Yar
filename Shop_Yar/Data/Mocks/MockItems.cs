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
                        Img="https://lh3.googleusercontent.com/proxy/XdnGgl7OBa5x594xONyl0GHnCaZSVET9qljjdFbCnYhsVg10Pad9tSY62wMIfJuGmrI3sr3XH-h3ZP65",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()
                    },
                    new Items(){
                        Id=1,
                        Name="DEXP MS-70",
                        Description="Благодаря чёрному корпусу с лаконичным дизайном микроволновка.",
                        Img="https://lh3.googleusercontent.com/proxy/XdnGgl7OBa5x594xONyl0GHnCaZSVET9qljjdFbCnYhsVg10Pad9tSY62wMIfJuGmrI3sr3XH-h3ZP65",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()},
                    new Items(){
                        Id=2,
                        Name="DEXP MS-70",
                        Description="Благодаря чёрному корпусу с лаконичным дизайном микроволновка.",
                        Img="https://lh3.googleusercontent.com/proxy/XdnGgl7OBa5x594xONyl0GHnCaZSVET9qljjdFbCnYhsVg10Pad9tSY62wMIfJuGmrI3sr3XH-h3ZP65",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()},
                    new Items(){
                        Id=3,
                        Name="DEXP MS-70",
                        Description="Благодаря чёрному корпусу с лаконичным дизайном микроволновка.",
                        Img="https://lh3.googleusercontent.com/proxy/XdnGgl7OBa5x594xONyl0GHnCaZSVET9qljjdFbCnYhsVg10Pad9tSY62wMIfJuGmrI3sr3XH-h3ZP65",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()},
                    new Items(){
                        Id=4,
                        Name="DEXP MS-70",
                        Description="Благодаря чёрному корпусу с лаконичным дизайном микроволновка.",
                        Img="https://lh3.googleusercontent.com/proxy/XdnGgl7OBa5x594xONyl0GHnCaZSVET9qljjdFbCnYhsVg10Pad9tSY62wMIfJuGmrI3sr3XH-h3ZP65",
                        Price=3699,
                        Category=_categorys.AllCategorys.Where(x=>x.Id==0).First()}
                };
            }
        }
    }
}