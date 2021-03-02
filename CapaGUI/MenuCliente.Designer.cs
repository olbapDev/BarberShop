namespace CapaGUI
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agregarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conToolStripMenuItem,
            this.modificarPlanToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conToolStripMenuItem
            // 
            this.conToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPlanToolStripMenuItem});
            this.conToolStripMenuItem.Name = "conToolStripMenuItem";
            this.conToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.conToolStripMenuItem.Text = "&Contratar";
            // 
            // modificarPlanToolStripMenuItem
            // 
            this.modificarPlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarServiciosToolStripMenuItem});
            this.modificarPlanToolStripMenuItem.Name = "modificarPlanToolStripMenuItem";
            this.modificarPlanToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.modificarPlanToolStripMenuItem.Text = "&Modificar Plan";
            this.modificarPlanToolStripMenuItem.Click += new System.EventHandler(this.modificarPlanToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cambiarServiciosToolStripMenuItem
            // 
            this.cambiarServiciosToolStripMenuItem.Name = "cambiarServiciosToolStripMenuItem";
            this.cambiarServiciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarServiciosToolStripMenuItem.Text = "&Cambiar Servicios";
            this.cambiarServiciosToolStripMenuItem.Click += new System.EventHandler(this.cambiarServiciosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 418);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // agregarPlanToolStripMenuItem
            // 
            this.agregarPlanToolStripMenuItem.Name = "agregarPlanToolStripMenuItem";
            this.agregarPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarPlanToolStripMenuItem.Text = "&AgregarPlan";
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 440);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPlanToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}