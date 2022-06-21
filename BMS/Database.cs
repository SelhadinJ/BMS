using System.Data.SqlClient;

namespace Boutique_Management_System
{
    internal class Database
    {
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        string _sql;

        public bool DropTabels()
        {
            _sql = "DROP TABLE purchases; " +
                   "DROP TABLE products; " +
                   "DROP TABLE categories; " +
                   "DROP TABLE audits; " +
                   "DROP TABLE customers; " +
                   "DROP TABLE users;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            int execute = _command.ExecuteNonQuery();
            return execute > 0;
        }
        public bool CreateTabels()
        {
            _sql = "CREATE TABLE users ( " +
                          "     userId INT IDENTITY(1, 1) PRIMARY KEY," +
                          "     firstName VARCHAR(15) NOT NULL, " +
                          "     lastName VARCHAR(15), " +
                          "     phoneNo VARCHAR(15) NOT NULL, " +
                          "     userType VARCHAR(15) NOT NULL, " +
                          "     userName VARCHAR(50) NOT NULL, " +
                          "     passwd VARCHAR(256) NOT NULL, " +
                          "     registeredDate VARCHAR(15) " +
                          "); " +
                          "CREATE TABLE customers ( " +
                          "     customersId INT IDENTITY(1, 1) PRIMARY KEY, " +
                          "     firstName VARCHAR(15) NOT NULL, " +
                          "     lastName VARCHAR(15), " +
                          "     phoneNo VARCHAR(15) NOT NULL, " +
                          "     gender VARCHAR(1) DEFAULT 'M', " +
                          "     address VARCHAR(50) NOT NULL, " +
                          "     userId INT, " +
                          "     registeredDate VARCHAR(15) " +
                          "     FOREIGN KEY(userId) REFERENCES users(userId) " +
                          "     ON DELETE SET NULL ON UPDATE CASCADE " +
                          "); " +
                          "CREATE TABLE audits ( " +
                          "     auditNo INT IDENTITY(1,1) PRIMARY KEY, " +
                          "     userId INT, " +
                          "     auditDate DATETIME, " +
                          "     auditStatus VARCHAR(10), " +
                          "     FOREIGN KEY(userId) REFERENCES users(userId) " +
                          "     ON DELETE CASCADE ON UPDATE CASCADE" +
                          "); " +
                          "CREATE TABLE categories ( " +
                          "     catNo INT PRIMARY KEY, " +
                          "     catDescription VARCHAR(50) NOT NULL " +
                          "); " +
                          "CREATE TABLE products ( " +
                          "     proNo INT IDENTITY(1,1) PRIMARY KEY, " +
                          "     proDescription VARCHAR(50) NOT NULL, " +
                          "     brand VARCHAR(15) NOT NULL, " +
                          "     unitPrice INT NOT NULL, " +
                          "     quantity INT NOT NULL, " +
                          "     catNo INT, " +
                          "     FOREIGN KEY(catNo) REFERENCES categories(catNo) " +
                          "     ON DELETE CASCADE ON UPDATE CASCADE " +
                          "); " +
                          "CREATE TABLE purchases ( " +
                          "     purchaseNo INT IDENTITY(1,1) PRIMARY KEY, " +
                          "     customersId INT, " +
                          "     proNo INT, " +
                          "     quantity INT NOT NULL, " +
                          "     totalPrice INT NOT NULL, " +
                          "     purchaseDate DATE, " +
                          "     userId INT, " +
                          "     FOREIGN KEY(proNo) REFERENCES products(proNo) " +
                          "     ON DELETE SET NULL, " +
                          "     FOREIGN KEY(userId) REFERENCES users(userId) " +
                          "     ON DELETE SET NULL " +
                          ");";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            int execute = _command.ExecuteNonQuery();
            _connection.Close();
            return execute > 0;
        }
    }
}
