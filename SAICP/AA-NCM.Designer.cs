namespace SAICP
{
    partial class frmNewMedicalDate
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
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cldDate = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.lblSelectDate = new DevComponents.DotNetBar.LabelX();
            this.tmsSelectHour = new DevComponents.Editors.DateTimeAdv.TimeSelector();
            this.lblSelectTime = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblFullName = new DevComponents.DotNetBar.LabelX();
            this.txtFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhoneNumber = new DevComponents.DotNetBar.LabelX();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.statusBar.Location = new System.Drawing.Point(0, 366);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(479, 22);
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
            this.cldDate.Location = new System.Drawing.Point(12, 167);
            this.cldDate.Name = "cldDate";
            // 
            // 
            // 
            this.cldDate.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cldDate.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cldDate.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cldDate.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cldDate.Size = new System.Drawing.Size(170, 131);
            this.cldDate.TabIndex = 1;
            this.cldDate.Text = "monthCalendarAdv1";
            this.cldDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldDate_DateSelected);
            // 
            // lblSelectDate
            // 
            // 
            // 
            // 
            this.lblSelectDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(12, 138);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(160, 23);
            this.lblSelectDate.TabIndex = 2;
            this.lblSelectDate.Text = "Seleccione una fecha...";
            // 
            // tmsSelectHour
            // 
            this.tmsSelectHour.AutoSize = true;
            // 
            // 
            // 
            this.tmsSelectHour.BackgroundStyle.Class = "ItemPanel";
            this.tmsSelectHour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tmsSelectHour.ContainerControlProcessDialogKey = true;
            this.tmsSelectHour.Location = new System.Drawing.Point(210, 167);
            this.tmsSelectHour.Name = "tmsSelectHour";
            this.tmsSelectHour.Size = new System.Drawing.Size(252, 190);
            // 
            // lblSelectTime
            // 
            // 
            // 
            // 
            this.lblSelectTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSelectTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTime.Location = new System.Drawing.Point(210, 138);
            this.lblSelectTime.Name = "lblSelectTime";
            this.lblSelectTime.Size = new System.Drawing.Size(155, 23);
            this.lblSelectTime.TabIndex = 4;
            this.lblSelectTime.Text = "Seleccione una hora...";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(97, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(16, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFullName
            // 
            // 
            // 
            // 
            this.lblFullName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 13);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(142, 23);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Nombre completo:";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFullName.Border.Class = "TextBoxBorder";
            this.txtFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFullName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(12, 42);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PreventEnterBeep = true;
            this.txtFullName.Size = new System.Drawing.Size(309, 27);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.WatermarkText = "Ingrese el nombre completo del paciente...";
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // lblPhoneNumber
            // 
            // 
            // 
            // 
            this.lblPhoneNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 75);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(160, 23);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Teléfono de contacto";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhoneNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 104);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(231, 27);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.WatermarkText = "Ingrese un número de teléfono...";
            // 
            // frmNewMedicalDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 388);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.tmsSelectHour);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.cldDate);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNewMedicalDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Nueva cita médica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewMedicalDate_FormClosing);
            this.Load += new System.EventHandler(this.frmNewMedicalDate_Load);
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
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv cldDate;
        private DevComponents.DotNetBar.LabelX lblSelectDate;
        private DevComponents.Editors.DateTimeAdv.TimeSelector tmsSelectHour;
        private DevComponents.DotNetBar.LabelX lblSelectTime;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX lblFullName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullName;
        private DevComponents.DotNetBar.LabelX lblPhoneNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
    }
}