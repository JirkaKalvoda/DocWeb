
namespace DocWeb
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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_minute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_open = new System.Windows.Forms.Button();
            this.tb_exeArgs = new System.Windows.Forms.TextBox();
            this.tb_exePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_day = new System.Windows.Forms.NumericUpDown();
            this.b_delTask = new System.Windows.Forms.Button();
            this.b_updateTask = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_delReg = new System.Windows.Forms.Button();
            this.b_addReg = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_enable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_enable);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nud_minute);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_hour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.b_open);
            this.groupBox1.Controls.Add(this.tb_exeArgs);
            this.groupBox1.Controls.Add(this.tb_exePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_day);
            this.groupBox1.Controls.Add(this.b_delTask);
            this.groupBox1.Controls.Add(this.b_updateTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MkDocs任务计划设置";
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(94, 109);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(288, 21);
            this.dtp_start.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "分";
            // 
            // nud_minute
            // 
            this.nud_minute.Location = new System.Drawing.Point(383, 186);
            this.nud_minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_minute.Name = "nud_minute";
            this.nud_minute.Size = new System.Drawing.Size(66, 21);
            this.nud_minute.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "时";
            // 
            // nud_hour
            // 
            this.nud_hour.Location = new System.Drawing.Point(248, 186);
            this.nud_hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.Size = new System.Drawing.Size(66, 21);
            this.nud_hour.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "天";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "重复周期（1分~31天）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "首次开始时刻";
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(394, 23);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(62, 30);
            this.b_open.TabIndex = 7;
            this.b_open.Text = "浏览";
            this.b_open.UseVisualStyleBackColor = true;
            // 
            // tb_exeArgs
            // 
            this.tb_exeArgs.Location = new System.Drawing.Point(94, 68);
            this.tb_exeArgs.Name = "tb_exeArgs";
            this.tb_exeArgs.Size = new System.Drawing.Size(288, 21);
            this.tb_exeArgs.TabIndex = 6;
            // 
            // tb_exePath
            // 
            this.tb_exePath.Location = new System.Drawing.Point(94, 26);
            this.tb_exePath.Name = "tb_exePath";
            this.tb_exePath.Size = new System.Drawing.Size(288, 21);
            this.tb_exePath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "可执行文件";
            // 
            // nud_day
            // 
            this.nud_day.Location = new System.Drawing.Point(117, 186);
            this.nud_day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_day.Name = "nud_day";
            this.nud_day.Size = new System.Drawing.Size(66, 21);
            this.nud_day.TabIndex = 2;
            this.nud_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_delTask
            // 
            this.b_delTask.Location = new System.Drawing.Point(252, 247);
            this.b_delTask.Name = "b_delTask";
            this.b_delTask.Size = new System.Drawing.Size(95, 41);
            this.b_delTask.TabIndex = 1;
            this.b_delTask.Text = "删除任务";
            this.b_delTask.UseVisualStyleBackColor = true;
            // 
            // b_updateTask
            // 
            this.b_updateTask.Location = new System.Drawing.Point(106, 247);
            this.b_updateTask.Name = "b_updateTask";
            this.b_updateTask.Size = new System.Drawing.Size(95, 41);
            this.b_updateTask.TabIndex = 0;
            this.b_updateTask.Text = "更新任务";
            this.b_updateTask.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_delReg);
            this.groupBox2.Controls.Add(this.b_addReg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本软件设置";
            // 
            // b_delReg
            // 
            this.b_delReg.Location = new System.Drawing.Point(252, 31);
            this.b_delReg.Name = "b_delReg";
            this.b_delReg.Size = new System.Drawing.Size(95, 41);
            this.b_delReg.TabIndex = 2;
            this.b_delReg.Text = "删除注册表";
            this.b_delReg.UseVisualStyleBackColor = true;
            // 
            // b_addReg
            // 
            this.b_addReg.Location = new System.Drawing.Point(106, 31);
            this.b_addReg.Name = "b_addReg";
            this.b_addReg.Size = new System.Drawing.Size(95, 41);
            this.b_addReg.TabIndex = 1;
            this.b_addReg.Text = "添加注册表";
            this.b_addReg.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.65848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.34152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 407);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cb_enable
            // 
            this.cb_enable.AutoSize = true;
            this.cb_enable.Checked = true;
            this.cb_enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_enable.Location = new System.Drawing.Point(15, 220);
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.Size = new System.Drawing.Size(48, 16);
            this.cb_enable.TabIndex = 17;
            this.cb_enable.Text = "启用";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "帮助网站更新程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_delTask;
        private System.Windows.Forms.Button b_updateTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_delReg;
        private System.Windows.Forms.Button b_addReg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.TextBox tb_exeArgs;
        private System.Windows.Forms.TextBox tb_exePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.CheckBox cb_enable;
    }
}

