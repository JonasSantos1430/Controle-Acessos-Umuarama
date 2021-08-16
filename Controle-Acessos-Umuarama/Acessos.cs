using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controle_Acessos_Umuarama
{
    public partial class Acessos : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;

        string strSQL;
        public Acessos()
        {
            InitializeComponent();
        }

        private void Acessos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet7.Acessos'. Você pode movê-la ou removê-la conforme necessário.
            this.acessosTableAdapter.Fill(this.vEICDataSet7.Acessos);

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Index % 2 == 0)
                {
                    item.DefaultCellStyle.BackColor = Color.Azure;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.LightSlateGray;
                }


                //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                // {

                //}
            }

            // private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            // {
            // {
            // }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "SELECT * FROM Acessos where Placa like ('"+textBox1.Text + " %')";

                comando = new SqlCommand(strSQL, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();

            }

        }
    }
}