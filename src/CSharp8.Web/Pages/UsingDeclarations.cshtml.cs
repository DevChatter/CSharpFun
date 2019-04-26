using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class UsingDeclarationsModel : PageModel
    {
        private static string connectionString;
        private static Student studentFromDb;

        public void OnGet()
        {

        }

        public static Student GetTopStudent()
        {
            const string sql = "SELECT TOP 1 * FROM [Students]";
            using var db = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, db);
            using SqlDataReader reader = cmd.ExecuteReader();

            // Do stuff
            return studentFromDb;
        }
    }

    public class Student
    {

    }
}