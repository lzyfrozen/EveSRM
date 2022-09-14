namespace EveSRM
{
    partial class SRMDockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNum = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBatteryPackGbtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSRM = new System.Windows.Forms.Label();
            this.cmbSRM = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrdNo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.1876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.81241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrdNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbNum);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtBatteryPackGbtCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSerialNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbSRM);
            this.panel1.Controls.Add(this.cmbSRM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 101);
            this.panel1.TabIndex = 0;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.ForeColor = System.Drawing.Color.Red;
            this.lbNum.Location = new System.Drawing.Point(24, 80);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(68, 17);
            this.lbNum.TabIndex = 6;
            this.lbNum.Text = "结果行数：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(830, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 57);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBatteryPackGbtCode
            // 
            this.txtBatteryPackGbtCode.Location = new System.Drawing.Point(365, 50);
            this.txtBatteryPackGbtCode.Name = "txtBatteryPackGbtCode";
            this.txtBatteryPackGbtCode.Size = new System.Drawing.Size(200, 23);
            this.txtBatteryPackGbtCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "电池包GBT编码：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(674, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 57);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(81, 50);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(150, 23);
            this.txtSerialNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "序列号：";
            // 
            // lbSRM
            // 
            this.lbSRM.AutoSize = true;
            this.lbSRM.Location = new System.Drawing.Point(12, 16);
            this.lbSRM.Name = "lbSRM";
            this.lbSRM.Size = new System.Drawing.Size(68, 17);
            this.lbSRM.TabIndex = 1;
            this.lbSRM.Text = "接口平台：";
            // 
            // cmbSRM
            // 
            this.cmbSRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRM.FormattingEnabled = true;
            this.cmbSRM.Location = new System.Drawing.Point(83, 12);
            this.cmbSRM.Name = "cmbSRM";
            this.cmbSRM.Size = new System.Drawing.Size(150, 25);
            this.cmbSRM.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 110);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtMessage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFeedback);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 548);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(600, 548);
            this.txtMessage.TabIndex = 4;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedback.Location = new System.Drawing.Point(0, 0);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFeedback.Size = new System.Drawing.Size(400, 548);
            this.txtFeedback.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "订单号：";
            // 
            // txtOrdNo
            // 
            this.txtOrdNo.Location = new System.Drawing.Point(365, 16);
            this.txtOrdNo.Name = "txtOrdNo";
            this.txtOrdNo.Size = new System.Drawing.Size(200, 23);
            this.txtOrdNo.TabIndex = 0;
            // 
            // SRMDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SRMDockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRMForm";
            this.Load += new System.EventHandler(this.SRMDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnSend;
        private TextBox txtBatteryPackGbtCode;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSerialNum;
        private Label label2;
        private Label lbSRM;
        private ComboBox cmbSRM;
        private SplitContainer splitContainer1;
        private TextBox txtMessage;
        private TextBox txtFeedback;
        private Label lbNum;
        private TextBox txtOrdNo;
        private Label label3;
    }
}