namespace TesteBack2017
{
    partial class form_teste_back2017
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_avg = new System.Windows.Forms.Button();
            this.lbl_id_customer = new System.Windows.Forms.Label();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.lbl_cpf_cnpj = new System.Windows.Forms.Label();
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.lbl_nm_customer = new System.Windows.Forms.Label();
            this.txt_nm_customer = new System.Windows.Forms.TextBox();
            this.lbl_active = new System.Windows.Forms.Label();
            this.txt_active = new System.Windows.Forms.TextBox();
            this.lbl_vl_total = new System.Windows.Forms.Label();
            this.txt_vl_total = new System.Windows.Forms.TextBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_avg_calculate = new System.Windows.Forms.Label();
            this.txt_avg_calculate = new System.Windows.Forms.TextBox();
            this.listViewAvg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(179, 134);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Registrar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_avg
            // 
            this.btn_avg.Location = new System.Drawing.Point(12, 198);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(175, 23);
            this.btn_avg.TabIndex = 7;
            this.btn_avg.Text = "Média entre os ids (1500 e 2700)";
            this.btn_avg.UseVisualStyleBackColor = true;
            this.btn_avg.Click += new System.EventHandler(this.btn_avg_Click);
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.AutoSize = true;
            this.lbl_id_customer.Location = new System.Drawing.Point(12, 20);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(61, 13);
            this.lbl_id_customer.TabIndex = 8;
            this.lbl_id_customer.Text = "id customer";
            // 
            // txt_id_customer
            // 
            this.txt_id_customer.Location = new System.Drawing.Point(12, 36);
            this.txt_id_customer.Name = "txt_id_customer";
            this.txt_id_customer.Size = new System.Drawing.Size(100, 20);
            this.txt_id_customer.TabIndex = 1;
            // 
            // lbl_cpf_cnpj
            // 
            this.lbl_cpf_cnpj.AutoSize = true;
            this.lbl_cpf_cnpj.Location = new System.Drawing.Point(151, 20);
            this.lbl_cpf_cnpj.Name = "lbl_cpf_cnpj";
            this.lbl_cpf_cnpj.Size = new System.Drawing.Size(59, 13);
            this.lbl_cpf_cnpj.TabIndex = 8;
            this.lbl_cpf_cnpj.Text = "CPF/CNPJ";
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(154, 36);
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf_cnpj.TabIndex = 2;
            // 
            // lbl_nm_customer
            // 
            this.lbl_nm_customer.AutoSize = true;
            this.lbl_nm_customer.Location = new System.Drawing.Point(9, 69);
            this.lbl_nm_customer.Name = "lbl_nm_customer";
            this.lbl_nm_customer.Size = new System.Drawing.Size(33, 13);
            this.lbl_nm_customer.TabIndex = 11;
            this.lbl_nm_customer.Text = "nome";
            // 
            // txt_nm_customer
            // 
            this.txt_nm_customer.Location = new System.Drawing.Point(12, 85);
            this.txt_nm_customer.Name = "txt_nm_customer";
            this.txt_nm_customer.Size = new System.Drawing.Size(345, 20);
            this.txt_nm_customer.TabIndex = 4;
            // 
            // lbl_active
            // 
            this.lbl_active.AutoSize = true;
            this.lbl_active.Location = new System.Drawing.Point(293, 20);
            this.lbl_active.Name = "lbl_active";
            this.lbl_active.Size = new System.Drawing.Size(88, 13);
            this.lbl_active.TabIndex = 10;
            this.lbl_active.Text = "ativo (\"s\" ou \"n\")";
            // 
            // txt_active
            // 
            this.txt_active.Location = new System.Drawing.Point(296, 36);
            this.txt_active.Name = "txt_active";
            this.txt_active.Size = new System.Drawing.Size(61, 20);
            this.txt_active.TabIndex = 3;
            // 
            // lbl_vl_total
            // 
            this.lbl_vl_total.AutoSize = true;
            this.lbl_vl_total.Location = new System.Drawing.Point(9, 121);
            this.lbl_vl_total.Name = "lbl_vl_total";
            this.lbl_vl_total.Size = new System.Drawing.Size(53, 13);
            this.lbl_vl_total.TabIndex = 12;
            this.lbl_vl_total.Text = "valor total";
            // 
            // txt_vl_total
            // 
            this.txt_vl_total.Location = new System.Drawing.Point(12, 137);
            this.txt_vl_total.Name = "txt_vl_total";
            this.txt_vl_total.Size = new System.Drawing.Size(100, 20);
            this.txt_vl_total.TabIndex = 5;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(9, 170);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 12;
            // 
            // lbl_avg_calculate
            // 
            this.lbl_avg_calculate.AutoSize = true;
            this.lbl_avg_calculate.Location = new System.Drawing.Point(202, 203);
            this.lbl_avg_calculate.Name = "lbl_avg_calculate";
            this.lbl_avg_calculate.Size = new System.Drawing.Size(88, 13);
            this.lbl_avg_calculate.TabIndex = 13;
            this.lbl_avg_calculate.Text = "Média calculada:";
            // 
            // txt_avg_calculate
            // 
            this.txt_avg_calculate.Enabled = false;
            this.txt_avg_calculate.Location = new System.Drawing.Point(296, 198);
            this.txt_avg_calculate.Name = "txt_avg_calculate";
            this.txt_avg_calculate.Size = new System.Drawing.Size(100, 20);
            this.txt_avg_calculate.TabIndex = 14;
            // 
            // listViewAvg
            // 
            this.listViewAvg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAvg.GridLines = true;
            this.listViewAvg.Location = new System.Drawing.Point(12, 227);
            this.listViewAvg.Name = "listViewAvg";
            this.listViewAvg.Size = new System.Drawing.Size(406, 145);
            this.listViewAvg.TabIndex = 15;
            this.listViewAvg.UseCompatibleStateImageBehavior = false;
            this.listViewAvg.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id customer";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF/CNPJ";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status Ativo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor total";
            this.columnHeader5.Width = 90;
            // 
            // form_teste_back2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 384);
            this.Controls.Add(this.listViewAvg);
            this.Controls.Add(this.txt_avg_calculate);
            this.Controls.Add(this.lbl_avg_calculate);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_vl_total);
            this.Controls.Add(this.lbl_vl_total);
            this.Controls.Add(this.txt_active);
            this.Controls.Add(this.lbl_active);
            this.Controls.Add(this.txt_nm_customer);
            this.Controls.Add(this.lbl_nm_customer);
            this.Controls.Add(this.txt_cpf_cnpj);
            this.Controls.Add(this.lbl_cpf_cnpj);
            this.Controls.Add(this.txt_id_customer);
            this.Controls.Add(this.lbl_id_customer);
            this.Controls.Add(this.btn_avg);
            this.Controls.Add(this.btn_register);
            this.Name = "form_teste_back2017";
            this.Text = "Teste Back 2017";
            this.Load += new System.EventHandler(this.form_teste_back2017_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_avg;
        private System.Windows.Forms.Label lbl_id_customer;
        private System.Windows.Forms.TextBox txt_id_customer;
        private System.Windows.Forms.Label lbl_cpf_cnpj;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.Label lbl_nm_customer;
        private System.Windows.Forms.TextBox txt_nm_customer;
        private System.Windows.Forms.Label lbl_active;
        private System.Windows.Forms.TextBox txt_active;
        private System.Windows.Forms.Label lbl_vl_total;
        private System.Windows.Forms.TextBox txt_vl_total;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_avg_calculate;
        private System.Windows.Forms.TextBox txt_avg_calculate;
        private System.Windows.Forms.ListView listViewAvg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

