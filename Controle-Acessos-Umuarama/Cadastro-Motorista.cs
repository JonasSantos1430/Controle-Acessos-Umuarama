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
    public partial class Cadastro_Motorista : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;

        string strSQL;
        public Cadastro_Motorista()
        {
            InitializeComponent();

        }

        private void Cadastro_Motorista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet2.TabM'. Você pode movê-la ou removê-la conforme necessário.
            this.tabMTableAdapter.Fill(this.vEICDataSet2.TabM);

        }

        private void Btn_NovoM_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "INSERT INTO TabM (Nome,Rg) VALUES (@Nome,@Rg)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Nome", Txt_Motorista.Text);
                comando.Parameters.AddWithValue("Rg", Msk_Rg.Text);
                

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
                this.tabMTableAdapter.Fill(this.vEICDataSet2.TabM);


                Txt_Motorista.Clear();
                Msk_Rg.Clear();
               



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

        private void Btn_EditarM_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "UPDATE TabM SET Nome=@Nome,Rg=@Rg WHERE Id_Motorista=@Id_Motorista";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Motorista",Txt_IdM.Text);
                comando.Parameters.AddWithValue("Nome", Txt_Motorista.Text);
                comando.Parameters.AddWithValue("Rg",Msk_Rg.Text);
                

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Alterado!");
                
        
                Txt_Motorista.Clear();
                Msk_Rg.Clear();
                Txt_IdM.Clear();

                this.tabMTableAdapter.Fill(this.vEICDataSet2.TabM);



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

        private void Btn_ConsultarM_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "SELECT * FROM TabM  WHERE Id_Motorista=@Id_Motorista";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Motorista", Txt_IdM.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Txt_Motorista.Text = Convert.ToString(dr["Nome"]);
                    Msk_Rg.Text = Convert.ToString(dr["Rg"]);
                    

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

        private void Btn_ExcluirM_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "DELETE FROM TabM WHERE Id_Motorista=@Id_Motorista";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Motorista", Txt_IdM.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Excluido!");
                this.tabMTableAdapter.Fill(this.vEICDataSet2.TabM);

                Txt_Motorista.Text = "";
                Msk_Rg.Text = "";
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                this.tabMTableAdapter.Fill(this.vEICDataSet2.TabM);

            }
        }
    }
}
