namespace IngSoft.Interfaces
{
    partial class EditCliente
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
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditar.ForeColor = System.Drawing.Color.Black;
            this.ButtonEditar.Location = new System.Drawing.Point(67, 229);
            this.ButtonEditar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(109, 31);
            this.ButtonEditar.TabIndex = 19;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonsalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(348, 232);
            this.buttonsalir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(107, 30);
            this.buttonsalir.TabIndex = 18;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Direccion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 187);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(226, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(23, 111);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(179, 20);
            this.txttelefono.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(41, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IngSoft.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(297, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 124);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // EditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(466, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditCliente";
            this.Text = "EditCliente";
            this.Load += new System.EventHandler(this.EditCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEditar;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}