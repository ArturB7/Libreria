namespace Libreria.Capa_Usuario
{
    partial class frmPrincipal
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
            this.btnTitulos = new System.Windows.Forms.Button();
            this.btnEditorial = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitulos
            // 
            this.btnTitulos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTitulos.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTitulos.Location = new System.Drawing.Point(440, 24);
            this.btnTitulos.Name = "btnTitulos";
            this.btnTitulos.Size = new System.Drawing.Size(179, 66);
            this.btnTitulos.TabIndex = 0;
            this.btnTitulos.Text = "Titulos";
            this.btnTitulos.UseVisualStyleBackColor = false;
            this.btnTitulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditorial
            // 
            this.btnEditorial.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEditorial.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditorial.Location = new System.Drawing.Point(440, 112);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(179, 67);
            this.btnEditorial.TabIndex = 1;
            this.btnEditorial.Text = "Editorial";
            this.btnEditorial.UseVisualStyleBackColor = false;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVentas.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Location = new System.Drawing.Point(28, 24);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(179, 67);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAutores.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutores.Location = new System.Drawing.Point(440, 201);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(179, 67);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReportes.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Location = new System.Drawing.Point(440, 294);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(179, 67);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 406);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnEditorial);
            this.Controls.Add(this.btnTitulos);
            this.Name = "frmPrincipal";
            this.Text = "Libreria ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitulos;
        private System.Windows.Forms.Button btnEditorial;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnReportes;
    }
}