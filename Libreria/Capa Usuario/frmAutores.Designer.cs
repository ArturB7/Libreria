namespace Libreria.Capa_Usuario
{
    partial class frmAutores
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
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.txtBuscarAutor = new System.Windows.Forms.TextBox();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.BackgroundImage = global::Libreria.Properties.Resources.editar_borrar_icono_5828_64;
            this.btnEliminarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarAutor.Location = new System.Drawing.Point(197, 376);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(65, 61);
            this.btnEliminarAutor.TabIndex = 13;
            this.btnEliminarAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.BackgroundImage = global::Libreria.Properties.Resources.editar_icono_9796_64;
            this.btnEditarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarAutor.Location = new System.Drawing.Point(113, 376);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(65, 61);
            this.btnEditarAutor.TabIndex = 12;
            this.btnEditarAutor.UseVisualStyleBackColor = true;
            this.btnEditarAutor.Click += new System.EventHandler(this.btnEditarAutor_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAutor.BackgroundImage = global::Libreria.Properties.Resources.agregar_editar_icono_6607_64;
            this.btnAgregarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAutor.Location = new System.Drawing.Point(29, 376);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(65, 61);
            this.btnAgregarAutor.TabIndex = 11;
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(544, 52);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(127, 20);
            this.txtBuscarAutor.TabIndex = 10;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAutor.BackgroundImage = global::Libreria.Properties.Resources.closer_1297401_960_720;
            this.btnBuscarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAutor.Location = new System.Drawing.Point(677, 24);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(50, 48);
            this.btnBuscarAutor.TabIndex = 9;
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autores";
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(29, 87);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(698, 277);
            this.dgvAutores.TabIndex = 7;
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 460);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnEditarAutor);
            this.Controls.Add(this.btnAgregarAutor);
            this.Controls.Add(this.txtBuscarAutor);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutores);
            this.Name = "frmAutores";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.frmAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.TextBox txtBuscarAutor;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvAutores;
    }
}