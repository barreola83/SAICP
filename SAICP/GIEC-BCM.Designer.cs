namespace SAICP
{
    partial class frmQueryMedicalQuerys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clnDate = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.txtPatient_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPatient_Name = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmdSearch = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmdCancel = new DevComponents.DotNetBar.ButtonX();
            this.Patient_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
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
            this.statusBar.Location = new System.Drawing.Point(0, 289);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(584, 22);
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
            // clnDate
            // 
            this.clnDate.AutoSize = true;
            // 
            // 
            // 
            this.clnDate.BackgroundStyle.Class = "MonthCalendarAdv";
            this.clnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.clnDate.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.clnDate.ContainerControlProcessDialogKey = true;
            this.clnDate.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.clnDate.Location = new System.Drawing.Point(36, 109);
            this.clnDate.Name = "clnDate";
            // 
            // 
            // 
            this.clnDate.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.clnDate.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.clnDate.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.clnDate.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.clnDate.Size = new System.Drawing.Size(170, 131);
            this.clnDate.TabIndex = 1;
            this.clnDate.Text = "monthCalendarAdv1";
            // 
            // txtPatient_Name
            // 
            this.txtPatient_Name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatient_Name.Border.Class = "TextBoxBorder";
            this.txtPatient_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatient_Name.DisabledBackColor = System.Drawing.Color.White;
            this.txtPatient_Name.ForeColor = System.Drawing.Color.Black;
            this.txtPatient_Name.Location = new System.Drawing.Point(12, 41);
            this.txtPatient_Name.Name = "txtPatient_Name";
            this.txtPatient_Name.PreventEnterBeep = true;
            this.txtPatient_Name.Size = new System.Drawing.Size(226, 22);
            this.txtPatient_Name.TabIndex = 2;
            // 
            // lblPatient_Name
            // 
            // 
            // 
            // 
            this.lblPatient_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPatient_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient_Name.Location = new System.Drawing.Point(12, 12);
            this.lblPatient_Name.Name = "lblPatient_Name";
            this.lblPatient_Name.Size = new System.Drawing.Size(170, 23);
            this.lblPatient_Name.TabIndex = 3;
            this.lblPatient_Name.Text = "Nombre del paciente:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 80);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(170, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Seleccione una fecha...";
            // 
            // cmdSearch
            // 
            this.cmdSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(497, 260);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "Buscar";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient_Name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(270, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(302, 242);
            this.dataGridViewX1.TabIndex = 6;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(396, 260);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancelar";
            // 
            // Patient_Name
            // 
            this.Patient_Name.HeaderText = "Nombre del paciente";
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Width = 259;
            // 
            // frmQueryMedicalQuerys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblPatient_Name);
            this.Controls.Add(this.txtPatient_Name);
            this.Controls.Add(this.clnDate);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQueryMedicalQuerys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de consultas médicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryMedicalQuerys_FormClosing);
            this.Load += new System.EventHandler(this.frmQueryMedicalQuerys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
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
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv clnDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatient_Name;
        private DevComponents.DotNetBar.LabelX lblPatient_Name;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX cmdSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX cmdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_Name;
    }
}