namespace K3Key
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.m_VirtualWinKeyChoice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_VirtualK3Choice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_K3SerialChoice = new System.Windows.Forms.ComboBox();
            this.m_VirtualWinKeyStatus = new System.Windows.Forms.Label();
            this.m_VirtualK3Status = new System.Windows.Forms.Label();
            this.m_K3SerialStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.m_CATSpeed = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.m_VirtualWinKeyChoice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_VirtualK3Choice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_K3SerialChoice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_VirtualWinKeyStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.m_VirtualK3Status, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_K3SerialStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.m_CATSpeed, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 236);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.tableLayoutPanel1.SetRowSpan(this.label5, 2);
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Virtual WinKey port:";
            // 
            // m_VirtualWinKeyChoice
            // 
            this.m_VirtualWinKeyChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_VirtualWinKeyChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_VirtualWinKeyChoice.FormattingEnabled = true;
            this.m_VirtualWinKeyChoice.Location = new System.Drawing.Point(119, 141);
            this.m_VirtualWinKeyChoice.Name = "m_VirtualWinKeyChoice";
            this.m_VirtualWinKeyChoice.Size = new System.Drawing.Size(172, 21);
            this.m_VirtualWinKeyChoice.TabIndex = 7;
            this.m_VirtualWinKeyChoice.SelectedIndexChanged += new System.EventHandler(this.WinKeyPortChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 139);
            this.label6.Name = "label6";
            this.tableLayoutPanel1.SetRowSpan(this.label6, 2);
            this.label6.Size = new System.Drawing.Size(172, 52);
            this.label6.TabIndex = 6;
            this.label6.Text = "One half of the VCP pair that will emulate a WinKey. Connect the other side of th" +
    "is pair to WinKey in Win-Test.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.tableLayoutPanel1.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Virtual radio port:";
            // 
            // m_VirtualK3Choice
            // 
            this.m_VirtualK3Choice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_VirtualK3Choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_VirtualK3Choice.FormattingEnabled = true;
            this.m_VirtualK3Choice.Location = new System.Drawing.Point(119, 75);
            this.m_VirtualK3Choice.Name = "m_VirtualK3Choice";
            this.m_VirtualK3Choice.Size = new System.Drawing.Size(172, 21);
            this.m_VirtualK3Choice.TabIndex = 4;
            this.m_VirtualK3Choice.SelectedIndexChanged += new System.EventHandler(this.BridgePortChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 73);
            this.label4.Name = "label4";
            this.tableLayoutPanel1.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(172, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "One half of the Virtual COM Port pair that will pretend to be a radio. Connect th" +
    "e other side of this pair to \"Radio 1\" in Win-Test.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.tableLayoutPanel1.SetRowSpan(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(172, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "The serial port that your radio is connected to (perhaps via a USB to RS232 conve" +
    "rter)";
            // 
            // m_K3SerialChoice
            // 
            this.m_K3SerialChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_K3SerialChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_K3SerialChoice.FormattingEnabled = true;
            this.m_K3SerialChoice.Location = new System.Drawing.Point(119, 9);
            this.m_K3SerialChoice.Name = "m_K3SerialChoice";
            this.m_K3SerialChoice.Size = new System.Drawing.Size(172, 21);
            this.m_K3SerialChoice.TabIndex = 1;
            this.m_K3SerialChoice.SelectedIndexChanged += new System.EventHandler(this.BridgePortChanged);
            // 
            // m_VirtualWinKeyStatus
            // 
            this.m_VirtualWinKeyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_VirtualWinKeyStatus.AutoSize = true;
            this.m_VirtualWinKeyStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_VirtualWinKeyStatus.Location = new System.Drawing.Point(119, 165);
            this.m_VirtualWinKeyStatus.Name = "m_VirtualWinKeyStatus";
            this.m_VirtualWinKeyStatus.Size = new System.Drawing.Size(172, 13);
            this.m_VirtualWinKeyStatus.TabIndex = 13;
            this.m_VirtualWinKeyStatus.Text = "Not connected";
            // 
            // m_VirtualK3Status
            // 
            this.m_VirtualK3Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_VirtualK3Status.AutoSize = true;
            this.m_VirtualK3Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_VirtualK3Status.Location = new System.Drawing.Point(119, 99);
            this.m_VirtualK3Status.Name = "m_VirtualK3Status";
            this.m_VirtualK3Status.Size = new System.Drawing.Size(172, 13);
            this.m_VirtualK3Status.TabIndex = 12;
            this.m_VirtualK3Status.Text = "Not connected";
            // 
            // m_K3SerialStatus
            // 
            this.m_K3SerialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_K3SerialStatus.AutoSize = true;
            this.m_K3SerialStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_K3SerialStatus.Location = new System.Drawing.Point(119, 33);
            this.m_K3SerialStatus.Name = "m_K3SerialStatus";
            this.m_K3SerialStatus.Size = new System.Drawing.Size(172, 13);
            this.m_K3SerialStatus.TabIndex = 11;
            this.m_K3SerialStatus.Text = "Not connected";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rig serial port:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 280);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Virtual COM Port (com0com)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CAT Speed:";
            // 
            // m_CATSpeed
            // 
            this.m_CATSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.m_CATSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CATSpeed.FormattingEnabled = true;
            this.m_CATSpeed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.m_CATSpeed.Location = new System.Drawing.Point(119, 206);
            this.m_CATSpeed.Name = "m_CATSpeed";
            this.m_CATSpeed.Size = new System.Drawing.Size(172, 21);
            this.m_CATSpeed.TabIndex = 15;
            this.m_CATSpeed.SelectedIndexChanged += new System.EventHandler(this.CATSpeedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 302);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "M0VFC K3Key";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox m_VirtualWinKeyChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_VirtualK3Choice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_K3SerialChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_K3SerialStatus;
        private System.Windows.Forms.Label m_VirtualK3Status;
        private System.Windows.Forms.Label m_VirtualWinKeyStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox m_CATSpeed;
    }
}

