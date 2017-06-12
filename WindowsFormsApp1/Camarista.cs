using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Camarista : Funcionario
    {
        /*private int proximo_quarto_servico;
        private int proximo_quarto_arrumar;
        private int tipo_de_servico; // 1 - Entregar Comida. 2 - Limpar Quarto
        */
        public Camarista(string nome_completo, string cpf, string login, string senha) : base(nome_completo, cpf,senha)
        {
            cargo = "Camarista";
        }

       /* public void RealizarServicoDeQuarto(int quarto, int tipo)
        {
            proximo_quarto_servico = quarto;
            tipo_de_servico = tipo;
        }

        public void ArrumarQuarto(int[] quarto, string[] estado_servico, int qntd)
        {
            int i;
            for (i = 0; i < qntd; i++) //Seleciona o próximo quarto a arrumar na lista de quartos.
            {
                if (estado_servico[i] == "arrumar")
                {
                    proximo_quarto_arrumar = quarto[i];
                    break;
                }
            }
        }*/
    }
}
