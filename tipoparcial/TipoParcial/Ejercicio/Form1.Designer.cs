namespace Ejercicio
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerListar = new System.Windows.Forms.Button();
            this.btnProm = new System.Windows.Forms.Button();
            this.lbListaSocios = new System.Windows.Forms.ListBox();
            this.lbResumen = new System.Windows.Forms.ListBox();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerListar
            // 
            this.btnVerListar.Location = new System.Drawing.Point(150, 113);
            this.btnVerListar.Name = "btnVerListar";
            this.btnVerListar.Size = new System.Drawing.Size(137, 23);
            this.btnVerListar.TabIndex = 1;
            this.btnVerListar.Text = "Ver lista";
            this.btnVerListar.UseVisualStyleBackColor = true;
            this.btnVerListar.Click += new System.EventHandler(this.btnVerListar_Click);
            // 
            // btnProm
            // 
            this.btnProm.Location = new System.Drawing.Point(321, 113);
            this.btnProm.Name = "btnProm";
            this.btnProm.Size = new System.Drawing.Size(275, 23);
            this.btnProm.TabIndex = 2;
            this.btnProm.Text = "Ver promedio";
            this.btnProm.UseVisualStyleBackColor = true;
            this.btnProm.Click += new System.EventHandler(this.btnProm_Click);
            // 
            // lbListaSocios
            // 
            this.lbListaSocios.FormattingEnabled = true;
            this.lbListaSocios.Location = new System.Drawing.Point(12, 12);
            this.lbListaSocios.Name = "lbListaSocios";
            this.lbListaSocios.Size = new System.Drawing.Size(275, 95);
            this.lbListaSocios.TabIndex = 3;
            // 
            // lbResumen
            // 
            this.lbResumen.FormattingEnabled = true;
            this.lbResumen.Location = new System.Drawing.Point(321, 12);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(275, 95);
            this.lbResumen.TabIndex = 4;
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.textBox1);
            this.Busqueda.Controls.Add(this.btnBuscar);
            this.Busqueda.Location = new System.Drawing.Point(12, 155);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(275, 90);
            this.Busqueda.TabIndex = 5;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(177, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 256);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.lbResumen);
            this.Controls.Add(this.lbListaSocios);
            this.Controls.Add(this.btnProm);
            this.Controls.Add(this.btnVerListar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion usuario";
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerListar;
        private System.Windows.Forms.Button btnProm;
        private System.Windows.Forms.ListBox lbListaSocios;
        private System.Windows.Forms.ListBox lbResumen;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}

