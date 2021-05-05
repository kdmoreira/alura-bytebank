using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("12345678912");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");
        }
    }
}
