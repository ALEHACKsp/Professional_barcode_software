
namespace QR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxQRCode = new MetroFramework.Controls.MetroTextBox();
            this.buttonGenerate = new MetroFramework.Controls.MetroButton();
            this.colorDialogPrimaryColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.panelPreviewBackgroundColor = new System.Windows.Forms.Panel();
            this.panelPreviewPrimaryColor = new System.Windows.Forms.Panel();
            this.iconPath = new MetroFramework.Controls.MetroTextBox();
            this.selectIconBtn = new MetroFramework.Controls.MetroButton();
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.textBoxQRCode2 = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxECC = new MetroFramework.Controls.MetroComboBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.exfilename = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxEncodingType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.chkGenerateLabel = new MetroFramework.Controls.MetroCheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtEncoded = new MetroFramework.Controls.MetroTextBox();
            this.QREncoding = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbtype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.ServerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.SQLDBName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.textBoxQRCode0 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQRCode
            // 
            // 
            // 
            // 
            this.textBoxQRCode.CustomButton.Image = null;
            this.textBoxQRCode.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textBoxQRCode.CustomButton.Name = "";
            this.textBoxQRCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxQRCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxQRCode.CustomButton.TabIndex = 1;
            this.textBoxQRCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxQRCode.CustomButton.UseSelectable = true;
            this.textBoxQRCode.CustomButton.Visible = false;
            this.textBoxQRCode.Lines = new string[0];
            this.textBoxQRCode.Location = new System.Drawing.Point(12, 128);
            this.textBoxQRCode.MaxLength = 32767;
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.PasswordChar = '\0';
            this.textBoxQRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxQRCode.SelectedText = "";
            this.textBoxQRCode.SelectionLength = 0;
            this.textBoxQRCode.SelectionStart = 0;
            this.textBoxQRCode.ShortcutsEnabled = true;
            this.textBoxQRCode.Size = new System.Drawing.Size(200, 23);
            this.textBoxQRCode.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBoxQRCode.TabIndex = 0;
            this.textBoxQRCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxQRCode.UseSelectable = true;
            this.textBoxQRCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxQRCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(227, 63);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(124, 29);
            this.buttonGenerate.Style = MetroFramework.MetroColorStyle.Silver;
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate And  Save";
            this.buttonGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonGenerate.UseSelectable = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 216);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ECC-Level:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(162, 323);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Background color:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 323);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Primary color:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(158, 627);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "icon";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 627);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Icon size: ";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // iconSize
            // 
            this.iconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSize.Location = new System.Drawing.Point(91, 589);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(60, 20);
            this.iconSize.TabIndex = 10;
            // 
            // panelPreviewBackgroundColor
            // 
            this.panelPreviewBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panelPreviewBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreviewBackgroundColor.Location = new System.Drawing.Point(285, 321);
            this.panelPreviewBackgroundColor.Name = "panelPreviewBackgroundColor";
            this.panelPreviewBackgroundColor.Size = new System.Drawing.Size(48, 24);
            this.panelPreviewBackgroundColor.TabIndex = 17;
            this.panelPreviewBackgroundColor.Click += new System.EventHandler(this.panelPreviewBackgroundColor_Click);
            // 
            // panelPreviewPrimaryColor
            // 
            this.panelPreviewPrimaryColor.BackColor = System.Drawing.Color.Black;
            this.panelPreviewPrimaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreviewPrimaryColor.Location = new System.Drawing.Point(108, 321);
            this.panelPreviewPrimaryColor.Name = "panelPreviewPrimaryColor";
            this.panelPreviewPrimaryColor.Size = new System.Drawing.Size(48, 24);
            this.panelPreviewPrimaryColor.TabIndex = 13;
            this.panelPreviewPrimaryColor.Click += new System.EventHandler(this.panelPreviewPrimaryColor_Click);
            // 
            // iconPath
            // 
            // 
            // 
            // 
            this.iconPath.CustomButton.Image = null;
            this.iconPath.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.iconPath.CustomButton.Name = "";
            this.iconPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.iconPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iconPath.CustomButton.TabIndex = 1;
            this.iconPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iconPath.CustomButton.UseSelectable = true;
            this.iconPath.CustomButton.Visible = false;
            this.iconPath.Lines = new string[0];
            this.iconPath.Location = new System.Drawing.Point(197, 627);
            this.iconPath.MaxLength = 32767;
            this.iconPath.Name = "iconPath";
            this.iconPath.PasswordChar = '\0';
            this.iconPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iconPath.SelectedText = "";
            this.iconPath.SelectionLength = 0;
            this.iconPath.SelectionStart = 0;
            this.iconPath.ShortcutsEnabled = true;
            this.iconPath.Size = new System.Drawing.Size(113, 23);
            this.iconPath.Style = MetroFramework.MetroColorStyle.Silver;
            this.iconPath.TabIndex = 18;
            this.iconPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iconPath.UseSelectable = true;
            this.iconPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iconPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // selectIconBtn
            // 
            this.selectIconBtn.Location = new System.Drawing.Point(316, 627);
            this.selectIconBtn.Name = "selectIconBtn";
            this.selectIconBtn.Size = new System.Drawing.Size(44, 23);
            this.selectIconBtn.Style = MetroFramework.MetroColorStyle.Silver;
            this.selectIconBtn.TabIndex = 19;
            this.selectIconBtn.Text = "Select";
            this.selectIconBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectIconBtn.UseSelectable = true;
            this.selectIconBtn.Click += new System.EventHandler(this.selectIconBtn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(227, 98);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 29);
            this.buttonSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save QR code";
            this.buttonSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonSave.UseSelectable = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxQRCode2
            // 
            // 
            // 
            // 
            this.textBoxQRCode2.CustomButton.Image = null;
            this.textBoxQRCode2.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textBoxQRCode2.CustomButton.Name = "";
            this.textBoxQRCode2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxQRCode2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxQRCode2.CustomButton.TabIndex = 1;
            this.textBoxQRCode2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxQRCode2.CustomButton.UseSelectable = true;
            this.textBoxQRCode2.CustomButton.Visible = false;
            this.textBoxQRCode2.Lines = new string[0];
            this.textBoxQRCode2.Location = new System.Drawing.Point(12, 157);
            this.textBoxQRCode2.MaxLength = 32767;
            this.textBoxQRCode2.Name = "textBoxQRCode2";
            this.textBoxQRCode2.PasswordChar = '\0';
            this.textBoxQRCode2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxQRCode2.SelectedText = "";
            this.textBoxQRCode2.SelectionLength = 0;
            this.textBoxQRCode2.SelectionStart = 0;
            this.textBoxQRCode2.ShortcutsEnabled = true;
            this.textBoxQRCode2.Size = new System.Drawing.Size(200, 23);
            this.textBoxQRCode2.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBoxQRCode2.TabIndex = 23;
            this.textBoxQRCode2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxQRCode2.UseSelectable = true;
            this.textBoxQRCode2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxQRCode2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.ItemHeight = 23;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(12, 238);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(121, 29);
            this.comboBoxECC.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxECC.TabIndex = 25;
            this.comboBoxECC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBoxECC.UseSelectable = true;
            this.comboBoxECC.SelectedIndexChanged += new System.EventHandler(this.comboBoxECC_SelectedIndexChanged_1);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(12, 372);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(339, 124);
            this.pictureBoxQRCode.TabIndex = 22;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 270);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "File Name:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // exfilename
            // 
            // 
            // 
            // 
            this.exfilename.CustomButton.Image = null;
            this.exfilename.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.exfilename.CustomButton.Name = "";
            this.exfilename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.exfilename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.exfilename.CustomButton.TabIndex = 1;
            this.exfilename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exfilename.CustomButton.UseSelectable = true;
            this.exfilename.CustomButton.Visible = false;
            this.exfilename.Lines = new string[] {
        "data.xlsx"};
            this.exfilename.Location = new System.Drawing.Point(12, 292);
            this.exfilename.MaxLength = 32767;
            this.exfilename.Name = "exfilename";
            this.exfilename.PasswordChar = '\0';
            this.exfilename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.exfilename.SelectedText = "";
            this.exfilename.SelectionLength = 0;
            this.exfilename.SelectionStart = 0;
            this.exfilename.ShortcutsEnabled = true;
            this.exfilename.Size = new System.Drawing.Size(71, 23);
            this.exfilename.Style = MetroFramework.MetroColorStyle.Silver;
            this.exfilename.TabIndex = 27;
            this.exfilename.Text = "data.xlsx";
            this.exfilename.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exfilename.UseSelectable = true;
            this.exfilename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.exfilename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBoxType
            // 
            this.metroComboBoxType.FormattingEnabled = true;
            this.metroComboBoxType.ItemHeight = 23;
            this.metroComboBoxType.Items.AddRange(new object[] {
            "Type 1",
            "Type 2"});
            this.metroComboBoxType.Location = new System.Drawing.Point(49, 63);
            this.metroComboBoxType.Name = "metroComboBoxType";
            this.metroComboBoxType.Size = new System.Drawing.Size(163, 29);
            this.metroComboBoxType.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxType.TabIndex = 28;
            this.metroComboBoxType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBoxType.UseSelectable = true;
            this.metroComboBoxType.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxType_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(141, 216);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Encoding Type:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ComboBoxEncodingType
            // 
            this.ComboBoxEncodingType.FormattingEnabled = true;
            this.ComboBoxEncodingType.ItemHeight = 23;
            this.ComboBoxEncodingType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Interleaved 2 of 5 Mod 10",
            "Standard 2 of 5",
            "Standard 2 of 5 Mod 10",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.ComboBoxEncodingType.Location = new System.Drawing.Point(141, 238);
            this.ComboBoxEncodingType.Name = "ComboBoxEncodingType";
            this.ComboBoxEncodingType.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxEncodingType.Style = MetroFramework.MetroColorStyle.Silver;
            this.ComboBoxEncodingType.TabIndex = 30;
            this.ComboBoxEncodingType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboBoxEncodingType.UseSelectable = true;
            this.ComboBoxEncodingType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEncodingType_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 68);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "QR:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.Location = new System.Drawing.Point(12, 351);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(98, 15);
            this.chkGenerateLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.chkGenerateLabel.TabIndex = 32;
            this.chkGenerateLabel.Text = "Generate label";
            this.chkGenerateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chkGenerateLabel.UseSelectable = true;
            this.chkGenerateLabel.CheckedChanged += new System.EventHandler(this.chkGenerateLabel_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 499);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "Encoded Value";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtEncoded
            // 
            // 
            // 
            // 
            this.txtEncoded.CustomButton.Image = null;
            this.txtEncoded.CustomButton.Location = new System.Drawing.Point(241, 2);
            this.txtEncoded.CustomButton.Name = "";
            this.txtEncoded.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtEncoded.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEncoded.CustomButton.TabIndex = 1;
            this.txtEncoded.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEncoded.CustomButton.UseSelectable = true;
            this.txtEncoded.CustomButton.Visible = false;
            this.txtEncoded.Lines = new string[0];
            this.txtEncoded.Location = new System.Drawing.Point(12, 521);
            this.txtEncoded.MaxLength = 32767;
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.PasswordChar = '\0';
            this.txtEncoded.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEncoded.SelectedText = "";
            this.txtEncoded.SelectionLength = 0;
            this.txtEncoded.SelectionStart = 0;
            this.txtEncoded.ShortcutsEnabled = true;
            this.txtEncoded.Size = new System.Drawing.Size(339, 100);
            this.txtEncoded.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtEncoded.TabIndex = 34;
            this.txtEncoded.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEncoded.UseSelectable = true;
            this.txtEncoded.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEncoded.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QREncoding
            // 
            // 
            // 
            // 
            this.QREncoding.CustomButton.Image = null;
            this.QREncoding.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.QREncoding.CustomButton.Name = "";
            this.QREncoding.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QREncoding.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QREncoding.CustomButton.TabIndex = 1;
            this.QREncoding.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QREncoding.CustomButton.UseSelectable = true;
            this.QREncoding.CustomButton.Visible = false;
            this.QREncoding.Lines = new string[0];
            this.QREncoding.Location = new System.Drawing.Point(12, 186);
            this.QREncoding.MaxLength = 32767;
            this.QREncoding.Name = "QREncoding";
            this.QREncoding.PasswordChar = '\0';
            this.QREncoding.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QREncoding.SelectedText = "";
            this.QREncoding.SelectionLength = 0;
            this.QREncoding.SelectionStart = 0;
            this.QREncoding.ShortcutsEnabled = true;
            this.QREncoding.Size = new System.Drawing.Size(200, 23);
            this.QREncoding.Style = MetroFramework.MetroColorStyle.Silver;
            this.QREncoding.TabIndex = 35;
            this.QREncoding.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QREncoding.UseSelectable = true;
            this.QREncoding.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QREncoding.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "EN",
            "AR"});
            this.metroComboBox1.Location = new System.Drawing.Point(257, 12);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(53, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox1.TabIndex = 36;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(59, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(182, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 37;
            this.metroTile1.Text = "Al-Hikma University College";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QR.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dbtype
            // 
            this.dbtype.FormattingEnabled = true;
            this.dbtype.ItemHeight = 23;
            this.dbtype.Items.AddRange(new object[] {
            "None",
            "MS Excel",
            "SQL Server",
            "Both"});
            this.dbtype.Location = new System.Drawing.Point(268, 238);
            this.dbtype.Name = "dbtype";
            this.dbtype.Size = new System.Drawing.Size(83, 29);
            this.dbtype.Style = MetroFramework.MetroColorStyle.Silver;
            this.dbtype.TabIndex = 39;
            this.dbtype.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dbtype.UseSelectable = true;
            this.dbtype.SelectedIndexChanged += new System.EventHandler(this.dbtype_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(268, 216);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel10.TabIndex = 40;
            this.metroLabel10.Text = "DB-Type:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ServerName
            // 
            // 
            // 
            // 
            this.ServerName.CustomButton.Image = null;
            this.ServerName.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.ServerName.CustomButton.Name = "";
            this.ServerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerName.CustomButton.TabIndex = 1;
            this.ServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerName.CustomButton.UseSelectable = true;
            this.ServerName.CustomButton.Visible = false;
            this.ServerName.Lines = new string[] {
        "codex"};
            this.ServerName.Location = new System.Drawing.Point(92, 292);
            this.ServerName.MaxLength = 32767;
            this.ServerName.Name = "ServerName";
            this.ServerName.PasswordChar = '\0';
            this.ServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerName.SelectedText = "";
            this.ServerName.SelectionLength = 0;
            this.ServerName.SelectionStart = 0;
            this.ServerName.ShortcutsEnabled = true;
            this.ServerName.Size = new System.Drawing.Size(90, 23);
            this.ServerName.Style = MetroFramework.MetroColorStyle.Silver;
            this.ServerName.TabIndex = 41;
            this.ServerName.Text = "codex";
            this.ServerName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerName.UseSelectable = true;
            this.ServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(88, 270);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(90, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel11.TabIndex = 42;
            this.metroLabel11.Text = "Server Name:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(188, 270);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(97, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel12.TabIndex = 44;
            this.metroLabel12.Text = "SQL DB Name:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SQLDBName
            // 
            // 
            // 
            // 
            this.SQLDBName.CustomButton.Image = null;
            this.SQLDBName.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.SQLDBName.CustomButton.Name = "";
            this.SQLDBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SQLDBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SQLDBName.CustomButton.TabIndex = 1;
            this.SQLDBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SQLDBName.CustomButton.UseSelectable = true;
            this.SQLDBName.CustomButton.Visible = false;
            this.SQLDBName.Lines = new string[] {
        "QRDB"};
            this.SQLDBName.Location = new System.Drawing.Point(192, 292);
            this.SQLDBName.MaxLength = 32767;
            this.SQLDBName.Name = "SQLDBName";
            this.SQLDBName.PasswordChar = '\0';
            this.SQLDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SQLDBName.SelectedText = "";
            this.SQLDBName.SelectionLength = 0;
            this.SQLDBName.SelectionStart = 0;
            this.SQLDBName.ShortcutsEnabled = true;
            this.SQLDBName.Size = new System.Drawing.Size(90, 23);
            this.SQLDBName.Style = MetroFramework.MetroColorStyle.Silver;
            this.SQLDBName.TabIndex = 43;
            this.SQLDBName.Text = "QRDB";
            this.SQLDBName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SQLDBName.UseSelectable = true;
            this.SQLDBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SQLDBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(227, 133);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Print  Excel Sheet";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(227, 168);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(124, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton2.TabIndex = 46;
            this.metroButton2.Text = "Convert DB To PDF";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // textBoxQRCode0
            // 
            // 
            // 
            // 
            this.textBoxQRCode0.CustomButton.Image = null;
            this.textBoxQRCode0.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.textBoxQRCode0.CustomButton.Name = "";
            this.textBoxQRCode0.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxQRCode0.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxQRCode0.CustomButton.TabIndex = 1;
            this.textBoxQRCode0.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxQRCode0.CustomButton.UseSelectable = true;
            this.textBoxQRCode0.CustomButton.Visible = false;
            this.textBoxQRCode0.Lines = new string[0];
            this.textBoxQRCode0.Location = new System.Drawing.Point(11, 99);
            this.textBoxQRCode0.MaxLength = 32767;
            this.textBoxQRCode0.Name = "textBoxQRCode0";
            this.textBoxQRCode0.PasswordChar = '\0';
            this.textBoxQRCode0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxQRCode0.SelectedText = "";
            this.textBoxQRCode0.SelectionLength = 0;
            this.textBoxQRCode0.SelectionStart = 0;
            this.textBoxQRCode0.ShortcutsEnabled = true;
            this.textBoxQRCode0.Size = new System.Drawing.Size(201, 23);
            this.textBoxQRCode0.TabIndex = 47;
            this.textBoxQRCode0.UseSelectable = true;
            this.textBoxQRCode0.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxQRCode0.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 655);
            this.Controls.Add(this.textBoxQRCode0);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.SQLDBName);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.dbtype);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.QREncoding);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.chkGenerateLabel);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.ComboBoxEncodingType);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroComboBoxType);
            this.Controls.Add(this.exfilename);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.textBoxQRCode2);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.selectIconBtn);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.panelPreviewBackgroundColor);
            this.Controls.Add(this.panelPreviewPrimaryColor);
            this.Controls.Add(this.iconSize);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxQRCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBoxQRCode;
        private MetroFramework.Controls.MetroButton buttonGenerate;
        private System.Windows.Forms.ColorDialog colorDialogPrimaryColor;
        private System.Windows.Forms.ColorDialog colorDialogBackgroundColor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Panel panelPreviewBackgroundColor;
        private System.Windows.Forms.Panel panelPreviewPrimaryColor;
        private MetroFramework.Controls.MetroTextBox iconPath;
        private MetroFramework.Controls.MetroButton selectIconBtn;
        private MetroFramework.Controls.MetroButton buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private MetroFramework.Controls.MetroTextBox textBoxQRCode2;
        private MetroFramework.Controls.MetroComboBox comboBoxECC;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox exfilename;
        private MetroFramework.Controls.MetroComboBox metroComboBoxType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox ComboBoxEncodingType;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroCheckBox chkGenerateLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox txtEncoded;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox QREncoding;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox dbtype;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox SQLDBName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox ServerName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox textBoxQRCode0;
    }
}

