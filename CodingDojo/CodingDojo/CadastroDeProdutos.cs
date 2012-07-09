using System;
using System.Windows.Forms;
using CodingDojo_BLL;
using CodingDojo_Models;

namespace CodingDojo
{
    public partial class FormCadastro : Form
    {
        private Produto produto;

        public FormCadastro()
        {
            InitializeComponent();
            produto = new Produto();
        }

        public void Atualizar(Produto produto)
        {
            
            this.produto = produto;

            PreencheProduto(produto);

            this.ShowDialog();      

        }

        private void PreencheProduto(Produto produto)
        {
            txtNome.Text = produto.Nome;
            txtDesc.Text = produto.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDesc.Text;

            ProdutoBll produtoBll = new ProdutoBll();

            if (produto.IdProduto == 0)
            {
                if (produtoBll.Salvar(produto))
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto");
                }
            }
            else
            {
                if (produtoBll.Alterar(produto))
                {
                    MessageBox.Show("Produto Alterado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Alterar Produto");
                }

                
                this.Close();
            }


            Limpar();
        }
        public void Limpar()
        {
            txtNome.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }

        private void lbnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
