namespace Gestion_Inventarios
{
    partial class FrmGestionInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtBuscador = new TextBox();
            panel2 = new Panel();
            btnSalir = new Button();
            panel3 = new Panel();
            grdGestionInventario = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdGestionInventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscador);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 24);
            panel1.TabIndex = 0;
            // 
            // txtBuscador
            // 
            txtBuscador.Dock = DockStyle.Fill;
            txtBuscador.Location = new Point(0, 0);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(663, 23);
            txtBuscador.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 52);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(563, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 52);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(grdGestionInventario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(663, 249);
            panel3.TabIndex = 2;
            // 
            // grdGestionInventario
            // 
            grdGestionInventario.AllowUserToAddRows = false;
            grdGestionInventario.AllowUserToDeleteRows = false;
            grdGestionInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGestionInventario.Dock = DockStyle.Fill;
            grdGestionInventario.Location = new Point(0, 0);
            grdGestionInventario.Name = "grdGestionInventario";
            grdGestionInventario.ReadOnly = true;
            grdGestionInventario.Size = new Size(663, 249);
            grdGestionInventario.TabIndex = 0;
            // 
            // FrmGestionInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 325);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGestionInventario";
            Text = "Gestion Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdGestionInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscador;
        private Panel panel2;
        private Button btnSalir;
        private Panel panel3;
        private DataGridView grdGestionInventario;
    }
}
