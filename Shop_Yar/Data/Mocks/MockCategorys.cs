using Shop_Yar.Data.Interfaces;
using Shop_Yar.Data.Models;
using System.Collections.Generic;


namespace Shop_Yar.Data.Mocks
{
    public class MockCategorys : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                return new List<Categorys>
                {
                    new Categorys()
                    {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновая печь-электроприбор."
                    },
                    new Categorys()
                    {
                        Id = 1,
                        Name = "Мультиварки",
                        Description = "Мультиварка-многофункциональная."
                    }
                };
            }
        }
    }
}
