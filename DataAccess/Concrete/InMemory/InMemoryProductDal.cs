using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() //crop+tap+tab
        {
            //Oracle,Sql Server'dan gelir gibi simüle edildi
            _products = new List<Product> { //içinde ürünler olan bir list oluşturuldu
                new Product {ProductID=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15}, //veri girişleri yapıldı
                new Product {ProductID=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product {ProductID=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product {ProductID=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product {ProductID=5,CategoryId=2,ProductName="Mouse",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product); 
            
            //normalde bir listeden eleman siler ama burada direkt olmaz. 
            //Çünkü beş adet veri beş adet adrese kaydoldu. Arayüzden bilgiler aynı olsa da o adres aynı değil.
            //bu yüzden her birinde farklı olan Id özelliklerini kullanırız.

            //    Product productToDelete = null;

            //    foreach (var p in _products)  //tek tek bütün elemanları dolaşarak bulur.
            //    {
            //        if (product.ProductID == p.ProductID)
            //        {
            //            productToDelete = p;
            //        }
            //    }

            //LINQ - Language Integrated Quary

            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            // foreach ın kısa hali yazılmış oldu.
            //p takma isim.
            //sonrası koşul kısmı.
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products; //liste olduğu gibi döndürüldü.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //where koşulunu sağlayanları yeni bir liste yaparak döndürür.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderilen ürün id sine sahip olan listedeki ürünü bul...
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
