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

        public List<Produto> ListarTodos()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RODRIGO-NOTE\SQLEXpress;Initial Catalog=DojoBD;Integrated Security=True");
            
            string sql = string.Format("select * from Produto");

            SqlCommand command = new SqlCommand(sql,connection);

            List<Produto> listProdutos = new List<Produto>();

            try
            {
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();


                while (dr.Read())
                {
                    Produto produto = new Produto();

                    produto.IdProduto = Convert.ToInt32(dr["Id"]);
                    produto.Nome = dr["Nome"].ToString();
                    produto.Descricao = dr["Descricao"].ToString();

                    listProdutos.Add(produto);
                }

                connection.Close();

                return listProdutos;
            }
            catch(System.Exception ex)
            {
                return null;
            }
        }

        public List<Produto> ListarProduto(string nome)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RODRIGO-NOTE\SQLEXpress;Initial Catalog=DojoBD;Integrated Security=True");

            string Sql = string.Format("Select * from Produto where Nome like '{0}%'", nome);

            SqlCommand command = new SqlCommand(Sql,connection);

            List<Produto> produtos = new List<Produto>();

            try
            {
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();


                while (dr.Read())
                {
                    Produto produto = new Produto();

                    produto.IdProduto = Convert.ToInt32(dr["Id"]);
                    produto.Nome = dr["Nome"].ToString();
                    produto.Descricao = dr["Descricao"].ToString();

                    produtos.Add(produto);
                }

                connection.Close();

                return produtos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Exluir(Produto produto)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RODRIGO-NOTE\SQLEXpress;Initial Catalog=DojoBD;Integrated Security=True");

            string sql = string.Format("Delete from Produto where Id={0}", produto.IdProduto);

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

        public bool Alterar(Produto produto)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RODRIGO-NOTE\SQLEXpress;Initial Catalog=DojoBD;Integrated Security=True");

            string sql = string.Format("Update Produto set Nome='{0}',Descricao='{1}' where Id = {2}", produto.Nome,
                                       produto.Descricao, produto.IdProduto);

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
