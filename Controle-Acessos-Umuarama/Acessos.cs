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
    public partial class Acessos : Form
    {
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
    }
}