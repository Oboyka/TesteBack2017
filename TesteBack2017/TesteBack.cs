using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace TesteBack2017
{
    public partial class form_teste_back2017 : Form
    {
        public form_teste_back2017()
        {
            InitializeComponent();
        }

        private void form_teste_back2017_Load(object sender, EventArgs e)
        {
        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            txt_active.Enabled = false;
            txt_cpf_cnpj.Enabled = false;
            txt_id_customer.Enabled = false;
            txt_vl_total.Enabled = false;
            txt_nm_customer.Enabled = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            lbl_msg.Text = "";
            //Verifica id_customer:   
            int id_customer;
            if (string.IsNullOrWhiteSpace(txt_id_customer.Text) || int.TryParse(txt_id_customer.Text, out id_customer) == false)
            {
                lbl_msg.Text = "Campo id customer inválido";
                return;
            }

            //verifica cpf/cnpj:
            decimal cpf_cnpj;
            if (string.IsNullOrWhiteSpace(txt_cpf_cnpj.Text) || decimal.TryParse(txt_cpf_cnpj.Text, out cpf_cnpj) == false)
            {
                lbl_msg.Text = "Campo cpf/ cnpj inválido";
                return;
            }

            //Verifica ativo:
            char ativo;
            if (string.IsNullOrWhiteSpace(txt_active.Text) || txt_active.Text.Length > 1 || Char.TryParse(txt_active.Text.ToLower(), out ativo) == false)
            {
                lbl_msg.Text = "Campo ativo inválido";
                return;
            }
            /*if ((!ativo.Equals('n')))
            {
                lbl_msg.Text = "campo ativo diferente de 's' ou 'n'!";
                return;
            }   */

            //verifica nome:
            string nome;
            if (string.IsNullOrWhiteSpace(txt_nm_customer.Text) || txt_nm_customer.Text.Length > 50)
            {
                lbl_msg.Text = "Campo nome inválido";
                return;
            }
            
            else
            {
                nome = txt_nm_customer.Text;
            }

            //Verifica valor:
            float valor;
            if (string.IsNullOrWhiteSpace(txt_vl_total.Text) || float.TryParse(txt_vl_total.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) == false)
            {
                lbl_msg.Text = "Campo valor inválido";
                return;
            }

            //insere valores na base de dados:
            using (SqlConnection conn = BDConnection.OpenConnection())
            {
                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tb_customer_account (id_customer, cpf_cnpj, nm_customer, is_active, vl_total) VALUES (@id, @cpf_cnpj, @nome, @ativo, @vl_total)", conn))
                {
                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@id", id_customer);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@ativo",  ativo);
                    cmd.Parameters.AddWithValue("@vl_total", valor);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        lbl_msg.Text = "Dados inseridos com sucesso";
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        lbl_msg.Text = "Erro: id inválido.";
                        return;
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_cnpj_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
