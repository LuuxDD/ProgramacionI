namespace CiclismoDesktopPorCodigo.Views
{
    partial class NuevoEditarClienteView
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtNombreContacto = new TextBox();
            label4 = new Label();
            txtApellidoContacto = new TextBox();
            btnGuardar = new Button();
            bntCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(227, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 167);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre Contacto:";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(227, 159);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(320, 23);
            txtNombreContacto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 214);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido Contacto:";
            // 
            // txtApellidoContacto
            // 
            txtApellidoContacto.Location = new Point(227, 206);
            txtApellidoContacto.Name = "txtApellidoContacto";
            txtApellidoContacto.Size = new Size(320, 23);
            txtApellidoContacto.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(227, 304);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 33);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(439, 304);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(108, 33);
            bntCancelar.TabIndex = 8;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // NuevoEditarClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 396);
            Controls.Add(bntCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidoContacto);
            Controls.Add(label4);
            Controls.Add(txtNombreContacto);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoEditarClienteView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo/Editar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtNombreContacto;
        private Label label4;
        private TextBox txtApellidoContacto;
        private Button btnGuardar;
        private Button bntCancelar;
    }
}