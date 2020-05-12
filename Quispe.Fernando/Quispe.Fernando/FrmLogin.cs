using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quispe.Fernando
{
    public partial class FrmLogin : Form
    {       
        public FrmLogin()
        {
            InitializeComponent();               

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            if (txtBoxUsuario.Text == "admin")
            {
                if (txtBoxPass.Text == "123456")
                {
                    FrmPpal abrir = new FrmPpal();
                    abrir.Show();
                    this.Limpiar();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }            
        }

        private void Limpiar()
        {
            this.txtBoxUsuario.Clear();
            this.txtBoxPass.Clear();       
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
