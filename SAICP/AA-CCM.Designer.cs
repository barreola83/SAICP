namespace SAICP
{
    partial class frmQueryMedicalDates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dgvData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldDate = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.lblSelectDate = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblSearchByName = new DevComponents.DotNetBar.LabelX();
            this.txtSearchByName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            // 
            // 
            // 
            this.statusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusBar.ContainerControlProcessDialogKey = true;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.DragDropSupport = true;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblMessage,
            this.progressBarItem1,
            this.lblBlank,
            this.lblDate,
            this.lblHour});
            this.statusBar.Location = new System.Drawing.Point(0, 283);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(789, 22);
            this.statusBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Text = "Listo";
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            this.progressBarItem1.Visible = false;
            // 
            // lblBlank
            // 
            this.lblBlank.Name = "lblBlank";
            this.lblBlank.Stretch = true;
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Fecha";
            // 
            // lblHour
            // 
            this.lblHour.Name = "lblHour";
            this.lblHour.Text = "Hora";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvDate,
            this.dgvTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvData.Location = new System.Drawing.Point(290, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(493, 260);
            this.dgvData.TabIndex = 1;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Nombre";
            this.dgvName.Name = "dgvName";
            this.dgvName.Width = 250;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Fecha";
            this.dgvDate.Name = "dgvDate";
            // 
            // dgvTime
            // 
            this.dgvTime.HeaderText = "Hora";
            this.dgvTime.Name = "dgvTime";
            // 
            // cldDate
            // 
            this.cldDate.AutoSize = true;
            // 
            // 
            // 
            this.cldDate.BackgroundStyle.Class = "MonthCalendarAdv";
            this.cldDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.cldDate.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cldDate.ContainerControlProcessDialogKey = true;
            this.cldDate.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.cldDate.Location = new System.Drawing.Point(24, 104);
            this.cldDate.Name = "cldDate";
            // 
            // 
            // 
            this.cldDate.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cldDate.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cldDate.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cldDate.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cldDate.Size = new System.Drawing.Size(170, 131);
            this.cldDate.TabIndex = 2;
            this.cldDate.Text = "monthCalendarAdv1";
            // 
            // lblSelectDate
            // 
            // 
            // 
            // 
            this.lblSelectDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(24, 75);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(170, 23);
            this.lblSelectDate.TabIndex = 3;
            this.lblSelectDate.Text = "Seleccione una fecha...";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(93, 249);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            // 
            // lblSearchByName
            // 
            // 
            // 
            // 
            this.lblSearchByName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSearchByName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(12, 5);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(160, 23);
            this.lblSearchByName.TabIndex = 6;
            this.lblSearchByName.Text = "Buscar por nombre...";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchByName.Border.Class = "TextBoxBorder";
            this.txtSearchByName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchByName.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchByName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.Location = new System.Drawing.Point(12, 34);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.PreventEnterBeep = true;
            this.txtSearchByName.Size = new System.Drawing.Size(257, 27);
            this.txtSearchByName.TabIndex = 7;
            this.txtSearchByName.WatermarkText = "Ingresa un nombre...";
            this.txtSearchByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByName_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(174, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            // 
            // frmQueryMedicalDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 305);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.cldDate);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQueryMedicalDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Consulta de citas m�dicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryMedicalDates_FormClosing);
            this.Load += new System.EventHandler(this.frmQueryMedicalDates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem lblMessage;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
        private DevComponents.DotNetBar.LabelItem lblBlank;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem lblHour;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv cldDate;
        private DevComponents.DotNetBar.LabelX lblSelectDate;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblSearchByName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByName;
        private DevComponents.DotNetBar.ButtonX btnDelete;
    }
}