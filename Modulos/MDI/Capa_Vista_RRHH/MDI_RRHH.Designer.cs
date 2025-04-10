namespace Capa_Vista_RRHH
{
    partial class MDI_RRHH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_inferior = new System.Windows.Forms.Panel();
            this.Pnl_Fecha = new System.Windows.Forms.Panel();
            this.Lbl_FechaActual = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Pnl_Usuario = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.mantenimientoExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manteniminetoExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Pnl_inferior.SuspendLayout();
            this.Pnl_Fecha.SuspendLayout();
            this.Pnl_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.manteniminetoExamenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoExamenToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.inicioToolStripMenuItem.Text = "Abrir";
            // 
            // Pnl_inferior
            // 
            this.Pnl_inferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_inferior.Controls.Add(this.Pnl_Fecha);
            this.Pnl_inferior.Controls.Add(this.Pnl_Usuario);
            this.Pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_inferior.Location = new System.Drawing.Point(0, 677);
            this.Pnl_inferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_inferior.Name = "Pnl_inferior";
            this.Pnl_inferior.Size = new System.Drawing.Size(1169, 73);
            this.Pnl_inferior.TabIndex = 1;
            // 
            // Pnl_Fecha
            // 
            this.Pnl_Fecha.Controls.Add(this.Lbl_FechaActual);
            this.Pnl_Fecha.Controls.Add(this.Lbl_Fecha);
            this.Pnl_Fecha.Location = new System.Drawing.Point(305, 10);
            this.Pnl_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Fecha.Name = "Pnl_Fecha";
            this.Pnl_Fecha.Size = new System.Drawing.Size(308, 50);
            this.Pnl_Fecha.TabIndex = 3;
            // 
            // Lbl_FechaActual
            // 
            this.Lbl_FechaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_FechaActual.AutoSize = true;
            this.Lbl_FechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_FechaActual.Location = new System.Drawing.Point(83, 12);
            this.Lbl_FechaActual.Name = "Lbl_FechaActual";
            this.Lbl_FechaActual.Size = new System.Drawing.Size(26, 25);
            this.Lbl_FechaActual.TabIndex = 2;
            this.Lbl_FechaActual.Text = "--";
            this.Lbl_FechaActual.Click += new System.EventHandler(this.Lbl_FechaActual_Click);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Fecha.Location = new System.Drawing.Point(3, 12);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(73, 25);
            this.Lbl_Fecha.TabIndex = 0;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Pnl_Usuario
            // 
            this.Pnl_Usuario.Controls.Add(this.lbl_nombreUsuario);
            this.Pnl_Usuario.Controls.Add(this.Lbl_Usuario);
            this.Pnl_Usuario.Location = new System.Drawing.Point(11, 10);
            this.Pnl_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Usuario.Name = "Pnl_Usuario";
            this.Pnl_Usuario.Size = new System.Drawing.Size(252, 50);
            this.Pnl_Usuario.TabIndex = 0;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(93, 12);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(26, 25);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "--";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Usuario.Location = new System.Drawing.Point(3, 12);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(85, 25);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuario:";
            this.Lbl_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // mantenimientoExamenToolStripMenuItem
            // 
            this.mantenimientoExamenToolStripMenuItem.Name = "mantenimientoExamenToolStripMenuItem";
            this.mantenimientoExamenToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.mantenimientoExamenToolStripMenuItem.Text = "Mantenimiento Examen";
            this.mantenimientoExamenToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoExamenToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manteniminetoExamenToolStripMenuItem
            // 
            this.manteniminetoExamenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manteniminetoExamenToolStripMenuItem.Name = "manteniminetoExamenToolStripMenuItem";
            this.manteniminetoExamenToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.manteniminetoExamenToolStripMenuItem.Text = "Mantenimineto Examen";
            this.manteniminetoExamenToolStripMenuItem.Click += new System.EventHandler(this.manteniminetoExamenToolStripMenuItem_Click);
            // 
            // MDI_RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1169, 750);
            this.Controls.Add(this.Pnl_inferior);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MDI_RRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marco Monroy 0901-21-843";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_RRHH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_inferior.ResumeLayout(false);
            this.Pnl_Fecha.ResumeLayout(false);
            this.Pnl_Fecha.PerformLayout();
            this.Pnl_Usuario.ResumeLayout(false);
            this.Pnl_Usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_inferior;
        private System.Windows.Forms.Panel Pnl_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Panel Pnl_Fecha;
        public System.Windows.Forms.Label Lbl_FechaActual;
        private System.Windows.Forms.Label Lbl_Fecha;
        public System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manteniminetoExamenToolStripMenuItem;
    }
}