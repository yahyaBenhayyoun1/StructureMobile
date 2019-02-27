using System;
using System.Collections.Generic;
using SQLite;

namespace StructureMobile.Models
{
    public class Product
    {


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }



        public Product()
        {
        }



        public static int InsertProduct(Product product)
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Person>();
                return conn.Insert(product);

            }

        }

        public static List<Product> GetProduct()
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Product>();
                return conn.Table<Product>().ToList();

            }

        }





    }
}
