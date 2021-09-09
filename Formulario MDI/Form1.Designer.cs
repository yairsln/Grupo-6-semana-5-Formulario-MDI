
namespace Formulario_MDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroDeDialogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuToolStripMenuItem1,
            this.menu3ToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cuadroDeDialogoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem,
            this.opcion3ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.menuToolStripMenuItem.Text = "Combos";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion1ToolStripMenuItem.Text = "combo 1";
            this.opcion1ToolStripMenuItem.Click += new System.EventHandler(this.opcion1ToolStripMenuItem_Click);
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion2ToolStripMenuItem.Text = "combo 2";
            this.opcion2ToolStripMenuItem.Click += new System.EventHandler(this.opcion2ToolStripMenuItem_Click);
            // 
            // opcion3ToolStripMenuItem
            // 
            this.opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            this.opcion3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion3ToolStripMenuItem.Text = "combo 3";
            this.opcion3ToolStripMenuItem.Click += new System.EventHandler(this.opcion3ToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.menuToolStripMenuItem1.Text = "Ensaladas";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heladosToolStripMenuItem,
            this.budinToolStripMenuItem,
            this.tartaletaToolStripMenuItem});
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.menu3ToolStripMenuItem.Text = "Postres";
            this.menu3ToolStripMenuItem.Click += new System.EventHandler(this.menu3ToolStripMenuItem_Click);
            // 
            // heladosToolStripMenuItem
            // 
            this.heladosToolStripMenuItem.Name = "heladosToolStripMenuItem";
            this.heladosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heladosToolStripMenuItem.Text = "Helados";
            this.heladosToolStripMenuItem.Click += new System.EventHandler(this.heladosToolStripMenuItem_Click);
            // 
            // budinToolStripMenuItem
            // 
            this.budinToolStripMenuItem.Name = "budinToolStripMenuItem";
            this.budinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.budinToolStripMenuItem.Text = "Budin ";
            this.budinToolStripMenuItem.Click += new System.EventHandler(this.budinToolStripMenuItem_Click);
            // 
            // tartaletaToolStripMenuItem
            // 
            this.tartaletaToolStripMenuItem.Name = "tartaletaToolStripMenuItem";
            this.tartaletaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tartaletaToolStripMenuItem.Text = "Tartaleta";
            this.tartaletaToolStripMenuItem.Click += new System.EventHandler(this.tartaletaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // cuadroDeDialogoToolStripMenuItem
            // 
            this.cuadroDeDialogoToolStripMenuItem.Name = "cuadroDeDialogoToolStripMenuItem";
            this.cuadroDeDialogoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.cuadroDeDialogoToolStripMenuItem.Text = "Cuadro de Dialogo ";
            this.cuadroDeDialogoToolStripMenuItem.Click += new System.EventHandler(this.cuadroDeDialogoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulario MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroDeDialogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tartaletaToolStripMenuItem;
    }
}

