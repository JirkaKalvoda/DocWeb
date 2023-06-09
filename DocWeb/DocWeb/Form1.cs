﻿// <auto-generated Note="Disable CodeMaid sorting." />
using DocWeb.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DocWeb
{
    public partial class Form1 : Form
    {
        private string fullPath = "\"" + Assembly.GetExecutingAssembly().Location + "\"";

        private TaskSchedulerParam taskSchedulerParam;

        private bool isFindTaskSche;

        private bool IsFindTaskSche
        {
            get
            {
                return isFindTaskSche;
            }
            set
            {
                isFindTaskSche = value;
                b_updateTask.Text = isFindTaskSche ? "更新任务" : "添加任务";
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = TaskSchedulerParam.TimePattern.Replace('T', ' ');
            Init();

            this.Load += Form1_Load;
            b_addReg.Click += B_addReg_Click;
            b_delReg.Click += B_delReg_Click;
            b_open.Click += B_open_Click;
            b_updateTask.Click += B_updateTask_Click;
            b_delTask.Click += B_delTask_Click;
        }


        private void Init()
        {
            if (RegisterRegKey.FindRegKey())
            {
                b_addReg.Enabled = false;
                b_delReg.Enabled = true;
                RegisterRegKey.AddRegKey(fullPath);
            }
            else
            {
                b_addReg.Enabled = true;
                b_delReg.Enabled = false;
            }
            
            if (RegisterTask.FindTaskScheduler(out taskSchedulerParam))
            {
                tb_exePath.Text = taskSchedulerParam.ExePath;
                tb_exeArgs.Text = taskSchedulerParam.ExeArgs;
                dtp_start.Value = DateTime.Parse(taskSchedulerParam.StartTime);
                cb_enable.Checked = taskSchedulerParam.Enable;
                PtIntervalToUi();
                IsFindTaskSche = true;
            }
            else
            {
                taskSchedulerParam = new TaskSchedulerParam();
                dtp_start.Value = DateTime.Parse(taskSchedulerParam.StartTime);
                IsFindTaskSche = false;
            }
        }

        /// <summary>
        /// 把Interval的PDTHM格式字符串转化成UI值
        /// </summary>
        private void PtIntervalToUi()
        {
            if (taskSchedulerParam != null)
            {
                string s = taskSchedulerParam.Interval;
                Match match;
                match = Regex.Match(s, @"(\d+)D");
                if (match.Success)
                {
                    nud_day.Value = int.Parse(match.Groups[1].Value);
                }
                else
                {
                    nud_day.Value = 0;
                }
                match = Regex.Match(s, @"(\d+)H");
                if (match.Success)
                {
                    nud_hour.Value = int.Parse(match.Groups[1].Value);
                }
                else
                {
                    nud_hour.Value = 0;
                }
                match = Regex.Match(s, @"(\d+)M");
                if (match.Success)
                {
                    nud_minute.Value = int.Parse(match.Groups[1].Value);
                }
                else
                {
                    nud_minute.Value = 0;
                }
            }
        }

        /// <summary>
        /// 把UI值转化成Interval的PDTHM格式字符串
        /// </summary>
        private void UiToPtInterval()
        {
            if (taskSchedulerParam != null)
            {
                string s = "P";
                s += Decimal.ToInt32(nud_day.Value) + "DT";
                s += Decimal.ToInt32(nud_hour.Value) + "H";
                s += Decimal.ToInt32(nud_minute.Value) + "M";
                taskSchedulerParam.Interval = s;
            }
        }


        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(tb_exePath.Text) ||
                Decimal.ToInt32(nud_day.Value) == 0 && Decimal.ToInt32(nud_hour.Value) == 0 && Decimal.ToInt32(nud_minute.Value) == 0 ||
                Decimal.ToInt32(nud_day.Value) == 31 && (Decimal.ToInt32(nud_hour.Value) > 0 || Decimal.ToInt32(nud_minute.Value) > 0)
            )
            {
                return false;
            }
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitTray();
        }


        private void B_addReg_Click(object sender, EventArgs e)
        {
            RegisterRegKey.AddRegKey(fullPath);
            b_addReg.Enabled = false;
            b_delReg.Enabled = true;
        }

        private void B_delReg_Click(object sender, EventArgs e)
        {
            RegisterRegKey.DeleteRegKey();
            b_addReg.Enabled = true;
            b_delReg.Enabled = false;
        }


        private void B_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog())
            {
                f.Filter = "*.exe;*.bat;*.cmd|*.exe;*.bat;*.cmd";
                f.InitialDirectory = fullPath;
                f.Multiselect = false;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    tb_exePath.Text = f.FileName;
                }
            }
        }



        private void B_updateTask_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("输入不全或越界", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            taskSchedulerParam.ExePath = tb_exePath.Text;
            taskSchedulerParam.ExeArgs = tb_exeArgs.Text;
            taskSchedulerParam.Enable = cb_enable.Checked;
            taskSchedulerParam.StartTime = dtp_start.Value.ToString(TaskSchedulerParam.TimePattern);
            UiToPtInterval();
            RegisterTask.AddOrUpdateTaskScheduler(taskSchedulerParam);
            IsFindTaskSche = true;
        }


        private void B_delTask_Click(object sender, EventArgs e)
        {
            RegisterTask.DeleteTaskScheduler();
            IsFindTaskSche = false;
        }


        #region 托盘控件

        private NotifyIcon notifyIcon1;

        private System.Windows.Forms.ToolStripMenuItem tlsmi_hide;
        private System.Windows.Forms.ToolStripMenuItem tlsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tlsmi_showMain;

        private void InitTray()
        {
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon();
            System.IntPtr iconHandle = Resources.update_32x32.GetHicon();
            this.notifyIcon1.Icon = Icon.FromHandle(iconHandle);

            this.tlsmi_hide = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "hide",
                Text = "退出时隐藏到托盘",
                Checked = true,
            };
            this.tlsmi_showMain = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "showMain",
                Text = "显示主界面",
            };
            this.tlsmi_exit = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "exit",
                Text = "退出",
            };

            var trayMenuStrip = new ContextMenuStrip();

            trayMenuStrip.Items.AddRange(new ToolStripItem[]
                {
                    this.tlsmi_hide,
                    this.tlsmi_showMain,
                    this.tlsmi_exit
                }
            );

            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "帮助网站更新程序";
            this.notifyIcon1.BalloonTipTitle = "帮助网站更新程序";
            this.notifyIcon1.ContextMenuStrip = trayMenuStrip;
            this.notifyIcon1.Text = "帮助网站更新程序";
            this.notifyIcon1.Visible = true;
            
            trayMenuStrip.ItemClicked += TrayMenuStrip_ItemClicked;
            this.notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            Hook(true);
        }


        private void TrayMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = e.ClickedItem as ToolStripMenuItem;
            switch (item.Name)
            {
                case "exit":
                    Application.Exit();
                    break;
                case "showMain":
                    NotifyIcon1_MouseDoubleClick(null, null);
                    break;
                case "hide":
                    item.Checked = !item.Checked;
                    break;
                case "tlsmi_other":
                    MessageBox.Show("事件点击来自 托盘图标的菜单", "其他功能");
                    break;
                case "tlsmi_banMsg":
                    if (!item.Checked)
                    {
                        MessageBox.Show("事件点击来自 托盘图标的菜单", "禁用通知");
                        item.Text = "启用通知";
                    }
                    else
                    {
                        MessageBox.Show("事件点击来自 托盘图标的菜单", "启用通知");
                        item.Text = "禁用通知";
                    }
                    item.Checked = !item.Checked;
                    break;
                default:
                    break;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowFromNotify();
            }
        }

        private void HideToNotify()
        {
            Hook(false);
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            Hook(true);
        }

        private void ShowFromNotify()
        {
            Hook(false);
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            Hook(true);
        }

        /// <summary>
        /// 避免属性修改时循环触发
        /// </summary>
        /// <param name="isBind"></param>
        private void Hook(bool isBind)
        {
            this.SizeChanged -= Form1_SizeChanged;
            this.FormClosing -= Form1_FormClosing;
            if (isBind)
            {
                this.SizeChanged += Form1_SizeChanged;
                this.FormClosing += Form1_FormClosing;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideToNotify();
            }
        }

        private bool _askExit = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_askExit)
                return;
            if (this.tlsmi_hide.Checked)
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    e.Cancel = true;
                    HideToNotify();
                }
            }
        }

        #endregion
    }
}
