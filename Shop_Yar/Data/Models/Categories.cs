﻿using System.Collections.Generic;


namespace Shop_Yar.Data.Models
{
    public class Categorys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Items> Items { get; set; }
    }
}
