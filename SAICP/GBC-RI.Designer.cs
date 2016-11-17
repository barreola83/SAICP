namespace SAICP
{
    partial class frmNewEarningRecord
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
            this.lblDateNumber = new DevComponents.DotNetBar.LabelX();
            this.txtDateNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPrice = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
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
            this.statusBar.Location = new System.Drawing.Point(0, 241);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(388, 22);
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
            this.cldDate.BackgroundStyle.BackColor = System.Drawing.Color.LightBlue;
            this.cldDate.BackgroundStyle.Class = "MonthCalendarAdv";
            this.cldDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.cldDate.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cldDate.ContainerControlProcessDialogKey = true;
            this.cldDate.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.cldDate.Location = new System.Drawing.Point(208, 36);
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
            // 
            // lblSelectDate
            // 
            // 
            // 
            // 
            this.lblSelectDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSelectDate.Location = new System.Drawing.Point(208, 7);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(136, 23);
            this.lblSelectDate.TabIndex = 2;
            this.lblSelectDate.Text = "Seleccione una fecha...";
            // 
            // lblDateNumber
            // 
            // 
            // 
            // 
            this.lblDateNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDateNumber.Location = new System.Drawing.Point(12, 30);
            this.lblDateNumber.Name = "lblDateNumber";
            this.lblDateNumber.Size = new System.Drawing.Size(98, 23);
            this.lblDateNumber.TabIndex = 3;
            this.lblDateNumber.Text = "Número de cita:";
            // 
            // txtDateNumber
            // 
            this.txtDateNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDateNumber.Border.Class = "TextBoxBorder";
            this.txtDateNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDateNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtDateNumber.ForeColor = System.Drawing.Color.Black;
            this.txtDateNumber.Location = new System.Drawing.Point(12, 59);
            this.txtDateNumber.Name = "txtDateNumber";
            this.txtDateNumber.PreventEnterBeep = true;
            this.txtDateNumber.Size = new System.Drawing.Size(153, 22);
            this.txtDateNumber.TabIndex = 4;
            this.txtDateNumber.WatermarkText = "Ingrese un número de cita...";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrice.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(12, 133);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.Size = new System.Drawing.Size(117, 22);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.WatermarkText = "Ingrese el importe...";
            // 
            // lblPrice
            // 
            // 
            // 
            // 
            this.lblPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPrice.Location = new System.Drawing.Point(12, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 23);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Importe:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(208, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(289, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            // 
            // frmNewEarningRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 263);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDateNumber);
            this.Controls.Add(this.lblDateNumber);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.cldDate);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNewEarningRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Registro de ingresos por concepto de citas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewEarningRecord_FormClosed);
            this.Load += new System.EventHandler(this.frmNewEarningRecord_Load);
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
        private DevComponents.DotNetBar.LabelX lblDateNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDateNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.LabelX lblPrice;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}