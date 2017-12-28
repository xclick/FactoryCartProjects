namespace FactoryCartsControlCenter
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelClient = new System.Windows.Forms.Panel();
            this.buttonRequestCartInfo = new System.Windows.Forms.Button();
            this.dataGridViewCartList = new System.Windows.Forms.DataGridView();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonTurnOnLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewCartList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer.Size = new System.Drawing.Size(614, 419);
            this.splitContainer.SplitterDistance = 195;
            this.splitContainer.TabIndex = 1;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.buttonTurnOnLight);
            this.panelClient.Controls.Add(this.buttonRequestCartInfo);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(222, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(392, 195);
            this.panelClient.TabIndex = 44;
            // 
            // buttonRequestCartInfo
            // 
            this.buttonRequestCartInfo.Location = new System.Drawing.Point(15, 12);
            this.buttonRequestCartInfo.Name = "buttonRequestCartInfo";
            this.buttonRequestCartInfo.Size = new System.Drawing.Size(75, 52);
            this.buttonRequestCartInfo.TabIndex = 3;
            this.buttonRequestCartInfo.Text = "发送获取小车信息请求";
            this.buttonRequestCartInfo.UseVisualStyleBackColor = true;
            this.buttonRequestCartInfo.Click += new System.EventHandler(this.buttonRequestCartInfo_Click);
            // 
            // dataGridViewCartList
            // 
            this.dataGridViewCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewCartList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCartList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCartList.MultiSelect = false;
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.RowTemplate.Height = 23;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(222, 195);
            this.dataGridViewCartList.TabIndex = 43;
            this.dataGridViewCartList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCartList_CellFormatting);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(614, 220);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonTurnOnLight
            // 
            this.buttonTurnOnLight.Location = new System.Drawing.Point(15, 70);
            this.buttonTurnOnLight.Name = "buttonTurnOnLight";
            this.buttonTurnOnLight.Size = new System.Drawing.Size(75, 52);
            this.buttonTurnOnLight.TabIndex = 4;
            this.buttonTurnOnLight.Text = "发送开灯指令";
            this.buttonTurnOnLight.UseVisualStyleBackColor = true;
            this.buttonTurnOnLight.Click += new System.EventHandler(this.buttonTurnOnLight_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(614, 419);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form_Main";
            this.Text = "FactoryCartsControlCenter Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button buttonRequestCartInfo;
        private System.Windows.Forms.DataGridView dataGridViewCartList;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonTurnOnLight;
    }
}

