namespace subastas.pro
{
    partial class frmSubastas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            grbRegistros = new GroupBox();
            button2 = new Button();
            dgvRegistros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label1 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtDocumentos = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            FA = new Label();
            grbSubastas = new GroupBox();
            btnRefrescarDatos = new Button();
            textBox1 = new TextBox();
            cmbApellidoF = new ComboBox();
            cmbNombreF = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            cmbDuracion = new ComboBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label11 = new Label();
            label8 = new Label();
            cmbProducto = new ComboBox();
            cmbOferta = new ComboBox();
            dgvFinalSubasta = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtCondicion = new TextBox();
            label10 = new Label();
            grbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grbSubastas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFinalSubasta).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(640, 25);
            button1.Name = "button1";
            button1.Size = new Size(186, 58);
            button1.TabIndex = 2;
            button1.Text = "Registrar Oferta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grbRegistros
            // 
            grbRegistros.BackColor = Color.SaddleBrown;
            grbRegistros.Controls.Add(button2);
            grbRegistros.Controls.Add(dgvRegistros);
            grbRegistros.Controls.Add(button3);
            grbRegistros.Controls.Add(label1);
            grbRegistros.Controls.Add(txtTelefono);
            grbRegistros.Controls.Add(label2);
            grbRegistros.Controls.Add(label5);
            grbRegistros.Controls.Add(label3);
            grbRegistros.Controls.Add(txtDocumentos);
            grbRegistros.Controls.Add(label4);
            grbRegistros.Controls.Add(txtApellido);
            grbRegistros.Controls.Add(txtNombre);
            grbRegistros.Controls.Add(txtEmail);
            grbRegistros.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbRegistros.Location = new Point(12, 53);
            grbRegistros.Name = "grbRegistros";
            grbRegistros.Size = new Size(386, 485);
            grbRegistros.TabIndex = 4;
            grbRegistros.TabStop = false;
            grbRegistros.Text = "Registro";
            // 
            // button2
            // 
            button2.Location = new Point(196, 412);
            button2.Name = "button2";
            button2.Size = new Size(150, 49);
            button2.TabIndex = 32;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRegistros.Location = new Point(6, 34);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(358, 140);
            dgvRegistros.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Documento";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            // 
            // button3
            // 
            button3.Location = new Point(9, 412);
            button3.Name = "button3";
            button3.Size = new Size(150, 49);
            button3.TabIndex = 31;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 193);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 318);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(163, 33);
            txtTelefono.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 316);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 22;
            label2.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 358);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 29;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 275);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 23;
            label3.Text = "Documento:";
            // 
            // txtDocumentos
            // 
            txtDocumentos.Location = new Point(151, 280);
            txtDocumentos.Name = "txtDocumentos";
            txtDocumentos.Size = new Size(163, 33);
            txtDocumentos.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 234);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 24;
            label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 239);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(163, 33);
            txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 33);
            txtNombre.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 33);
            txtEmail.TabIndex = 26;
            // 
            // FA
            // 
            FA.AutoSize = true;
            FA.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FA.Location = new Point(558, 9);
            FA.Name = "FA";
            FA.Size = new Size(121, 32);
            FA.TabIndex = 20;
            FA.Text = "SUBASTAS";
            // 
            // grbSubastas
            // 
            grbSubastas.BackColor = Color.SaddleBrown;
            grbSubastas.Controls.Add(btnRefrescarDatos);
            grbSubastas.Controls.Add(textBox1);
            grbSubastas.Controls.Add(cmbApellidoF);
            grbSubastas.Controls.Add(cmbNombreF);
            grbSubastas.Controls.Add(label12);
            grbSubastas.Controls.Add(label13);
            grbSubastas.Controls.Add(cmbDuracion);
            grbSubastas.Controls.Add(pictureBox1);
            grbSubastas.Controls.Add(button4);
            grbSubastas.Controls.Add(label11);
            grbSubastas.Controls.Add(label8);
            grbSubastas.Controls.Add(cmbProducto);
            grbSubastas.Controls.Add(cmbOferta);
            grbSubastas.Controls.Add(dgvFinalSubasta);
            grbSubastas.Controls.Add(label6);
            grbSubastas.Controls.Add(label7);
            grbSubastas.Controls.Add(label9);
            grbSubastas.Controls.Add(txtCondicion);
            grbSubastas.Controls.Add(label10);
            grbSubastas.Controls.Add(button1);
            grbSubastas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbSubastas.Location = new Point(415, 53);
            grbSubastas.Name = "grbSubastas";
            grbSubastas.Size = new Size(871, 485);
            grbSubastas.TabIndex = 21;
            grbSubastas.TabStop = false;
            grbSubastas.Text = "Subastas";
            // 
            // btnRefrescarDatos
            // 
            btnRefrescarDatos.Location = new Point(640, 89);
            btnRefrescarDatos.Name = "btnRefrescarDatos";
            btnRefrescarDatos.Size = new Size(186, 58);
            btnRefrescarDatos.TabIndex = 55;
            btnRefrescarDatos.Text = "Refrescar Datos";
            btnRefrescarDatos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 139);
            textBox1.TabIndex = 54;
            // 
            // cmbApellidoF
            // 
            cmbApellidoF.FormattingEnabled = true;
            cmbApellidoF.Location = new Point(445, 83);
            cmbApellidoF.Name = "cmbApellidoF";
            cmbApellidoF.Size = new Size(164, 33);
            cmbApellidoF.TabIndex = 53;
            // 
            // cmbNombreF
            // 
            cmbNombreF.FormattingEnabled = true;
            cmbNombreF.Location = new Point(445, 44);
            cmbNombreF.Name = "cmbNombreF";
            cmbNombreF.Size = new Size(163, 33);
            cmbNombreF.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(357, 39);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 50;
            label12.Text = "Nombre:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(356, 80);
            label13.Name = "label13";
            label13.Size = new Size(79, 25);
            label13.TabIndex = 51;
            label13.Text = "Apellido:";
            // 
            // cmbDuracion
            // 
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(143, 78);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(164, 33);
            cmbDuracion.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_05_05_084025;
            pictureBox1.Location = new Point(617, 345);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(98, 402);
            button4.Name = "button4";
            button4.Size = new Size(186, 47);
            button4.TabIndex = 47;
            button4.Text = "Finalizar Subasta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(487, 239);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 45;
            label11.Text = "Ganador:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(430, 14);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 44;
            label8.Text = "Cliente:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(143, 39);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(163, 33);
            cmbProducto.TabIndex = 43;
            // 
            // cmbOferta
            // 
            cmbOferta.FormattingEnabled = true;
            cmbOferta.Location = new Point(445, 124);
            cmbOferta.Name = "cmbOferta";
            cmbOferta.Size = new Size(163, 33);
            cmbOferta.TabIndex = 42;
            // 
            // dgvFinalSubasta
            // 
            dgvFinalSubasta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalSubasta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvFinalSubasta.Location = new Point(24, 214);
            dgvFinalSubasta.Name = "dgvFinalSubasta";
            dgvFinalSubasta.Size = new Size(431, 182);
            dgvFinalSubasta.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Apellido Cliente";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Oferta";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Duraccion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 34);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 31;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(357, 119);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 32;
            label7.Text = "Oferta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 114);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 33;
            label9.Text = "Condicciones:";
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(143, 119);
            txtCondicion.Multiline = true;
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(163, 72);
            txtCondicion.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 73);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 34;
            label10.Text = "duraccion:";
            // 
            // frmSubastas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1298, 563);
            Controls.Add(grbSubastas);
            Controls.Add(FA);
            Controls.Add(grbRegistros);
            Name = "frmSubastas";
            Text = "frmSubastas";
            grbRegistros.ResumeLayout(false);
            grbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grbSubastas.ResumeLayout(false);
            grbSubastas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFinalSubasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private GroupBox grbRegistros;
        private Button button2;
        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button3;
        private Label label1;
        private TextBox txtTelefono;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox txtDocumentos;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private Label FA;
        private GroupBox grbSubastas;
        private DataGridView dgvFinalSubasta;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txtCondicion;
        private Label label10;
        private Label label8;
        private ComboBox cmbProducto;
        private ComboBox cmbOferta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label11;
        private Button button4;
        private PictureBox pictureBox1;
        private ComboBox cmbDuracion;
        private ComboBox cmbApellidoF;
        private ComboBox cmbNombreF;
        private Label label12;
        private Label label13;
        private TextBox textBox1;
        private Button btnRefrescarDatos;
    }
}