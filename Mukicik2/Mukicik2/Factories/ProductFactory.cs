using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Factories
{
    public class ProductFactory
    {
        public static Product addProduct(String name, int price, String image, float rating, int category)
        {
            Product newProduct = new Product();
            newProduct.ProductName = name;
            newProduct.ProductPrice = price;
            newProduct.ProductImage = image;
            newProduct.ProductRating = rating;
            newProduct.CategoryId = category;
            return newProduct;
        }
    }
}