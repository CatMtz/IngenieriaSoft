namespace IngSoft.Interfaces
{
    partial class R_VentaMes
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
            this.grvVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvVenta
            // 
            this.grvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvVenta.Location = new System.Drawing.Point(23, 141);
            this.grvVenta.Name = "grvVenta";
            this.grvVenta.Size = new System.Drawing.Size(503, 143);
            this.grvVenta.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mes";
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalir.Location = new System.Drawing.Point(427, 318);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(108, 26);
            this.ButtonSalir.TabIndex = 10;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = false;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            this.ButtonSalir.MouseLeave += new System.EventHandler(this.ButtonSalir_MouseLeave);
            this.ButtonSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonSalir_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total de ventas";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(17, 324);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(125, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IngSoft.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(289, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 105);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DTPFecha
            // 
            this.DTPFecha.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Location = new System.Drawing.Point(12, 62);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(271, 25);
            this.DTPFecha.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // R_VentaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(547, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grvVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Name = "R_VentaMes";
            this.Text = "R_VentaMes";
            this.Load += new System.EventHandler(this.R_VentaMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;

        
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Button button1;
    }
}