using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList paises = new ArrayList {"España", "Francia", "Portugal", "Alemania", "Paises Bajos", "Inglaterra"};
            cboxPais.DataSource = paises;

            tempFecha.Start();


            ttAyuda.SetToolTip(btnGuardar, "Guardar los datos");
            ttAyuda.SetToolTip(btnLimpiar, "Limpiar los campos");
            ttAyuda.SetToolTip(btnSalir, "Salir de la aplicación");

            
        }

        private void tempFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var fecha = mcNacimiento.SelectionStart;
            

            MessageBox.Show("Usuario: "+tboxNombre.Text+
                "\nDireccion: "+tboxDireccion.Text+
                "\nCorreo: "+tboxCorreo.Text+
                "\nFecha de nacimiento: " + fecha+
                "\nEdad: " + nudEdad.Value+
                "\nGenero: " + (rbHombre.Checked ? "Hombre" : rbMujer.Checked ? "Mujer" : "Otro")+
                "\nPais: " + cboxPais.SelectedItem+
                "\nBoletin: " + (cbBoletin.Checked ? "Si" : "No")+
                "\nIntereses: " +(cbAlcohol.Checked ? "Alcohol " : "") + (cbDulces.Checked ? "Dulces " : "") +
                "\nHobbies: " + (chlbHobbies.CheckedItems.Count > 0 ? String.Join(", ", chlbHobbies.CheckedItems.Cast<string>().ToArray()) : "Ninguno") +
                "\nNivel de Satisfaccion: " + tbSatisfaccion.Value+
                "\nProbabilidades de Recomendar este servicio: " + tbRecomendar.Value +
                "\n¿Tiene imagen de perfil actualmente?: " + (pboxImagen.Image != null ? "Si" : "No"), 
                "Resumen de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            ofdImagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            ofdImagen.Title = "Selecciona una imagen";
            DialogResult rs = ofdImagen.ShowDialog();
            if (rs == DialogResult.OK) {
                pboxImagen.Image = Image.FromFile(ofdImagen.FileName);
            }
        }
    }
}
