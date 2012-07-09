using System;
using System.Windows.Forms;
using CodingDojo_BLL;
using CodingDojo_Models;

namespace CodingDojo
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDesc.Text;

            ProdutoBll produtoBll = new ProdutoBll();
            produtoBll.Salvar(produto);

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
