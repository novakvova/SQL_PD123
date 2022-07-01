using System;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using Bogus;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;

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
            SqlConnection con = new SqlConnection(connection + $"Initial Catalog=testdb");
            con.Open();
            string dirSql = "SqlQuery";
            string[] tabels = { "tblUsers.sql", "tblGroups.sql", "tblStudents.sql" };
            foreach (var tableName in tabels)
            {
                string sql = File.ReadAllText($"{dirSql}\\{tableName}");
                SqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery(); //посилаємо команду в БД
                Console.WriteLine($"Create table {tableName}");
            }
            


            //Console.WriteLine("Вкажіть назву таблиці");
            //string tableName = Console.ReadLine();
            //SqlConnection con = new SqlConnection(connection);
            //con.Open();

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT name FROM master.sys.databases";
            //using (var reader = cmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine(reader["name"]);
            //    }
            //}

            //Console.WriteLine("вказіть БД для роботи: ");

            ///Stopwatch stopWatch = new Stopwatch();
            ///stopWatch.Start();
            ///string dbName = "pd123";//Console.ReadLine();
            ///SqlConnection con = new SqlConnection(connection+ $"Initial Catalog={dbName}");
            ///con.Open();
            ///Console.WriteLine("Вкажіть кількість записів:");
            ///int n = int.Parse(Console.ReadLine());
            ///var faker = new Faker<UserCreate>("uk")
            ///    .RuleFor(x => x.Name, f => f.Person.FullName)
            ///    .RuleFor(x => x.Email, f => f.Internet.Email())
            ///    .RuleFor(x => x.Phome, f => f.Phone.PhoneNumber());
            ///List<UserCreate> users = new List<UserCreate>();
            ///for (int i = 0; i < 100; i++)
            ///{
            ///    var user = faker.Generate();
            ///    
            ///
            ///    users.Add(user);
            ///}
            ///
            ///DataTable dt = new DataTable();
            ///dt.Columns.Add(new DataColumn(nameof(UserCreate.Id)));
            ///dt.Columns.Add(new DataColumn(nameof(UserCreate.Email)));
            ///dt.Columns.Add(new DataColumn(nameof(UserCreate.Name)));
            ///dt.Columns.Add(new DataColumn(nameof(UserCreate.Phome)));
            ///Random random = new Random();
            ///for (int i = 0; i < n; i++)
            ///{
            ///    int r = random.Next(0, 100);
            ///    var user = users[r];
            ///    DataRow row = dt.NewRow();
            ///    row[nameof(UserCreate.Id)]=user.Id;
            ///    row[nameof(UserCreate.Email)]=user.Email;
            ///    row[nameof(UserCreate.Name)]=user.Name;
            ///    row[nameof(UserCreate.Phome)]=user.Phome;
            ///    dt.Rows.Add(row);
            ///    //SqlCommand cmd = con.CreateCommand();
            ///    //cmd.CommandText = "INSERT INTO tblUsers " +
            ///    //    "(Email, Name, Phome) " +
            ///    //    $"VALUES('{user.Email}', N'{user.Name}', '{user.Phome}'); ";
            ///    //cmd.ExecuteNonQuery();
            ///}
            ///using(SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
            ///{
            ///    bulkCopy.DestinationTableName = "tblUsers";
            ///    bulkCopy.WriteToServer(dt);
            ///}
            ///stopWatch.Stop();
            ///TimeSpan ts = stopWatch.Elapsed;
            ///// Format and display the TimeSpan value.
            ///string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ///    ts.Hours, ts.Minutes, ts.Seconds,
            ///    ts.Milliseconds / 10);
            ///Console.WriteLine("RunTime " + elapsedTime);

            //cmd.CommandText = "INSERT INTO users " +
            //    "(Email, FirstName, LastName) " +
            //    "VALUES('jj@ff.ffu', N'Іван', N'Драч'); ";
            //cmd.ExecuteNonQuery();

            //-------------------
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
