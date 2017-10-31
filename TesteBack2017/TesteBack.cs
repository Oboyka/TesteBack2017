using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

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
            lbl_msg.Text = "";

            txt_active.Enabled = false;
            txt_cpf_cnpj.Enabled = false;
            txt_id_customer.Enabled = false;
            txt_vl_total.Enabled = false;
            txt_nm_customer.Enabled = false;

            //Consulta a média entre ids 1500 e 2700 e valor > 560:
            using (SqlConnection conn = BDConnection.OpenConnection())
            {
                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("SELECT AVG(vl_total) FROM tb_customer_account WHERE vl_total > 560 AND id_customer BETWEEN 1500 AND 2700", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            decimal media = reader.GetDecimal(0);
                            txt_avg_calculate.Text = media.ToString();
                        }
                        else
                        {
                            txt_avg_calculate.Text = "Não houve resultados.";
                        }
                    }
                }
            }

            txt_active.Enabled = true;
            txt_cpf_cnpj.Enabled = true;
            txt_id_customer.Enabled = true;
            txt_vl_total.Enabled = true;
            txt_nm_customer.Enabled = true;

            //Carrega dados para exibir no list view:
            DataSet _DataSet;
            SqlDataAdapter _DataAdapterCustomers;
            try
            {
                using (SqlConnection conn = BDConnection.OpenConnection())
                {
                    // Cria um comando para inserir um novo registro à tabela
                    //using (SqlCommand cmd = new SqlCommand("select id_customer, cpf_cnpj, nm_customer, is_active, vl_total from tb_customer_account where vl_total > 560 and id_customer between 1500 and 2700 order by vl_total desc; ", conn))
                    //{
                    string strSQL = "select id_customer, cpf_cnpj, nm_customer, is_active, vl_total from tb_customer_account where vl_total > 560 and id_customer between 1500 and 2700 order by vl_total desc; ";
                        _DataSet = new DataSet();
                        _DataAdapterCustomers = new SqlDataAdapter(strSQL, conn);
                        _DataAdapterCustomers.Fill(_DataSet, "Customers");
                    //}
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "Não foi possivel acessar os dados.";
                return;
            }

            listViewAvg.Clear();
            listViewAvg.View = View.Details;
            listViewAvg.GridLines = true;
          
            listViewAvg.Columns.Add("Id customer", 70, HorizontalAlignment.Left);
            listViewAvg.Columns.Add("cpf_cnpj", 70, HorizontalAlignment.Left);
            listViewAvg.Columns.Add("Nome customer", 70, HorizontalAlignment.Left);
            listViewAvg.Columns.Add("Status Ativo", 70, HorizontalAlignment.Left);
            listViewAvg.Columns.Add("Valor total", 70, HorizontalAlignment.Left);

            DataTable dtable = _DataSet.Tables["Customers"];
            
            // limpa o ListView
            //listViewAvg.Items.Clear();

            // exibe os itens no controle ListView 
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Somente as linhas que não foram deletadas
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem lvi = new ListViewItem(drow["id_customer"].ToString());
                    lvi.SubItems.Add(drow["cpf_cnpj"].ToString());
                    lvi.SubItems.Add(drow["nm_customer"].ToString());
                    lvi.SubItems.Add(drow["is_active"].ToString());
                    lvi.SubItems.Add(drow["vl_total"].ToString());

                    // Inclui os itens no ListView
                    listViewAvg.Items.Add(lvi);
                }
            }

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
                    cmd.Parameters.AddWithValue("@ativo", ativo);
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
