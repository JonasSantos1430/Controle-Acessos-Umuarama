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
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet.TabV'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVTableAdapter.Fill(this.vEICDataSet.TabV);
            // TODO: esta linha de código carrega dados na tabela 'cAD_VEICULODataSet._Dados_Veiculo'. Você pode movê-la ou removê-la conforme necessário.
           // this.dados_VeiculoTableAdapter.Fill(this.cAD_VEICULODataSet._Dados_Veiculo);

        }

        private void Btn_NovoV_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection ("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "INSERT INTO TabV (Placa,Modelo,Cor) VALUES (@Placa,@Modelo,@Cor)";

                comando = new SqlCommand (strSQL,conexao);

                comando.Parameters.AddWithValue("Placa",Txt_Placa.Text);
                comando.Parameters.AddWithValue("Modelo",Txt_Modelo.Text);
                comando.Parameters.AddWithValue("Cor",Txt_Cor.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
                this.tabVTableAdapter.Fill(this.vEICDataSet.TabV);
                Txt_Placa.Text = "";
                Txt_Modelo.Text = "";
                Txt_Cor.Text = "";
                


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

        private void Btn_ConsultV_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "SELECT * FROM TabV WHERE Id_Veiculo=@Id_Veiculo";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Veiculo", Txt_Id.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Txt_Placa.Text = Convert.ToString(dr["Placa"]);
                    Txt_Modelo.Text = Convert.ToString(dr["Modelo"]);
                    Txt_Cor.Text = Convert.ToString(dr["Cor"]);

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

        private void Btn_EditarV_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "UPDATE TabV SET Placa=@Placa,Modelo=@Modelo,Cor=@Cor WHERE Id_Veiculo=@Id_Veiculo";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Veiculo", Txt_Id.Text);
                comando.Parameters.AddWithValue("Placa", Txt_Placa.Text);
                comando.Parameters.AddWithValue("Modelo", Txt_Modelo.Text);
                comando.Parameters.AddWithValue("Cor", Txt_Cor.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Alterado!");
                Txt_Id.Text = "";
                Txt_Placa.Text = "";
                Txt_Modelo.Text = "";
                Txt_Cor.Text = "";
                this.tabVTableAdapter.Fill(this.vEICDataSet.TabV);



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

        private void Btn_ExcluirV_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "DELETE FROM TabM WHERE Id_Motorista=@Id_Motorista";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Id_Motorista", Txt_Id.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Excluido!");
                this.tabVTableAdapter.Fill(this.vEICDataSet.TabV);

                Txt_Id.Text = "";
                Txt_Placa.Text = "";
                Txt_Modelo.Text = "";
                Txt_Cor.Text = "";
                
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

        private void Btn_CadMotorista_Click(object sender, EventArgs e)
        {
            Form Cadastro_Motorista = new Cadastro_Motorista();

            Cadastro_Motorista.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        { //Botao Cadastrar Residencia

            Form Cad_Residencia = new Cad_Residencia();

            Cad_Residencia.ShowDialog();

        }

        private void Btn_Registros_Click(object sender, EventArgs e)
        {
            Form Registros = new Registros();
            Registros.ShowDialog();
        }

        private void cADASTRARMOTORISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cadastro_Motorista = new Cadastro_Motorista();

            Cadastro_Motorista.ShowDialog();
        }

        private void oPÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cadastro_Motorista = new Cadastro_Motorista();

            Cadastro_Motorista.ShowDialog();
        }

        private void cadastrarResidênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cad_Residencia = new Cad_Residencia();

            Cad_Residencia.ShowDialog();
        }

        private void registrarAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registros = new Registros();
            Registros.ShowDialog();
        }
    }
}
