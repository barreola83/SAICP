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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryMedicalQuerys));
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem2 = new DevComponents.DotNetBar.ProgressBarItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblNot = new DevComponents.DotNetBar.LabelItem();
            this.lblNot_2 = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clnDate = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.txtSearchByName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPatient_Name = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmdBack = new DevComponents.DotNetBar.ButtonX();
            this.dgvData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdDelete = new DevComponents.DotNetBar.ButtonX();
            this.statusBar.SuspendLayout();
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
            this.statusBar.Controls.Add(this.metroStatusBar1);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.DragDropSupport = true;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblMessage,
            this.progressBarItem1,
            this.lblBlank,
            this.lblNot,
            this.lblNot_2});
            this.statusBar.Location = new System.Drawing.Point(0, 289);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(782, 22);
            this.statusBar.TabIndex = 0;
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.progressBarItem2,
            this.labelItem2,
            this.lblDate,
            this.lblHour});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(782, 22);
            this.metroStatusBar1.TabIndex = 1;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Listo";
            // 
            // progressBarItem2
            // 
            // 
            // 
            // 
            this.progressBarItem2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem2.ChunkGradientAngle = 0F;
            this.progressBarItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem2.Name = "progressBarItem2";
            this.progressBarItem2.RecentlyUsed = false;
            this.progressBarItem2.Visible = false;
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Stretch = true;
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
            // lblNot
            // 
            this.lblNot.Name = "lblNot";
            this.lblNot.Text = "Fecha";
            // 
            // lblNot_2
            // 
            this.lblNot_2.Name = "lblNot_2";
            this.lblNot_2.Text = "Hora";
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
            this.clnDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clnDate.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.clnDate.Location = new System.Drawing.Point(12, 109);
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
            this.clnDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clnDate_DateSelected);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchByName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchByName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchByName.Border.Class = "TextBoxBorder";
            this.txtSearchByName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchByName.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchByName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.Location = new System.Drawing.Point(12, 41);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.PreventEnterBeep = true;
            this.txtSearchByName.Size = new System.Drawing.Size(226, 27);
            this.txtSearchByName.TabIndex = 2;
            this.txtSearchByName.WatermarkText = "Ingresa un nombre...";
            this.txtSearchByName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchByName_KeyDown);
            this.txtSearchByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByName_KeyPress);
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
            // cmdBack
            // 
            this.cmdBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBack.AutoSize = true;
            this.cmdBack.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.Location = new System.Drawing.Point(12, 255);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 28);
            this.cmdBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdBack.TabIndex = 7;
            this.cmdBack.Text = "Regresar";
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.folio,
            this.date});
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvData.Location = new System.Drawing.Point(279, 13);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(503, 270);
            this.dgvData.TabIndex = 8;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Número de cita";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre del paciente";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 120;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 90;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(93, 255);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(63, 28);
            this.cmdDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Eliminar";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // frmQueryMedicalQuerys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 311);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblPatient_Name);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.clnDate);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQueryMedicalQuerys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de consultas médicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryMedicalQuerys_FormClosing);
            this.Load += new System.EventHandler(this.frmQueryMedicalQuerys_Load);
            this.statusBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem lblMessage;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
        private DevComponents.DotNetBar.LabelItem lblBlank;
        private DevComponents.DotNetBar.LabelItem lblNot;
        private DevComponents.DotNetBar.LabelItem lblNot_2;
        private System.Windows.Forms.Timer timer;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv clnDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByName;
        private DevComponents.DotNetBar.LabelX lblPatient_Name;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX cmdBack;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem2;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem lblHour;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private DevComponents.DotNetBar.ButtonX cmdDelete;
    }
}