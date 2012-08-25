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
            this.m_Connect = new System.Windows.Forms.Button();
            this.m_RtfRadio = new System.Windows.Forms.RichTextBox();
            this.m_RtfWinKey = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // m_Connect
            // 
            this.m_Connect.Location = new System.Drawing.Point(12, 12);
            this.m_Connect.Name = "m_Connect";
            this.m_Connect.Size = new System.Drawing.Size(75, 23);
            this.m_Connect.TabIndex = 0;
            this.m_Connect.Text = "Connect";
            this.m_Connect.UseVisualStyleBackColor = true;
            this.m_Connect.Click += new System.EventHandler(this.m_Connect_Click);
            // 
            // m_RtfRadio
            // 
            this.m_RtfRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_RtfRadio.Location = new System.Drawing.Point(12, 41);
            this.m_RtfRadio.Name = "m_RtfRadio";
            this.m_RtfRadio.Size = new System.Drawing.Size(585, 175);
            this.m_RtfRadio.TabIndex = 1;
            this.m_RtfRadio.Text = "";
            // 
            // m_RtfWinKey
            // 
            this.m_RtfWinKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_RtfWinKey.Location = new System.Drawing.Point(12, 222);
            this.m_RtfWinKey.Name = "m_RtfWinKey";
            this.m_RtfWinKey.Size = new System.Drawing.Size(585, 175);
            this.m_RtfWinKey.TabIndex = 2;
            this.m_RtfWinKey.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 408);
            this.Controls.Add(this.m_RtfWinKey);
            this.Controls.Add(this.m_RtfRadio);
            this.Controls.Add(this.m_Connect);
            this.Name = "MainForm";
            this.Text = "K3Key";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_Connect;
        private System.Windows.Forms.RichTextBox m_RtfRadio;
        private System.Windows.Forms.RichTextBox m_RtfWinKey;
    }
}

