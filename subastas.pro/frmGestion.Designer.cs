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
            FA = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProductoNuevo = new TextBox();
            txtDuracionNueva = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // FA
            // 
            FA.AutoSize = true;
            FA.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FA.Location = new Point(189, 9);
            FA.Name = "FA";
            FA.Size = new Size(97, 32);
            FA.TabIndex = 1;
            FA.Text = "Gestion ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 175);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 7;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 129);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 8;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 88);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 215);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 10;
            label4.Text = "Duracion:";
            // 
            // txtProductoNuevo
            // 
            txtProductoNuevo.Location = new Point(198, 175);
            txtProductoNuevo.Name = "txtProductoNuevo";
            txtProductoNuevo.Size = new Size(194, 23);
            txtProductoNuevo.TabIndex = 11;
            // 
            // txtDuracionNueva
            // 
            txtDuracionNueva.Location = new Point(198, 217);
            txtDuracionNueva.Name = "txtDuracionNueva";
            txtDuracionNueva.Size = new Size(194, 23);
            txtDuracionNueva.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(198, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(12, 279);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 17;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 279);
            button2.Name = "button2";
            button2.Size = new Size(181, 51);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 56);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 19;
            label6.Text = "Nueva Subasta";
            // 
            // frmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(476, 405);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDuracionNueva);
            Controls.Add(txtProductoNuevo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FA);
            Name = "frmGestion";
            Text = "frmSubastas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProductoNuevo;
        private TextBox txtDuracionNueva;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button button1;
        private Button button2;
        private Label label6;
    }
}