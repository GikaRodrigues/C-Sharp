// using System;

// namespace EscolaDeRock
// {
//     enum FormacaoEnum : uint
//     {
//         TRIO,
//         QUARTETO
//     }

//     enum InstrumentosEnum : uint
//     {
//         BATERIA,
//         GUITARRA,
//         PIANO,
//         FLAUTA,
//         VIOLAO
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var opcoesFormacao = new List<string>(){
//                 "   -0                           ",
//                 "   -1                      "
//             };
//             bool querSair = false;
//             string barraMenu = "===================================";
//             string[] itensMenuFormacaoEnum;GetNames(typeof(FormacaoEnum));
//             int opcaoFormacaoSelecionada = 0;

//             do
//             {
//             bool formacaoEscolhida = false;
                
//                 do
//                 {
//                     Console.Clear();
//                     System.Console.WriteLine(barraMenu);
//                     System.Console.WriteLine("===================================");
//                     System.Console.WriteLine("  \\m/      Escola de Rock       \\m/");
//                     System.Console.WriteLine("       Escolha sua formação:       ");
//                     System.Console.WriteLine(barraMenu);

//                     for (int i = 0; i < opcoesFormacao.Count; i++)
//                     {
//                         string titulo = TratarTituloMenu(itensMenuFormacaoEnum[i++]);

//                         if (opcaoFormacaoSelecionada)
//                         {
//                             DestacarOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-",     ">").Replace(i.ToString(), titulo));
//                         }else
//                         {
//                             System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),    titulo));
//                         }
//                     }

//                     var tecla = Console.ReadKey(true).Key;

//                     switch (tecla)
//                     {
//                         case ConsoleKey.UpArrow:
//                             opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
//                         break;
//                         // case ConsoleKey.DownArrow:
//                         //     opcaoFormacaoSelecionada == opcaoFormacaoSelecionada.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
//                         // break;
//                         case ConsoleKey.Enter:
//                             formacaoEscolhida = true;
//                         break;
//                     }
                
//                 } while (!formacaoEscolhida);




//                 bool bandaEstaCompleta = false;
//                 int vagas = 0;

//                 switch (opcaoFormacaoSelecionada)
//                 {
//                     case 0:
//                         do
//                         {
//                             ExibirMenuDeInstrumentos();
//                             System.Console.WriteLine("Digite o codigo do instrumento para a harmonia");
//                             int codigo = int.Parse(Console.ReadLine());
//                             var instrumento = Candidatos.Instrumentos[codigo];

//                             ColocarNaBanda();
//                         } while (!bandaEstaCompleta);
//                     break;
//                     case 1:
//                     break;
//                     default:
//                 }

//             } while (!querSair);
//         }

//         public static string TratarTituloMenu (string titulo) {
            
//         }

//         public static void DestacarOpcao (string opcao) {
            
//         }

//         public static void ExibirMenuDeInstrumentos () {
//             var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
//             int codigo = 1;
//             string menuInstrumentoBorda = "##############################";
//             System.Console.WriteLine (menuInstrumentoBorda);
//             System.Console.WriteLine ("#         Instrumentos        #");

//             foreach (var instrumento in instrumentos) 
//             {
//                 System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
//             }

//             System.Console.WriteLine (menuInstrumentoBorda);

//         }
//     }
// }
