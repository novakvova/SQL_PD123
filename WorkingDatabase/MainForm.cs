using System.Data.SqlClient;

namespace WorkingDatabase
{
    public partial class MainForm : Form
    {
        SqlConnection con;
        string dirSql = "SqlTabels";
        string dbName = "pd123";
        string conSTR = "Data Source=.;Integrated Security=True;";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenTabels_Click(object sender, EventArgs e)
        {
            string dbName = "myPD123";
            string conSTR = "Data Source=.;Integrated Security=True;";
            string conectionSTR = $"{conSTR}Initial Catalog={dbName}";
            con = new SqlConnection(conectionSTR);
            con.Open();

            CreateTabels();
        }
        private void CreateTabels()
        {
            ExecuteCommandFromFile("tblRegions.sql");
            ExecuteCommandFromFile("tblCities.sql");
            ExecuteCommandFromFile("tblUsers.sql");
            ExecuteCommandFromFile("tblRoles.sql");
            ExecuteCommandFromFile("tblUserRoles.sql");
            ExecuteCommandFromFile("tblUserAdresses.sql");
            ExecuteCommandFromFile("tblGroups.sql");
            ExecuteCommandFromFile("tblStudents.sql");
        }

        private void ExecuteCommandFromFile(string file)
        {
            string sql = ReadSqlFile(file);
            SqlCommand command = con.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery(); //посилаємо команду в БД
        }
        private string ReadSqlFile(string file)
        {
            string sql = File.ReadAllText($"{dirSql}\\{file}");
            return sql;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conectionSTR = $"{conSTR}Initial Catalog={dbName}";
            con = new SqlConnection(conectionSTR);
            con.Open();
            string sql = "SELECT * " +
                "FROM tblUsers " +
                "ORDER BY Id " +
                "OFFSET     1000000  ROWS " +
                "FETCH NEXT 2 ROWS ONLY;";
            SqlCommand command = con.CreateCommand();
            command.CommandText = sql;
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                object [] row = { reader["Id"].ToString(), 
                    reader["Name"].ToString(), 
                    reader["Email"].ToString(), reader["Phome"].ToString() };
                dgvUsers.Rows.Add(row);
            }


        }
    }
}