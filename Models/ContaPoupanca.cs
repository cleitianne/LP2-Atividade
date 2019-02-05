using System;
using System.Collections.Generic;
using System.Text;

namespace LP2.Models
{
    public class ContaPoupanca1 : Conta
    {
        public int Variacao {get; set;}
        public float SaldoPoupanca { get; set; }
        public DateTime DataAniversario{ get; set; }
        public float Juros {get; set;}

        public void Sacar(float valor){
            this.SaldoPoupanca-=valor;
        }
        public void Depositar(float valor){
            this.SaldoPoupanca+=valor;
        }
        public void AdicionarRendimentos() {
            if(DateTime.Now.Equals(DataAniversario)){
                var redimentos = this.SaldoPoupanca * this.Juros;
                Depositar(redimentos);
            }
        }
    }
}
