namespace FactoryCart
{
    partial class Form_Main
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
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelClient = new System.Windows.Forms.Panel();
            this.checkBoxLightON = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCartName = new System.Windows.Forms.TextBox();
            this.buttonPublishStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(545, 202);
            this.textBoxLog.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelClient);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer.Size = new System.Drawing.Size(545, 343);
            this.splitContainer.SplitterDistance = 137;
            this.splitContainer.TabIndex = 1;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.checkBoxLightON);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.textBoxCartName);
            this.panelClient.Controls.Add(this.buttonPublishStatus);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(545, 137);
            this.panelClient.TabIndex = 44;
            // 
            // checkBoxLightON
            // 
            this.checkBoxLightON.Location = new System.Drawing.Point(124, 39);
            this.checkBoxLightON.Name = "checkBoxLightON";
            this.checkBoxLightON.Size = new System.Drawing.Size(104, 24);
            this.checkBoxLightON.TabIndex = 6;
            this.checkBoxLightON.Text = "灯亮";
            this.checkBoxLightON.UseVisualStyleBackColor = true;
            this.checkBoxLightON.CheckedChanged += new System.EventHandler(this.checkBoxLightON_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "小车名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCartName
            // 
            this.textBoxCartName.Location = new System.Drawing.Point(124, 12);
            this.textBoxCartName.Name = "textBoxCartName";
            this.textBoxCartName.Size = new System.Drawing.Size(143, 21);
            this.textBoxCartName.TabIndex = 4;
            // 
            // buttonPublishStatus
            // 
            this.buttonPublishStatus.Location = new System.Drawing.Point(273, 12);
            this.buttonPublishStatus.Name = "buttonPublishStatus";
            this.buttonPublishStatus.Size = new System.Drawing.Size(87, 23);
            this.buttonPublishStatus.TabIndex = 3;
            this.buttonPublishStatus.Text = "发送状态信息";
            this.buttonPublishStatus.UseVisualStyleBackColor = true;
            this.buttonPublishStatus.Click += new System.EventHandler(this.buttonPublishStatus_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(545, 343);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form_Main";
            this.Text = "FactoryCart Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button buttonPublishStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCartName;
        private System.Windows.Forms.CheckBox checkBoxLightON;
    }
}

