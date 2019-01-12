using System;

namespace ProjetoBanco
{
    class Program
    {
        // Criando os objetos
        private static Banco banco = new Banco();
        private static Conta contaDestino;

        // Construtor
        static Program()
        {
            var cidade = new Cidade("Jundiaí","SP");
            var endereco = new Endereco("Rua Denis", "Centro", "13219-000", 100, cidade);
            var cliente = new Cliente("Luís Lança", "36038072851", new DateTime(1999, 7, 9), endereco);
            contaDestino = banco.AbrirConta(cliente);
        }

        // O programa
        static void Main(string[] args)
        {
            try
            {
                var cidade = new Cidade("Jundiaí", "SP");
                var endereco = new Endereco("Rua Denis", "Centro", "13219-000", 100, cidade);
                var cliente = new Cliente("Luís Lança", "36038072851", new DateTime(1999, 7, 9), endereco);

                var contaLuis = banco.AbrirConta(cliente);

                contaLuis.Depositar(15000);
                contaLuis.Sacar(200);
                contaLuis.TirarExtrato();
                contaLuis.Transferir(1, 1, 500);
                contaLuis.TirarExtrato();
                contaDestino.TirarExtrato();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            Console.ResetColor();
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
     
        }
    }
}
