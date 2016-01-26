using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Manager.Models
{
    public class GenericDataAccess
    {
        public static SqlCommand CreateCommand()
        {
            string connectString =
            WebConfigurationManager.ConnectionStrings["ApartmentConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            return command;
        }

        public static DataTable ExecuteSelectCommand(SqlCommand command)
        {
            DataTable table;
            try
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            finally { command.Connection.Close(); }
            
            return table;
        }

        public static int ExecuteNoneQuery(SqlCommand command)
        {
            int affectedRows = -1;
            try
            {
                command.Connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            finally { command.Connection.Close(); }
            return affectedRows;
        }

        public static string ExecuteScalar(SqlCommand command)
        {
            string value = "";
            try
            {
                command.Connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            finally { command.Connection.Close(); }
            return value;
        }
    }
}