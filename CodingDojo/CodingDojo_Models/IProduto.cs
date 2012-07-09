using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo_Models
{
    public interface IProduto
    {
        bool Salvar(Produto produto);
        List<Produto> ListarTodos();
        List<Produto> ListarProduto(string nome);
        bool Exluir(Produto produto);
        bool Alterar(Produto produto);
    }
}
