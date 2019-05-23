using System;
using System.Collections.Generic;
using System.IO;
using Ex2.Utils;
using Ex2.ViewModel;

namespace Ex2.Repositorio
{
    public class TarefasRepositorio
    {
        
        //List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel>();

        public TarefasViewModel Inserir(TarefasViewModel tarefas){
            int contador = 0;
            List<TarefasViewModel> listaDeTarefas = Listar();
            if (listaDeTarefas != null)
            {
                contador = listaDeTarefas.Count;
            }

            tarefas.Id = contador + 1;
            tarefas.DataCriacao = DateTime.Now;
            //insere o objeto tarefas dentro da lista
            //listaDeTarefas.Add(tarefas);
            StreamWriter sw = new StreamWriter("Tarefas.csv", true);
            sw.WriteLine($"{tarefas.Id};{tarefas.Nome};{tarefas.Descricao};{tarefas.DataCriacao}");
            sw.Close();

            return tarefas;
        }

            public List<TarefasViewModel> Listar(){
                List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel>();
            TarefasViewModel tarefasViewModel;
            if (!File.Exists("tarefas.csv")) {
                return null;
            }
            string[] tarefas = File.ReadAllLines("tarefas.csv");
            
            foreach (var item in tarefas)
            {
                if (item != null)
                {
                string[] dadosDeCadaTarefa = item.Split(";");
                tarefasViewModel = new TarefasViewModel();
                tarefasViewModel.Id = int.Parse(dadosDeCadaTarefa[0]);
                tarefasViewModel.Nome = dadosDeCadaTarefa[1];
                tarefasViewModel.Descricao = dadosDeCadaTarefa[2];
                tarefasViewModel.DataCriacao = DateTime.Parse(dadosDeCadaTarefa[3]);
                listaDeTarefas.Add(tarefasViewModel);
                }//fim if
            }
            return listaDeTarefas;
        }//fim listar
    }
}