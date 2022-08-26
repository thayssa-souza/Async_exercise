using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Async_exercise
{
    public partial class frmApp : Form
    {
        ListBox listPag = new();
        ListBox listaImp = new();
        ListBox listaRec = new();
        ListBox listaDesp = new();

        public frmApp()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await GetInfosAsync();

        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            listPag.Size = new System.Drawing.Size(100, 100);
            listPag.Location = new System.Drawing.Point(28, 130);

            listaImp.Size = new System.Drawing.Size(100, 100);
            listaImp.Location = new System.Drawing.Point(170, 130);

            listaRec.Size = new System.Drawing.Size(100, 100);
            listaRec.Location = new System.Drawing.Point(320, 130);

            listaDesp.Size = new System.Drawing.Size(100, 100);
            listaDesp.Location = new System.Drawing.Point(462, 130);
        }

        public async Task GetInfosAsync()
        {
            await ExibirCalculo();

            var folhas = Infos.FolhaPagamentoInfo();

            foreach (FolhaPagamento itemP in folhas)
            {
                listPag.Items.Add(itemP.SalarioFunc1);
                listPag.Items.Add(itemP.SalarioFunc2);
                listPag.Items.Add(itemP.SalarioFunc3);
            }
            this.Controls.Add(listPag);
            for (int i = 0; i < Infos.FolhaPagamentoInfo().Count; i++)
            {
                Debug.WriteLine(i);
            }


            var impost = Infos.ImpostosInfos();
            foreach (var itemI in impost)
            {
                listaImp.Items.Add(itemI.ImpostoPJ);
                listaImp.Items.Add(itemI.ImpostoEmpresa);
            }
            this.Controls.Add(listaImp);
            for (int i = 0; i < Infos.ImpostosInfos().Count; i++)
            {
                Debug.WriteLine(i);
            }


            var recei = Infos.ReceitasInfo();
            foreach (var itemR in recei)
            {
                listaRec.Items.Add(itemR.ReceitaMensal);
                listaRec.Items.Add(itemR.ReceitaAnual);
            }
            this.Controls.Add(listaRec);
            for (int i = 0; i < Infos.DespesasInfo().Count; i++)
            {
                Debug.WriteLine(i);
            }


            var desp = Infos.DespesasInfo();
            foreach (var itemD in desp)
            {
                listaDesp.Items.Add(itemD.DespFuncionarios);
                listaDesp.Items.Add(itemD.DespAluguel);
            }
            this.Controls.Add(listaDesp);
            for (int i = 0; i < Infos.DespesasInfo().Count; i++)
            {
                Debug.WriteLine(i);
            }

        }

        public async Task ExibirCalculo()
        {
            btnCalcular.Enabled = false;
            lblAgResult.ForeColor = Color.Coral;
            lblAgResult.Text = "Processando...";
            
            await Task.Delay(TimeSpan.FromSeconds(5));

            lblAgResult.ForeColor = Color.Blue;
            lblAgResult.Text = "Cálculos gerados com sucesso!\n +" +
                "Tempo total da operação: segundos";
            btnCalcular.Enabled = true;
        }

        public void ShowLists()
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}