
namespace BD2_2024.Forms
{
    partial class MainForm
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
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.btnVerPermissoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.Location = new System.Drawing.Point(12, 75);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(153, 57);
            this.BtnFuncionario.TabIndex = 1;
            this.BtnFuncionario.Text = "Funcionários";
            this.BtnFuncionario.UseVisualStyleBackColor = true;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(12, 12);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(153, 57);
            this.BtnNovaVenda.TabIndex = 0;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // btnVerPermissoes
            // 
            this.btnVerPermissoes.Location = new System.Drawing.Point(12, 138);
            this.btnVerPermissoes.Name = "btnVerPermissoes";
            this.btnVerPermissoes.Size = new System.Drawing.Size(153, 57);
            this.btnVerPermissoes.TabIndex = 2;
            this.btnVerPermissoes.Text = "Visualizar Permissões";
            this.btnVerPermissoes.UseVisualStyleBackColor = true;
            this.btnVerPermissoes.UseWaitCursor = true;
            this.btnVerPermissoes.Click += new System.EventHandler(this.btnVerPermissoes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.btnVerPermissoes);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.BtnFuncionario);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Button btnVerPermissoes;
    }
}