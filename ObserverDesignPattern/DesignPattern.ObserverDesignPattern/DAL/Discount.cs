﻿namespace DesignPattern.ObserverDesignPattern.DAL
{
    public class Discount
    {
        public int ID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool DiscountCodeStatus { get; set; }
    }
}