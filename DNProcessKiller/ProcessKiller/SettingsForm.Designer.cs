namespace ProcessKiller
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.KeySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ProcessKillerButtonLabel = new System.Windows.Forms.Label();
            this.ProcessKillerKeyTextbox = new System.Windows.Forms.TextBox();
            this.CountDownButtonLabel = new System.Windows.Forms.Label();
            this.DisableProcessKillLabel = new System.Windows.Forms.Label();
            this.DisableProcessKillCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerCountDownTimeSettingsLabel = new System.Windows.Forms.Label();
            this.TimerCountDownTimeTextBox = new System.Windows.Forms.TextBox();
            this.CountDownKeyTextBox = new System.Windows.Forms.TextBox();
            this.TimerCountDownWarnningTimeSettingsLabel = new System.Windows.Forms.Label();
            this.TimerCountDownWarnningTimeTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoggingSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GameDicLabel = new System.Windows.Forms.Label();
            this.ServerSettingLabel = new System.Windows.Forms.Label();
            this.ServerSelectionBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PathSelectionButton = new System.Windows.Forms.Button();
            this.GameDicPathTextBox = new System.Windows.Forms.TextBox();
            this.ipsetinggroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_manual = new System.Windows.Forms.RadioButton();
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.lb_ipsetting = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lb_pot = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.KeySettingsGroupBox.SuspendLayout();
            this.SettingsTable.SuspendLayout();
            this.LoggingSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ipsetinggroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeySettingsGroupBox
            // 
            this.KeySettingsGroupBox.Controls.Add(this.SettingsTable);
            this.KeySettingsGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeySettingsGroupBox.Location = new System.Drawing.Point(9, 9);
            this.KeySettingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.KeySettingsGroupBox.Name = "KeySettingsGroupBox";
            this.KeySettingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.KeySettingsGroupBox.Size = new System.Drawing.Size(248, 172);
            this.KeySettingsGroupBox.TabIndex = 0;
            this.KeySettingsGroupBox.TabStop = false;
            this.KeySettingsGroupBox.Text = "功能与按键设置";
            // 
            // SettingsTable
            // 
            this.SettingsTable.ColumnCount = 2;
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.92308F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.07692F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.SettingsTable.Controls.Add(this.ProcessKillerButtonLabel, 0, 0);
            this.SettingsTable.Controls.Add(this.ProcessKillerKeyTextbox, 1, 0);
            this.SettingsTable.Controls.Add(this.CountDownButtonLabel, 0, 1);
            this.SettingsTable.Controls.Add(this.DisableProcessKillLabel, 0, 2);
            this.SettingsTable.Controls.Add(this.DisableProcessKillCheckBox, 1, 2);
            this.SettingsTable.Controls.Add(this.TimerCountDownTimeSettingsLabel, 0, 3);
            this.SettingsTable.Controls.Add(this.TimerCountDownTimeTextBox, 1, 3);
            this.SettingsTable.Controls.Add(this.CountDownKeyTextBox, 1, 1);
            this.SettingsTable.Controls.Add(this.TimerCountDownWarnningTimeSettingsLabel, 0, 4);
            this.SettingsTable.Controls.Add(this.TimerCountDownWarnningTimeTextBox, 1, 4);
            this.SettingsTable.Location = new System.Drawing.Point(5, 16);
            this.SettingsTable.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsTable.Name = "SettingsTable";
            this.SettingsTable.RowCount = 5;
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SettingsTable.Size = new System.Drawing.Size(191, 143);
            this.SettingsTable.TabIndex = 0;
            // 
            // ProcessKillerButtonLabel
            // 
            this.ProcessKillerButtonLabel.AutoSize = true;
            this.ProcessKillerButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessKillerButtonLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessKillerButtonLabel.Location = new System.Drawing.Point(2, 0);
            this.ProcessKillerButtonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProcessKillerButtonLabel.Name = "ProcessKillerButtonLabel";
            this.ProcessKillerButtonLabel.Size = new System.Drawing.Size(104, 26);
            this.ProcessKillerButtonLabel.TabIndex = 0;
            this.ProcessKillerButtonLabel.Text = "掉线快捷键:      ";
            this.ProcessKillerButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessKillerKeyTextbox
            // 
            this.ProcessKillerKeyTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProcessKillerKeyTextbox.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessKillerKeyTextbox.Location = new System.Drawing.Point(110, 2);
            this.ProcessKillerKeyTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ProcessKillerKeyTextbox.Name = "ProcessKillerKeyTextbox";
            this.ProcessKillerKeyTextbox.ReadOnly = true;
            this.ProcessKillerKeyTextbox.Size = new System.Drawing.Size(67, 21);
            this.ProcessKillerKeyTextbox.TabIndex = 1;
            this.ProcessKillerKeyTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountDownButtonLabel
            // 
            this.CountDownButtonLabel.AutoSize = true;
            this.CountDownButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountDownButtonLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CountDownButtonLabel.Location = new System.Drawing.Point(2, 26);
            this.CountDownButtonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountDownButtonLabel.Name = "CountDownButtonLabel";
            this.CountDownButtonLabel.Size = new System.Drawing.Size(104, 26);
            this.CountDownButtonLabel.TabIndex = 2;
            this.CountDownButtonLabel.Text = "倒计时快捷键:   ";
            this.CountDownButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisableProcessKillLabel
            // 
            this.DisableProcessKillLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisableProcessKillLabel.AutoSize = true;
            this.DisableProcessKillLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisableProcessKillLabel.Location = new System.Drawing.Point(2, 52);
            this.DisableProcessKillLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DisableProcessKillLabel.Name = "DisableProcessKillLabel";
            this.DisableProcessKillLabel.Size = new System.Drawing.Size(104, 30);
            this.DisableProcessKillLabel.TabIndex = 4;
            this.DisableProcessKillLabel.Text = "禁用秒掉功能:   ";
            this.DisableProcessKillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisableProcessKillCheckBox
            // 
            this.DisableProcessKillCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DisableProcessKillCheckBox.AutoSize = true;
            this.DisableProcessKillCheckBox.Location = new System.Drawing.Point(110, 60);
            this.DisableProcessKillCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisableProcessKillCheckBox.Name = "DisableProcessKillCheckBox";
            this.DisableProcessKillCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DisableProcessKillCheckBox.TabIndex = 5;
            this.DisableProcessKillCheckBox.UseVisualStyleBackColor = true;
            this.DisableProcessKillCheckBox.CheckedChanged += new System.EventHandler(this.DisableProcessKillCheckBox_CheckedChanged);
            // 
            // TimerCountDownTimeSettingsLabel
            // 
            this.TimerCountDownTimeSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerCountDownTimeSettingsLabel.AutoSize = true;
            this.TimerCountDownTimeSettingsLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerCountDownTimeSettingsLabel.Location = new System.Drawing.Point(2, 82);
            this.TimerCountDownTimeSettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimerCountDownTimeSettingsLabel.Name = "TimerCountDownTimeSettingsLabel";
            this.TimerCountDownTimeSettingsLabel.Size = new System.Drawing.Size(104, 31);
            this.TimerCountDownTimeSettingsLabel.TabIndex = 6;
            this.TimerCountDownTimeSettingsLabel.Text = "计时器时间设置:";
            this.TimerCountDownTimeSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerCountDownTimeTextBox
            // 
            this.TimerCountDownTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimerCountDownTimeTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerCountDownTimeTextBox.Location = new System.Drawing.Point(110, 86);
            this.TimerCountDownTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimerCountDownTimeTextBox.Name = "TimerCountDownTimeTextBox";
            this.TimerCountDownTimeTextBox.ShortcutsEnabled = false;
            this.TimerCountDownTimeTextBox.Size = new System.Drawing.Size(67, 23);
            this.TimerCountDownTimeTextBox.TabIndex = 7;
            this.TimerCountDownTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountDownKeyTextBox
            // 
            this.CountDownKeyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountDownKeyTextBox.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownKeyTextBox.Location = new System.Drawing.Point(110, 28);
            this.CountDownKeyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CountDownKeyTextBox.Name = "CountDownKeyTextBox";
            this.CountDownKeyTextBox.ReadOnly = true;
            this.CountDownKeyTextBox.Size = new System.Drawing.Size(67, 21);
            this.CountDownKeyTextBox.TabIndex = 3;
            this.CountDownKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerCountDownWarnningTimeSettingsLabel
            // 
            this.TimerCountDownWarnningTimeSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerCountDownWarnningTimeSettingsLabel.AutoSize = true;
            this.TimerCountDownWarnningTimeSettingsLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerCountDownWarnningTimeSettingsLabel.Location = new System.Drawing.Point(2, 113);
            this.TimerCountDownWarnningTimeSettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimerCountDownWarnningTimeSettingsLabel.Name = "TimerCountDownWarnningTimeSettingsLabel";
            this.TimerCountDownWarnningTimeSettingsLabel.Size = new System.Drawing.Size(104, 30);
            this.TimerCountDownWarnningTimeSettingsLabel.TabIndex = 8;
            this.TimerCountDownWarnningTimeSettingsLabel.Text = "倒计时提示时间:";
            this.TimerCountDownWarnningTimeSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerCountDownWarnningTimeTextBox
            // 
            this.TimerCountDownWarnningTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimerCountDownWarnningTimeTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerCountDownWarnningTimeTextBox.Location = new System.Drawing.Point(110, 116);
            this.TimerCountDownWarnningTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimerCountDownWarnningTimeTextBox.Name = "TimerCountDownWarnningTimeTextBox";
            this.TimerCountDownWarnningTimeTextBox.Size = new System.Drawing.Size(67, 23);
            this.TimerCountDownWarnningTimeTextBox.TabIndex = 9;
            this.TimerCountDownWarnningTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(129, 289);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 26);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "应用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(303, 290);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 26);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoggingSettingsGroupBox
            // 
            this.LoggingSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.LoggingSettingsGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoggingSettingsGroupBox.Location = new System.Drawing.Point(10, 188);
            this.LoggingSettingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoggingSettingsGroupBox.Name = "LoggingSettingsGroupBox";
            this.LoggingSettingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.LoggingSettingsGroupBox.Size = new System.Drawing.Size(247, 94);
            this.LoggingSettingsGroupBox.TabIndex = 3;
            this.LoggingSettingsGroupBox.TabStop = false;
            this.LoggingSettingsGroupBox.Text = "登录设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.25103F));
            this.tableLayoutPanel1.Controls.Add(this.GameDicLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerSettingLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServerSelectionBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GameDicLabel
            // 
            this.GameDicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDicLabel.AutoSize = true;
            this.GameDicLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameDicLabel.Location = new System.Drawing.Point(2, 0);
            this.GameDicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameDicLabel.Name = "GameDicLabel";
            this.GameDicLabel.Size = new System.Drawing.Size(59, 35);
            this.GameDicLabel.TabIndex = 0;
            this.GameDicLabel.Text = "游戏路径:";
            this.GameDicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerSettingLabel
            // 
            this.ServerSettingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSettingLabel.AutoSize = true;
            this.ServerSettingLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerSettingLabel.Location = new System.Drawing.Point(2, 35);
            this.ServerSettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerSettingLabel.Name = "ServerSettingLabel";
            this.ServerSettingLabel.Size = new System.Drawing.Size(59, 35);
            this.ServerSettingLabel.TabIndex = 1;
            this.ServerSettingLabel.Text = "大区选择:";
            this.ServerSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerSelectionBox
            // 
            this.ServerSelectionBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerSelectionBox.DropDownWidth = 135;
            this.ServerSelectionBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerSelectionBox.FormattingEnabled = true;
            this.ServerSelectionBox.Location = new System.Drawing.Point(65, 40);
            this.ServerSelectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ServerSelectionBox.Name = "ServerSelectionBox";
            this.ServerSelectionBox.Size = new System.Drawing.Size(163, 25);
            this.ServerSelectionBox.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.92593F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tableLayoutPanel2.Controls.Add(this.PathSelectionButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GameDicPathTextBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(122, 28);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // PathSelectionButton
            // 
            this.PathSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PathSelectionButton.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathSelectionButton.Location = new System.Drawing.Point(94, 3);
            this.PathSelectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.PathSelectionButton.Name = "PathSelectionButton";
            this.PathSelectionButton.Size = new System.Drawing.Size(25, 21);
            this.PathSelectionButton.TabIndex = 4;
            this.PathSelectionButton.Text = "...";
            this.PathSelectionButton.UseVisualStyleBackColor = true;
            this.PathSelectionButton.Click += new System.EventHandler(this.PathSelectionButton_Click);
            // 
            // GameDicPathTextBox
            // 
            this.GameDicPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GameDicPathTextBox.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameDicPathTextBox.Location = new System.Drawing.Point(2, 3);
            this.GameDicPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameDicPathTextBox.Name = "GameDicPathTextBox";
            this.GameDicPathTextBox.ReadOnly = true;
            this.GameDicPathTextBox.Size = new System.Drawing.Size(88, 21);
            this.GameDicPathTextBox.TabIndex = 3;
            // 
            // ipsetinggroupBox
            // 
            this.ipsetinggroupBox.Controls.Add(this.tableLayoutPanel3);
            this.ipsetinggroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipsetinggroupBox.Location = new System.Drawing.Point(274, 10);
            this.ipsetinggroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ipsetinggroupBox.Name = "ipsetinggroupBox";
            this.ipsetinggroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ipsetinggroupBox.Size = new System.Drawing.Size(233, 172);
            this.ipsetinggroupBox.TabIndex = 4;
            this.ipsetinggroupBox.TabStop = false;
            this.ipsetinggroupBox.Text = "服务器设置";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.08772F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.91228F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Controls.Add(this.rb_manual, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.rb_auto, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_ipsetting, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_area, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_ip, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_ip, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_pot, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_port, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_area, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 143);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rb_manual
            // 
            this.rb_manual.AutoSize = true;
            this.rb_manual.Location = new System.Drawing.Point(80, 29);
            this.rb_manual.Name = "rb_manual";
            this.rb_manual.Size = new System.Drawing.Size(50, 20);
            this.rb_manual.TabIndex = 5;
            this.rb_manual.TabStop = true;
            this.rb_manual.Text = "手动";
            this.rb_manual.UseVisualStyleBackColor = true;
            this.rb_manual.CheckedChanged += new System.EventHandler(this.rb_auto_CheckedChanged);
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Location = new System.Drawing.Point(80, 3);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(50, 20);
            this.rb_auto.TabIndex = 5;
            this.rb_auto.TabStop = true;
            this.rb_auto.Text = "自动";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.rb_auto_CheckedChanged);
            // 
            // lb_ipsetting
            // 
            this.lb_ipsetting.AutoSize = true;
            this.lb_ipsetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ipsetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ipsetting.Location = new System.Drawing.Point(2, 0);
            this.lb_ipsetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ipsetting.Name = "lb_ipsetting";
            this.lb_ipsetting.Size = new System.Drawing.Size(73, 26);
            this.lb_ipsetting.TabIndex = 0;
            this.lb_ipsetting.Text = "服务器设置:";
            this.lb_ipsetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_area
            // 
            this.lb_area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_area.Location = new System.Drawing.Point(2, 52);
            this.lb_area.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(73, 30);
            this.lb_area.TabIndex = 4;
            this.lb_area.Text = "大区 :        ";
            this.lb_area.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ip
            // 
            this.lb_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ip.AutoSize = true;
            this.lb_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ip.Location = new System.Drawing.Point(2, 82);
            this.lb_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(73, 31);
            this.lb_ip.TabIndex = 6;
            this.lb_ip.Text = "ip地址 :     ";
            this.lb_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ip
            // 
            this.txt_ip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ip.Location = new System.Drawing.Point(79, 86);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.ShortcutsEnabled = false;
            this.txt_ip.Size = new System.Drawing.Size(109, 23);
            this.txt_ip.TabIndex = 7;
            this.txt_ip.Text = "14.152.76.110";
            // 
            // lb_pot
            // 
            this.lb_pot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pot.AutoSize = true;
            this.lb_pot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pot.Location = new System.Drawing.Point(2, 113);
            this.lb_pot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_pot.Name = "lb_pot";
            this.lb_pot.Size = new System.Drawing.Size(73, 30);
            this.lb_pot.TabIndex = 8;
            this.lb_pot.Text = "端口 :        ";
            this.lb_pot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_port
            // 
            this.txt_port.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_port.Location = new System.Drawing.Point(79, 116);
            this.txt_port.Margin = new System.Windows.Forms.Padding(2);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(67, 23);
            this.txt_port.TabIndex = 9;
            this.txt_port.Text = "14301";
            // 
            // txt_area
            // 
            this.txt_area.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_area.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_area.Location = new System.Drawing.Point(79, 55);
            this.txt_area.Margin = new System.Windows.Forms.Padding(2);
            this.txt_area.Name = "txt_area";
            this.txt_area.ShortcutsEnabled = false;
            this.txt_area.Size = new System.Drawing.Size(109, 23);
            this.txt_area.TabIndex = 10;
            this.txt_area.Text = "华南电信一区";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.ipsetinggroupBox);
            this.Controls.Add(this.LoggingSettingsGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.KeySettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.KeySettingsGroupBox.ResumeLayout(false);
            this.SettingsTable.ResumeLayout(false);
            this.SettingsTable.PerformLayout();
            this.LoggingSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ipsetinggroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KeySettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel SettingsTable;
        private System.Windows.Forms.Label ProcessKillerButtonLabel;
        private System.Windows.Forms.TextBox ProcessKillerKeyTextbox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CountDownButtonLabel;
        private System.Windows.Forms.TextBox CountDownKeyTextBox;
        private System.Windows.Forms.GroupBox LoggingSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GameDicLabel;
        private System.Windows.Forms.Label ServerSettingLabel;
        private System.Windows.Forms.TextBox GameDicPathTextBox;
        private System.Windows.Forms.ComboBox ServerSelectionBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PathSelectionButton;
        private System.Windows.Forms.Label DisableProcessKillLabel;
        private System.Windows.Forms.CheckBox DisableProcessKillCheckBox;
        private System.Windows.Forms.Label TimerCountDownTimeSettingsLabel;
        private System.Windows.Forms.TextBox TimerCountDownTimeTextBox;
        private System.Windows.Forms.Label TimerCountDownWarnningTimeSettingsLabel;
        private System.Windows.Forms.TextBox TimerCountDownWarnningTimeTextBox;
        private System.Windows.Forms.GroupBox ipsetinggroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.Label lb_ipsetting;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lb_pot;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_area;
    }
}