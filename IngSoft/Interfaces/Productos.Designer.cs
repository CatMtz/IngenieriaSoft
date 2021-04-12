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
            this.menuproductos = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).BeginInit();
            this.menuproductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvProductos
            // 
            this.grvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductos.Location = new System.Drawing.Point(12, 27);
            this.grvProductos.Name = "grvProductos";
            this.grvProductos.Size = new System.Drawing.Size(415, 384);
            this.grvProductos.TabIndex = 0;
            // 
            // menuproductos
            // 
            this.menuproductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuproductos.Location = new System.Drawing.Point(0, 0);
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(442, 24);
            this.menuproductos.TabIndex = 1;
            this.menuproductos.Text = "menuStrip1";
            this.menuproductos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuproductos_ItemClicked);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Red;
            this.buttonsalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(324, 440);
            this.buttonsalir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(107, 30);
            this.buttonsalir.TabIndex = 19;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 483);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.grvProductos);
            this.Controls.Add(this.menuproductos);
            this.MainMenuStrip = this.menuproductos;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).EndInit();
            this.menuproductos.ResumeLayout(false);
            this.menuproductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvProductos;
        private System.Windows.Forms.MenuStrip menuproductos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button buttonsalir;
    }
}