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
    public partial class Cad_Residencia : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Cad_Residencia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cad_Residencia_Load(object sender, EventArgs e)
        {   
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet3.TabResid'. Você pode movê-la ou removê-la conforme necessário.
            this.tabResidTableAdapter.Fill(this.vEICDataSet3.TabResid);

        }

        private void Btn_Novo_Resid_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "INSERT INTO TabResid (Nome_Resid,Numer_Resi) VALUES (@Nome_Resid,@Numer_Resi)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Nome_Resid", Txt_NomeResid.Text);
                comando.Parameters.AddWithValue("Numer_Resi", Txt_Num_Resid.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
                this.tabResidTableAdapter.Fill(this.vEICDataSet3.TabResid);


                Txt_NomeResid.Text = "";
                Txt_Num_Resid.Text = "";


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

        private void Btn_ConsultResid_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "SELECT * FROM TabResid  WHERE Id_Resid=@Id_Resid";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Resid", Txt_ConsultResid.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Txt_NomeResid.Text = Convert.ToString(dr["Nome_Resid"]);
                    Txt_Num_Resid.Text = Convert.ToString(dr["Numer_Resi"]);


                }


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

        private void Btn_Edit_Resid_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "UPDATE TabResid SET Nome_Resid=@Nome_Resid,Numer_Resi=@Numer_Resi WHERE Id_Resid=@Id_Resid";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Resid", Txt_ConsultResid.Text);
                comando.Parameters.AddWithValue("Nome_Resid", Txt_NomeResid.Text);
                comando.Parameters.AddWithValue("Numer_Resi", Txt_Num_Resid.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Alterado!");
                this.tabResidTableAdapter.Fill(this.vEICDataSet3.TabResid);

                Txt_ConsultResid.Clear();
                Txt_NomeResid.Clear();
                Txt_Num_Resid.Clear();
                
              
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

        private void Btn_Excluir_Resid_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "DELETE FROM TabResid WHERE Id_Resid=@Id_Resid";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Resid", Txt_ConsultResid.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Excluido!");
                this.tabResidTableAdapter.Fill(this.vEICDataSet3.TabResid);

                Txt_ConsultResid.Text = "";
                Txt_NomeResid.Text = "";
                Txt_Num_Resid.Text = "";


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
