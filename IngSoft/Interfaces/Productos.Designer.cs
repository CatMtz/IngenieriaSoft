namespace IngSoft.Interfaces
{
    partial class Productos
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
            this.grvProductos = new System.Windows.Forms.DataGridView();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.btnAgregaar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grvProductos
            // 
            this.grvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductos.Location = new System.Drawing.Point(12, 27);
            this.grvProductos.Name = "grvProductos";
            this.grvProductos.Size = new System.Drawing.Size(676, 384);
            this.grvProductos.TabIndex = 0;
            this.grvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProductos_CellContentClick);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonsalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(609, 440);
            this.buttonsalir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(81, 24);
            this.buttonsalir.TabIndex = 19;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            this.buttonsalir.MouseLeave += new System.EventHandler(this.buttonsalir_MouseLeave);
            this.buttonsalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonsalir_MouseMove);
            // 
            // btnAgregaar
            // 
            this.btnAgregaar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaar.Location = new System.Drawing.Point(12, 438);
            this.btnAgregaar.Name = "btnAgregaar";
            this.btnAgregaar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregaar.TabIndex = 20;
            this.btnAgregaar.Text = "Agregar";
            this.btnAgregaar.UseVisualStyleBackColor = true;
            this.btnAgregaar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(701, 483);
            this.Controls.Add(this.btnAgregaar);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.grvProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvProductos;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.Button btnAgregaar;
    }
}