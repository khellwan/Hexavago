using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Recepcionista : Funcionario
    {
        public Recepcionista(string nome_completo, string cpf, string login, string senha) : base(nome_completo, cpf, senha)
        {
            cargo = "Recepcionista";
        }

        public int FazerReserva(int[] quarto, string[] estado, int qntd)
        {
            int i;
            for (i = 0; i < qntd; i++) //Seleciona o próximo quarto vago na lista de quartos.
            {
                if (estado[i] == "vago")
                {
                    return quarto[i];
                }
            }
            return -1; //Não há nenhum quarto vago
        }
    }
}
