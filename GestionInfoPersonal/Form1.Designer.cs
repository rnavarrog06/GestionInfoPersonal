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
            this.components = new System.ComponentModel.Container();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.pnlRadioBtn = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxCorreo = new System.Windows.Forms.TextBox();
            this.tboxDireccion = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecomendar = new System.Windows.Forms.Label();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.tbRecomendar = new System.Windows.Forms.TrackBar();
            this.tbSatisfaccion = new System.Windows.Forms.TrackBar();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.cboxPais = new System.Windows.Forms.ComboBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.chlbHobbies = new System.Windows.Forms.CheckedListBox();
            this.cbDulces = new System.Windows.Forms.CheckBox();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.cbBoletin = new System.Windows.Forms.CheckBox();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tempFecha = new System.Windows.Forms.Timer(this.components);
            this.btnImagen = new System.Windows.Forms.Button();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.tcPrincipal.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.pnlRadioBtn.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRecomendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatisfaccion)).BeginInit();
            this.tpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpDatosPersonales);
            this.tcPrincipal.Controls.Add(this.tpPreferencias);
            this.tcPrincipal.Controls.Add(this.tpVisualizacion);
            this.tcPrincipal.Location = new System.Drawing.Point(10, 11);
            this.tcPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(581, 345);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.BackColor = System.Drawing.Color.Pink;
            this.tpDatosPersonales.Controls.Add(this.nudEdad);
            this.tpDatosPersonales.Controls.Add(this.lblEdad);
            this.tpDatosPersonales.Controls.Add(this.pnlRadioBtn);
            this.tpDatosPersonales.Controls.Add(this.pnlTextBox);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 22);
            this.tpDatosPersonales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDatosPersonales.Size = new System.Drawing.Size(573, 319);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos Personales";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(424, 256);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(90, 20);
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
            this.lblEdad.Location = new System.Drawing.Point(452, 228);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // pnlRadioBtn
            // 
            this.pnlRadioBtn.BackColor = System.Drawing.Color.MistyRose;
            this.pnlRadioBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRadioBtn.Controls.Add(this.lblGenero);
            this.pnlRadioBtn.Controls.Add(this.rbOtro);
            this.pnlRadioBtn.Controls.Add(this.rbMujer);
            this.pnlRadioBtn.Controls.Add(this.rbHombre);
            this.pnlRadioBtn.Location = new System.Drawing.Point(20, 218);
            this.pnlRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRadioBtn.Name = "pnlRadioBtn";
            this.pnlRadioBtn.Size = new System.Drawing.Size(346, 93);
            this.pnlRadioBtn.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 39);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero:";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(87, 68);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(87, 37);
            this.rbMujer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(87, 6);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextBox.Controls.Add(this.lblNacimiento);
            this.pnlTextBox.Controls.Add(this.mcNacimiento);
            this.pnlTextBox.Controls.Add(this.lblCorreo);
            this.pnlTextBox.Controls.Add(this.lblDireccion);
            this.pnlTextBox.Controls.Add(this.lblNombre);
            this.pnlTextBox.Controls.Add(this.tboxCorreo);
            this.pnlTextBox.Controls.Add(this.tboxDireccion);
            this.pnlTextBox.Controls.Add(this.tboxNombre);
            this.pnlTextBox.Location = new System.Drawing.Point(19, 5);
            this.pnlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(547, 198);
            this.pnlTextBox.TabIndex = 0;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(364, 0);
            this.lblNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblNacimiento.TabIndex = 7;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // mcNacimiento
            // 
            this.mcNacimiento.Location = new System.Drawing.Point(301, 19);
            this.mcNacimiento.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mcNacimiento.Name = "mcNacimiento";
            this.mcNacimiento.TabIndex = 6;
            
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(20, 145);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 89);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 32);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxCorreo
            // 
            this.tboxCorreo.Location = new System.Drawing.Point(88, 143);
            this.tboxCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxCorreo.Name = "tboxCorreo";
            this.tboxCorreo.Size = new System.Drawing.Size(190, 20);
            this.tboxCorreo.TabIndex = 2;
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.Location = new System.Drawing.Point(88, 86);
            this.tboxDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(190, 20);
            this.tboxDireccion.TabIndex = 1;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(88, 29);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(190, 20);
            this.tboxNombre.TabIndex = 0;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.panel1);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tpPreferencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPreferencias.Size = new System.Drawing.Size(573, 319);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.lblRecomendar);
            this.panel1.Controls.Add(this.lblSatisfaccion);
            this.panel1.Controls.Add(this.tbRecomendar);
            this.panel1.Controls.Add(this.tbSatisfaccion);
            this.panel1.Controls.Add(this.lblResidencia);
            this.panel1.Controls.Add(this.cboxPais);
            this.panel1.Controls.Add(this.lblHobbies);
            this.panel1.Controls.Add(this.chlbHobbies);
            this.panel1.Controls.Add(this.cbDulces);
            this.panel1.Controls.Add(this.cbAlcohol);
            this.panel1.Controls.Add(this.cbBoletin);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 300);
            this.panel1.TabIndex = 0;
            // 
            // lblRecomendar
            // 
            this.lblRecomendar.AutoSize = true;
            this.lblRecomendar.Location = new System.Drawing.Point(316, 209);
            this.lblRecomendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecomendar.Name = "lblRecomendar";
            this.lblRecomendar.Size = new System.Drawing.Size(157, 13);
            this.lblRecomendar.TabIndex = 10;
            this.lblRecomendar.Text = "¿Recomendarías este servicio?";
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(339, 106);
            this.lblSatisfaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Size = new System.Drawing.Size(107, 13);
            this.lblSatisfaccion.TabIndex = 9;
            this.lblSatisfaccion.Text = "Nivel de Satisfaccion";
            // 
            // tbRecomendar
            // 
            this.tbRecomendar.BackColor = System.Drawing.Color.Linen;
            this.tbRecomendar.Location = new System.Drawing.Point(275, 224);
            this.tbRecomendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRecomendar.Name = "tbRecomendar";
            this.tbRecomendar.Size = new System.Drawing.Size(232, 45);
            this.tbRecomendar.TabIndex = 8;
            // 
            // tbSatisfaccion
            // 
            this.tbSatisfaccion.BackColor = System.Drawing.Color.Linen;
            this.tbSatisfaccion.Location = new System.Drawing.Point(275, 122);
            this.tbSatisfaccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSatisfaccion.Name = "tbSatisfaccion";
            this.tbSatisfaccion.Size = new System.Drawing.Size(232, 45);
            this.tbSatisfaccion.TabIndex = 7;
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(339, 36);
            this.lblResidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(103, 13);
            this.lblResidencia.TabIndex = 6;
            this.lblResidencia.Text = "País de Residencia:";
            // 
            // cboxPais
            // 
            this.cboxPais.FormattingEnabled = true;
            this.cboxPais.Location = new System.Drawing.Point(275, 54);
            this.cboxPais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxPais.Name = "cboxPais";
            this.cboxPais.Size = new System.Drawing.Size(233, 21);
            this.cboxPais.TabIndex = 5;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(53, 154);
            this.lblHobbies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(46, 13);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Hobbies";
            // 
            // chlbHobbies
            // 
            this.chlbHobbies.FormattingEnabled = true;
            this.chlbHobbies.Items.AddRange(new object[] {
            "Deporte",
            "Videojuegos",
            "Coleccionismo",
            "Música",
            "Limpieza",
            "Viajes"});
            this.chlbHobbies.Location = new System.Drawing.Point(17, 170);
            this.chlbHobbies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chlbHobbies.Name = "chlbHobbies";
            this.chlbHobbies.Size = new System.Drawing.Size(116, 94);
            this.chlbHobbies.TabIndex = 3;
            // 
            // cbDulces
            // 
            this.cbDulces.AutoSize = true;
            this.cbDulces.Location = new System.Drawing.Point(17, 57);
            this.cbDulces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDulces.Name = "cbDulces";
            this.cbDulces.Size = new System.Drawing.Size(123, 17);
            this.cbDulces.TabIndex = 2;
            this.cbDulces.Text = "Dulces, chucherias..";
            this.cbDulces.UseVisualStyleBackColor = true;
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(17, 36);
            this.cbAlcohol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(121, 17);
            this.cbAlcohol.TabIndex = 1;
            this.cbAlcohol.Text = "Bebidas Alcoholicas";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbBoletin
            // 
            this.cbBoletin.AutoSize = true;
            this.cbBoletin.Location = new System.Drawing.Point(17, 15);
            this.cbBoletin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoletin.Name = "cbBoletin";
            this.cbBoletin.Size = new System.Drawing.Size(123, 17);
            this.cbBoletin.TabIndex = 0;
            this.cbBoletin.Text = "Suscribirse al Boletin";
            this.cbBoletin.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.BackColor = System.Drawing.Color.Lavender;
            this.tpVisualizacion.Controls.Add(this.lblFecha2);
            this.tpVisualizacion.Controls.Add(this.btnImagen);
            this.tpVisualizacion.Controls.Add(this.lblFecha);
            this.tpVisualizacion.Controls.Add(this.pboxImagen);
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 22);
            this.tpVisualizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpVisualizacion.Size = new System.Drawing.Size(573, 319);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualizacion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(105, 248);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 1;
            // 
            // pboxImagen
            // 
            this.pboxImagen.BackColor = System.Drawing.Color.White;
            this.pboxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxImagen.Location = new System.Drawing.Point(65, 15);
            this.pboxImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(236, 221);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 0;
            this.pboxImagen.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(26, 375);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(254, 374);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 32);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(482, 374);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tempFecha
            // 
            this.tempFecha.Interval = 1000;
            this.tempFecha.Tick += new System.EventHandler(this.tempFecha_Tick);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(384, 195);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(111, 41);
            this.btnImagen.TabIndex = 2;
            this.btnImagen.Text = "Abrir Fichero";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "Imagen";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(65, 248);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(40, 13);
            this.lblFecha2.TabIndex = 3;
            this.lblFecha2.Text = "Fecha:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tcPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gestión Avanzada de Información Profesional";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbRecomendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatisfaccion)).EndInit();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
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
        private System.Windows.Forms.TextBox tboxCorreo;
        private System.Windows.Forms.TextBox tboxDireccion;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.MonthCalendar mcNacimiento;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDulces;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.CheckBox cbBoletin;
        private System.Windows.Forms.TrackBar tbRecomendar;
        private System.Windows.Forms.TrackBar tbSatisfaccion;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.ComboBox cboxPais;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckedListBox chlbHobbies;
        private System.Windows.Forms.Label lblRecomendar;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer tempFecha;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.Label lblFecha2;
    }
}

