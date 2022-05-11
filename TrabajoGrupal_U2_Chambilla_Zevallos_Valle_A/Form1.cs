using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoGrupal_U2_Chambilla_Zevallos_Valle_A
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if((cbusuario.SelectedIndex == 0 && txtcontraseña.Text == "2020066918") || (cbusuario.SelectedIndex == 1 && txtcontraseña.Text == "2020066916") || (cbusuario.SelectedIndex == 1 && txtcontraseña.Text == "2020066924"))
            {
               MessageBox.Show("Logeo exitoso","INGRESO",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
               Banco_de_Sangre frm = new Banco_de_Sangre();
               frm.Show();        

            }
            else
            {
                txtcontraseña.Clear();
                MessageBox.Show("Logeo no exitoso", "INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador +=1;
                if (contador == 5)
                {
                    this.Dispose();
                }
            }
        }
    }
}
