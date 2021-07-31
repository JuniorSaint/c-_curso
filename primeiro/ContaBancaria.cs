using System;
namespace primeiro
{
    public class ContaBancaria
    {


        public string Titular { get; set; }
        public int ContaBancariaP { get; private set; }
        public double DepositoRetirada { get; set; }
        public double SaldoIncial { get; set; }


        public ContaBancaria(int contaBancaria, string titular, double saldoInicial, double depositoRetirada)
        {
            ContaBancariaP = contaBancaria;
            Titular = titular;
            DepositoRetirada = depositoRetirada;
            SaldoIncial = saldoInicial;
        }

        public ContaBancaria(int contaBancaria, string titular, double depositoRetirada)
        {
            ContaBancariaP = contaBancaria;
            Titular = titular;
            DepositoRetirada = depositoRetirada;

        }

        public string SaldoFinal() {

            if (DepositoRetirada > 0)
            {
                double saldo = SaldoIncial + DepositoRetirada;
                return $"Seu deposito foi de {DepositoRetirada:f2} e seu saldo atual é {saldo:f2}, referente a conta {ContaBancariaP} do titular {Titular:f2} ";
            }
            else {
                double saldo = SaldoIncial + DepositoRetirada - 5.00;
                return $"Sua retira foi de {DepositoRetirada:f2} e seu saldo atual é {saldo:f2}, referente a conta {ContaBancariaP} do titular {Titular:f2} ";
            }
        }
    }

}   
    
