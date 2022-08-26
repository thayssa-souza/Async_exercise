using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_exercise
{
    public static class Infos
    {
        public static List<FolhaPagamento> FolhaPagamentoInfo()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.SalarioFunc1 = 3000;
            folhaPagamento.SalarioFunc2 = 1000;
            folhaPagamento.SalarioFunc3 = 2000;

            List<FolhaPagamento> listPag = new List<FolhaPagamento>();
            listPag.Add(folhaPagamento);

            return listPag;
        }

        public static List<Impostos> ImpostosInfos()
        {
            Impostos imposto = new Impostos();
            imposto.ImpostoPJ = 500;
            imposto.ImpostoEmpresa = 2000;

            List<Impostos> listImposto = new();
            listImposto.Add(imposto);

            return listImposto;
        }

        public static List<Receitas> ReceitasInfo()
        {
            Receitas receita = new Receitas();
            receita.ReceitaMensal = 10000;
            receita.ReceitaAnual = 120000;

            List<Receitas> listRec = new();
            listRec.Add(receita);

            return listRec;
        }

        public static List<Despesas> DespesasInfo()
        {
            Despesas despesa = new Despesas();
            despesa.DespFuncionarios = 5000;
            despesa.DespAluguel = 2000;

            List<Despesas> listDesp = new();
            listDesp.Add(despesa);

            return listDesp;
        }
    }
}
