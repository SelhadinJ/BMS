using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    //Category Table Model
    internal class Category
    {
        //Private Fields
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        int _catNo;
        string _description;

        public int CatNo { get { return _catNo; } set { _catNo = value; } }
        public string Description { get { return _description; } set { _description = value; } }

        //2 Overloaded Constructors
        public Category() { }
        public Category(int catNo, string description)
        {
            _catNo = catNo;
            _description = description;
        }
        public bool AddCategory()
        {
            _sql = "INSERT INTO categories VALUES (@catNo, @description);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            _command.Parameters.AddWithValue("@description", _description);
            int execute = _command.ExecuteNonQuery();
            _connection.Close();
            return (execute > 0);
        }
        public bool RemoveCategory()
        {
            _sql = "DELETE FROM categories WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            int execute = _command.ExecuteNonQuery();
            return (execute > 0);
        }
        public Category GetCategory(int catNo)
        {
            _sql = "SELECT * FROM categories WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", catNo);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                string description = _sqlReader.GetString(1);
                return new Category(catNo, description);
            }
            return null;
        }
        public string GetCatDescription(int catNo)
        {
            _sql = "SELECT catDescription FROM categories WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", catNo);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                return _sqlReader.GetString(0);
                
            }
            return null;
        }
        public Category GetCategory(string description)
        {
            _sql = "SELECT * FROM categories WHERE catDescription = @description;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@description", description);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                int catNo = _sqlReader.GetInt32(0);
                return new Category(catNo, description);
            }
            return null;
        }
        public bool CheckCategory()
        {
            _sql = "SELECT * FROM categories " +
                   "WHERE catNo = @catNo AND catDescription = @description;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            _command.Parameters.AddWithValue("@description", _description);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckDescription()
        {
            _sql = "SELECT * FROM categories " +
                   "WHERE catDescription = @description;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@description", _description);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckDescription(string description)
        {
            _sql = "SELECT * FROM categories " +
                   "WHERE catDescription = @description;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@description", description);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckCategoryNo()
        {
            _sql = "SELECT * FROM categories " +
                   "WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckCategoryNo(int catNo)
        {
            _sql = "SELECT * FROM categories " +
                   "WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNo", catNo);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public void ViewCategory(DataGridView table)
        {
            _sql = "SELECT * FROM categories";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _sqlReader = _command.ExecuteReader();
            // Create a DataTable object to hold all the data returned by the query.
            DataTable dataTable = new DataTable();
            // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
            dataTable.Load(_sqlReader);
            table.DataSource = dataTable;
        }
        public bool UpdateDescription(string description)
        {
            _sql = "UPDATE categories SET catDescription = @description WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@description", description);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            int execute = _command.ExecuteNonQuery();
            return (execute > 0);
        }
        public void UpdateCategoryNo(int catNoPassed)
        {
            _sql = "UPDATE categories SET catNo = @catNoPassed WHERE catNo = @catNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@catNoPassed", catNoPassed);
            _command.Parameters.AddWithValue("@catNo", _catNo);
            _command.ExecuteNonQuery();
        }
    }
}
