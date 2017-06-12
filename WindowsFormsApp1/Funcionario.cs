using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Funcionario
    {
        protected string nome_completo { get; set; }
        protected string cpf { get; set; }
        protected string senha { get; set; }
        protected string cargo;

        public Funcionario(string nome_completo, string cpf, string senha)
        {
            this.nome_completo = nome_completo;
            this.cpf = cpf;
            this.senha = senha;
        }
    }
}
