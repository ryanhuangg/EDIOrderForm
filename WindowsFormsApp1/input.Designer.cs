namespace EDIForm
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.PODate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTabs = new System.Windows.Forms.TabControl();
            this.POLine1 = new System.Windows.Forms.TabPage();
            this.overallThick = new System.Windows.Forms.ComboBox();
            this.shipDate = new System.Windows.Forms.DateTimePicker();
            this.gasFill = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.spacer = new System.Windows.Forms.ComboBox();
            this.gridStyle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.partNum1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.openingsHigh = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.leftLeg = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.openingsWide = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.L3Coat = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.L3Treat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.L3Thick = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.L2Coat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.L2Treat = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.L2Thick = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.shapeNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.baseLeg = new System.Windows.Forms.TextBox();
            this.L1Coat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.L1Treat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.L1Thick = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.POLine = new System.Windows.Forms.TextBox();
            this.addTab = new System.Windows.Forms.TabPage();
            this.remove = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.removeNum = new System.Windows.Forms.Button();
            this.removeTabNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PODisplay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resequence = new System.Windows.Forms.Button();
            this.inputTabs.SuspendLayout();
            this.POLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PODate
            // 
            this.PODate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODate.Location = new System.Drawing.Point(1244, 28);
            this.PODate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PODate.Name = "PODate";
            this.PODate.Size = new System.Drawing.Size(148, 30);
            this.PODate.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1146, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PO Date";
            // 
            // inputTabs
            // 
            this.inputTabs.Controls.Add(this.POLine1);
            this.inputTabs.Controls.Add(this.addTab);
            this.inputTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTabs.Location = new System.Drawing.Point(54, 143);
            this.inputTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTabs.Name = "inputTabs";
            this.inputTabs.SelectedIndex = 0;
            this.inputTabs.Size = new System.Drawing.Size(1672, 755);
            this.inputTabs.TabIndex = 4;
            this.inputTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputTabs_MouseDown);
            // 
            // POLine1
            // 
            this.POLine1.AutoScroll = true;
            this.POLine1.BackColor = System.Drawing.Color.SlateGray;
            this.POLine1.Controls.Add(this.overallThick);
            this.POLine1.Controls.Add(this.shipDate);
            this.POLine1.Controls.Add(this.gasFill);
            this.POLine1.Controls.Add(this.label21);
            this.POLine1.Controls.Add(this.spacer);
            this.POLine1.Controls.Add(this.gridStyle);
            this.POLine1.Controls.Add(this.label9);
            this.POLine1.Controls.Add(this.label4);
            this.POLine1.Controls.Add(this.label37);
            this.POLine1.Controls.Add(this.quantity);
            this.POLine1.Controls.Add(this.label36);
            this.POLine1.Controls.Add(this.label33);
            this.POLine1.Controls.Add(this.partNum1);
            this.POLine1.Controls.Add(this.label32);
            this.POLine1.Controls.Add(this.openingsHigh);
            this.POLine1.Controls.Add(this.label25);
            this.POLine1.Controls.Add(this.leftLeg);
            this.POLine1.Controls.Add(this.label20);
            this.POLine1.Controls.Add(this.openingsWide);
            this.POLine1.Controls.Add(this.label19);
            this.POLine1.Controls.Add(this.MCode);
            this.POLine1.Controls.Add(this.label18);
            this.POLine1.Controls.Add(this.L3Coat);
            this.POLine1.Controls.Add(this.label15);
            this.POLine1.Controls.Add(this.L3Treat);
            this.POLine1.Controls.Add(this.label16);
            this.POLine1.Controls.Add(this.L3Thick);
            this.POLine1.Controls.Add(this.label17);
            this.POLine1.Controls.Add(this.L2Coat);
            this.POLine1.Controls.Add(this.label12);
            this.POLine1.Controls.Add(this.L2Treat);
            this.POLine1.Controls.Add(this.label13);
            this.POLine1.Controls.Add(this.L2Thick);
            this.POLine1.Controls.Add(this.label14);
            this.POLine1.Controls.Add(this.label11);
            this.POLine1.Controls.Add(this.shapeNum);
            this.POLine1.Controls.Add(this.label10);
            this.POLine1.Controls.Add(this.baseLeg);
            this.POLine1.Controls.Add(this.L1Coat);
            this.POLine1.Controls.Add(this.label8);
            this.POLine1.Controls.Add(this.L1Treat);
            this.POLine1.Controls.Add(this.label7);
            this.POLine1.Controls.Add(this.L1Thick);
            this.POLine1.Controls.Add(this.label6);
            this.POLine1.Controls.Add(this.label5);
            this.POLine1.Controls.Add(this.label3);
            this.POLine1.Controls.Add(this.POLine);
            this.POLine1.Location = new System.Drawing.Point(4, 34);
            this.POLine1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.POLine1.Name = "POLine1";
            this.POLine1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.POLine1.Size = new System.Drawing.Size(1664, 717);
            this.POLine1.TabIndex = 0;
            this.POLine1.Text = "POLine 1";
            this.POLine1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // overallThick
            // 
            this.overallThick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overallThick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.overallThick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overallThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallThick.FormattingEnabled = true;
            this.overallThick.Items.AddRange(new object[] {
            "0 3/4",
            "0 13/16",
            "0 7/8",
            "1 3/8"});
            this.overallThick.Location = new System.Drawing.Point(1383, 135);
            this.overallThick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.overallThick.Name = "overallThick";
            this.overallThick.Size = new System.Drawing.Size(180, 37);
            this.overallThick.TabIndex = 7;
            // 
            // shipDate
            // 
            this.shipDate.BackColor = System.Drawing.Color.Black;
            this.shipDate.CustomFormat = "yyyyMMdd";
            this.shipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shipDate.Location = new System.Drawing.Point(1383, 34);
            this.shipDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipDate.Name = "shipDate";
            this.shipDate.Size = new System.Drawing.Size(180, 35);
            this.shipDate.TabIndex = 3;
            // 
            // gasFill
            // 
            this.gasFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gasFill.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gasFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gasFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasFill.FormattingEnabled = true;
            this.gasFill.Items.AddRange(new object[] {
            "Argon",
            "Air"});
            this.gasFill.Location = new System.Drawing.Point(1383, 174);
            this.gasFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gasFill.Name = "gasFill";
            this.gasFill.Size = new System.Drawing.Size(180, 37);
            this.gasFill.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(1240, 178);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 29);
            this.label21.TabIndex = 73;
            this.label21.Text = "Gas Fill";
            // 
            // spacer
            // 
            this.spacer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spacer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacer.FormattingEnabled = true;
            this.spacer.Items.AddRange(new object[] {
            "Black Warm Edge",
            "Light Grey Warm Edge",
            "White Warm Edge",
            "Aluminum"});
            this.spacer.Location = new System.Drawing.Point(759, 211);
            this.spacer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(282, 37);
            this.spacer.TabIndex = 8;
            // 
            // gridStyle
            // 
            this.gridStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gridStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridStyle.FormattingEnabled = true;
            this.gridStyle.Items.AddRange(new object[] {
            "Colonial",
            "Prairie"});
            this.gridStyle.Location = new System.Drawing.Point(264, 568);
            this.gridStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridStyle.Name = "gridStyle";
            this.gridStyle.Size = new System.Drawing.Size(180, 37);
            this.gridStyle.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(633, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 70;
            this.label9.Text = "Spacer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(50, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "(Width/Height must be multiples of 1/16)";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(663, 138);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 29);
            this.label37.TabIndex = 67;
            this.label37.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(820, 134);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(148, 35);
            this.quantity.TabIndex = 6;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(1137, 138);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(247, 29);
            this.label36.TabIndex = 65;
            this.label36.Text = "Overall Thickness (in)";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(642, 34);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(149, 29);
            this.label33.TabIndex = 59;
            this.label33.Text = "Part Number";
            // 
            // partNum1
            // 
            this.partNum1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.partNum1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.partNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNum1.Location = new System.Drawing.Point(820, 29);
            this.partNum1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partNum1.Name = "partNum1";
            this.partNum1.Size = new System.Drawing.Size(148, 35);
            this.partNum1.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(573, 617);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(219, 29);
            this.label32.TabIndex = 57;
            this.label32.Text = "Vertical Square Qty";
            // 
            // openingsHigh
            // 
            this.openingsHigh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openingsHigh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openingsHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingsHigh.Location = new System.Drawing.Point(820, 612);
            this.openingsHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openingsHigh.Name = "openingsHigh";
            this.openingsHigh.Size = new System.Drawing.Size(148, 35);
            this.openingsHigh.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(112, 178);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 29);
            this.label25.TabIndex = 45;
            this.label25.Text = "Height";
            // 
            // leftLeg
            // 
            this.leftLeg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.leftLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLeg.Location = new System.Drawing.Point(264, 174);
            this.leftLeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftLeg.Name = "leftLeg";
            this.leftLeg.Size = new System.Drawing.Size(148, 35);
            this.leftLeg.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(544, 577);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 29);
            this.label20.TabIndex = 33;
            this.label20.Text = "Horizontal Square Qty";
            // 
            // openingsWide
            // 
            this.openingsWide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openingsWide.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openingsWide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingsWide.Location = new System.Drawing.Point(820, 572);
            this.openingsWide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openingsWide.Name = "openingsWide";
            this.openingsWide.Size = new System.Drawing.Size(148, 35);
            this.openingsWide.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(118, 622);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 29);
            this.label19.TabIndex = 31;
            this.label19.Text = "MCode";
            // 
            // MCode
            // 
            this.MCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCode.Location = new System.Drawing.Point(264, 612);
            this.MCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MCode.Name = "MCode";
            this.MCode.Size = new System.Drawing.Size(148, 35);
            this.MCode.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(118, 577);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 29);
            this.label18.TabIndex = 29;
            this.label18.Text = "Grid Style";
            // 
            // L3Coat
            // 
            this.L3Coat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L3Coat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L3Coat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L3Coat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3Coat.FormattingEnabled = true;
            this.L3Coat.Items.AddRange(new object[] {
            "Clear",
            "LoE",
            "Frosted"});
            this.L3Coat.Location = new System.Drawing.Point(1383, 380);
            this.L3Coat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L3Coat.Name = "L3Coat";
            this.L3Coat.Size = new System.Drawing.Size(180, 37);
            this.L3Coat.TabIndex = 17;
            this.L3Coat.SelectedIndexChanged += new System.EventHandler(this.L3Coat_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1173, 385);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 29);
            this.label15.TabIndex = 26;
            this.label15.Text = "Lite 3 Coating";
            // 
            // L3Treat
            // 
            this.L3Treat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L3Treat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L3Treat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L3Treat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3Treat.FormattingEnabled = true;
            this.L3Treat.Items.AddRange(new object[] {
            "Annealed",
            "Tempered",
            "Heat Actived"});
            this.L3Treat.Location = new System.Drawing.Point(1383, 425);
            this.L3Treat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L3Treat.Name = "L3Treat";
            this.L3Treat.Size = new System.Drawing.Size(180, 37);
            this.L3Treat.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(1173, 429);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 29);
            this.label16.TabIndex = 24;
            this.label16.Text = "Lite 3 Treatment";
            // 
            // L3Thick
            // 
            this.L3Thick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L3Thick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L3Thick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L3Thick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3Thick.FormattingEnabled = true;
            this.L3Thick.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.L3Thick.Location = new System.Drawing.Point(1383, 335);
            this.L3Thick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L3Thick.Name = "L3Thick";
            this.L3Thick.Size = new System.Drawing.Size(180, 37);
            this.L3Thick.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(1173, 340);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 29);
            this.label17.TabIndex = 22;
            this.label17.Text = "Lite 3 Thickness";
            // 
            // L2Coat
            // 
            this.L2Coat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L2Coat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L2Coat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L2Coat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2Coat.FormattingEnabled = true;
            this.L2Coat.Items.AddRange(new object[] {
            "Clear",
            "LoE",
            "Frosted"});
            this.L2Coat.Location = new System.Drawing.Point(820, 380);
            this.L2Coat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L2Coat.Name = "L2Coat";
            this.L2Coat.Size = new System.Drawing.Size(180, 37);
            this.L2Coat.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(604, 385);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Lite 2 Coating";
            // 
            // L2Treat
            // 
            this.L2Treat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L2Treat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L2Treat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L2Treat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2Treat.FormattingEnabled = true;
            this.L2Treat.Items.AddRange(new object[] {
            "Annealed",
            "Tempered",
            "Heat Actived"});
            this.L2Treat.Location = new System.Drawing.Point(820, 425);
            this.L2Treat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L2Treat.Name = "L2Treat";
            this.L2Treat.Size = new System.Drawing.Size(180, 37);
            this.L2Treat.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(604, 432);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "Lite 2 Treatment";
            // 
            // L2Thick
            // 
            this.L2Thick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L2Thick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L2Thick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L2Thick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2Thick.FormattingEnabled = true;
            this.L2Thick.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.L2Thick.Location = new System.Drawing.Point(820, 335);
            this.L2Thick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L2Thick.Name = "L2Thick";
            this.L2Thick.Size = new System.Drawing.Size(180, 37);
            this.L2Thick.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(604, 340);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "Lite 2 Thickness";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1186, 622);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Shape Number";
            // 
            // shapeNum
            // 
            this.shapeNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.shapeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeNum.Location = new System.Drawing.Point(1388, 617);
            this.shapeNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shapeNum.Name = "shapeNum";
            this.shapeNum.ReadOnly = true;
            this.shapeNum.Size = new System.Drawing.Size(148, 35);
            this.shapeNum.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(112, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Width";
            // 
            // baseLeg
            // 
            this.baseLeg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.baseLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLeg.Location = new System.Drawing.Point(264, 134);
            this.baseLeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baseLeg.Name = "baseLeg";
            this.baseLeg.Size = new System.Drawing.Size(148, 35);
            this.baseLeg.TabIndex = 4;
            // 
            // L1Coat
            // 
            this.L1Coat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L1Coat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L1Coat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L1Coat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1Coat.FormattingEnabled = true;
            this.L1Coat.Items.AddRange(new object[] {
            "Clear",
            "LoE",
            "Frosted"});
            this.L1Coat.Location = new System.Drawing.Point(264, 380);
            this.L1Coat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L1Coat.Name = "L1Coat";
            this.L1Coat.Size = new System.Drawing.Size(180, 37);
            this.L1Coat.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Lite 1 Coating";
            // 
            // L1Treat
            // 
            this.L1Treat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L1Treat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L1Treat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L1Treat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1Treat.FormattingEnabled = true;
            this.L1Treat.Items.AddRange(new object[] {
            "Annealed",
            "Tempered",
            "Heat Actived"});
            this.L1Treat.Location = new System.Drawing.Point(264, 425);
            this.L1Treat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L1Treat.Name = "L1Treat";
            this.L1Treat.Size = new System.Drawing.Size(180, 37);
            this.L1Treat.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 429);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lite 1 Treatment";
            // 
            // L1Thick
            // 
            this.L1Thick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L1Thick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L1Thick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L1Thick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1Thick.FormattingEnabled = true;
            this.L1Thick.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.L1Thick.Location = new System.Drawing.Point(264, 335);
            this.L1Thick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.L1Thick.Name = "L1Thick";
            this.L1Thick.Size = new System.Drawing.Size(180, 37);
            this.L1Thick.TabIndex = 10;
            this.L1Thick.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lite 1 Thickness";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1230, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ship Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "PO Line#";
            // 
            // POLine
            // 
            this.POLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.POLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POLine.Location = new System.Drawing.Point(264, 34);
            this.POLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.POLine.Name = "POLine";
            this.POLine.Size = new System.Drawing.Size(148, 35);
            this.POLine.TabIndex = 1;
            // 
            // addTab
            // 
            this.addTab.Location = new System.Drawing.Point(4, 34);
            this.addTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTab.Size = new System.Drawing.Size(1664, 717);
            this.addTab.TabIndex = 5;
            this.addTab.Text = "   +";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(1448, 23);
            this.remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(250, 35);
            this.remove.TabIndex = 102;
            this.remove.Text = "Remove Last Tab";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(442, 23);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 35);
            this.exportButton.TabIndex = 106;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // removeNum
            // 
            this.removeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNum.Location = new System.Drawing.Point(1448, 68);
            this.removeNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeNum.Name = "removeNum";
            this.removeNum.Size = new System.Drawing.Size(177, 35);
            this.removeNum.TabIndex = 103;
            this.removeNum.Text = "Remove Tab #";
            this.removeNum.UseVisualStyleBackColor = true;
            this.removeNum.Click += new System.EventHandler(this.RemoveNum_Click);
            // 
            // removeTabNum
            // 
            this.removeTabNum.Location = new System.Drawing.Point(1634, 71);
            this.removeTabNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeTabNum.Name = "removeTabNum";
            this.removeTabNum.Size = new System.Drawing.Size(62, 26);
            this.removeTabNum.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "PO Number";
            // 
            // PODisplay
            // 
            this.PODisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODisplay.Location = new System.Drawing.Point(858, 26);
            this.PODisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PODisplay.Name = "PODisplay";
            this.PODisplay.ReadOnly = true;
            this.PODisplay.Size = new System.Drawing.Size(148, 30);
            this.PODisplay.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDIForm.Properties.Resources.ultraseal;
            this.pictureBox1.Location = new System.Drawing.Point(60, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // resequence
            // 
            this.resequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resequence.Location = new System.Drawing.Point(1150, 71);
            this.resequence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resequence.Name = "resequence";
            this.resequence.Size = new System.Drawing.Size(243, 35);
            this.resequence.TabIndex = 105;
            this.resequence.Text = "Resequence";
            this.resequence.UseVisualStyleBackColor = true;
            this.resequence.Click += new System.EventHandler(this.resequence_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1790, 946);
            this.Controls.Add(this.resequence);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PODisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTabNum);
            this.Controls.Add(this.removeNum);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.PODate);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.inputTabs);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.inputTabs.ResumeLayout(false);
            this.POLine1.ResumeLayout(false);
            this.POLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PODate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl inputTabs;
        private System.Windows.Forms.TabPage POLine1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox POLine;
        private System.Windows.Forms.ComboBox L1Thick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox L1Coat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox L1Treat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox shapeNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox baseLeg;
        private System.Windows.Forms.ComboBox L3Coat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox L3Treat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox L3Thick;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox L2Coat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox L2Treat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox L2Thick;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox openingsWide;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox MCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox partNum1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox openingsHigh;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox leftLeg;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button removeNum;
        private System.Windows.Forms.TextBox removeTabNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PODisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox gridStyle;
        private System.Windows.Forms.ComboBox gasFill;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox spacer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker shipDate;
        private System.Windows.Forms.Button resequence;
        private System.Windows.Forms.ComboBox overallThick;
    }
}