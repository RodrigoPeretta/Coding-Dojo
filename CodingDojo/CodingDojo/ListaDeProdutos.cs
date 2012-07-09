using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodingDojo_BLL;
using CodingDojo_Models;

namespace CodingDojo
{
    public partial class ListaDeProdutos : Form
    {
        public ListaDeProdutos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();

            Limpar();
        }

        public void Listar()
        {
            ProdutoBll produtoBll = new ProdutoBll();

            if (String.IsNullOrEmpty(txtBuscar.Text))
            {
                dgvProdutos.DataSource = produtoBll.ListarTodos();
            }
            else
            {
                dgvProdutos.DataSource = produtoBll.ListarProduto(txtBuscar.Text);

            }
        }

        private void Limpar()
        {
            txtBuscar.Text = string.Empty;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            var row = dgvProdutos.SelectedRows[0];

            produto.IdProduto = Convert.ToInt32(row.Cells["IdProduto"].Value);
            produto.Nome = row.Cells["Nome"].Value.ToString();
            produto.Descricao = row.Cells["Descricao"].Value.ToString();

            ProdutoBll produtoBll = new ProdutoBll();
            produtoBll.Exluir(produto);

            if (produtoBll.Exluir(produto))
            {
                MessageBox.Show("Produto Excluido com Sucesso");
                dgvProdutos.DataSource = produtoBll.ListarTodos();
            }
            else
            {
                MessageBox.Show("Erro ao Excluir Produto");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();

            var row = dgvProdutos.SelectedRows[0];

            produto.IdProduto = Convert.ToInt32(row.Cells["IdProduto"].Value);
            produto.Nome = row.Cells["Nome"].Value.ToString();
            produto.Descricao = row.Cells["Descricao"].Value.ToString();
    
            FormCadastro cadastro = new FormCadastro();

            cadastro.Atualizar(produto);

            Listar();
        }

        private void btnCadastrarN_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();

            cadastro.ShowDialog();
        }
    }
}
