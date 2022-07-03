namespace TextClassification
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btnClassification = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.switchColumnChart = new MaterialSkin.Controls.MaterialSwitch();
            this.switchPioChart = new MaterialSkin.Controls.MaterialSwitch();
            this.txtEndData = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtStartData = new MaterialSkin.Controls.MaterialTextBox2();
            this.radioSection = new System.Windows.Forms.RadioButton();
            this.radioAllTime = new System.Windows.Forms.RadioButton();
            this.saveChart = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1239, 698);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.materialProgressBar1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.materialButton3);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.btnClassification);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ImageKey = "data-classificationBlack.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1231, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Классификация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::TextClassification.Properties.Resources.remove;
            this.pictureBox2.Location = new System.Drawing.Point(67, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(573, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Обработанно документов:";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(10, 641);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(1215, 5);
            this.materialProgressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Состояние сервера: Не найден";
            // 
            // materialCard1
            // 
            this.materialCard1.AllowDrop = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 6);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(250, 327);
            this.materialCard1.TabIndex = 4;
            this.materialCard1.DragDrop += new System.Windows.Forms.DragEventHandler(this.materialCard1_DragDrop);
            this.materialCard1.DragEnter += new System.Windows.Forms.DragEventHandler(this.materialCard1_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TextClassification.Properties.Resources.loadFolder;
            this.pictureBox1.Location = new System.Drawing.Point(57, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(7, 474);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(250, 36);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "Разбить по папкам";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Enabled = false;
            this.materialButton2.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(7, 426);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(250, 36);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "Открыть документ";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // btnClassification
            // 
            this.btnClassification.AutoSize = false;
            this.btnClassification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClassification.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClassification.Depth = 0;
            this.btnClassification.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClassification.HighEmphasis = true;
            this.btnClassification.Icon = null;
            this.btnClassification.Location = new System.Drawing.Point(7, 353);
            this.btnClassification.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClassification.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClassification.Size = new System.Drawing.Size(250, 61);
            this.btnClassification.TabIndex = 1;
            this.btnClassification.Text = "Обработать";
            this.btnClassification.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClassification.UseAccentColor = false;
            this.btnClassification.UseVisualStyleBackColor = true;
            this.btnClassification.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(274, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(951, 606);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название документа";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тематический класс";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Язык документа";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата обработки";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата создания";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дублирование";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Path";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pieChart1);
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.saveChart);
            this.tabPage2.Controls.Add(this.materialButton4);
            this.tabPage2.Controls.Add(this.cartesianChart1);
            this.tabPage2.ImageKey = "analyticsBlack.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Визуализация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.InitialRotation = 0D;
            this.pieChart1.Location = new System.Drawing.Point(291, 17);
            this.pieChart1.MaxAngle = 360D;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(934, 632);
            this.pieChart1.TabIndex = 3;
            this.pieChart1.Total = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialComboBox1);
            this.materialCard2.Controls.Add(this.switchColumnChart);
            this.materialCard2.Controls.Add(this.switchPioChart);
            this.materialCard2.Controls.Add(this.txtEndData);
            this.materialCard2.Controls.Add(this.txtStartData);
            this.materialCard2.Controls.Add(this.radioSection);
            this.materialCard2.Controls.Add(this.radioAllTime);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(260, 440);
            this.materialCard2.TabIndex = 2;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "c1",
            "c2",
            "c3",
            "c4",
            "c5"});
            this.materialComboBox1.Location = new System.Drawing.Point(13, 376);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(230, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 6;
            // 
            // switchColumnChart
            // 
            this.switchColumnChart.AutoSize = true;
            this.switchColumnChart.Depth = 0;
            this.switchColumnChart.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchColumnChart.Location = new System.Drawing.Point(36, 315);
            this.switchColumnChart.Margin = new System.Windows.Forms.Padding(0);
            this.switchColumnChart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchColumnChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchColumnChart.Name = "switchColumnChart";
            this.switchColumnChart.Ripple = true;
            this.switchColumnChart.Size = new System.Drawing.Size(159, 37);
            this.switchColumnChart.TabIndex = 5;
            this.switchColumnChart.Text = "Гистограмма";
            this.switchColumnChart.UseVisualStyleBackColor = true;
            this.switchColumnChart.CheckedChanged += new System.EventHandler(this.switchColumnChart_CheckedChanged);
            // 
            // switchPioChart
            // 
            this.switchPioChart.AutoSize = true;
            this.switchPioChart.Depth = 0;
            this.switchPioChart.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchPioChart.Location = new System.Drawing.Point(36, 266);
            this.switchPioChart.Margin = new System.Windows.Forms.Padding(0);
            this.switchPioChart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchPioChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchPioChart.Name = "switchPioChart";
            this.switchPioChart.Ripple = true;
            this.switchPioChart.Size = new System.Drawing.Size(146, 37);
            this.switchPioChart.TabIndex = 4;
            this.switchPioChart.Text = "Диаграмма";
            this.switchPioChart.UseVisualStyleBackColor = true;
            this.switchPioChart.CheckedChanged += new System.EventHandler(this.switchPioChart_CheckedChanged);
            // 
            // txtEndData
            // 
            this.txtEndData.AnimateReadOnly = false;
            this.txtEndData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndData.Depth = 0;
            this.txtEndData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndData.HideSelection = true;
            this.txtEndData.Hint = "По ДД.ММ.ГГГГ";
            this.txtEndData.LeadingIcon = null;
            this.txtEndData.Location = new System.Drawing.Point(17, 184);
            this.txtEndData.MaxLength = 32767;
            this.txtEndData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEndData.Name = "txtEndData";
            this.txtEndData.PasswordChar = '\0';
            this.txtEndData.PrefixSuffixText = null;
            this.txtEndData.ReadOnly = false;
            this.txtEndData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndData.SelectedText = "";
            this.txtEndData.SelectionLength = 0;
            this.txtEndData.SelectionStart = 0;
            this.txtEndData.ShortcutsEnabled = true;
            this.txtEndData.Size = new System.Drawing.Size(226, 48);
            this.txtEndData.TabIndex = 3;
            this.txtEndData.TabStop = false;
            this.txtEndData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndData.TrailingIcon = null;
            this.txtEndData.UseSystemPasswordChar = false;
            // 
            // txtStartData
            // 
            this.txtStartData.AnimateReadOnly = false;
            this.txtStartData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStartData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStartData.Depth = 0;
            this.txtStartData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartData.HideSelection = true;
            this.txtStartData.Hint = "C ДД.ММ.ГГГГ";
            this.txtStartData.LeadingIcon = null;
            this.txtStartData.Location = new System.Drawing.Point(17, 113);
            this.txtStartData.MaxLength = 32767;
            this.txtStartData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStartData.Name = "txtStartData";
            this.txtStartData.PasswordChar = '\0';
            this.txtStartData.PrefixSuffixText = null;
            this.txtStartData.ReadOnly = false;
            this.txtStartData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartData.SelectedText = "";
            this.txtStartData.SelectionLength = 0;
            this.txtStartData.SelectionStart = 0;
            this.txtStartData.ShortcutsEnabled = true;
            this.txtStartData.Size = new System.Drawing.Size(226, 48);
            this.txtStartData.TabIndex = 2;
            this.txtStartData.TabStop = false;
            this.txtStartData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartData.TrailingIcon = null;
            this.txtStartData.UseSystemPasswordChar = false;
            // 
            // radioSection
            // 
            this.radioSection.AutoSize = true;
            this.radioSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioSection.Location = new System.Drawing.Point(41, 55);
            this.radioSection.Name = "radioSection";
            this.radioSection.Size = new System.Drawing.Size(128, 32);
            this.radioSection.TabIndex = 1;
            this.radioSection.TabStop = true;
            this.radioSection.Text = "За период";
            this.radioSection.UseVisualStyleBackColor = true;
            this.radioSection.CheckedChanged += new System.EventHandler(this.radioSection_CheckedChanged);
            // 
            // radioAllTime
            // 
            this.radioAllTime.AutoSize = true;
            this.radioAllTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAllTime.Location = new System.Drawing.Point(41, 17);
            this.radioAllTime.Name = "radioAllTime";
            this.radioAllTime.Size = new System.Drawing.Size(151, 32);
            this.radioAllTime.TabIndex = 0;
            this.radioAllTime.TabStop = true;
            this.radioAllTime.Text = "За все время";
            this.radioAllTime.UseVisualStyleBackColor = true;
            this.radioAllTime.CheckedChanged += new System.EventHandler(this.radioAllTime_CheckedChanged);
            // 
            // saveChart
            // 
            this.saveChart.AutoSize = false;
            this.saveChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChart.Depth = 0;
            this.saveChart.HighEmphasis = true;
            this.saveChart.Icon = null;
            this.saveChart.Location = new System.Drawing.Point(14, 542);
            this.saveChart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChart.Name = "saveChart";
            this.saveChart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChart.Size = new System.Drawing.Size(260, 36);
            this.saveChart.TabIndex = 1;
            this.saveChart.Text = "Сохранить график";
            this.saveChart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChart.UseAccentColor = false;
            this.saveChart.UseVisualStyleBackColor = true;
            this.saveChart.Click += new System.EventHandler(this.saveChart_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(14, 470);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(260, 60);
            this.materialButton4.TabIndex = 0;
            this.materialButton4.Text = "Построить";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(291, 17);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(934, 632);
            this.cartesianChart1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "analytics.png");
            this.imageList1.Images.SetKeyName(1, "analyticsBlack.png");
            this.imageList1.Images.SetKeyName(2, "data-classificationBlack.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1245, 765);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(1245, 765);
            this.Name = "Form1";
            this.Text = "СПО Классификации и визуализации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnClassification;
        private MaterialSkin.Controls.MaterialButton saveChart;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.RadioButton radioSection;
        private System.Windows.Forms.RadioButton radioAllTime;
        private MaterialSkin.Controls.MaterialTextBox2 txtEndData;
        private MaterialSkin.Controls.MaterialTextBox2 txtStartData;
        private MaterialSkin.Controls.MaterialSwitch switchColumnChart;
        private MaterialSkin.Controls.MaterialSwitch switchPioChart;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
