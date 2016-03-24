namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientSocket = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientSocket
            // 
            this.btnClientSocket.Location = new System.Drawing.Point(407, 28);
            this.btnClientSocket.Name = "btnClientSocket";
            this.btnClientSocket.Size = new System.Drawing.Size(75, 23);
            this.btnClientSocket.TabIndex = 0;
            this.btnClientSocket.Text = "Client";
            this.btnClientSocket.UseVisualStyleBackColor = true;
            this.btnClientSocket.Click += new System.EventHandler(this.btnClientSocket_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(12, 9);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(69, 12);
            this.lblServerStatus.TabIndex = 1;
            this.lblServerStatus.Text = "UnConnected";
            // 
            // tbxContent
            // 
            this.tbxContent.Location = new System.Drawing.Point(13, 82);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxContent.Size = new System.Drawing.Size(644, 319);
            this.tbxContent.TabIndex = 2;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(34, 28);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(303, 22);
            this.txtCommand.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(513, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 431);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.tbxContent);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnClientSocket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientSocket;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnClose;
    }
}

