using System;
using System.Data.SqlClient;

namespace DapperUygulama.Concrete.Dapper
{
    public class DbConfig : IDisposable
    {
        private SqlConnection con;
        private SqlConnectionStringBuilder builder;

        public DbConfig()
        {
            con = new SqlConnection(ConnectionStringGetir());
        }

     
        private string ConnectionStringGetir()
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".\\SQLExpress";
            builder.InitialCatalog = "DapperUygulama";
            builder.UserID = "sa";
            builder.Password = "1";
            return builder.ConnectionString;
        }

        public SqlConnection BaglantiyiGetir()
        {
            return con;
        }

        public void Dispose()
        {
          
        }
    }
}
