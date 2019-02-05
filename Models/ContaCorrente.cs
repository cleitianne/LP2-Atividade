using System;
using System.Collections.Generic;
using System.Text;

namespace LP2.Models
{
    public class ContaCorrente : Conta
    {
        public float SaldoCorrente { get; set; }
        
        public void Sacar(float valor){
            this.SaldoCorrente-=valor;
        }
        public void Depositar(float valor){
            this.SaldoCorrente+=valor;
        }
    }
}
