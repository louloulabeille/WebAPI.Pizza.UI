﻿namespace WebAPI.PIZZA.UI.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string[] Ingredients { get; set; }
        public string ImageUrl { get; set; }

    }
}