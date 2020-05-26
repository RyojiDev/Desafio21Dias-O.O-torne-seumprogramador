using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ORMDesafio21Dias
{
    public sealed class Service
    {

        private Ctype ctype;

        public Service()
        {

        }

        public Service(Ctype _ctype)
        {
            this.ctype = _ctype;
        }

        public void Save()
        {
            using (SqlConnection conn = new SqlConnection(this.ctype.ConnectionString))
            {

                List<string> columns = new List<string>();
                List<object> values = new List<object>();

                foreach (var p in this.ctype.GetType().GetProperties())
                {
                    TableAttribute[] propertyAttributes = (TableAttribute[])p.GetCustomAttributes(typeof(TableAttribute), false);
                    if (propertyAttributes != null && propertyAttributes.Length > 0)
                    {
                        if (!propertyAttributes[0].IsNotOnDataBase && string.IsNullOrEmpty(propertyAttributes[0].PrimaryKey))
                        {
                            columns.Add(p.Name);
                            values.Add(p.GetValue(this.ctype));
                        }
                    }
                }

                string table = $"{this.ctype.GetType().Name.ToLower()}s";

                TableAttribute[] tableAttributes = (TableAttribute[])this.ctype.GetType().GetCustomAttributes(typeof(TableAttribute), false);
                if (tableAttributes != null && tableAttributes.Length > 0)
                {
                    table = tableAttributes[0].Name;
                }

                string sql = $"insert into {table} (id, nome, endereco, tipo, cpfcnpj) values ( @id, @nome, @endereco, @tipo, @cpfcnpj)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = ctype.Id;





                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public static T All<T>()
        {
            throw new NotImplementedException();
        }

    }
}

