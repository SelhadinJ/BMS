using System;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;


namespace Boutique_Management_System
{
    //User Table Model
    internal class User
    {
        //Private Fields
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        int _userId;
        string _firstName;
        string _lastName;
        string _phoneNo;
        string _userType;
        string _userName;
        string _password;
        string _registeredDate;

        //Properties
        public int UserId { get { return _userId; } set { _userId = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string PhoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        public string UserType { get { return _userType; } set { _userType = value; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        
        public User() {}
        public User(string firstName, string lastName, string phoneNo, string userType, string userName, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNo = phoneNo;
            _userType = userType;
            _userName = userName;
            _password = HashPassword(password);
            _registeredDate = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public User(int userId, string firstName, string lastName, string phoneNo, string userType, string userName, string password, string registeredDate)
        {
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNo = phoneNo;
            _userType = userType;
            _userName = userName;
            _password = password;
            _registeredDate = registeredDate;
        }

        //Utility Methods
        public bool DoesExist()
        {
            _sql = "SELECT * FROM users";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool SingleUser()
        {
            _sql = "SELECT COUNT(*) FROM users";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
                return (_sqlReader.GetInt32(0) == 1);
            return false;
        }
        public bool SearchById(TextBox searchByIdF, string passedUserType, DataGridView table, Panel tablePanel)
        {
            string userId = searchByIdF.Text;
            if (userId.Equals(""))
            {
                tablePanel.Visible = false;
                return false;
            }
            else if (new User().SearchById(userId, passedUserType, table))
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
        public bool SearchByName(TextBox searchByNameF, string passedUserType, DataGridView table, Panel tablePanel)
        {
            string name = searchByNameF.Text;
            if (name.Equals(""))
            {
                tablePanel.Visible = false;
                return false;
            }
            else if (new User().SearchByName(name, passedUserType, table))
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
        public bool CreateUser()
        {
            _sql = "INSERT INTO users VALUES (@firstName, @lastName, @phoneNo, @userType, @userName, @passwd, @registeredDate);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", _firstName);
            _command.Parameters.AddWithValue("@lastName", _lastName);
            _command.Parameters.AddWithValue("@phoneNo", _phoneNo);
            _command.Parameters.AddWithValue("@userType", _userType);
            _command.Parameters.AddWithValue("@userName", _userName);
            _command.Parameters.AddWithValue("@passwd", _password);
            _command.Parameters.AddWithValue("@registeredDate", _registeredDate);
            int execute = _command.ExecuteNonQuery();
            _connection.Close();
            return (execute > 0);
        }
        public User GetUser(int userId)
        {
            _sql = "SELECT * FROM users WHERE userId = @userId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", userId);
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                string firstName = _sqlReader.GetString(1);
                string lastName = _sqlReader.GetString(2);
                string phoneNo = _sqlReader.GetString(3);
                string userType = _sqlReader.GetString(4);
                string userName = _sqlReader.GetString(5);
                string password = _sqlReader.GetString(6);
                string registeredDate = _sqlReader.GetString(7);
                return new User(userId, firstName, lastName, phoneNo, userType, userName, password, registeredDate);
            }
            return null;
        }
        public User GetSuperAdmin()
        {
            _sql = "SELECT * FROM users WHERE userType = @userType;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userType", "Super Admin");
            _sqlReader = _command.ExecuteReader();
            if (_sqlReader.Read())
            {
                int userId = _sqlReader.GetInt32(0);
                string firstName = _sqlReader.GetString(1);
                string lastName = _sqlReader.GetString(2);
                string phoneNo = _sqlReader.GetString(3);
                string userName = _sqlReader.GetString(5);
                string password = _sqlReader.GetString(6);
                string registeredDate = _sqlReader.GetString(7);
                return new User(userId, firstName, lastName, phoneNo, "Super Admin", userName, password, registeredDate);
            }
            return null;
        }
        public bool SearchById(string userId, string passedUserType, DataGridView table)
        {
            if (passedUserType.Equals("Super Admin"))
            {
                _sql = "SELECT userId, firstName, lastName, phoneNo, userType, registeredDate " +
                       "FROM users " +
                       "WHERE userId LIKE CONCAT('%',@userId,'%');";
            } else
            {
                _sql = "SELECT userId, firstName, lastName, phoneNo, userType, registeredDate " +
                       "FROM users " +
                       "WHERE userId LIKE CONCAT('%',@userId,'%') AND " +
                       "userType = 'Sales Person'";
            }
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", userId);
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
        public bool SearchByName(string name, string passedUserType, DataGridView table)
        {
            if (passedUserType.Equals("Super Admin"))
            {
                _sql = "SELECT userId, firstName, lastName, phoneNo, userType, registeredDate " +
                       "FROM users " +
                       "WHERE firstName LIKE CONCAT('%',@firstName,'%') OR " +
                       "lastName LIKE CONCAT('%',@lastName,'%');";
            }
            else
            {
                _sql = "SELECT userId, firstName, lastName, phoneNo, userType, registeredDate " +
                       "FROM users " +
                       "WHERE (firstName LIKE CONCAT('%',@firstName,'%') OR " +
                       "lastName LIKE CONCAT('%',@lastName,'%')) AND " +
                       "(userType = 'Sales Person');";
            }
            
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
        public void Update(string firstName, string lastName, string phoneNo, string userType)
        {
            _sql = "UPDATE users " +
                   "SET firstName = @firstName, " +
                   "lastName = @lastName, " +
                   "phoneNo = @phoneNo, " +
                   "userType = @userType " +
                   "WHERE userId = @userId";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@firstName", firstName);
            _command.Parameters.AddWithValue("@lastName", lastName);
            _command.Parameters.AddWithValue("@phoneNo", phoneNo);
            _command.Parameters.AddWithValue("@userType", userType);
            _command.Parameters.AddWithValue("@userId", _userId);
            _command.ExecuteNonQuery();
        }
        public bool CheckUserName()
        {
            _sql = "SELECT * FROM users " +
                   "WHERE userName = @userName AND userType = @userType;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userName", _userName);
            _command.Parameters.AddWithValue("@userType", _userType);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public bool CheckUserId(int userId)
        {
            _sql = "SELECT * FROM users " +
                   "WHERE userId = @userId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", userId);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader.HasRows;
        }
        public SqlDataReader Authenticate(string userName, string password)
        {
            _sql = "SELECT * FROM users WHERE userName = @userName AND passwd = @passwd;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userName", userName);
            _command.Parameters.AddWithValue("@passwd", HashPassword(password));
            _sqlReader = _command.ExecuteReader();
            return _sqlReader;
        }
        public SqlDataReader Authenticate(string userName, string password, string userType)
        {
            _sql = "SELECT * FROM users WHERE userName = @userName AND passwd = @passwd AND userType = @userType;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userName", userName);
            _command.Parameters.AddWithValue("@passwd", HashPassword(password));
            _command.Parameters.AddWithValue("@userType", userType);
            _sqlReader = _command.ExecuteReader();
            return _sqlReader;
        }
        public void ChangePassword(string password)
        {
            _sql = "UPDATE users SET passwd = @passwd WHERE userId = @userId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@passwd", HashPassword(password));
            _command.Parameters.AddWithValue("@userId", UserId);
            _command.ExecuteNonQuery();
            _connection.Close();
        }
        public bool DeleteUser()
        {
            _sql = "DELETE FROM users WHERE userId = @userId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", _userId);
            int execute = _command.ExecuteNonQuery();
            return (execute > 0);
        }
        public string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
        public void Clear(TextBox firstNameF, TextBox lastNameF, TextBox phoneNoF, TextBox userNameF, TextBox passwdF)
        {
            firstNameF.Text = ""; lastNameF.Text = ""; phoneNoF.Text = "";
            userNameF.Text = ""; passwdF.Text = "";
        }
        public bool IsPhoneValid(string phoneNo)
        {
            return Int32.TryParse(phoneNo, out int phone);
        }
        public bool IsUserIdValid(string userId)
        {
            return Int32.TryParse(userId, out int user);
        }
    }
}