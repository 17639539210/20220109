namespace _20220109
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.显示列表 = new System.Windows.Forms.DataGridView();
            this.菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox支线任务3 = new System.Windows.Forms.CheckBox();
            this.checkBox支线任务1 = new System.Windows.Forms.CheckBox();
            this.checkBox支线任务2 = new System.Windows.Forms.CheckBox();
            this.checkBox_主线任务 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.显示列表)).BeginInit();
            this.菜单.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.显示列表);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1387, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示区域";
            // 
            // 显示列表
            // 
            this.显示列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.显示列表.ContextMenuStrip = this.菜单;
            this.显示列表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.显示列表.Location = new System.Drawing.Point(4, 22);
            this.显示列表.Margin = new System.Windows.Forms.Padding(4);
            this.显示列表.Name = "显示列表";
            this.显示列表.RowHeadersWidth = 51;
            this.显示列表.RowTemplate.Height = 23;
            this.显示列表.Size = new System.Drawing.Size(1379, 402);
            this.显示列表.TabIndex = 0;
            this.显示列表.DoubleClick += new System.EventHandler(this.显示列表_DoubleClick);
            // 
            // 菜单
            // 
            this.菜单.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.恢复ToolStripMenuItem});
            this.菜单.Name = "菜单";
            this.菜单.Size = new System.Drawing.Size(211, 128);
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.启动ToolStripMenuItem.Text = "启动";
            this.启动ToolStripMenuItem.Click += new System.EventHandler(this.启动ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click_1);
            // 
            // 恢复ToolStripMenuItem
            // 
            this.恢复ToolStripMenuItem.Name = "恢复ToolStripMenuItem";
            this.恢复ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.恢复ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.恢复ToolStripMenuItem.Text = "恢复";
            this.恢复ToolStripMenuItem.Click += new System.EventHandler(this.恢复ToolStripMenuItem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1387, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置区域";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1379, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1371, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 80);
            this.button3.TabIndex = 0;
            this.button3.Text = "反选";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 80);
            this.button2.TabIndex = 0;
            this.button2.Text = "全部取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "全选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox支线任务3);
            this.tabPage2.Controls.Add(this.checkBox支线任务1);
            this.tabPage2.Controls.Add(this.checkBox支线任务2);
            this.tabPage2.Controls.Add(this.checkBox_主线任务);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1371, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox支线任务3
            // 
            this.checkBox支线任务3.AutoSize = true;
            this.checkBox支线任务3.Location = new System.Drawing.Point(14, 95);
            this.checkBox支线任务3.Name = "checkBox支线任务3";
            this.checkBox支线任务3.Size = new System.Drawing.Size(97, 19);
            this.checkBox支线任务3.TabIndex = 0;
            this.checkBox支线任务3.Text = "支线任务3";
            this.checkBox支线任务3.UseVisualStyleBackColor = true;
            // 
            // checkBox支线任务1
            // 
            this.checkBox支线任务1.AutoSize = true;
            this.checkBox支线任务1.Location = new System.Drawing.Point(14, 45);
            this.checkBox支线任务1.Name = "checkBox支线任务1";
            this.checkBox支线任务1.Size = new System.Drawing.Size(97, 19);
            this.checkBox支线任务1.TabIndex = 0;
            this.checkBox支线任务1.Text = "支线任务1";
            this.checkBox支线任务1.UseVisualStyleBackColor = true;
            // 
            // checkBox支线任务2
            // 
            this.checkBox支线任务2.AutoSize = true;
            this.checkBox支线任务2.Location = new System.Drawing.Point(14, 70);
            this.checkBox支线任务2.Name = "checkBox支线任务2";
            this.checkBox支线任务2.Size = new System.Drawing.Size(97, 19);
            this.checkBox支线任务2.TabIndex = 0;
            this.checkBox支线任务2.Text = "支线任务2";
            this.checkBox支线任务2.UseVisualStyleBackColor = true;
            // 
            // checkBox_主线任务
            // 
            this.checkBox_主线任务.AutoSize = true;
            this.checkBox_主线任务.Location = new System.Drawing.Point(14, 22);
            this.checkBox_主线任务.Name = "checkBox_主线任务";
            this.checkBox_主线任务.Size = new System.Drawing.Size(89, 19);
            this.checkBox_主线任务.TabIndex = 0;
            this.checkBox_主线任务.Text = "主线任务";
            this.checkBox_主线任务.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1371, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1405, 797);
            this.MinimumSize = new System.Drawing.Size(1405, 797);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.显示列表)).EndInit();
            this.菜单.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip 菜单;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复ToolStripMenuItem;
        private System.Windows.Forms.DataGridView 显示列表;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox支线任务3;
        private System.Windows.Forms.CheckBox checkBox支线任务1;
        private System.Windows.Forms.CheckBox checkBox支线任务2;
        private System.Windows.Forms.CheckBox checkBox_主线任务;
    }
}

