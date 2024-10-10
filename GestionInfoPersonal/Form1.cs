using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInfoPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Limpiar todos los campos?", "Limpiar campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                limpiar();
            }
        
        }

        private void limpiar()
        {
            tboxNombre.Text = String.Empty;
            tboxDireccion.Text = String.Empty;
            tboxCorreo.Text = String.Empty;

            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbOtro.Checked = false;

            mcNacimiento.SetDate(DateTime.Now);
            nudEdad.Value = 1;

            cbBoletin.Checked = false;
            cbAlcohol.Checked = false;
            cbDulces.Checked = false;

            while (chlbHobbies.CheckedIndices.Count > 0) { 

                chlbHobbies.SetItemChecked(chlbHobbies.CheckedIndices[0], false);

            }

            tbSatisfaccion.Value = 0;
            tbRecomendar.Value = 0;

            pboxImagen.Image = null;

        }

        private void mcNacimiento_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblNacimiento.Text = mcNacimiento.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList paises = new ArrayList {"España", "Francia", "Portugal", "Alemania", "Paises Bajos", "Inglaterra"};
            cboxPais.DataSource = paises;

            tempFecha.Start();
        }

        private void tempFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
