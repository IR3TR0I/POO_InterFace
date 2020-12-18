using System;
using System.Collections.Generic;

namespace poo_interface.Classes
{
    public class NewBaseType
    {
        public void Alterar(int cod)
        {
            throw new NotImplementedException();
        }
    }

    public class Carrinho : NewBaseType, ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();
        private object codigo;

        public void Alterar(int Codigo, Produto novoProduto)
        {
            //Codigo lambda 
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
            carrinho.Find(x=> x.Codigo == codigo).Codigo = novoProduto.Codigo;

        }

        public new void Alterar(int cod)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Deletar(int cod)
        {
            Produto prodDelete = carrinho.Find(x => x.Codigo == codigo);
            if(prodDelete != null){
                carrinho.Remove(prodDelete);
            }
        }

        public void Listar()
        {
            foreach (Produto produto in carrinho)
            {
                Console.WriteLine($"R$r {produto.Preco,2} - {produto.Nome}");
            }
        }

        internal void Alterar(object codigo, Produto p3)
        {
            throw new NotImplementedException();
        }

        internal void Deletar(object codigo)
        {
            throw new NotImplementedException();
        }
    }
}