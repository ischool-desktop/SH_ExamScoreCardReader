namespace SH_ExamScoreCardReader
{
    partial class WarningForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTempCount = new DevComponents.DotNetBar.LabelX();
            this.btnRemoveTemp = new DevComponents.DotNetBar.ButtonX();
            this.btnAddTemp = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnGoOn = new DevComponents.DotNetBar.ButtonX();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.chID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.lblTempCount);
            this.panelEx1.Controls.Add(this.btnRemoveTemp);
            this.panelEx1.Controls.Add(this.btnAddTemp);
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.btnGoOn);
            this.panelEx1.Location = new System.Drawing.Point(0, 435);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(814, 43);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(267, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "待處理項目：";
            // 
            // lblTempCount
            // 
            this.lblTempCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lblTempCount.BackgroundStyle.Class = "";
            this.lblTempCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTempCount.Location = new System.Drawing.Point(350, 10);
            this.lblTempCount.Name = "lblTempCount";
            this.lblTempCount.Size = new System.Drawing.Size(43, 23);
            this.lblTempCount.TabIndex = 3;
            this.lblTempCount.Text = "0";
            // 
            // btnRemoveTemp
            // 
            this.btnRemoveTemp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemoveTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTemp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemoveTemp.Location = new System.Drawing.Point(136, 9);
            this.btnRemoveTemp.Name = "btnRemoveTemp";
            this.btnRemoveTemp.Size = new System.Drawing.Size(120, 25);
            this.btnRemoveTemp.TabIndex = 1;
            this.btnRemoveTemp.Text = "移出待處理";
            this.btnRemoveTemp.Click += new System.EventHandler(this.btnRemoveTemp_Click);
            // 
            // btnAddTemp
            // 
            this.btnAddTemp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTemp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddTemp.Location = new System.Drawing.Point(9, 9);
            this.btnAddTemp.Name = "btnAddTemp";
            this.btnAddTemp.Size = new System.Drawing.Size(120, 25);
            this.btnAddTemp.TabIndex = 0;
            this.btnAddTemp.Text = "加入待處理";
            this.btnAddTemp.Click += new System.EventHandler(this.btnAddTemp_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(705, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "關閉";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoOn
            // 
            this.btnGoOn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGoOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoOn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGoOn.Location = new System.Drawing.Point(578, 9);
            this.btnGoOn.Name = "btnGoOn";
            this.btnGoOn.Size = new System.Drawing.Size(120, 25);
            this.btnGoOn.TabIndex = 4;
            this.btnGoOn.Text = "繼續匯入";
            this.btnGoOn.Click += new System.EventHandler(this.btnGoOn_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chID,
            this.chItem,
            this.chMessage});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(814, 387);
            this.dgv.TabIndex = 0;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 21);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "訊息";
            // 
            // chID
            // 
            this.chID.HeaderText = "ID";
            this.chID.Name = "chID";
            this.chID.ReadOnly = true;
            this.chID.Visible = false;
            // 
            // chItem
            // 
            this.chItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chItem.HeaderText = "學生";
            this.chItem.Name = "chItem";
            this.chItem.ReadOnly = true;
            this.chItem.Width = 59;
            // 
            // chMessage
            // 
            this.chMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chMessage.HeaderText = "訊息";
            this.chMessage.Name = "chMessage";
            this.chMessage.ReadOnly = true;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 478);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "WarningForm";
            this.Text = "訊息檢視";
            this.Shown += new System.EventHandler(this.WarningForm_Shown);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnGoOn;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblTempCount;
        private DevComponents.DotNetBar.ButtonX btnRemoveTemp;
        private DevComponents.DotNetBar.ButtonX btnAddTemp;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessage;
    }
}