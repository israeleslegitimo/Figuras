namespace WindowsFormsApp1
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.Coordenadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coordenadas
            // 
            this.Coordenadas.AutoSize = true;
            this.Coordenadas.BackColor = System.Drawing.SystemColors.Control;
            this.Coordenadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Coordenadas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coordenadas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Coordenadas.Location = new System.Drawing.Point(820, 0);
            this.Coordenadas.Name = "Coordenadas";
            this.Coordenadas.Size = new System.Drawing.Size(84, 26);
            this.Coordenadas.TabIndex = 22;
            this.Coordenadas.Text = "X=0   Y=0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(-3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(976, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangulosToolStripMenuItem,
            this.elipcesToolStripMenuItem,
            this.lineaToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // rectangulosToolStripMenuItem
            // 
            this.rectangulosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangulosToolStripMenuItem.Image")));
            this.rectangulosToolStripMenuItem.Name = "rectangulosToolStripMenuItem";
            this.rectangulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangulosToolStripMenuItem.Text = "Rectangulos";
            this.rectangulosToolStripMenuItem.Click += new System.EventHandler(this.rectangulosToolStripMenuItem_Click);
            // 
            // elipcesToolStripMenuItem
            // 
            this.elipcesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("elipcesToolStripMenuItem.Image")));
            this.elipcesToolStripMenuItem.Name = "elipcesToolStripMenuItem";
            this.elipcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elipcesToolStripMenuItem.Text = "elipces";
            this.elipcesToolStripMenuItem.Click += new System.EventHandler(this.elipcesToolStripMenuItem_Click);
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineaToolStripMenuItem.Image")));
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineaToolStripMenuItem.Text = "Linea";
            this.lineaToolStripMenuItem.Click += new System.EventHandler(this.lineaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seleccionarToolStripMenuItem.Image")));
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.seleccionarToolStripMenuItem.Text = "Ver color";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.seleccionarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem.Image")));
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bordeToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // bordeToolStripMenuItem
            // 
            this.bordeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negroToolStripMenuItem,
            this.rojoToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.blancoToolStripMenuItem,
            this.transparenteToolStripMenuItem});
            this.bordeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bordeToolStripMenuItem.Image")));
            this.bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            this.bordeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bordeToolStripMenuItem.Text = "cambiar color ";
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("negroToolStripMenuItem.Image")));
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negroToolStripMenuItem.Text = "Negro";
            this.negroToolStripMenuItem.Click += new System.EventHandler(this.negroToolStripMenuItem_Click);
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rojoToolStripMenuItem.Image")));
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            this.rojoToolStripMenuItem.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("azulToolStripMenuItem.Image")));
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verdeToolStripMenuItem.Image")));
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // blancoToolStripMenuItem
            // 
            this.blancoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blancoToolStripMenuItem.Image")));
            this.blancoToolStripMenuItem.Name = "blancoToolStripMenuItem";
            this.blancoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.blancoToolStripMenuItem.Text = "Blanco";
            this.blancoToolStripMenuItem.Click += new System.EventHandler(this.blancoToolStripMenuItem_Click);
            // 
            // transparenteToolStripMenuItem
            // 
            this.transparenteToolStripMenuItem.Name = "transparenteToolStripMenuItem";
            this.transparenteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.transparenteToolStripMenuItem.Text = "Transparente";
            this.transparenteToolStripMenuItem.Click += new System.EventHandler(this.transparenteToolStripMenuItem_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coordenadas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint 2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Coordenadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparenteToolStripMenuItem;
    }
}

