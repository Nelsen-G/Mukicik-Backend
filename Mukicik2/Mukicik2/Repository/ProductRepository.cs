using Mukicik2.Factories;
using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Repository
{
    public class ProductRepository
    {
        Database1Entities db = SingletonDB.GetInstance();

        public List<Product> GetTopProducts()
        {
            return (from p in db.Products select p).OrderByDescending(product => product.ProductRating).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return (from p in db.Products select p).ToList();
        }

        public void InsertProduct(String name, int price, String image, float rating, int category)
        {
            Product insert = ProductFactory.addProduct(name, price, image, rating, category);
            db.Products.Add(insert);
            db.SaveChanges();
        }

        public void UpdateProduct(String id, String name, int price, String image, float rating, int category)
        {
            Product update = db.Products.Find(int.Parse(id));
            update.ProductName = name;
            update.ProductPrice = price;
            update.ProductRating = rating;
            update.CategoryId = category;
            db.SaveChanges();
        }

        public List<Product> GetByID(int id)
        {
            return (from c in db.Products where c.CategoryId == id select c).ToList();
        }

        public void DeleteProduct(String id)
        {
            Product delete = db.Products.Find(int.Parse(id));
            db.Products.Remove(delete);
            db.SaveChanges();
        }
    }
}