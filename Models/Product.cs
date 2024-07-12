using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private int _discountPercent;
        private float _priceAfterDiscount;

        public int GetId() { return _id; }
        public string GetName() { return _name; }
        public int GetPrice() { return _price; }
        public int GetDiscount() { return _discountPercent; }
        public void SetId(int id) { _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetPrice(int price) {  _price = price; }
        public void SetDiscount(int discountPercent) {  _discountPercent = discountPercent; }

        //public float GetPriceAfterDiscount() {  return _priceAfterDiscount; }

        public float CalculatePriceAfterDiscount()
        {


            _priceAfterDiscount = _price - (_price * _discountPercent / 100);
            return _priceAfterDiscount;
            
            
        }

        

    }
}
