using Desafio21DiasOO.Dia11.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia11.Models
{
    public class Servico
    {
        public static List<Fisica> TabelaFisica = new List<Fisica>();
        public static List<Juridica> TabelaJuridica = new List<Juridica>();
        private IPessoa pessoa;


        public Servico()
        {

        }

        public Servico(IPessoa IPessoa)
        {
            this.pessoa = IPessoa;
        }

        public List<IPessoa> Busca()
        {
            var lista = new List<IPessoa>();
            if (this.GetType() == typeof(Fisica))
            {
                lista.Add(new Juridica() { Nome = "Juridica" });
            }
            else
            {
                lista.Add(new Fisica() { Nome = "Fisica" });
            }
            return lista;
        }

        public static void Salvar(IPessoa iPessoa)
        {

            if (iPessoa.GetType().Name == "Fisica")
            {
                Servico.TabelaFisica.Add((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                Servico.TabelaJuridica.Add((Juridica)iPessoa);
            }
        }

        public static void Excluir(IPessoa iPessoa)
        {

            if (iPessoa.GetType().Name == "Fisica")
            {
                Servico.ExcluirPessoaFisica((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                Servico.ExcluirPessoaJuridica((Juridica)iPessoa);
            }
        }

        private static void ExcluirPessoaJuridica(Juridica juridica)
        {
            throw new NotImplementedException();
        }

        private static void ExcluirPessoaFisica(Fisica iPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
