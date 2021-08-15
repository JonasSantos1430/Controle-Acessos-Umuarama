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
    public partial class Registros : Form

    {
        SqlConnection   conexao;
        SqlCommand      comando;
        

        string strSQL;

        public Registros()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet6.TabResid'. Você pode movê-la ou removê-la conforme necessário.
            this.tabResidTableAdapter.Fill(this.vEICDataSet6.TabResid);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet5.TabM'. Você pode movê-la ou removê-la conforme necessário.
            this.tabMTableAdapter.Fill(this.vEICDataSet5.TabM);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet4.TabV'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVTableAdapter.Fill(this.vEICDataSet4.TabV);

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SalvarReg_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = VEIC; Integrated Security = True");

                strSQL = "INSERT INTO Acessos (Data,Placa,Modelo,Cor,Motorista,RG,Tipo_Registro,Horário,Casa) VALUES (@Data,@Placa,@Modelo,@Cor,@Motorista,@RG,@Tipo_Registro,@Horário,@Casa)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("Data", Txt_Data.Text);
                comando.Parameters.AddWithValue("Placa", CB_Placa.Text);
                comando.Parameters.AddWithValue("Modelo", CB_Modelo.Text);
                comando.Parameters.AddWithValue("Cor", CB_Cor.Text);
                comando.Parameters.AddWithValue("Motorista",CB_Motorista.Text);
                comando.Parameters.AddWithValue("RG", CB_RG.Text);
                comando.Parameters.AddWithValue("Tipo_Registro",Txt_Tipo_Reg.Text);
                comando.Parameters.AddWithValue("Horário", DateTime.Now);
                comando.Parameters.AddWithValue("Casa", CB_Resid.Text);




                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
                
               // Txt_Placa.Text = "";
                //Txt_Modelo.Text = "";
               // Txt_Cor.Text = "";



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

        private void button1_Click(object sender, EventArgs e)
        {
            //Form Acessos = new Acessos();
           // Acessos.ShowDialog();
            Form Relatorio = new Relatorio();
            Relatorio.ShowDialog();

        }

        private void Horas_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Txt_Data_TextChanged(object sender, EventArgs e)
        {
            Txt_Data.Text = DateTime.Now.ToString();
        }

        private void Txt_Tipo_Reg_TextChanged(object sender, EventArgs e)
        {
            if(Rb_Entrada.Checked == true)
            {
                Txt_Tipo_Reg.Text = "Entrada";

            }
            else
            {

                Txt_Tipo_Reg.Text = "Saída";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void Rb_Entrada_Click(object sender, EventArgs e)
        {
            if(Rb_Entrada.Checked==true)
            {
                Txt_Tipo_Reg.Text = "Entrada";
                

            }
            
        }

        private void Rb_Saida_Click(object sender, EventArgs e)
        {
            if (Rb_Saida.Checked == true)
            {
                Txt_Tipo_Reg.Text = "Saída";
            }
        }
    }
}
