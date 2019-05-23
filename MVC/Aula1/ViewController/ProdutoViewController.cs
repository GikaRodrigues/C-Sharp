using System;
using System.Collections.Generic;
using Aula1.Repositorio;
using Aula1.Utils;
using Aula1.ViewModel;

namespace Aula1.ViewController
{
    public class ProdutoViewController
    {

        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(){
            string nome, descricao, categoria;
            float preco;
                
                    do
                    {
                        System.Console.WriteLine("Digite o nome da comida:");
                        nome = Console.ReadLine();
                        if (!string.IsNullOrEmpty(nome))
                        {
                            System.Console.WriteLine("Coloque o nome do baguio!");
                        }//fim if
                    } while (!string.IsNullOrEmpty(nome));

                    do
                    {
                        System.Console.WriteLine("Insira uma descrição:");
                        descricao = Console.ReadLine();
                        if (!string.IsNullOrEmpty(descricao))
                        {
                            System.Console.WriteLine("Coloque uma descriçao cacete!");
                        }//fim if
                    } while (!string.IsNullOrEmpty(descricao));

                    do
                    {
                        System.Console.WriteLine("Digite o preço do prato:");
                        preco = float.Parse(Console.ReadLine());
                        if (float.IsNegative(preco))
                        {
                            System.Console.WriteLine("COLOCA UM NÚMERO COMUM ANIMAL!");
                        }

                    } while (float.IsNegative(preco));

                    do
                    {
                        System.Console.WriteLine("Digite a categoria do prato:");
                        categoria = Console.ReadLine();
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            System.Console.WriteLine("COLOCA A CATEGORIA!");
                        }//fim if
                    } while (!string.IsNullOrEmpty(categoria));

                     //Cria um objeto do tipo produto
                    ProdutoViewModel produtoViewModel = new ProdutoViewModel();
                    produtoViewModel.Nome = nome;
                    produtoViewModel.Descricao = descricao;
                    produtoViewModel.Preco = preco;
                    produtoViewModel.Categoria = categoria;

            }
            public static void ListarProduto()
            {
                List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();

                foreach (var item in listaDeProdutos)
                {
                System.Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nDescrição:{item.Descricao}\nPreço:{item.Preco}\nCategoria:{item.Categoria}Data de criação: {item.DataCriacao}");
                }

        }

            public static void BuscarId(){
                System.Console.WriteLine("Qual o Id do produto mano:");
                int procura = int.Parse(Console.ReadLine());
                List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
                foreach (var item in listaDeProdutos)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine("Não existe o produto com esse Id!");
                    }
                    if (procura.Equals(item.Id))
                    {
                         System.Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nDescrição:{item.Descricao}\nPreço:{item.Preco}\nCategoria:{item.Categoria}Data de criação: {item.DataCriacao}");
                    }
            }
       }
    }
}