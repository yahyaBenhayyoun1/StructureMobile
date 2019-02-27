using System;
using System.Collections.Generic;
using SQLite;

namespace StructureMobile.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Passeword { get; set; }

        public int Age { get; set; }


        public Person()
        {

        }

        public static int InsertPerson(Person person)
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Person>();
                return conn.Insert(person);

            }

        }

        public static List<Person> GetPerson()
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Person>();
                return conn.Table<Person>().ToList();

            }

        }







        public static bool CheckLogin(string UserName, String UserPassword)
        {

            using (SQLite.SQLiteConnection db = new SQLiteConnection(App.DatabasePath))
            {
              
                var count = db.Table<Person>().Where( i => i.Name == UserName && i.Passeword == UserPassword).Count();

                if (count > 0)
                    return true;

                else
                    return false;
    
            }

                   
        }

    }
}