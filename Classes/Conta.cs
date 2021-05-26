using System;

namespace DIO.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get;  set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        public string Nome { get;  set; }

        public Conta(TipoConta TipoConta, double Saldo, double Credito, string Nome)
        {
            this.TipoConta = TipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public bool Sacar(double ValorSaque)
        {
            // Validação de saldo suficiente
            if (this.Saldo - ValorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= ValorSaque;
            
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting

            return true;
        }

        public void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double ValorTransferencia, Conta ContaDestino)
        {
            if (this.Sacar(ValorTransferencia))
            {
                ContaDestino.Depositar(ValorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
            return retorno;
        }
    }
}