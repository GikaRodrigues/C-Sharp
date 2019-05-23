using System.Collections.Generic;
using Aula1.ViewModel;

namespace Aula1.Repositorio
{
    public class ProdutoRepositorio
    {
        List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
        /// <sumary>Método responsavel por armazenar um Produto</sumary>
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            produto.Id = listaDeProdutos.Count + 1;
            //insere o objeto produto dentro da lista
            listaDeProdutos.Add(produto);

            return produto;
        }

        public List<ProdutoViewModel> Listar(){
            return listaDeProdutos;
        }    
    }
}