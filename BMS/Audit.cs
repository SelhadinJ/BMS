using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    //Audit Table Model
    internal class Audit
    {
        readonly string _url = "Data Source = ANONYMOUS; Database = BoutiqueMS; Integrated Security = SSPI";
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _sqlReader;
        string _sql;
        User _user;
        DateTime _auditDate;
        string _status;

        //2 Overloaded Constructors
        public Audit() { }
        public Audit(User user, string status)
        {
            _user = user;
            _auditDate = DateTime.Now;
            _status = status;
        }
        public void InsertAuditRecord()
        {
            _sql = "INSERT INTO audits VALUES (@userId, @auditDate, @status);";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", _user.UserId);
            _command.Parameters.AddWithValue("@auditDate", _auditDate);
            _command.Parameters.AddWithValue("@status", _status);
            _command.ExecuteNonQuery();
            _connection.Close();
        }
        public bool GetAuditOf(int userId, DateTime from, DateTime to, DataGridView table)
        {
            _sql = "EXECUTE getAuditOf_From_To_ @userId, @from, @to;";
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
        public int ResetAuditRecord(int userId)
        {
            _sql = "DELETE FROM audits WHERE userId = @userId;";
            _connection = new SqlConnection(_url);
            _connection.Open();
            _command = new SqlCommand(_sql, _connection);
            _command.Parameters.AddWithValue("@userId", userId);
            return _command.ExecuteNonQuery();
        }
    }
}
