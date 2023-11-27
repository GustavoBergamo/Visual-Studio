namespace PimVII
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.txtBoxValorTotal = new System.Windows.Forms.TextBox();
            this.txtBoxClienteId = new System.Windows.Forms.TextBox();
            this.txtBoxProdutos = new System.Windows.Forms.TextBox();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.btnLerDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 185);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(354, 198);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(65, 20);
            this.txtBoxData.TabIndex = 1;
            // 
            // txtBoxValorTotal
            // 
            this.txtBoxValorTotal.Location = new System.Drawing.Point(467, 198);
            this.txtBoxValorTotal.Name = "txtBoxValorTotal";
            this.txtBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValorTotal.TabIndex = 2;
            // 
            // txtBoxClienteId
            // 
            this.txtBoxClienteId.Location = new System.Drawing.Point(586, 198);
            this.txtBoxClienteId.Name = "txtBoxClienteId";
            this.txtBoxClienteId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxClienteId.TabIndex = 3;
            // 
            // txtBoxProdutos
            // 
            this.txtBoxProdutos.Location = new System.Drawing.Point(706, 198);
            this.txtBoxProdutos.Name = "txtBoxProdutos";
            this.txtBoxProdutos.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProdutos.TabIndex = 4;
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Location = new System.Drawing.Point(13, 13);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.Size = new System.Drawing.Size(825, 136);
            this.dgCarrinho.TabIndex = 8;
            // 
            // btnLerDados
            // 
            this.btnLerDados.Location = new System.Drawing.Point(12, 211);
            this.btnLerDados.Name = "btnLerDados";
            this.btnLerDados.Size = new System.Drawing.Size(100, 23);
            this.btnLerDados.TabIndex = 9;
            this.btnLerDados.Text = "Consultar";
            this.btnLerDados.UseVisualStyleBackColor = true;
            this.btnLerDados.Click += new System.EventHandler(this.btnLerDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o ID a ser consultado";
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Location = new System.Drawing.Point(188, 198);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(75, 36);
            this.btnConsultarTodos.TabIndex = 11;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data (ano-mes-dia)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valot total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Produtos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(354, 235);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(467, 235);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(586, 234);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 296);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLerDados);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.txtBoxProdutos);
            this.Controls.Add(this.txtBoxClienteId);
            this.Controls.Add(this.txtBoxValorTotal);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "PimVII";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.TextBox txtBoxValorTotal;
        private System.Windows.Forms.TextBox txtBoxClienteId;
        private System.Windows.Forms.TextBox txtBoxProdutos;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.Button btnLerDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
    }
}

