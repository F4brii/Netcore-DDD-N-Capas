using System;
using System.Data;
using System.Data.SqlClient;

namespace test.Infraestructure.Context 
{
    
    public class ConnectionSQl 
    {
        protected SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=test;User ID=SA;Password=Assemblix86*;");
    }

}