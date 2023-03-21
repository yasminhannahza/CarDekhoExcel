namespace CarDekhoExcel
{
    partial class frmDekho
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
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnLoadDekho = new System.Windows.Forms.Button();
            this.btnFilterDekho = new System.Windows.Forms.Button();
            this.txtFilterDekho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 517);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1687, 33);
            this.pbProgress.TabIndex = 6;
            this.pbProgress.Visible = false;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 225);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(1687, 271);
            this.txtConsole.TabIndex = 5;
            // 
            // btnLoadDekho
            // 
            this.btnLoadDekho.Location = new System.Drawing.Point(631, 12);
            this.btnLoadDekho.Name = "btnLoadDekho";
            this.btnLoadDekho.Size = new System.Drawing.Size(155, 46);
            this.btnLoadDekho.TabIndex = 7;
            this.btnLoadDekho.Text = "Load Dekho";
            this.btnLoadDekho.UseVisualStyleBackColor = true;
            this.btnLoadDekho.Click += new System.EventHandler(this.btnLoadDekho_Click);
            // 
            // btnFilterDekho
            // 
            this.btnFilterDekho.Location = new System.Drawing.Point(631, 88);
            this.btnFilterDekho.Name = "btnFilterDekho";
            this.btnFilterDekho.Size = new System.Drawing.Size(155, 46);
            this.btnFilterDekho.TabIndex = 8;
            this.btnFilterDekho.Text = "Filter Dekho";
            this.btnFilterDekho.UseVisualStyleBackColor = true;
            this.btnFilterDekho.Click += new System.EventHandler(this.btnFilterDekho_Click);
            // 
            // txtFilterDekho
            // 
            this.txtFilterDekho.Location = new System.Drawing.Point(314, 112);
            this.txtFilterDekho.Name = "txtFilterDekho";
            this.txtFilterDekho.Size = new System.Drawing.Size(301, 22);
            this.txtFilterDekho.TabIndex = 9;
            // 
            // frmDekho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 564);
            this.Controls.Add(this.txtFilterDekho);
            this.Controls.Add(this.btnFilterDekho);
            this.Controls.Add(this.btnLoadDekho);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.txtConsole);
            this.Name = "frmDekho";
            this.Text = "Car Dekho?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnLoadDekho;
        private System.Windows.Forms.Button btnFilterDekho;
        private System.Windows.Forms.TextBox txtFilterDekho;
    }
}

