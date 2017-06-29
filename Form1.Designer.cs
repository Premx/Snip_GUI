namespace Snip_GUI
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
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByHostnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByHTTPCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddKey = new System.Windows.Forms.Button();
            this.buttonDelKey = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(-3, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 13);
            this.labelProgress.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.Location = new System.Drawing.Point(36, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(391, 16);
            this.labelStatus.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "access.log.parsed";
            this.saveFileDialog1.Filter = "Log files|*.log|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "access.log";
            this.openFileDialog1.Filter = "Log files|*.log|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.chartsToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(832, 27);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pieChartToolStripMenuItem});
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.chartsToolStripMenuItem.Text = "Charts";
            // 
            // pieChartToolStripMenuItem
            // 
            this.pieChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browserToolStripMenuItem});
            this.pieChartToolStripMenuItem.Name = "pieChartToolStripMenuItem";
            this.pieChartToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pieChartToolStripMenuItem.Text = "Pie Chart";
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.browserToolStripMenuItem.Text = "Browser";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByHostnameToolStripMenuItem,
            this.sortByDateToolStripMenuItem,
            this.sortByRequestToolStripMenuItem,
            this.sortByHTTPCodeToolStripMenuItem,
            this.sortByBrowserToolStripMenuItem,
            this.sortByAgentToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // sortByHostnameToolStripMenuItem
            // 
            this.sortByHostnameToolStripMenuItem.Name = "sortByHostnameToolStripMenuItem";
            this.sortByHostnameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByHostnameToolStripMenuItem.Text = "Sort by Hostname";
            this.sortByHostnameToolStripMenuItem.Click += new System.EventHandler(this.sortByHostnameToolStripMenuItem_Click);
            // 
            // sortByDateToolStripMenuItem
            // 
            this.sortByDateToolStripMenuItem.Name = "sortByDateToolStripMenuItem";
            this.sortByDateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByDateToolStripMenuItem.Text = "Sort by Date";
            this.sortByDateToolStripMenuItem.Click += new System.EventHandler(this.sortByDateToolStripMenuItem_Click);
            // 
            // sortByRequestToolStripMenuItem
            // 
            this.sortByRequestToolStripMenuItem.Name = "sortByRequestToolStripMenuItem";
            this.sortByRequestToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByRequestToolStripMenuItem.Text = "Sort by Request";
            this.sortByRequestToolStripMenuItem.Click += new System.EventHandler(this.sortByRequestToolStripMenuItem_Click);
            // 
            // sortByHTTPCodeToolStripMenuItem
            // 
            this.sortByHTTPCodeToolStripMenuItem.Name = "sortByHTTPCodeToolStripMenuItem";
            this.sortByHTTPCodeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByHTTPCodeToolStripMenuItem.Text = "Sort by HTTP Code";
            this.sortByHTTPCodeToolStripMenuItem.Click += new System.EventHandler(this.sortByHTTPCodeToolStripMenuItem_Click);
            // 
            // sortByBrowserToolStripMenuItem
            // 
            this.sortByBrowserToolStripMenuItem.Name = "sortByBrowserToolStripMenuItem";
            this.sortByBrowserToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByBrowserToolStripMenuItem.Text = "Sort by Browser";
            this.sortByBrowserToolStripMenuItem.Click += new System.EventHandler(this.sortByBrowserToolStripMenuItem_Click);
            // 
            // sortByAgentToolStripMenuItem
            // 
            this.sortByAgentToolStripMenuItem.Name = "sortByAgentToolStripMenuItem";
            this.sortByAgentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sortByAgentToolStripMenuItem.Text = "Sort by Agent";
            this.sortByAgentToolStripMenuItem.Click += new System.EventHandler(this.sortByAgentToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 312);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(61, 290);
            this.listBox1.TabIndex = 5;
            // 
            // buttonAddKey
            // 
            this.buttonAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddKey.Location = new System.Drawing.Point(-1, 290);
            this.buttonAddKey.MaximumSize = new System.Drawing.Size(33, 23);
            this.buttonAddKey.Name = "buttonAddKey";
            this.buttonAddKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddKey.Size = new System.Drawing.Size(33, 23);
            this.buttonAddKey.TabIndex = 6;
            this.buttonAddKey.Text = "+";
            this.buttonAddKey.UseVisualStyleBackColor = true;
            this.buttonAddKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelKey
            // 
            this.buttonDelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelKey.Location = new System.Drawing.Point(29, 290);
            this.buttonDelKey.MaximumSize = new System.Drawing.Size(33, 23);
            this.buttonDelKey.Name = "buttonDelKey";
            this.buttonDelKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelKey.Size = new System.Drawing.Size(32, 23);
            this.buttonDelKey.TabIndex = 7;
            this.buttonDelKey.Text = "-";
            this.buttonDelKey.UseVisualStyleBackColor = true;
            this.buttonDelKey.Click += new System.EventHandler(this.buttonDelKey_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 312);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.labelProgress);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 16);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.buttonDelKey);
            this.panel3.Controls.Add(this.buttonAddKey);
            this.panel3.Location = new System.Drawing.Point(771, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 313);
            this.panel3.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(770, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "and";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(770, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "or";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 388);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.MinimumSize = new System.Drawing.Size(848, 427);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddKey;
        private System.Windows.Forms.Button buttonDelKey;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem pieChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByHostnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByHTTPCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

