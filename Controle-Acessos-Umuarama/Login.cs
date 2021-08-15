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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_Nome_Login.Text == "Jonas" && Txt_Senha_Login.Text=="1234")
            {           
                        Form Registros = new Registros();
                        this.Hide();
                        Registros.ShowDialog();
                     
            }

            else
            {
                MessageBox.Show("Login ou Senhas invalidos!");

            }

            
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
