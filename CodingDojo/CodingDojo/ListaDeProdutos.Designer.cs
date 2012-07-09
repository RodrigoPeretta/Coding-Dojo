namespace CodingDojo
{
    partial class ListaDeProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grpPesquisar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrarN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grpPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 152);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(355, 167);
            this.dgvProdutos.TabIndex = 2;
            // 
            // grpPesquisar
            // 
            this.grpPesquisar.Controls.Add(this.btnListar);
            this.grpPesquisar.Controls.Add(this.txtBuscar);
            this.grpPesquisar.Location = new System.Drawing.Point(12, 35);
            this.grpPesquisar.Name = "grpPesquisar";
            this.grpPesquisar.Size = new System.Drawing.Size(355, 83);
            this.grpPesquisar.TabIndex = 3;
            this.grpPesquisar.TabStop = false;
            this.grpPesquisar.Text = "Pesquisar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(272, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForm.Location = new System.Drawing.Point(90, 9);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(198, 23);
            this.lblNomeForm.TabIndex = 7;
            this.lblNomeForm.Text = "Lista de Produtos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 123);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(93, 123);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Alterar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrarN
            // 
            this.btnCadastrarN.Location = new System.Drawing.Point(284, 123);
            this.btnCadastrarN.Name = "btnCadastrarN";
            this.btnCadastrarN.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarN.TabIndex = 10;
            this.btnCadastrarN.Text = "Cadastrar Novo";
            this.btnCadastrarN.UseVisualStyleBackColor = true;
            this.btnCadastrarN.Click += new System.EventHandler(this.btnCadastrarN_Click);
            // 
            // ListaDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 331);
            this.Controls.Add(this.btnCadastrarN);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblNomeForm);
            this.Controls.Add(this.grpPesquisar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "ListaDeProdutos";
            this.Text = "Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grpPesquisar.ResumeLayout(false);
            this.grpPesquisar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grpPesquisar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNomeForm;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrarN;
    }
}