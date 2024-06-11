namespace BD2_2024.Forms
{
    partial class VerPemissoesForm
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
            this.dataGridViewPermissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPermissions
            // 
            this.dataGridViewPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermissions.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPermissions.Name = "dataGridViewPermissions";
            this.dataGridViewPermissions.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewPermissions.TabIndex = 0;
            // 
            // VerPemissoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPermissions);
            this.Name = "VerPemissoesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VerPemissoesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPermissions;
    }
}