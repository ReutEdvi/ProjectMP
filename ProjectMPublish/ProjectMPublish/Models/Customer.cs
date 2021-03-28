using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectMPublish.Models.DAL;

namespace ProjectMPublish.Models
{
    public class Customer
    {
        int id;
        string email;
        string password;



        public Customer() { }

        public Customer(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public Customer Read(string email, string password)
        {
            DBServices dbs = new DBServices();
            return dbs.ReadCustomer(email, password);


        }
    }
}