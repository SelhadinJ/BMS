using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    //Customer Table Model
    internal class Customer
    {
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        int _customerId;
        string _firstName;
        string _lastName;
        string _phoneNo;
        string _gender;
        string _address;
        User _user;
        string _registeredDate;

        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string PhoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        //3 Overloaded Constructors
        public Customer() { }
        public Customer(string firstName, string lastName, string phoneNo, string gender, string address, User passedUser)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNo = phoneNo;
            _gender = gender;
            _address = address;
            _user = passedUser;
            _registeredDate = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public Customer(int customerId, string firstName, string lastName, string phoneNo, string gender, string address, User passedUser, string registeredDate)
        {
            _customerId = customerId;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNo = phoneNo;
            _gender = gender;
            _address = address;
            _user = passedUser;
            _registeredDate = registeredDate;
        }
        public bool RegisterCustomer()
        {
            _sql = "INSERT INTO customers VALUES (@firstName, @lastName, @phoneNo, @gender, @address, @userId, @registeredDate);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", _firstName);
            _command.Parameters.AddWithValue("@lastName", _lastName);
            _command.Parameters.AddWithValue("@phoneNo", _phoneNo);
            _command.Parameters.AddWithValue("@gender", _gender);
            _command.Parameters.AddWithValue("@address", _address);
            _command.Parameters.AddWithValue("@userId", _user.UserId);
            _command.Parameters.AddWithValue("@registeredDate", _registeredDate);
            int execute = _command.ExecuteNonQuery();
            _connection.Close();
            return (execute > 0);
        }
        public Customer GetCustomer(int customerId)
        {
            _sql = "SELECT * FROM customers WHERE customersId = @customersId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@customersId", customerId);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                string firstName = _sqlReader.GetString(1);
                string lastName = _sqlReader.GetString(2);
                string phoneNo = _sqlReader.GetString(3);
                string gender = _sqlReader.GetString(4);
                string address = _sqlReader.GetString(5);
                int userId = _sqlReader.GetInt32(6);
                string registeredDate = _sqlReader.GetString(7);
                User user = new User().GetUser(userId);
                return new Customer(customerId, firstName, lastName, phoneNo, gender, address, user, registeredDate);
            }
            return null;
        }
        public void Update(string firstName, string lastName, string phoneNo, string gender, string address)
        {
            _sql = "UPDATE customers " +
                   "SET firstName = @firstName, " +
                   "lastName = @lastName, " +
                   "phoneNo = @phoneNo, " +
                   "gender = @gender, " +
                   "address = @address " +
                   "WHERE customersId = @customerId";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", firstName);
            _command.Parameters.AddWithValue("@lastName", lastName);
            _command.Parameters.AddWithValue("@phoneNo", phoneNo);
            _command.Parameters.AddWithValue("@gender", gender);
            _command.Parameters.AddWithValue("@address",address);
            _command.Parameters.AddWithValue("@customerId", _customerId);
            _command.ExecuteNonQuery();
        }
        public bool DeleteCustomer()
        {
            _sql = "DELETE FROM customers WHERE customersId = @customerId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@customerId", _customerId);
            int execute = _command.ExecuteNonQuery();
            return (execute > 0);
        }
        public void Clear(TextBox firstNameF, TextBox lastNameF, TextBox phoneNoF, TextBox addressF, RadioButton male, RadioButton female)
        {
            firstNameF.Text = ""; lastNameF.Text = ""; phoneNoF.Text = "";
            addressF.Text = ""; male.Checked = false; female.Checked = false;
        }
        public bool CheckCustomer()
        {
            _sql = "SELECT * FROM customers WHERE firstName = @firstName AND phoneNo = @phoneNo AND address = @address;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", _firstName);
            _command.Parameters.AddWithValue("@phoneNo", _phoneNo);
            _command.Parameters.AddWithValue("@address", _address);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckCustomerId(int customerId)
        {
            _sql = "SELECT * FROM customers WHERE customersId = @customersId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@customersId", customerId);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool SearchByName(string name, DataGridView table)
        {
            _sql = "SELECT * FROM customers " +
                   "WHERE firstName LIKE CONCAT('%',@firstName,'%') " +
                   "OR lastName LIKE CONCAT('%',@lastName,'%');";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", name);
            _command.Parameters.AddWithValue("@lastName", name);
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
        public bool SearchByName(TextBox searchByNameF, DataGridView table, Panel tablePanel)
        {
            string name = searchByNameF.Text;
            if (name.Equals(""))
            {
                tablePanel.Visible = false;
                return false;
            }
            else if (new Customer().SearchByName(name, table))
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
        public bool IsPhoneValid(string phoneNo)
        {
            return Int32.TryParse(phoneNo, out int phone);
        }
        public bool IsCustomerIdValid(string customerId)
        {
            return Int32.TryParse(customerId, out int customer);
        }
    }
}
