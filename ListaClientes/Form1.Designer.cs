namespace ListaClientes
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtEndereço = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtData = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "RG :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(112, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "CPF : ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(160, 71);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(333, 26);
			this.txtNome.TabIndex = 3;
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(160, 107);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(333, 26);
			this.txtRG.TabIndex = 4;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(160, 150);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(333, 26);
			this.txtCPF.TabIndex = 5;
			this.txtCPF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(103, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Data de Nascimento :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(110, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Telefone :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(103, 290);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Endereço :";
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(187, 236);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(306, 26);
			this.txtTelefone.TabIndex = 10;
			// 
			// txtEndereço
			// 
			this.txtEndereço.Location = new System.Drawing.Point(187, 284);
			this.txtEndereço.Name = "txtEndereço";
			this.txtEndereço.Size = new System.Drawing.Size(306, 26);
			this.txtEndereço.TabIndex = 11;
			this.txtEndereço.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 329);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 32);
			this.button1.TabIndex = 12;
			this.button1.Text = "Exibir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(361, 329);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 32);
			this.button2.TabIndex = 13;
			this.button2.Text = "Adicionar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(370, 193);
			this.txtData.Mask = "00/00/0000";
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(123, 26);
			this.txtData.TabIndex = 14;
			this.txtData.ValidatingType = typeof(System.DateTime);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 379);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtEndereço);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtEndereço;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MaskedTextBox txtData;
	}
}

