using System;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class Program {

        static void Main(string[] args) {
            Arquivo input = null;
            Arquivo output = null;
            string saida = "";
            
            if (args.Length >= 2 && args.Length < 5) {
                for (int i = 0; i < args.Length; i++) {
                    if (args[i] == "--in")
                        input = new Arquivo(args[i + 1]);

                    if (args[i] == "--out")
                        saida = args[i + 1];
                }

                if (saida.Length > 0)
                    input.converteParaFinanceiro(saida);
                else
                    input.converteParaFinanceiro();
            } else {
                Console.WriteLine("O modo correto de uso é:");
                Console.WriteLine("conv --in nome_arquivo_input [--out nome_arquivo_output]");
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }

    }

}
