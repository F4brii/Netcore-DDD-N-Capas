using System;
using System.Data;
using System.Data.SqlClient;

namespace test.Infraestructure.Context {
    
    public class Connection {

        const string StringConnection = @"Data Source=localhost;Initial Catalog=test;User ID=SA;Password=Assemblix86*;";
        private static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open();
            return connection;
        }

        public static SqlCommand GetCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetConnection();
            return command;
        }

        public static int RunCommand(SqlCommand command)
        {
            int response = command.ExecuteNonQuery();
            command.Connection.Close();
            return response;
        }

        public static SqlDataReader RunCommandReader(SqlCommand command)
        {
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}