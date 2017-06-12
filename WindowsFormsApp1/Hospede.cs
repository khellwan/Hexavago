using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hospede
    {
        private string nome_completo;
        private string cpf;
        private string senha;
        private string email;
        private int ano_de_nascimento;

        public Hospede(string nome_completo, string cpf, string senha, string email, int ano_de_nascimento)
        {
            this.nome_completo = nome_completo;
            this.cpf = cpf;
            this.senha = senha;
            this.email = email;
            this.ano_de_nascimento = ano_de_nascimento;
        }
    }

}
