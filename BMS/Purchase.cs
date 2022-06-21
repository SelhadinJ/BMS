using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    //Purchase Table Model
    internal class Purchase
    {
        //Private Fields
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        Customer _customer;
        Product _product;
        int _quantity;
        int _totalPrice;
        DateTime _purchaseDate;
        User _user;

        //2 Overloaded Constructors
        public int TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
        public Purchase() { }
        public Purchase(Customer customer, Product product, int quantity, User user)
        {
            _customer = customer;
            _product = product;
            _quantity = quantity;
            _totalPrice = quantity * product.UnitPrice;
            _purchaseDate = DateTime.Now.Date;
            _user = user;
        }
        public bool GetAllPurchases(DateTime from, DateTime to, DataGridView table)
        {
            _sql = "EXECUTE getPurchaseFrom_To_ @from, @to;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@from", from);
            _command.Parameters.AddWithValue("@to", to);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.HasRows)
            {
                // Create a DataTable object to hold all the data returned by the query.
                DataTable dataTable = new DataTable();
                // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
                dataTable.Load(_sqlReader);
                table.DataSource = dataTable;
                return true;
            }
            return false;
        }
        public bool AddPurchase()
        {
            _sql = "INSERT INTO purchases VALUES (@customerId, @proNo, @quantity, @totalPrice, @purchaseDate, @userId);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@customerId", _customer.CustomerId);
            _command.Parameters.AddWithValue("@proNo", _product.ProNo);
            _command.Parameters.AddWithValue("@quantity", _quantity);
            _command.Parameters.AddWithValue("@totalPrice", _totalPrice);
            _command.Parameters.AddWithValue("@purchaseDate", _purchaseDate);
            _command.Parameters.AddWithValue("@userId", _user.UserId);
            int execute = _command.ExecuteNonQuery();
            if (execute > 0)
            {
                string _sql2 = "UPDATE products SET quantity = @qty WHERE proNo = @proNo;";
                SqlCommand _command2 = new SqlCommand(_sql2, _connection);
                int databaseQty = new Product().GetProduct(_product.ProNo).Quantity;
                _command2.Parameters.AddWithValue("@qty", databaseQty - _quantity);
                _command2.Parameters.AddWithValue("@proNo", _product.ProNo);
                int execute2 = _command2.ExecuteNonQuery();
                return (execute2 > 0);
            }
            return false;
        }
        public bool GetSalesOf(int userId, DateTime from, DateTime to, DataGridView table)
        {
            _sql = "EXECUTE getSalesOf_From_To_ @userId, @from, @to;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", userId);
            _command.Parameters.AddWithValue("@from", from);
            _command.Parameters.AddWithValue("@to", to);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.HasRows)
            {
                // Create a DataTable object to hold all the data returned by the query.
                DataTable dataTable = new DataTable();
                // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
                dataTable.Load(_sqlReader);
                table.DataSource = dataTable;
                return true;
            }
            return false;
        }
    }
}
