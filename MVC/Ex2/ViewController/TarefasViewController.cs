using System;
using System.Collections.Generic;
using Ex2.Repositorio;
using Ex2.Utils;
using Ex2.ViewModel;

namespace Ex2.ViewController
{
    public class TarefasViewController
    {
        
        static TarefasRepositorio tarefasRepositorio = new TarefasRepositorio();

        public static void CadastrarTarefas(){
            string nome, descricao,statusTarefa;

            do
            {
                System.Console.WriteLine("Digite o nome:");
                        nome = Console.ReadLine();
                        if (string.IsNullOrEmpty(nome))
                        {
                            System.Console.WriteLine("Coloque o nome do baguio!");
                        }//fim if
            } while (string.IsNullOrEmpty(nome));

            do
                {
                    System.Console.WriteLine("Insira uma descrição:");
                    descricao = Console.ReadLine();
                    if (string.IsNullOrEmpty(descricao))
                    {
                        System.Console.WriteLine("Coloque uma descriçao cacete!");
                    }//fim if
                } while (string.IsNullOrEmpty(descricao));

                do
                {
                    System.Console.WriteLine("Insira o status da tarefa (a fazer, fazendo ou feito):");
                    statusTarefa = Console.ReadLine();
                    if (string.IsNullOrEmpty(statusTarefa))
                    {
                        System.Console.WriteLine("Coloque o status!");
                    }//fim if
                } while (string.IsNullOrEmpty(statusTarefa));


            TarefasViewModel produtoViewModel = new TarefasViewModel();
                    produtoViewModel.Nome = nome;
                    produtoViewModel.Descricao = descricao;
                    produtoViewModel.StatusTarefa = statusTarefa;
        }


        public static void ListarTarefas(){

            List<TarefasViewModel> listaDeTarefas = tarefasRepositorio.Listar();

            foreach (var item in listaDeTarefas)
            {
                Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nDescrição: {item.Descricao}\nStatus Tarefa: {item.StatusTarefa}\nId usuario:{item.IdUsuario}\nData criação: {item.DataCriacao}");
            }
        }
    }
}