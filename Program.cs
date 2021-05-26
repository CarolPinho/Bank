using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta MinhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Carolina Pinho");

            Console.WriteLine(MinhaConta.ToString());
        }
    }
}
