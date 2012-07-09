namespace CodingDojo
{
    partial class FormCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbnCancelar = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(262, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbnCancelar
            // 
            this.lbnCancelar.Location = new System.Drawing.Point(172, 297);
            this.lbnCancelar.Name = "lbnCancelar";
            this.lbnCancelar.Size = new System.Drawing.Size(75, 23);
            this.lbnCancelar.TabIndex = 1;
            this.lbnCancelar.Text = "Cancelar";
            this.lbnCancelar.UseVisualStyleBackColor = true;
            this.lbnCancelar.Click += new System.EventHandler(this.lbnCancelar_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(34, 143);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(98, 140);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(240, 109);
            this.txtDesc.TabIndex = 5;
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForm.Location = new System.Drawing.Point(94, 31);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(241, 23);
            this.lblNomeForm.TabIndex = 6;
            this.lblNomeForm.Text = "Cadastro de Produtos";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 348);
            this.Controls.Add(this.lblNomeForm);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lbnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormCadastro";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button lbnCancelar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblNomeForm;
    }
}

