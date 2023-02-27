using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprovado_Reprovado
{
    internal class Program
    {
        // Regiao do struct
        #region
        struct notas
        {
            public int nota;
            public string presenca;
        }
        #endregion
        static void Main(string[] args)
        {
            //referencia ao struct
            notas media= new notas();

            Console.WriteLine("Ola, bem vindo ao programa de avaliaçao estudantil.");
            Console.WriteLine("Aqui sera feito a relaçao entre as notas e a % de presença, e no final sera " +
                "exibido se a sua situaçao é aprovado, recupeçao ou retido.");
            //Solicita ao usuario a entrada da nota
            try
            {
                Console.WriteLine("Digite abaixo a nota do aluno!");
                media.nota = int.Parse(Console.ReadLine());

                Console.WriteLine("Agora digite a porcentagem de presençao desse aluno");
                media.presenca = Console.ReadLine().TrimEnd('%');
            } catch (FormatException) 
            { 
                Console.WriteLine("Numero invalido, reinicie o programa e digite um numero inteiro!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Area da conversao de string para int

            int presenca = Int32.Parse(media.presenca);
            
            // Local das condiçoes
            if ( media.nota >= 7 && presenca >= 75 ) {
                Console.WriteLine( "APROVADO" );
            }
            else if ( media.nota <7 && media.nota >= 4 && presenca >= 75 ) {
                Console.WriteLine( "RECUPERAÇAO" );
            } else if ( media.nota >= 7 && presenca <75 ) {
                Console.WriteLine( "RECUPERAÇAO" );
            } else if( media.nota < 7 && media.nota >= 4 ){
                Console.WriteLine( "RETIDO" );
            } else if (media.nota < 4){
                Console.WriteLine( "RETIDO" );
            }

            Console.ReadKey();

        }
    }
}
