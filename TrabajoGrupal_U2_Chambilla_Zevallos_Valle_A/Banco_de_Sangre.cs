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
    public partial class Banco_de_Sangre : Form
    {
        private DataGridViewColumn[] titulo = new DataGridViewColumn[8];
        public Banco_de_Sangre()
        {
            InitializeComponent();
            //FECHA Y HORA
            txtfechahora.Enabled = false;

            //Tabla
            dgvregistros.Columns.Clear();

            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Nro°";
            titulo[0].Name = "ColNumero";
            titulo[0].Width = 50;

            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Apellidos";
            titulo[1].Name = "ColApellidos";
            titulo[1].Width = 90;

            titulo[2] = new DataGridViewTextBoxColumn();
            titulo[2].HeaderText = "Nombres";
            titulo[2].Name = "ColNombres";
            titulo[2].Width = 80;

            titulo[3] = new DataGridViewTextBoxColumn();
            titulo[3].HeaderText = "Tipo de Sangre";
            titulo[3].Name = "ColTipoSangre";
            titulo[3].Width = 50;

            titulo[4] = new DataGridViewTextBoxColumn();
            titulo[4].HeaderText = "Factor RH";
            titulo[4].Name = "ColRH";
            titulo[4].Width = 50;

            titulo[5] = new DataGridViewTextBoxColumn();
            titulo[5].HeaderText = "Dirección";
            titulo[5].Name = "ColDireccion";
            titulo[5].Width = 100;

            titulo[6] = new DataGridViewTextBoxColumn();
            titulo[6].HeaderText = "Telefono";
            titulo[6].Name = "ColTelf";
            titulo[6].Width = 70;

            titulo[7] = new DataGridViewTextBoxColumn();
            titulo[7].HeaderText = "Fecha y hora";
            titulo[7].Name = "ColFechaHora";
            titulo[7].Width = 90;

            dgvregistros.Columns.AddRange(titulo);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombres.Clear();
            txtapellidos.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtfechahora.Clear();            
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            txtfechahora.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        }
    }
}
