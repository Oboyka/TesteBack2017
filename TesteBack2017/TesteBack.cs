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
            try
            {
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
                                txt_avg_calculate.Text = "R$ " + media.ToString("n2");
                            }
                            else
                            {
                                MessageBox.Show($"Não houve resultados.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel acessar os dados. Erro: {ex.Message}", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Carrega dados para exibir no list view:
            try
            {
                using (SqlConnection conn = BDConnection.OpenConnection())
                {
                    // Cria um comando para inserir um novo registro à tabela
                    using (SqlCommand cmd = new SqlCommand("select id_customer, cpf_cnpj, nm_customer, is_active, vl_total from tb_customer_account where vl_total > 560 and id_customer between 1500 and 2700 order by vl_total desc", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listViewAvg.Items.Clear();

                            while (reader.Read())
                            {
                                // Define os itens da lista
                                ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                                lvi.SubItems.Add(reader.GetDecimal(1).ToString());
                                lvi.SubItems.Add(reader.GetString(2).ToString());
                                lvi.SubItems.Add(reader.GetString(3).ToString());
                                lvi.SubItems.Add(reader.GetDecimal(4).ToString());

                                // Inclui os itens no ListView
                                listViewAvg.Items.Add(lvi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel acessar os dados. Erro: {ex.Message}", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //Verifica id_customer:   
            int id_customer;
            if (string.IsNullOrWhiteSpace(txt_id_customer.Text) || int.TryParse(txt_id_customer.Text, out id_customer) == false)
            {
                MessageBox.Show("Campo id customer inválido.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifica cpf/cnpj:
            decimal cpf_cnpj;
            if (string.IsNullOrWhiteSpace(txt_cpf_cnpj.Text) || decimal.TryParse(txt_cpf_cnpj.Text, out cpf_cnpj) == false)
            {
                MessageBox.Show("Campo cpf/ cnpj inválido.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verifica ativo:
            if (string.IsNullOrWhiteSpace(txt_active.Text) || txt_active.Text.Length > 1)
            {
                MessageBox.Show("Campo ativo inválido.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char ativo = txt_active.Text.ToLower()[0];
            if (ativo != 'n' && ativo != 's')
            {
                MessageBox.Show("Campo ativo diferente de 's' e 'n'.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifica nome:
            string nome = txt_nm_customer.Text;
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 50)
            {
                MessageBox.Show("Campo nome inválido.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verifica valor:
            float valor;
            if (string.IsNullOrWhiteSpace(txt_vl_total.Text) || float.TryParse(txt_vl_total.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) == false)
            {
                MessageBox.Show("Campo valor inválido.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
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

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso.", "Bacana...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show($"Chave duplicada (id customer)!", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Erro ao inserir os dados: {ex.Message}", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir os dados: {ex.Message}", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
