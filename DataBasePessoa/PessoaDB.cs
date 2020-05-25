using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePessoa
{
    public class PessoaDB
    {

        private string SqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(SqlConn()))
            {
                try
                {
                    string queryString = "Select * from PessoaFisica";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    return table;

                }
                catch (Exception e)
                {
                    throw new Exception("Erro: " + e.Message);
                }

            }
        }

       

    }
}

