namespace GestionInfoPersonal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.pnlRadioBtn = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecomendar = new System.Windows.Forms.Label();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cbDulces = new System.Windows.Forms.CheckBox();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.cbBoletin = new System.Windows.Forms.CheckBox();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tcPrincipal.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.pnlRadioBtn.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpDatosPersonales);
            this.tcPrincipal.Controls.Add(this.tpPreferencias);
            this.tcPrincipal.Controls.Add(this.tpVisualizacion);
            this.tcPrincipal.Location = new System.Drawing.Point(13, 13);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(775, 425);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.Controls.Add(this.nudEdad);
            this.tpDatosPersonales.Controls.Add(this.lblEdad);
            this.tpDatosPersonales.Controls.Add(this.pnlRadioBtn);
            this.tpDatosPersonales.Controls.Add(this.pnlTextBox);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosPersonales.Size = new System.Drawing.Size(767, 396);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos Personales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(566, 315);
            this.nudEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 3;
            this.nudEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(603, 281);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // pnlRadioBtn
            // 
            this.pnlRadioBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRadioBtn.Controls.Add(this.lblGenero);
            this.pnlRadioBtn.Controls.Add(this.radioButton3);
            this.pnlRadioBtn.Controls.Add(this.radioButton2);
            this.pnlRadioBtn.Controls.Add(this.radioButton1);
            this.pnlRadioBtn.Location = new System.Drawing.Point(26, 268);
            this.pnlRadioBtn.Name = "pnlRadioBtn";
            this.pnlRadioBtn.Size = new System.Drawing.Size(460, 114);
            this.pnlRadioBtn.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(28, 48);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 16);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextBox.Controls.Add(this.lblNacimiento);
            this.pnlTextBox.Controls.Add(this.mcNacimiento);
            this.pnlTextBox.Controls.Add(this.lblCorreo);
            this.pnlTextBox.Controls.Add(this.lblDireccion);
            this.pnlTextBox.Controls.Add(this.lblNombre);
            this.pnlTextBox.Controls.Add(this.textBox3);
            this.pnlTextBox.Controls.Add(this.textBox2);
            this.pnlTextBox.Controls.Add(this.textBox1);
            this.pnlTextBox.Location = new System.Drawing.Point(25, 6);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(729, 243);
            this.pnlTextBox.TabIndex = 0;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(523, -1);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblNacimiento.TabIndex = 7;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // mcNacimiento
            // 
            this.mcNacimiento.Location = new System.Drawing.Point(456, 26);
            this.mcNacimiento.Name = "mcNacimiento";
            this.mcNacimiento.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(26, 179);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 109);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 0;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.panel1);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(767, 396);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRecomendar);
            this.panel1.Controls.Add(this.lblSatisfaccion);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.lblResidencia);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblHobbies);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.cbDulces);
            this.panel1.Controls.Add(this.cbAlcohol);
            this.panel1.Controls.Add(this.cbBoletin);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 369);
            this.panel1.TabIndex = 0;
            // 
            // lblRecomendar
            // 
            this.lblRecomendar.AutoSize = true;
            this.lblRecomendar.Location = new System.Drawing.Point(421, 257);
            this.lblRecomendar.Name = "lblRecomendar";
            this.lblRecomendar.Size = new System.Drawing.Size(197, 16);
            this.lblRecomendar.TabIndex = 10;
            this.lblRecomendar.Text = "¿Recomendarías este servicio?";
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(452, 131);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Size = new System.Drawing.Size(133, 16);
            this.lblSatisfaccion.TabIndex = 9;
            this.lblSatisfaccion.Text = "Nivel de Satisfaccion";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Linen;
            this.trackBar2.Location = new System.Drawing.Point(367, 276);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(309, 56);
            this.trackBar2.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Linen;
            this.trackBar1.Location = new System.Drawing.Point(367, 150);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 56);
            this.trackBar1.TabIndex = 7;
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(452, 44);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(128, 16);
            this.lblResidencia.TabIndex = 6;
            this.lblResidencia.Text = "País de Residencia:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(71, 190);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(59, 16);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Hobbies";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Deporte",
            "Videojuegos",
            "Coleccionismo",
            "Música",
            "Limpieza",
            "Viajes"});
            this.checkedListBox1.Location = new System.Drawing.Point(23, 209);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(154, 123);
            this.checkedListBox1.TabIndex = 3;
            // 
            // cbDulces
            // 
            this.cbDulces.AutoSize = true;
            this.cbDulces.Location = new System.Drawing.Point(23, 70);
            this.cbDulces.Name = "cbDulces";
            this.cbDulces.Size = new System.Drawing.Size(148, 20);
            this.cbDulces.TabIndex = 2;
            this.cbDulces.Text = "Dulces, chucherias..";
            this.cbDulces.UseVisualStyleBackColor = true;
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(23, 44);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(153, 20);
            this.cbAlcohol.TabIndex = 1;
            this.cbAlcohol.Text = "Bebidas Alcoholicas";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbBoletin
            // 
            this.cbBoletin.AutoSize = true;
            this.cbBoletin.Location = new System.Drawing.Point(23, 18);
            this.cbBoletin.Name = "cbBoletin";
            this.cbBoletin.Size = new System.Drawing.Size(154, 20);
            this.cbBoletin.TabIndex = 0;
            this.cbBoletin.Text = "Suscribirse al Boletin";
            this.cbBoletin.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Controls.Add(this.lblFecha);
            this.tpVisualizacion.Controls.Add(this.pictureBox1);
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisualizacion.Size = new System.Drawing.Size(767, 396);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualizacion";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(84, 304);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(34, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(338, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 40);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(642, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "Form1";
            this.Text = "Gestión Avanzada de Información Profesional";
            this.tcPrincipal.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.tpDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.pnlRadioBtn.ResumeLayout(false);
            this.pnlRadioBtn.PerformLayout();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualizacion;
        private System.Windows.Forms.Panel pnlRadioBtn;
        private System.Windows.Forms.Panel pnlTextBox;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.MonthCalendar mcNacimiento;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDulces;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.CheckBox cbBoletin;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblRecomendar;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

