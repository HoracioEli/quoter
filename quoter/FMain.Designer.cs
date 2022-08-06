
namespace quoter
{
    partial class FMain
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
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.panelSubrama = new System.Windows.Forms.Panel();
            this.btnRoboTransito = new System.Windows.Forms.Button();
            this.btnRoboValores = new System.Windows.Forms.Button();
            this.btrnSubramas = new System.Windows.Forms.Button();
            this.PanelFormHijo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Panel_Left.SuspendLayout();
            this.panelSubrama.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.Black;
            this.Panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Left.Controls.Add(this.btnSalir);
            this.Panel_Left.Controls.Add(this.panelSubrama);
            this.Panel_Left.Controls.Add(this.btrnSubramas);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(250, 600);
            this.Panel_Left.TabIndex = 0;
            // 
            // panelSubrama
            // 
            this.panelSubrama.BackColor = System.Drawing.Color.DimGray;
            this.panelSubrama.Controls.Add(this.btnRoboTransito);
            this.panelSubrama.Controls.Add(this.btnRoboValores);
            this.panelSubrama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubrama.Location = new System.Drawing.Point(0, 33);
            this.panelSubrama.Name = "panelSubrama";
            this.panelSubrama.Size = new System.Drawing.Size(246, 194);
            this.panelSubrama.TabIndex = 2;
            // 
            // btnRoboTransito
            // 
            this.btnRoboTransito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoboTransito.FlatAppearance.BorderSize = 0;
            this.btnRoboTransito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRoboTransito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoboTransito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoboTransito.ForeColor = System.Drawing.Color.White;
            this.btnRoboTransito.Location = new System.Drawing.Point(0, 33);
            this.btnRoboTransito.Name = "btnRoboTransito";
            this.btnRoboTransito.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoboTransito.Size = new System.Drawing.Size(246, 33);
            this.btnRoboTransito.TabIndex = 3;
            this.btnRoboTransito.Text = "Robo - Tránsito";
            this.btnRoboTransito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoboTransito.UseVisualStyleBackColor = true;
            this.btnRoboTransito.Click += new System.EventHandler(this.btnRoboTransito_Click);
            // 
            // btnRoboValores
            // 
            this.btnRoboValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoboValores.FlatAppearance.BorderSize = 0;
            this.btnRoboValores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRoboValores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoboValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoboValores.ForeColor = System.Drawing.Color.White;
            this.btnRoboValores.Location = new System.Drawing.Point(0, 0);
            this.btnRoboValores.Name = "btnRoboValores";
            this.btnRoboValores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoboValores.Size = new System.Drawing.Size(246, 33);
            this.btnRoboValores.TabIndex = 2;
            this.btnRoboValores.Text = "Robo - Valores";
            this.btnRoboValores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoboValores.UseVisualStyleBackColor = true;
            this.btnRoboValores.Click += new System.EventHandler(this.btnRoboValores_Click);
            // 
            // btrnSubramas
            // 
            this.btrnSubramas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btrnSubramas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btrnSubramas.FlatAppearance.BorderSize = 0;
            this.btrnSubramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrnSubramas.ForeColor = System.Drawing.Color.White;
            this.btrnSubramas.Location = new System.Drawing.Point(0, 0);
            this.btrnSubramas.Name = "btrnSubramas";
            this.btrnSubramas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btrnSubramas.Size = new System.Drawing.Size(246, 33);
            this.btrnSubramas.TabIndex = 1;
            this.btrnSubramas.Text = "Rama - Subrama";
            this.btrnSubramas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrnSubramas.UseVisualStyleBackColor = true;
            this.btrnSubramas.Click += new System.EventHandler(this.btrnSubramas_Click);
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.LightGray;
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(250, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(700, 600);
            this.PanelFormHijo.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 563);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(246, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.PanelFormHijo);
            this.Controls.Add(this.Panel_Left);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a QUOTER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Panel_Left.ResumeLayout(false);
            this.panelSubrama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.Panel panelSubrama;
        private System.Windows.Forms.Button btnRoboValores;
        private System.Windows.Forms.Button btrnSubramas;
        private System.Windows.Forms.Button btnRoboTransito;
        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button btnSalir;
    }
}

