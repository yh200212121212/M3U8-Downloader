namespace M3U8_Downloader
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_ChangePath = new System.Windows.Forms.Button();
            this.button_OpenPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DownloadPath = new System.Windows.Forms.TextBox();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_Stop = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.嗅探工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换肤ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.获取FFmpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取新版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视频转码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视频合并ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houzhui = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.选择后缀名 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Download
            // 
            this.button_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Download.FlatAppearance.BorderSize = 0;
            this.button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Download.ForeColor = System.Drawing.Color.Black;
            this.button_Download.Location = new System.Drawing.Point(69, 338);
            this.button_Download.Margin = new System.Windows.Forms.Padding(4);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(159, 70);
            this.button_Download.TabIndex = 11;
            this.button_Download.Text = "下载";
            this.button_Download.UseVisualStyleBackColor = false;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Quit.FlatAppearance.BorderSize = 0;
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Quit.ForeColor = System.Drawing.Color.Black;
            this.button_Quit.Location = new System.Drawing.Point(276, 338);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(159, 70);
            this.button_Quit.TabIndex = 12;
            this.button_Quit.Text = "退出";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入m3u8地址(支持拖入.m3u8文件)";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.AllowDrop = true;
            this.textBox_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Adress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Adress.ForeColor = System.Drawing.Color.Black;
            this.textBox_Adress.Location = new System.Drawing.Point(71, 68);
            this.textBox_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Adress.Multiline = true;
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(363, 47);
            this.textBox_Adress.TabIndex = 1;
            this.textBox_Adress.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Adress_DragDrop);
            this.textBox_Adress.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Adress_DragEnter);
            this.textBox_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Adress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入文件名";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name.ForeColor = System.Drawing.Color.Black;
            this.textBox_Name.Location = new System.Drawing.Point(71, 144);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(363, 27);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.Text = "Video";
            // 
            // button_ChangePath
            // 
            this.button_ChangePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_ChangePath.FlatAppearance.BorderSize = 0;
            this.button_ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ChangePath.ForeColor = System.Drawing.Color.Black;
            this.button_ChangePath.Location = new System.Drawing.Point(71, 286);
            this.button_ChangePath.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChangePath.Name = "button_ChangePath";
            this.button_ChangePath.Size = new System.Drawing.Size(159, 31);
            this.button_ChangePath.TabIndex = 9;
            this.button_ChangePath.Text = "更改下载路径";
            this.button_ChangePath.UseVisualStyleBackColor = false;
            this.button_ChangePath.Click += new System.EventHandler(this.button_ChangePath_Click);
            // 
            // button_OpenPath
            // 
            this.button_OpenPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_OpenPath.FlatAppearance.BorderSize = 0;
            this.button_OpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenPath.ForeColor = System.Drawing.Color.Black;
            this.button_OpenPath.Location = new System.Drawing.Point(276, 286);
            this.button_OpenPath.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenPath.Name = "button_OpenPath";
            this.button_OpenPath.Size = new System.Drawing.Size(159, 31);
            this.button_OpenPath.TabIndex = 10;
            this.button_OpenPath.Text = "打开下载路径";
            this.button_OpenPath.UseVisualStyleBackColor = false;
            this.button_OpenPath.Click += new System.EventHandler(this.button_OpenPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "当前下载路径";
            // 
            // textBox_DownloadPath
            // 
            this.textBox_DownloadPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_DownloadPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DownloadPath.ForeColor = System.Drawing.Color.Black;
            this.textBox_DownloadPath.Location = new System.Drawing.Point(71, 201);
            this.textBox_DownloadPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DownloadPath.Multiline = true;
            this.textBox_DownloadPath.Name = "textBox_DownloadPath";
            this.textBox_DownloadPath.ReadOnly = true;
            this.textBox_DownloadPath.Size = new System.Drawing.Size(363, 54);
            this.textBox_DownloadPath.TabIndex = 8;
            // 
            // textBox_Info
            // 
            this.textBox_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Info.ForeColor = System.Drawing.Color.Black;
            this.textBox_Info.Location = new System.Drawing.Point(475, 68);
            this.textBox_Info.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.ReadOnly = true;
            this.textBox_Info.Size = new System.Drawing.Size(849, 318);
            this.textBox_Info.TabIndex = 13;
            this.textBox_Info.Text = "请在左侧进行操作...";
            this.textBox_Info.TextChanged += new System.EventHandler(this.textBox_Info_TextChanged);
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(687, 362);
            this.Command.Margin = new System.Windows.Forms.Padding(4);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(636, 265);
            this.Command.TabIndex = 11;
            this.Command.TabStop = false;
            this.Command.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(471, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "信息显示窗口：";
            // 
            // linkLabel_Stop
            // 
            this.linkLabel_Stop.AutoSize = true;
            this.linkLabel_Stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Stop.ForeColor = System.Drawing.Color.Black;
            this.linkLabel_Stop.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Stop.Location = new System.Drawing.Point(589, 42);
            this.linkLabel_Stop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_Stop.Name = "linkLabel_Stop";
            this.linkLabel_Stop.Size = new System.Drawing.Size(99, 20);
            this.linkLabel_Stop.TabIndex = 14;
            this.linkLabel_Stop.TabStop = true;
            this.linkLabel_Stop.Text = "点此终止下载";
            this.linkLabel_Stop.Visible = false;
            this.linkLabel_Stop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Stop_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1155, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "总时长";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(975, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "已下载";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(707, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "视频信息";
            this.label7.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.嗅探工具ToolStripMenuItem,
            this.生成日志ToolStripMenuItem,
            this.换肤ToolStripMenuItem1,
            this.获取FFmpegToolStripMenuItem,
            this.获取新版本ToolStripMenuItem,
            this.视频转码ToolStripMenuItem,
            this.视频合并ToolStripMenuItem,
            this.文件ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 嗅探工具ToolStripMenuItem
            // 
            this.嗅探工具ToolStripMenuItem.Name = "嗅探工具ToolStripMenuItem";
            this.嗅探工具ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.嗅探工具ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.嗅探工具ToolStripMenuItem.Text = "嗅探工具&[M]";
            this.嗅探工具ToolStripMenuItem.Click += new System.EventHandler(this.嗅探工具ToolStripMenuItem_Click);
            // 
            // 生成日志ToolStripMenuItem
            // 
            this.生成日志ToolStripMenuItem.Enabled = false;
            this.生成日志ToolStripMenuItem.Name = "生成日志ToolStripMenuItem";
            this.生成日志ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.生成日志ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.生成日志ToolStripMenuItem.Text = "生成日志&[L]";
            this.生成日志ToolStripMenuItem.Click += new System.EventHandler(this.生成日志ToolStripMenuItem_Click);
            // 
            // 换肤ToolStripMenuItem1
            // 
            this.换肤ToolStripMenuItem1.Name = "换肤ToolStripMenuItem1";
            this.换肤ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.换肤ToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.换肤ToolStripMenuItem1.Text = "换肤&[S]";
            this.换肤ToolStripMenuItem1.Click += new System.EventHandler(this.换肤ToolStripMenuItem1_Click);
            // 
            // 获取FFmpegToolStripMenuItem
            // 
            this.获取FFmpegToolStripMenuItem.Name = "获取FFmpegToolStripMenuItem";
            this.获取FFmpegToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.获取FFmpegToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.获取FFmpegToolStripMenuItem.Text = "获取FFmpeg&[P]";
            this.获取FFmpegToolStripMenuItem.Click += new System.EventHandler(this.获取FFmpegToolStripMenuItem_Click);
            // 
            // 获取新版本ToolStripMenuItem
            // 
            this.获取新版本ToolStripMenuItem.Name = "获取新版本ToolStripMenuItem";
            this.获取新版本ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.获取新版本ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.获取新版本ToolStripMenuItem.Text = "获取新版本&[N]";
            this.获取新版本ToolStripMenuItem.Click += new System.EventHandler(this.获取新版本ToolStripMenuItem_Click_1);
            // 
            // 视频转码ToolStripMenuItem
            // 
            this.视频转码ToolStripMenuItem.Name = "视频转码ToolStripMenuItem";
            this.视频转码ToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.视频转码ToolStripMenuItem.Text = "封装转换&[Z]";
            this.视频转码ToolStripMenuItem.Click += new System.EventHandler(this.视频转码ToolStripMenuItem_Click);
            // 
            // 视频合并ToolStripMenuItem
            // 
            this.视频合并ToolStripMenuItem.Name = "视频合并ToolStripMenuItem";
            this.视频合并ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.视频合并ToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.视频合并ToolStripMenuItem.Text = "视频合并&[J]";
            this.视频合并ToolStripMenuItem.Click += new System.EventHandler(this.视频合并ToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件ToolStripMenuItem.Text = "文件&[F]";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // houzhui
            // 
            this.houzhui.AutoSize = true;
            this.houzhui.Location = new System.Drawing.Point(591, 411);
            this.houzhui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houzhui.Name = "houzhui";
            this.houzhui.Size = new System.Drawing.Size(23, 15);
            this.houzhui.TabIndex = 19;
            this.houzhui.Text = ".*";
            this.houzhui.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(475, 389);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.MarqueeAnimationSpeed = 50;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(849, 19);
            this.ProgressBar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "后缀名：";
            // 
            // 选择后缀名
            // 
            this.选择后缀名.FormattingEnabled = true;
            this.选择后缀名.Items.AddRange(new object[] {
            "MP4",
            "MKV",
            "TS",
            "FLV"});
            this.选择后缀名.Location = new System.Drawing.Point(261, 119);
            this.选择后缀名.Name = "选择后缀名";
            this.选择后缀名.Size = new System.Drawing.Size(121, 23);
            this.选择后缀名.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1348, 426);
            this.Controls.Add(this.选择后缀名);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.houzhui);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel_Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DownloadPath);
            this.Controls.Add(this.button_OpenPath);
            this.Controls.Add(this.button_ChangePath);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M3U8 Downloader  by：nilaoda/yh20021212 [1.0.1]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_ChangePath;
        private System.Windows.Forms.Button button_OpenPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DownloadPath;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_Stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label houzhui;
        private System.Windows.Forms.ToolStripMenuItem 嗅探工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视频转码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换肤ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 获取FFmpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取新版本ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem 视频合并ToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ComboBox 选择后缀名;
    }
}

