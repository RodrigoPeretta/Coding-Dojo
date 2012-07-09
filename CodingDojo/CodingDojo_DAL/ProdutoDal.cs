using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CodingDojo_Models;

namespace CodingDojo_DAL
{
    public class ProdutoDal: IProduto
    {

        public bool Salvar(Produto produto)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RODRIGO-NOTE\SQLEXpress;Initial Catalog=DojoBD;Integrated Security=True");

            string sql = string.Format("insert into Produto Values('{0}','{1}')", produto.Nome, produto.Descricao);

            SqlCommand command = new SqlCommand(sql,connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
