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
            this.btnAgregarTitulo = new System.Windows.Forms.Button();
            this.btnEditarTitulo = new System.Windows.Forms.Button();
            this.btnEliminarTitulo = new System.Windows.Forms.Button();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTitulo
            // 
            this.btnAgregarTitulo.Location = new System.Drawing.Point(35, 407);
            this.btnAgregarTitulo.Name = "btnAgregarTitulo";
            this.btnAgregarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTitulo.TabIndex = 16;
            this.btnAgregarTitulo.Text = "Nuevo";
            this.btnAgregarTitulo.UseVisualStyleBackColor = true;
            // 
            // btnEditarTitulo
            // 
            this.btnEditarTitulo.Location = new System.Drawing.Point(127, 407);
            this.btnEditarTitulo.Name = "btnEditarTitulo";
            this.btnEditarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTitulo.TabIndex = 15;
            this.btnEditarTitulo.Text = "Editar";
            this.btnEditarTitulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTitulo
            // 
            this.btnEliminarTitulo.Location = new System.Drawing.Point(220, 407);
            this.btnEliminarTitulo.Name = "btnEliminarTitulo";
            this.btnEliminarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTitulo.TabIndex = 14;
            this.btnEliminarTitulo.Text = "Eliminar";
            this.btnEliminarTitulo.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Location = new System.Drawing.Point(487, 54);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(158, 20);
            this.txtBuscarTitulo.TabIndex = 13;
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(651, 52);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTitulo.TabIndex = 12;
            this.btnBuscarTitulo.Text = "Buscar";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(35, 88);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.Size = new System.Drawing.Size(692, 301);
            this.dgvTitulos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titulos";
            // 
            // frmTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 455);
            this.Controls.Add(this.btnAgregarTitulo);
            this.Controls.Add(this.btnEditarTitulo);
            this.Controls.Add(this.btnEliminarTitulo);
            this.Controls.Add(this.txtBuscarTitulo);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.label1);
            this.Name = "frmTitulos";
            this.Text = "Titulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTitulo;
        private System.Windows.Forms.Button btnEditarTitulo;
        private System.Windows.Forms.Button btnEliminarTitulo;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.Label label1;
    }
}