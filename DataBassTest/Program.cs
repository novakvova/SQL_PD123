using System;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace DataBassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            string connection = configuration.GetConnectionString("DefaultConnection");

            //Console.WriteLine("Вкажіть назву таблиці");
            //string tableName = Console.ReadLine();
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO users " +
                "(Email, FirstName, LastName) " +
                "VALUES('jj@ff.ffu', N'Іван', N'Драч'); ";
            cmd.ExecuteNonQuery();
            //cmd.CommandText = $"CREATE TABLE {tableName} " +
            //    "( "+
            //    "Id int IDENTITY PRIMARY KEY NOT NULL," +
            //    "Email nvarchar(50) UNIQUE NOT NULL," +
            //    "FirstName nvarchar(50)," +
            //    "LastName nvarchar(50),"+
            //    " );";
            //cmd.ExecuteNonQuery();

        }
    }
}
