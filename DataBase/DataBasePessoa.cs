using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.DataBase
{
    public class DataBasePessoa
    {

        private string SqlConn()
        {
            return ConfigurationManager.AppSettings["SqlCoon"];
        }

        public DataTable Lista()
        {
            return null;
        }

        public string Mostrar()
        {
            return "Mostrei";
        }
    
    }

}

   
