namespace Libreria.Capa_Usuario
{
    partial class frmEditoriales
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
            this.btnEliminarEditorial = new System.Windows.Forms.Button();
            this.btnEditarEditorial = new System.Windows.Forms.Button();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.txtBuscarEditorial = new System.Windows.Forms.TextBox();
            this.btnBuscarEditorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEditores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarEditorial
            // 
            this.btnEliminarEditorial.BackgroundImage = global::Libreria.Properties.Resources.editar_borrar_icono_5828_64;
            this.btnEliminarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarEditorial.Location = new System.Drawing.Point(207, 376);
            this.btnEliminarEditorial.Name = "btnEliminarEditorial";
            this.btnEliminarEditorial.Size = new System.Drawing.Size(65, 61);
            this.btnEliminarEditorial.TabIndex = 20;
            this.btnEliminarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnEditarEditorial
            // 
            this.btnEditarEditorial.BackgroundImage = global::Libreria.Properties.Resources.editar_icono_9796_64;
            this.btnEditarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarEditorial.Location = new System.Drawing.Point(123, 376);
            this.btnEditarEditorial.Name = "btnEditarEditorial";
            this.btnEditarEditorial.Size = new System.Drawing.Size(65, 61);
            this.btnEditarEditorial.TabIndex = 19;
            this.btnEditarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEditorial.BackgroundImage = global::Libreria.Properties.Resources.agregar_editar_icono_6607_64;
            this.btnAgregarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEditorial.Location = new System.Drawing.Point(39, 376);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(65, 61);
            this.btnAgregarEditorial.TabIndex = 18;
            this.btnAgregarEditorial.UseVisualStyleBackColor = false;
            // 
            // txtBuscarEditorial
            // 
            this.txtBuscarEditorial.Location = new System.Drawing.Point(554, 52);
            this.txtBuscarEditorial.Name = "txtBuscarEditorial";
            this.txtBuscarEditorial.Size = new System.Drawing.Size(127, 20);
            this.txtBuscarEditorial.TabIndex = 17;
            // 
            // btnBuscarEditorial
            // 
            this.btnBuscarEditorial.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEditorial.BackgroundImage = global::Libreria.Properties.Resources.closer_1297401_960_720;
            this.btnBuscarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEditorial.Location = new System.Drawing.Point(687, 24);
            this.btnBuscarEditorial.Name = "btnBuscarEditorial";
            this.btnBuscarEditorial.Size = new System.Drawing.Size(50, 48);
            this.btnBuscarEditorial.TabIndex = 16;
            this.btnBuscarEditorial.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Editoriales";
            // 
            // dgvEditores
            // 
            this.dgvEditores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditores.Location = new System.Drawing.Point(39, 87);
            this.dgvEditores.Name = "dgvEditores";
            this.dgvEditores.Size = new System.Drawing.Size(698, 277);
            this.dgvEditores.TabIndex = 14;
            // 
            // frmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 469);
            this.Controls.Add(this.btnEliminarEditorial);
            this.Controls.Add(this.btnEditarEditorial);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.txtBuscarEditorial);
            this.Controls.Add(this.btnBuscarEditorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEditores);
            this.Name = "frmEditoriales";
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.frmEditoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarEditorial;
        private System.Windows.Forms.Button btnEditarEditorial;
        private System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.TextBox txtBuscarEditorial;
        private System.Windows.Forms.Button btnBuscarEditorial;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvEditores;
    }
}