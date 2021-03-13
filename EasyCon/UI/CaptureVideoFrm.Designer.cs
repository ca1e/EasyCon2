namespace EasyCon.UI
{
    partial class CaptureVideoFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureVideoFrm));
            this.reasultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Snapshot = new System.Windows.Forms.PictureBox();
            this.captureBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rangeBtn = new System.Windows.Forms.Button();
            this.searchTextBtn = new System.Windows.Forms.Button();
            this.targetBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgTypeCbx = new System.Windows.Forms.ComboBox();
            this.targetImg = new System.Windows.Forms.PictureBox();
            this.imgLabelNametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lowestMatch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.targRangX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.targRangY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.targRangW = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.targRangH = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.searchRangX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.searchRangY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.searchRangW = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.searchRangH = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchMethodComBox = new System.Windows.Forms.ComboBox();
            this.imgLableList = new System.Windows.Forms.ListBox();
            this.SaveTagBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.DynTestBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchResultImg = new System.Windows.Forms.PictureBox();
            this.CaptureVideoHelp = new System.Windows.Forms.TextBox();
            this.openCapBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.VideoSourcePlayerMonitor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monitorVisChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Snapshot)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSourcePlayerMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // reasultListBox
            // 
            this.reasultListBox.FormattingEnabled = true;
            this.reasultListBox.ItemHeight = 12;
            this.reasultListBox.Location = new System.Drawing.Point(520, 485);
            this.reasultListBox.Name = "reasultListBox";
            this.reasultListBox.Size = new System.Drawing.Size(120, 40);
            this.reasultListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "搜图标签-双击加载";
            // 
            // Snapshot
            // 
            this.Snapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Snapshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Snapshot.Location = new System.Drawing.Point(1, 1);
            this.Snapshot.Margin = new System.Windows.Forms.Padding(0);
            this.Snapshot.Name = "Snapshot";
            this.Snapshot.Size = new System.Drawing.Size(640, 360);
            this.Snapshot.TabIndex = 4;
            this.Snapshot.TabStop = false;
            this.Snapshot.Paint += new System.Windows.Forms.PaintEventHandler(this.Snapshot_Paint);
            this.Snapshot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseDown);
            this.Snapshot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseMove);
            this.Snapshot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseUp);
            this.Snapshot.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Snapshot_MouseWheel);
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(7, 387);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(66, 23);
            this.captureBtn.TabIndex = 5;
            this.captureBtn.Text = "截图";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "双击切换采集/编辑模式，滚轮缩放，ctrl+滚轮水平缩放，shift+滚轮垂直缩放";
            // 
            // rangeBtn
            // 
            this.rangeBtn.Location = new System.Drawing.Point(79, 387);
            this.rangeBtn.Name = "rangeBtn";
            this.rangeBtn.Size = new System.Drawing.Size(86, 23);
            this.rangeBtn.TabIndex = 8;
            this.rangeBtn.Text = "开始圈选(红)";
            this.rangeBtn.UseVisualStyleBackColor = true;
            this.rangeBtn.Click += new System.EventHandler(this.rangeBtn_Click);
            // 
            // searchTextBtn
            // 
            this.searchTextBtn.Location = new System.Drawing.Point(263, 387);
            this.searchTextBtn.Name = "searchTextBtn";
            this.searchTextBtn.Size = new System.Drawing.Size(74, 23);
            this.searchTextBtn.TabIndex = 9;
            this.searchTextBtn.Text = "搜索测试";
            this.searchTextBtn.UseVisualStyleBackColor = true;
            this.searchTextBtn.Click += new System.EventHandler(this.searchTextBtn_Click);
            // 
            // targetBtn
            // 
            this.targetBtn.Location = new System.Drawing.Point(171, 387);
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(86, 23);
            this.targetBtn.TabIndex = 10;
            this.targetBtn.Text = "开始圈选(绿)";
            this.targetBtn.UseVisualStyleBackColor = true;
            this.targetBtn.Click += new System.EventHandler(this.targetBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imgTypeCbx);
            this.groupBox1.Controls.Add(this.targetImg);
            this.groupBox1.Controls.Add(this.imgLabelNametxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lowestMatch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.targRangX);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.targRangY);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.targRangW);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.targRangH);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.searchRangX);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.searchRangY);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.searchRangW);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.searchRangH);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchMethodComBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 176);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "图类型:";
            // 
            // imgTypeCbx
            // 
            this.imgTypeCbx.FormattingEnabled = true;
            this.imgTypeCbx.Location = new System.Drawing.Point(78, 50);
            this.imgTypeCbx.Name = "imgTypeCbx";
            this.imgTypeCbx.Size = new System.Drawing.Size(104, 20);
            this.imgTypeCbx.TabIndex = 35;
            this.imgTypeCbx.Text = "选择图类型";
            // 
            // targetImg
            // 
            this.targetImg.Location = new System.Drawing.Point(439, 120);
            this.targetImg.Name = "targetImg";
            this.targetImg.Size = new System.Drawing.Size(63, 48);
            this.targetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetImg.TabIndex = 34;
            this.targetImg.TabStop = false;
            // 
            // imgLabelNametxt
            // 
            this.imgLabelNametxt.Location = new System.Drawing.Point(78, 16);
            this.imgLabelNametxt.Name = "imgLabelNametxt";
            this.imgLabelNametxt.Size = new System.Drawing.Size(99, 21);
            this.imgLabelNametxt.TabIndex = 33;
            this.imgLabelNametxt.Text = "5号路蛋屋主人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "搜图标签名:";
            // 
            // lowestMatch
            // 
            this.lowestMatch.Location = new System.Drawing.Point(442, 18);
            this.lowestMatch.Name = "lowestMatch";
            this.lowestMatch.Size = new System.Drawing.Size(62, 21);
            this.lowestMatch.TabIndex = 31;
            this.lowestMatch.Text = "90.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "最低更新匹配度:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(317, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 29;
            this.label22.Text = "搜索范围";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(100, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 28;
            this.label21.Text = "目标位置";
            // 
            // targRangX
            // 
            this.targRangX.Location = new System.Drawing.Point(41, 121);
            this.targRangX.Name = "targRangX";
            this.targRangX.Size = new System.Drawing.Size(69, 21);
            this.targRangX.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "X:";
            // 
            // targRangY
            // 
            this.targRangY.Location = new System.Drawing.Point(144, 121);
            this.targRangY.Name = "targRangY";
            this.targRangY.Size = new System.Drawing.Size(69, 21);
            this.targRangY.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(119, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "Y:";
            // 
            // targRangW
            // 
            this.targRangW.Location = new System.Drawing.Point(41, 148);
            this.targRangW.Name = "targRangW";
            this.targRangW.Size = new System.Drawing.Size(69, 21);
            this.targRangW.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "宽:";
            // 
            // targRangH
            // 
            this.targRangH.Location = new System.Drawing.Point(144, 148);
            this.targRangH.Name = "targRangH";
            this.targRangH.Size = new System.Drawing.Size(69, 21);
            this.targRangH.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(116, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 20;
            this.label20.Text = "高:";
            // 
            // searchRangX
            // 
            this.searchRangX.Location = new System.Drawing.Point(256, 121);
            this.searchRangX.Name = "searchRangX";
            this.searchRangX.Size = new System.Drawing.Size(69, 21);
            this.searchRangX.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "X:";
            // 
            // searchRangY
            // 
            this.searchRangY.Location = new System.Drawing.Point(359, 121);
            this.searchRangY.Name = "searchRangY";
            this.searchRangY.Size = new System.Drawing.Size(69, 21);
            this.searchRangY.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "Y:";
            // 
            // searchRangW
            // 
            this.searchRangW.Location = new System.Drawing.Point(256, 148);
            this.searchRangW.Name = "searchRangW";
            this.searchRangW.Size = new System.Drawing.Size(69, 21);
            this.searchRangW.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "宽:";
            // 
            // searchRangH
            // 
            this.searchRangH.Location = new System.Drawing.Point(359, 148);
            this.searchRangH.Name = "searchRangH";
            this.searchRangH.Size = new System.Drawing.Size(69, 21);
            this.searchRangH.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(331, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "高:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "搜索方法:";
            // 
            // searchMethodComBox
            // 
            this.searchMethodComBox.FormattingEnabled = true;
            this.searchMethodComBox.Location = new System.Drawing.Point(241, 17);
            this.searchMethodComBox.Name = "searchMethodComBox";
            this.searchMethodComBox.Size = new System.Drawing.Size(104, 20);
            this.searchMethodComBox.TabIndex = 0;
            this.searchMethodComBox.Text = "选择搜索方法";
            // 
            // imgLableList
            // 
            this.imgLableList.FormattingEnabled = true;
            this.imgLableList.ItemHeight = 12;
            this.imgLableList.Location = new System.Drawing.Point(651, 324);
            this.imgLableList.Name = "imgLableList";
            this.imgLableList.Size = new System.Drawing.Size(143, 280);
            this.imgLableList.TabIndex = 19;
            this.imgLableList.DoubleClick += new System.EventHandler(this.imgLableList_DoubleClick);
            // 
            // SaveTagBtn
            // 
            this.SaveTagBtn.Location = new System.Drawing.Point(440, 387);
            this.SaveTagBtn.Name = "SaveTagBtn";
            this.SaveTagBtn.Size = new System.Drawing.Size(68, 23);
            this.SaveTagBtn.TabIndex = 20;
            this.SaveTagBtn.Text = "保存标签";
            this.SaveTagBtn.UseVisualStyleBackColor = true;
            this.SaveTagBtn.Click += new System.EventHandler(this.SaveTagBtn_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(520, 462);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 12);
            this.label23.TabIndex = 21;
            this.label23.Text = "匹配度：耗时：";
            // 
            // DynTestBtn
            // 
            this.DynTestBtn.Location = new System.Drawing.Point(343, 387);
            this.DynTestBtn.Name = "DynTestBtn";
            this.DynTestBtn.Size = new System.Drawing.Size(96, 23);
            this.DynTestBtn.TabIndex = 22;
            this.DynTestBtn.Text = "动态测试";
            this.DynTestBtn.UseVisualStyleBackColor = true;
            this.DynTestBtn.Click += new System.EventHandler(this.DynTestBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchResultImg
            // 
            this.searchResultImg.Location = new System.Drawing.Point(520, 531);
            this.searchResultImg.Name = "searchResultImg";
            this.searchResultImg.Size = new System.Drawing.Size(120, 73);
            this.searchResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchResultImg.TabIndex = 24;
            this.searchResultImg.TabStop = false;
            // 
            // CaptureVideoHelp
            // 
            this.CaptureVideoHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CaptureVideoHelp.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptureVideoHelp.Location = new System.Drawing.Point(800, 324);
            this.CaptureVideoHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaptureVideoHelp.Multiline = true;
            this.CaptureVideoHelp.Name = "CaptureVideoHelp";
            this.CaptureVideoHelp.ReadOnly = true;
            this.CaptureVideoHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CaptureVideoHelp.Size = new System.Drawing.Size(284, 280);
            this.CaptureVideoHelp.TabIndex = 25;
            this.CaptureVideoHelp.Text = resources.GetString("CaptureVideoHelp.Text");
            // 
            // openCapBtn
            // 
            this.openCapBtn.Location = new System.Drawing.Point(514, 387);
            this.openCapBtn.Name = "openCapBtn";
            this.openCapBtn.Size = new System.Drawing.Size(66, 23);
            this.openCapBtn.TabIndex = 26;
            this.openCapBtn.Text = "打开截图";
            this.openCapBtn.UseVisualStyleBackColor = true;
            this.openCapBtn.Click += new System.EventHandler(this.openCapBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(648, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "当前分辨率：1080P点击切换";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // VideoSourcePlayerMonitor
            // 
            this.VideoSourcePlayerMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.VideoSourcePlayerMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VideoSourcePlayerMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoSourcePlayerMonitor.Location = new System.Drawing.Point(648, 1);
            this.VideoSourcePlayerMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.VideoSourcePlayerMonitor.Name = "VideoSourcePlayerMonitor";
            this.VideoSourcePlayerMonitor.Size = new System.Drawing.Size(436, 251);
            this.VideoSourcePlayerMonitor.TabIndex = 29;
            this.VideoSourcePlayerMonitor.TabStop = false;
            this.VideoSourcePlayerMonitor.Paint += new System.Windows.Forms.PaintEventHandler(this.VideoSourcePlayerMonitor_Paint);
            this.VideoSourcePlayerMonitor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseDoubleClick);
            this.VideoSourcePlayerMonitor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseDown);
            this.VideoSourcePlayerMonitor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseMove);
            this.VideoSourcePlayerMonitor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseUp);
            this.VideoSourcePlayerMonitor.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMonitor_MouseWheel);
            this.VideoSourcePlayerMonitor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.VideoSourcePlayerMonitor_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "左键按住移动，滚轮缩放，右键按住圈选";
            // 
            // monitorVisChk
            // 
            this.monitorVisChk.AutoSize = true;
            this.monitorVisChk.Checked = true;
            this.monitorVisChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.monitorVisChk.Location = new System.Drawing.Point(1000, 256);
            this.monitorVisChk.Name = "monitorVisChk";
            this.monitorVisChk.Size = new System.Drawing.Size(84, 16);
            this.monitorVisChk.TabIndex = 32;
            this.monitorVisChk.Text = "监视器显示";
            this.monitorVisChk.UseVisualStyleBackColor = true;
            this.monitorVisChk.CheckedChanged += new System.EventHandler(this.monitorVisChk_CheckedChanged);
            // 
            // CaptureVideoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 611);
            this.Controls.Add(this.monitorVisChk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoSourcePlayerMonitor);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.openCapBtn);
            this.Controls.Add(this.CaptureVideoHelp);
            this.Controls.Add(this.searchResultImg);
            this.Controls.Add(this.DynTestBtn);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.SaveTagBtn);
            this.Controls.Add(this.imgLableList);
            this.Controls.Add(this.reasultListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetBtn);
            this.Controls.Add(this.searchTextBtn);
            this.Controls.Add(this.rangeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.Snapshot);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaptureVideoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaptureVideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureVideo_FormClosed);
            this.Load += new System.EventHandler(this.CaptureVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Snapshot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSourcePlayerMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox reasultListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Snapshot;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rangeBtn;
        private System.Windows.Forms.Button searchTextBtn;
        private System.Windows.Forms.Button targetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox imgLableList;
        private System.Windows.Forms.Button SaveTagBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox targRangX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox targRangY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox targRangW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox targRangH;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox searchRangX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox searchRangY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox searchRangW;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox searchRangH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox searchMethodComBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button DynTestBtn;
        private System.Windows.Forms.TextBox lowestMatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imgLabelNametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox searchResultImg;
        private System.Windows.Forms.PictureBox targetImg;
        private System.Windows.Forms.TextBox CaptureVideoHelp;
        private System.Windows.Forms.Button openCapBtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox VideoSourcePlayerMonitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox imgTypeCbx;
        private System.Windows.Forms.CheckBox monitorVisChk;
    }
}