using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClientes
{
	public class Cliente
	{
        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public DateTime DatadeNascimento { get; set; }

        public string Telefone { get; set; }

        public string Endereço { get; set; }


        public Cliente (string nome, string rg, string cpf,
			DateTime datadeNascimento, string telefone, string endereço)
        {
            Nome = nome;
            RG = rg;
            CPF = cpf;
            DatadeNascimento = datadeNascimento;
            Telefone = telefone;
            Endereço = endereço;


        }
    }
}
