namespace Libreria.Capa_Usuario
{
    partial class frmTitulos
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
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.btnAgregarTitulo = new System.Windows.Forms.Button();
            this.btnModificarTitulo = new System.Windows.Forms.Button();
            this.btnEliminarTitulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(40, 100);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.Size = new System.Drawing.Size(698, 277);
            this.dgvTitulos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulos";
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarTitulo.BackgroundImage = global::Libreria.Properties.Resources.closer_1297401_960_720;
            this.btnBuscarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTitulo.Location = new System.Drawing.Point(688, 37);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(50, 48);
            this.btnBuscarTitulo.TabIndex = 2;
            this.btnBuscarTitulo.UseVisualStyleBackColor = false;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Location = new System.Drawing.Point(555, 65);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(127, 20);
            this.txtBuscarTitulo.TabIndex = 3;
            // 
            // btnAgregarTitulo
            // 
            this.btnAgregarTitulo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTitulo.BackgroundImage = global::Libreria.Properties.Resources.agregar_editar_icono_6607_64;
            this.btnAgregarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarTitulo.Location = new System.Drawing.Point(40, 389);
            this.btnAgregarTitulo.Name = "btnAgregarTitulo";
            this.btnAgregarTitulo.Size = new System.Drawing.Size(65, 61);
            this.btnAgregarTitulo.TabIndex = 4;
            this.btnAgregarTitulo.UseVisualStyleBackColor = false;
            this.btnAgregarTitulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarTitulo
            // 
            this.btnModificarTitulo.BackgroundImage = global::Libreria.Properties.Resources.editar_icono_9796_64;
            this.btnModificarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTitulo.Location = new System.Drawing.Point(124, 389);
            this.btnModificarTitulo.Name = "btnModificarTitulo";
            this.btnModificarTitulo.Size = new System.Drawing.Size(65, 61);
            this.btnModificarTitulo.TabIndex = 5;
            this.btnModificarTitulo.UseVisualStyleBackColor = true;
            this.btnModificarTitulo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminarTitulo
            // 
            this.btnEliminarTitulo.BackgroundImage = global::Libreria.Properties.Resources.editar_borrar_icono_5828_64;
            this.btnEliminarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTitulo.Location = new System.Drawing.Point(208, 389);
            this.btnEliminarTitulo.Name = "btnEliminarTitulo";
            this.btnEliminarTitulo.Size = new System.Drawing.Size(65, 61);
            this.btnEliminarTitulo.TabIndex = 6;
            this.btnEliminarTitulo.UseVisualStyleBackColor = true;
            this.btnEliminarTitulo.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.btnEliminarTitulo);
            this.Controls.Add(this.btnModificarTitulo);
            this.Controls.Add(this.btnAgregarTitulo);
            this.Controls.Add(this.txtBuscarTitulo);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTitulos);
            this.Name = "frmTitulos";
            this.Text = "Titulos";
            this.Load += new System.EventHandler(this.frmTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Button btnAgregarTitulo;
        private System.Windows.Forms.Button btnModificarTitulo;
        private System.Windows.Forms.Button btnEliminarTitulo;
        public System.Windows.Forms.DataGridView dgvTitulos;
    }
}