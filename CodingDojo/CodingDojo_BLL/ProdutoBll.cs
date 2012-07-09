using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingDojo_DAL;
using CodingDojo_Models;

namespace CodingDojo_BLL
{
    public class ProdutoBll:IProduto
    {
        private bool Validar(Produto produto)
        {
            if (String.IsNullOrEmpty(produto.Nome))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool Salvar(Produto produto)
        {
            if (Validar(produto))
            {
                ProdutoDal produtoDal = new ProdutoDal();
                produtoDal.Salvar(produto);
            }

            return true;
        }
    }
}
