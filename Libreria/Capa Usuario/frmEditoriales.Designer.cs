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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEditores = new System.Windows.Forms.Button();
            this.txtBuscarEditores = new System.Windows.Forms.TextBox();
            this.btnEliminarEditor = new System.Windows.Forms.Button();
            this.btnEditarEditor = new System.Windows.Forms.Button();
            this.btnAgregarEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editoriales";
            // 
            // btnBuscarEditores
            // 
            this.btnBuscarEditores.Location = new System.Drawing.Point(650, 57);
            this.btnBuscarEditores.Name = "btnBuscarEditores";
            this.btnBuscarEditores.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEditores.TabIndex = 2;
            this.btnBuscarEditores.Text = "Buscar";
            this.btnBuscarEditores.UseVisualStyleBackColor = true;
            // 
            // txtBuscarEditores
            // 
            this.txtBuscarEditores.Location = new System.Drawing.Point(486, 59);
            this.txtBuscarEditores.Name = "txtBuscarEditores";
            this.txtBuscarEditores.Size = new System.Drawing.Size(158, 20);
            this.txtBuscarEditores.TabIndex = 3;
            // 
            // btnEliminarEditor
            // 
            this.btnEliminarEditor.Location = new System.Drawing.Point(218, 418);
            this.btnEliminarEditor.Name = "btnEliminarEditor";
            this.btnEliminarEditor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEditor.TabIndex = 4;
            this.btnEliminarEditor.Text = "Eliminar";
            this.btnEliminarEditor.UseVisualStyleBackColor = true;
            // 
            // btnEditarEditor
            // 
            this.btnEditarEditor.Location = new System.Drawing.Point(125, 418);
            this.btnEditarEditor.Name = "btnEditarEditor";
            this.btnEditarEditor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEditor.TabIndex = 5;
            this.btnEditarEditor.Text = "Editar";
            this.btnEditarEditor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEditor
            // 
            this.btnAgregarEditor.Location = new System.Drawing.Point(33, 418);
            this.btnAgregarEditor.Name = "btnAgregarEditor";
            this.btnAgregarEditor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEditor.TabIndex = 6;
            this.btnAgregarEditor.Text = "Nuevo";
            this.btnAgregarEditor.UseVisualStyleBackColor = true;
            // 
            // frmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.no_se_dice_ler__es_leer___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 473);
            this.Controls.Add(this.btnAgregarEditor);
            this.Controls.Add(this.btnEditarEditor);
            this.Controls.Add(this.btnEliminarEditor);
            this.Controls.Add(this.txtBuscarEditores);
            this.Controls.Add(this.btnBuscarEditores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEditoriales";
            this.Text = "frmEditoriales";
            this.Load += new System.EventHandler(this.frmEditoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEditores;
        private System.Windows.Forms.TextBox txtBuscarEditores;
        private System.Windows.Forms.Button btnEliminarEditor;
        private System.Windows.Forms.Button btnEditarEditor;
        private System.Windows.Forms.Button btnAgregarEditor;
    }
}