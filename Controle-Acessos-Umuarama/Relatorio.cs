using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Acessos_Umuarama
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet12.TabV'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVTableAdapter2.Fill(this.vEICDataSet12.TabV);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet11.TabV'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVTableAdapter1.Fill(this.vEICDataSet11.TabV);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet10.TabV'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVTableAdapter.Fill(this.vEICDataSet10.TabV);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet9.TabResid'. Você pode movê-la ou removê-la conforme necessário.
            this.tabResidTableAdapter.Fill(this.vEICDataSet9.TabResid);
            // TODO: esta linha de código carrega dados na tabela 'vEICDataSet8.Acessos'. Você pode movê-la ou removê-la conforme necessário.
            this.acessosTableAdapter.Fill(this.vEICDataSet8.Acessos);

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                cb_Placa.Enabled= false;

            }
            else
            {

                cb_Placa.Enabled = true;
            }
      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cb_Modelo.Enabled = false;

            }
            else
            {

                cb_Modelo.Enabled = true;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                cb_Cor.Enabled = false;

            }
            else
            {

                cb_Cor.Enabled = true;
            }
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
             Form Acessos = new Acessos();
             Acessos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
