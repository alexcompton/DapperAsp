using Dapper;
using DapperAsp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperAsp.Repo
{
    public class Repo
    {
        public List<Customer> GetCustomersFromText(string str)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                return db.Query<Customer>("Select * FROM [SalesLT].[Customer] WHERE FirstName Like '%" + str + "%'").ToList();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                return db.Query<Customer>("Select * FROM [SalesLT].[Customer]").ToList();
            }
        }
    }
}