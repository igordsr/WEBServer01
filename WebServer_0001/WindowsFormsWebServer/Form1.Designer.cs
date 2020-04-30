namespace WindowsFormsWebServer
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
            this.lblCep = new System.Windows.Forms.Label();
            this.txtBox_cep = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtBoxResponse = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBoby = new System.Windows.Forms.RichTextBox();
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(12, 12);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(29, 13);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "Cod:";
            // 
            // txtBox_cep
            // 
            this.txtBox_cep.Location = new System.Drawing.Point(54, 9);
            this.txtBox_cep.Name = "txtBox_cep";
            this.txtBox_cep.Size = new System.Drawing.Size(100, 20);
            this.txtBox_cep.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(161, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtBoxResponse
            // 
            this.txtBoxResponse.Location = new System.Drawing.Point(15, 40);
            this.txtBoxResponse.Name = "txtBoxResponse";
            this.txtBoxResponse.Size = new System.Drawing.Size(221, 259);
            this.txtBoxResponse.TabIndex = 3;
            this.txtBoxResponse.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Id:";
            // 
            // txtBoxBoby
            // 
            this.txtBoxBoby.Location = new System.Drawing.Point(245, 105);
            this.txtBoxBoby.Name = "txtBoxBoby";
            this.txtBoxBoby.Size = new System.Drawing.Size(290, 194);
            this.txtBoxBoby.TabIndex = 8;
            this.txtBoxBoby.Text = "";
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.Location = new System.Drawing.Point(292, 36);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserId.TabIndex = 10;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(292, 64);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTitle.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(460, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 333);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxUserId);
            this.Controls.Add(this.txtBoxBoby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxResponse);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtBox_cep);
            this.Controls.Add(this.lblCep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtBox_cep;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RichTextBox txtBoxResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtBoxBoby;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Button btnSend;
    }
}

