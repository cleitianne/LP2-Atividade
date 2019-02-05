using System;
using System.Collections.Generic;
using System.Text;

namespace LP2.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Contas = new HashSet<Conta>();   
        }
        public int Id { get; set; }
        public string Nome {get; set;}
        public string Cpf {get;set;}
        public ICollection<Conta> Contas {get;set;}

    }
}
