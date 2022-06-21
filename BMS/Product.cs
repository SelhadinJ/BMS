using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    //Product Table Model
    internal class Product
    {
        //Private Fields
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        int _proNo;
        string _description;
        string _brand;
        int _unitPrice;
        int _quantity;
        Category _category;

        public int ProNo { get { return _proNo; } set { _proNo = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public int UnitPrice { get { return _unitPrice; } set { _unitPrice = value; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Category Category { get { return _category; } set { _category = value; } }

        //3 Overloaded Constructors
        public Product() { }
        public Product(string description, string brand, int unitPrice, int quantity, Category category)
        {
            _description = description;
            _brand = brand;
            _unitPrice = unitPrice;
            _quantity = quantity;
            _category = category;
        }
        public Product(int proNo, string description, string brand, int unitPrice, int quantity, Category category)
        {
            _proNo = proNo;
            _description = description;
            _brand = brand;
            _unitPrice = unitPrice;
            _quantity = quantity;
            _category = category;
        }
        public bool AddProduct()
        {
            _sql = "INSERT INTO products VALUES (@proDescription, @brand, @unitPrice, @quantity, @catNo);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@proDescription", _description);
            _command.Parameters.AddWithValue("@brand", _brand);
            _command.Parameters.AddWithValue("@unitPrice", _unitPrice);
            _command.Parameters.AddWithValue("@quantity", _quantity);
            _command.Parameters.AddWithValue("@catNo", _category.CatNo);
            int execute = _command.ExecuteNonQuery();
            _connection.Close();
            return (execute > 0);
        }
        public Product GetProduct(int proNo)
        {
            _sql = "SELECT * FROM products " +
                   "WHERE proNo = @proNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@proNo", proNo);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                string description = _sqlReader.GetString(1);
                string brand = _sqlReader.GetString(2);
                int unitPrice = _sqlReader.GetInt32(3);
                int quantity = _sqlReader.GetInt32(4);
                int catNo = _sqlReader.GetInt32(5);
                return new Product(proNo, description, brand, unitPrice, quantity, new Category().GetCategory(catNo));
            }
            return null;
        }
        public bool DeleteProduct()
        {
            _sql = "DELETE FROM products WHERE proNo = @proNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@proNo", _proNo);
            int execute = _command.ExecuteNonQuery();
            return (execute > 0);
        }
        public bool SearchByProNo(string proNo, DataGridView table)
        {
            _sql = "SELECT * FROM products " +
                   "WHERE proNo LIKE CONCAT('%',@proNo,'%')";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@proNo", proNo);
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
        public bool SearchByBrand(TextBox searchByBrandF, DataGridView table, Panel tablePanel)
        {
            string brand = searchByBrandF.Text;
            if (brand.Equals(""))
            {
                tablePanel.Visible = false;
                return false;
            }
            else if (new Product().SearchByBrand(brand, table))
            {
                tablePanel.Visible = true;
                return true;
            }
            else
            {
                tablePanel.Visible = false;
                return false;
            }
        }
        public bool SearchByProNo(TextBox searchByProNoF, DataGridView table, Panel tablePanel)
        {
            string proNo = searchByProNoF.Text;
            if (proNo.Equals(""))
            {
                tablePanel.Visible = false;
                return false;
            }
            else if (new Product().SearchByProNo(proNo, table))
            {
                tablePanel.Visible = true;
                return true;
            }
            else
            {
                tablePanel.Visible = false;
                return false;
            }
        }
        public bool SearchByBrand(string brand, DataGridView table)
        {
            _sql = "SELECT * FROM products " +
                   "WHERE brand LIKE CONCAT('%',@brand,'%')";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@brand", brand);
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
        public Product GetProduct(string passedDescription, string passedBrand)
        {
            _sql = "SELECT * FROM products " +
                   "WHERE proDescription = @description AND brand = @brand;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@brand", passedBrand);
            _command.Parameters.AddWithValue("@description", passedDescription);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                int proNo = _sqlReader.GetInt32(0);
                int unitPrice = _sqlReader.GetInt32(3);
                int quantity = _sqlReader.GetInt32(4);
                int catNo = _sqlReader.GetInt32(5);
                return new Product(proNo, passedDescription, passedBrand, unitPrice, quantity, new Category().GetCategory(catNo));
            }
            return null;
        }
        public void UpdateQty(int proNo, int quantity)
        {
            _sql = "UPDATE products " +
                   "SET quantity = @quantity " +
                   "WHERE proNo = @proNo";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@quantity", quantity);
            _command.Parameters.AddWithValue("@proNo", proNo);
            _command.ExecuteNonQuery();
        }
        public void Update()
        {
            _sql = "UPDATE products " +
                   "SET proDescription = @description, " +
                   "brand = @brand, " +
                   "quantity = @quantity, " +
                   "unitPrice = @unitPrice, " +
                   "catNo = @catNo " +
                   "WHERE proNo = @proNo";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@description", _description);
            _command.Parameters.AddWithValue("@brand", _brand);
            _command.Parameters.AddWithValue("@quantity", _quantity);
            _command.Parameters.AddWithValue("@unitPrice", _unitPrice);
            _command.Parameters.AddWithValue("@catNo", _category.CatNo);
            _command.Parameters.AddWithValue("@proNo", _proNo);
            _command.ExecuteNonQuery();
        }
        public bool CheckProduct()
        {
            _sql = "SELECT * FROM products " +
                   "WHERE proDescription = @description AND brand = @brand;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@brand", _brand);
            _command.Parameters.AddWithValue("@description", _description);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckProductNo(int proNo)
        {
            _sql = "SELECT * FROM products " +
                   "WHERE proNo = @proNo;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@proNo", proNo);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public void Clear(TextBox descriptionF, TextBox brandF, TextBox unitPriceF, TextBox quantityF, ComboBox categoryC)
        {
            descriptionF.Text = ""; brandF.Text = ""; unitPriceF.Text = "";
            quantityF.Text = ""; categoryC.SelectedIndex = -1;
        }
        public void PopulateCategory(ComboBox category)
        {
            _sql = "SELECT catDescription FROM categories";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.HasRows)
            {
                while (_sqlReader.Read())
                {
                    category.Items.Add(_sqlReader.GetString(0));
                }
            }
        }
        public bool IsProNoValid(string proNoString)
        {
            return Int32.TryParse(proNoString, out int proNo);
        }
        public bool IsUnitPriceValid(string unitPriceString)
        {
            return Int32.TryParse(unitPriceString, out int unitPrice);
        }
        public bool IsQtyValid(string qtyString)
        {
            return Int32.TryParse(qtyString, out int qty);
        }
    }
}
