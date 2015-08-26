using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20150825_NetSimpleCripto {
    class Program {
        static void Main(string[] args) {
            string texto = null;

            Console.Write("Digite o texto a ser criptografado: ");
            texto = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Criptografado:");
            texto = Cripto.GetInstancia().ToCripto(texto);
            Console.WriteLine(texto);

            Console.WriteLine();
            Console.WriteLine("Decriptografado:");
            texto = Cripto.GetInstancia().ToDecripto(texto);
            Console.WriteLine(texto);

            Console.WriteLine();
            Console.WriteLine("Tabela de conversão:");
            Cripto.GetInstancia().PrintTabela();
            Console.ReadKey();
        }
    }
}
