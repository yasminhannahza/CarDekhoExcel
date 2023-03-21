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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btnFilterDekho = new System.Windows.Forms.Button();
            this.btnLoadDekho = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelTR = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.DisplayAttr = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Label();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.AttributeList = new System.Windows.Forms.ListBox();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.FilterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(868, 365);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.DoubleClick += new System.EventHandler(this.txtConsole_DoubleClick);
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgress.Location = new System.Drawing.Point(0, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(868, 29);
            this.pbProgress.TabIndex = 6;
            this.pbProgress.Visible = false;
            // 
            // btnFilterDekho
            // 
            this.btnFilterDekho.Enabled = false;
            this.btnFilterDekho.Location = new System.Drawing.Point(491, 20);
            this.btnFilterDekho.Name = "btnFilterDekho";
            this.btnFilterDekho.Size = new System.Drawing.Size(162, 90);
            this.btnFilterDekho.TabIndex = 8;
            this.btnFilterDekho.Text = "Filter Dekho";
            this.btnFilterDekho.UseVisualStyleBackColor = true;
            this.btnFilterDekho.Click += new System.EventHandler(this.btnFilterDekho_Click);
            // 
            // btnLoadDekho
            // 
            this.btnLoadDekho.Location = new System.Drawing.Point(22, 63);
            this.btnLoadDekho.Name = "btnLoadDekho";
            this.btnLoadDekho.Size = new System.Drawing.Size(155, 46);
            this.btnLoadDekho.TabIndex = 7;
            this.btnLoadDekho.Text = "Load Dekho";
            this.btnLoadDekho.UseVisualStyleBackColor = true;
            this.btnLoadDekho.Click += new System.EventHandler(this.btnLoadDekho_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelTR);
            this.splitContainer1.Panel1.Controls.Add(this.FilterBox);
            this.splitContainer1.Panel1.Controls.Add(this.Title);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadDekho);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(868, 591);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 11;
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Location = new System.Drawing.Point(13, 158);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(0, 16);
            this.labelTR.TabIndex = 10;
            // 
            // FilterBox
            // 
            this.FilterBox.Controls.Add(this.cmbFilter);
            this.FilterBox.Controls.Add(this.DisplayAttr);
            this.FilterBox.Controls.Add(this.btnFilterDekho);
            this.FilterBox.Controls.Add(this.Sort);
            this.FilterBox.Controls.Add(this.rbNone);
            this.FilterBox.Controls.Add(this.rbDesc);
            this.FilterBox.Controls.Add(this.AttributeList);
            this.FilterBox.Controls.Add(this.rbAsc);
            this.FilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox.Location = new System.Drawing.Point(183, 56);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(670, 122);
            this.FilterBox.TabIndex = 9;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(187, 41);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(284, 26);
            this.cmbFilter.TabIndex = 11;
            // 
            // DisplayAttr
            // 
            this.DisplayAttr.AutoSize = true;
            this.DisplayAttr.Location = new System.Drawing.Point(187, 20);
            this.DisplayAttr.Name = "DisplayAttr";
            this.DisplayAttr.Size = new System.Drawing.Size(135, 18);
            this.DisplayAttr.TabIndex = 9;
            this.DisplayAttr.Text = "Select value to filter";
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Location = new System.Drawing.Point(187, 75);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(89, 18);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort by Year";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(406, 94);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(65, 22);
            this.rbNone.TabIndex = 3;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(293, 94);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(107, 22);
            this.rbDesc.TabIndex = 2;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // AttributeList
            // 
            this.AttributeList.Enabled = false;
            this.AttributeList.FormattingEnabled = true;
            this.AttributeList.ItemHeight = 18;
            this.AttributeList.Items.AddRange(new object[] {
            "Brand",
            "Model",
            "Year",
            "SellingPrice",
            "DrivenKM",
            "Fuel",
            "SellerType",
            "Transmission",
            "Owner"});
            this.AttributeList.Location = new System.Drawing.Point(6, 25);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(175, 94);
            this.AttributeList.TabIndex = 1;
            this.AttributeList.SelectedIndexChanged += new System.EventHandler(this.AttributeList_SelectedIndexChanged);
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Location = new System.Drawing.Point(190, 94);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(97, 22);
            this.rbAsc.TabIndex = 0;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(317, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(156, 36);
            this.Title.TabIndex = 6;
            this.Title.Text = "Car Dekho";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtConsole);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pbProgress);
            this.splitContainer2.Size = new System.Drawing.Size(868, 398);
            this.splitContainer2.SplitterDistance = 365;
            this.splitContainer2.TabIndex = 0;
            // 
            // frmDekho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDekho";
            this.Text = "Car Dekho?";
            this.Load += new System.EventHandler(this.frmDekho_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button btnFilterDekho;
        private System.Windows.Forms.Button btnLoadDekho;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.ListBox AttributeList;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label DisplayAttr;
        private System.Windows.Forms.Label labelTR;
    }
}

