namespace Async_exercise
{
    partial class frmApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFinancas = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblImpostos = new System.Windows.Forms.Label();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAgResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinancas
            // 
            this.lblFinancas.AutoSize = true;
            this.lblFinancas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinancas.Location = new System.Drawing.Point(46, 30);
            this.lblFinancas.Name = "lblFinancas";
            this.lblFinancas.Size = new System.Drawing.Size(121, 21);
            this.lblFinancas.TabIndex = 0;
            this.lblFinancas.Text = "App - Finanças";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(31, 81);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(86, 40);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Folha de \r\npagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImpostos
            // 
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImpostos.Location = new System.Drawing.Point(188, 101);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(70, 20);
            this.lblImpostos.TabIndex = 2;
            this.lblImpostos.Text = "Impostos";
            // 
            // lblReceitas
            // 
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceitas.Location = new System.Drawing.Point(337, 101);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(64, 20);
            this.lblReceitas.TabIndex = 3;
            this.lblReceitas.Text = "Receitas";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDespesas.Location = new System.Drawing.Point(478, 101);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(71, 20);
            this.lblDespesas.TabIndex = 4;
            this.lblDespesas.Text = "Despesas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(237, 245);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAgResult
            // 
            this.lblAgResult.AutoSize = true;
            this.lblAgResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgResult.Location = new System.Drawing.Point(175, 290);
            this.lblAgResult.Name = "lblAgResult";
            this.lblAgResult.Size = new System.Drawing.Size(19, 21);
            this.lblAgResult.TabIndex = 6;
            this.lblAgResult.Text = "...";
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 355);
            this.Controls.Add(this.lblAgResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDespesas);
            this.Controls.Add(this.lblReceitas);
            this.Controls.Add(this.lblImpostos);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblFinancas);
            this.Name = "frmApp";
            this.Text = "App Finanças";
            this.Load += new System.EventHandler(this.frmApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFinancas;
        private Label lblPagamento;
        private Label lblImpostos;
        private Label lblReceitas;
        private Label lblDespesas;
        private Button btnCalcular;
        private Label lblAgResult;
        private ListBox listaPag;
    }
}