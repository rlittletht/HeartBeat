namespace HeartBeat
{
    partial class t
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
            System.Windows.Forms.Label m_stStatus;
            this.m_pbStart = new System.Windows.Forms.Button();
            this.m_ebStatus = new System.Windows.Forms.TextBox();
            this.m_ebLastResponse = new System.Windows.Forms.TextBox();
            m_stStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_stStatus
            // 
            m_stStatus.AutoSize = true;
            m_stStatus.Location = new System.Drawing.Point(13, 13);
            m_stStatus.Name = "m_stStatus";
            m_stStatus.Size = new System.Drawing.Size(37, 13);
            m_stStatus.TabIndex = 1;
            m_stStatus.Text = "Status";
            // 
            // m_pbStart
            // 
            this.m_pbStart.Location = new System.Drawing.Point(298, 12);
            this.m_pbStart.Name = "m_pbStart";
            this.m_pbStart.Size = new System.Drawing.Size(75, 23);
            this.m_pbStart.TabIndex = 0;
            this.m_pbStart.Text = "Start";
            this.m_pbStart.UseVisualStyleBackColor = true;
            this.m_pbStart.Click += new System.EventHandler(this.StartHeartbeat);
            // 
            // m_ebStatus
            // 
            this.m_ebStatus.Location = new System.Drawing.Point(56, 10);
            this.m_ebStatus.Name = "m_ebStatus";
            this.m_ebStatus.Size = new System.Drawing.Size(182, 20);
            this.m_ebStatus.TabIndex = 2;
            // 
            // m_ebLastResponse
            // 
            this.m_ebLastResponse.Location = new System.Drawing.Point(12, 36);
            this.m_ebLastResponse.Name = "m_ebLastResponse";
            this.m_ebLastResponse.Size = new System.Drawing.Size(361, 20);
            this.m_ebLastResponse.TabIndex = 3;
            // 
            // t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 94);
            this.Controls.Add(this.m_ebLastResponse);
            this.Controls.Add(this.m_ebStatus);
            this.Controls.Add(m_stStatus);
            this.Controls.Add(this.m_pbStart);
            this.Name = "t";
            this.Text = "Service HeartBeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_pbStart;
        private System.Windows.Forms.TextBox m_ebStatus;
        private System.Windows.Forms.TextBox m_ebLastResponse;
    }
}

