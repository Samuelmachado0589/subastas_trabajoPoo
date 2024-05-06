namespace subastas.pro
{
    partial class frmGestion
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
            dgvRegistros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            FA = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtDocumentos = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRegistros.Location = new Point(41, 63);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(544, 214);
            dgvRegistros.TabIndex = 0;
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
            // FA
            // 
            FA.AutoSize = true;
            FA.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FA.Location = new Point(329, 9);
            FA.Name = "FA";
            FA.Size = new Size(131, 32);
            FA.TabIndex = 1;
            FA.Text = "REGISTROS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 330);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 453);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 8;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 412);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 9;
            label3.Text = "Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 371);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 10;
            label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 330);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 500);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 12;

            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(155, 376);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtDocumentos
            // 
            txtDocumentos.Location = new Point(155, 417);
            txtDocumentos.Name = "txtDocumentos";
            txtDocumentos.Size = new Size(194, 23);
            txtDocumentos.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 495);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 15;
            label5.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(155, 455);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(387, 412);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 17;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 412);
            button2.Name = "button2";
            button2.Size = new Size(181, 51);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDocumentos);
            Controls.Add(txtApellido);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FA);
            Controls.Add(dgvRegistros);
            Name = "Registros";
            Text = "frmSubastas";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label FA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtDocumentos;
        private Label label5;
        private TextBox txtTelefono;
        private Button button1;
        private Button button2;
    }
}