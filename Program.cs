using System;
using LP2.Models;

namespace LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco(){
                Id = 1,
                Nome = "Banco do Brasil"                
            };
            Agencia agencia = new Agencia(){
                Id = 1,
                Banco = banco,
                BancoId = 1,
                Cidade = "Aracati",
                Nome = "Ag do Aracati",
                Numero  = "0121-x"
            };
            Cliente cliente = new Cliente(){
                Id = 1,
                Nome = "Cleitianne",
                Cpf = "000.000.000-00",


            };
            ContaCorrente cc = new ContaCorrente(){
                Id = 1,
                Cliente = cliente,
                ClienteId = 1,
                Numero = "2601-x",
                SaldoCorrente = 300,
                Agencia = agencia,
                AgenciaId = 1
            };
            while(true){
                Console.WriteLine("Digite 1 para depositar");
                Console.WriteLine("Digite 2 para Sacar");
                Console.WriteLine("Digite 3 Consultar Saldo");
                Console.WriteLine("Digite 0 para sair");
                var op = Convert.ToInt32(Console.ReadLine());
                if(op==0)break;
                if(op==1){
                    var valor = 0;
                    Console.WriteLine("Digite o valor que voce deseja depositar");
                    valor = Convert.ToInt32(Console.ReadLine());
                    cc.Depositar(valor);
                }
                if(op==2){
                    var valor = 0;
                    Console.WriteLine("Digite o valor que voce deseja sacar");
                    valor = Convert.ToInt32(Console.ReadLine());
                    cc.Sacar(valor);
                }
                if(op==3){
                    
                    Console.WriteLine("Seu saldo é: " + cc.SaldoCorrente);
                                    }
            }
        }
    }
}
