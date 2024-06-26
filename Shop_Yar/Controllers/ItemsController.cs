﻿using Shop_Yar.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shop_Yar.Data.ViewModell;

namespace Shop_Yar.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategorys IAllCategorys;

        VMItems VMItems = new VMItems();

        public ItemsController(IItems IAllItems, ICategorys IAllCategorys)
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
        }
        public ViewResult List( int id=0)
        {
            ViewBag.Title = "Страница с предметами";
            VMItems.Itmes = IAllItems.AllItems;
            VMItems.Categorys = IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
        }
    }
}
