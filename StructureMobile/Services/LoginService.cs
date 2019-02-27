using System;
using StructureMobile.Models;
namespace StructureMobile.Services
{
    public class LoginService
    {

        public LoginService()
        {
        }


        public static string Login(string Login, string Password)
        {
            bool check = Person.CheckLogin(Login, Password);

            /*if (Login =="Admin"&& Password == "admin") 
                {
                    return "token";
                }
                */

            if (check == true)
            {
                return "TOCKEN";
            }

            else
            {
                return "ERROR";
            }
            

        }
    }
}
