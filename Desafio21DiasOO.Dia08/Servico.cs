using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia08
{
    public class Servico
    {
        public Servico()
        {

        }

        public static void Salvar(IPessoa iPessoa)
        {
            iPessoa.Salvar();
        }
    }
}
