using System;

namespace SAICP
{
    partial class frmUpdateMedicalQuery
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMedicalQuery));
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.pgrSaving = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stcGeneral_Data = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dgvPercentilTable = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiTable = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtFolio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtHead_Circunference = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIMC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSize = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWeight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblxTreatment = new DevComponents.DotNetBar.LabelX();
            this.lblxDiagnostic = new DevComponents.DotNetBar.LabelX();
            this.lblxPhysical_Exploration = new DevComponents.DotNetBar.LabelX();
            this.txtReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTreatment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiagnostic = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhysical_Exploration = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblxReason = new DevComponents.DotNetBar.LabelX();
            this.lblxHead_Circunference = new DevComponents.DotNetBar.LabelX();
            this.lblxIMC = new DevComponents.DotNetBar.LabelX();
            this.lblxSize = new DevComponents.DotNetBar.LabelX();
            this.lblxWeight = new DevComponents.DotNetBar.LabelX();
            this.lblxName = new DevComponents.DotNetBar.LabelX();
            this.stiGeneral_Data = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.chrSize = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sptSize = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.chrIMC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sptIMC = new DevComponents.DotNetBar.SuperTabItem();
            this.stiGraphics = new DevComponents.DotNetBar.SuperTabItem();
            this.cmdCancel = new DevComponents.DotNetBar.ButtonX();
            this.cmdSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblMedicalQueryDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.stcGeneral_Data)).BeginInit();
            this.stcGeneral_Data.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercentilTable)).BeginInit();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSize)).BeginInit();
            this.superTabControlPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrIMC)).BeginInit();
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
            this.pgrSaving,
            this.lblBlank,
            this.lblDate,
            this.lblHour});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Text = "Listo";
            // 
            // pgrSaving
            // 
            // 
            // 
            // 
            this.pgrSaving.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pgrSaving.ChunkGradientAngle = 0F;
            this.pgrSaving.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.pgrSaving.Name = "pgrSaving";
            this.pgrSaving.RecentlyUsed = false;
            this.pgrSaving.Visible = false;
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
            // stcGeneral_Data
            // 
            this.stcGeneral_Data.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.stcGeneral_Data.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.stcGeneral_Data.ControlBox.MenuBox.Name = "";
            this.stcGeneral_Data.ControlBox.Name = "";
            this.stcGeneral_Data.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stcGeneral_Data.ControlBox.MenuBox,
            this.stcGeneral_Data.ControlBox.CloseBox});
            this.stcGeneral_Data.Controls.Add(this.superTabControlPanel1);
            this.stcGeneral_Data.Controls.Add(this.superTabControlPanel2);
            this.stcGeneral_Data.Controls.Add(this.superTabControlPanel3);
            this.stcGeneral_Data.ForeColor = System.Drawing.Color.Black;
            this.stcGeneral_Data.Location = new System.Drawing.Point(12, 33);
            this.stcGeneral_Data.Name = "stcGeneral_Data";
            this.stcGeneral_Data.ReorderTabsEnabled = true;
            this.stcGeneral_Data.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.stcGeneral_Data.SelectedTabIndex = 0;
            this.stcGeneral_Data.Size = new System.Drawing.Size(760, 430);
            this.stcGeneral_Data.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stcGeneral_Data.TabIndex = 1;
            this.stcGeneral_Data.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiGeneral_Data,
            this.stiGraphics,
            this.stiTable});
            this.stcGeneral_Data.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.stcGeneral_Data.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.dgvPercentilTable);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(760, 405);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.stiTable;
            // 
            // dgvPercentilTable
            // 
            this.dgvPercentilTable.AllowUserToDeleteRows = false;
            this.dgvPercentilTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercentilTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.weight,
            this.standardWeight,
            this.size,
            this.standardSize});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPercentilTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPercentilTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvPercentilTable.Location = new System.Drawing.Point(4, 4);
            this.dgvPercentilTable.Name = "dgvPercentilTable";
            this.dgvPercentilTable.ReadOnly = true;
            this.dgvPercentilTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPercentilTable.Size = new System.Drawing.Size(753, 398);
            this.dgvPercentilTable.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre del paciente";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 210;
            // 
            // age
            // 
            this.age.HeaderText = "Edad";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.HeaderText = "Peso";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // standardWeight
            // 
            this.standardWeight.HeaderText = "Peso estándar";
            this.standardWeight.Name = "standardWeight";
            this.standardWeight.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Talla";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // standardSize
            // 
            this.standardSize.HeaderText = "Talla estándar";
            this.standardSize.Name = "standardSize";
            this.standardSize.ReadOnly = true;
            // 
            // stiTable
            // 
            this.stiTable.AttachedControl = this.superTabControlPanel3;
            this.stiTable.GlobalItem = false;
            this.stiTable.Name = "stiTable";
            this.stiTable.Text = "Tabla";
            this.stiTable.Click += new System.EventHandler(this.stiTable_Click);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.txtFolio);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Controls.Add(this.txtHead_Circunference);
            this.superTabControlPanel1.Controls.Add(this.txtIMC);
            this.superTabControlPanel1.Controls.Add(this.txtSize);
            this.superTabControlPanel1.Controls.Add(this.txtWeight);
            this.superTabControlPanel1.Controls.Add(this.txtName);
            this.superTabControlPanel1.Controls.Add(this.lblxTreatment);
            this.superTabControlPanel1.Controls.Add(this.lblxDiagnostic);
            this.superTabControlPanel1.Controls.Add(this.lblxPhysical_Exploration);
            this.superTabControlPanel1.Controls.Add(this.txtReason);
            this.superTabControlPanel1.Controls.Add(this.txtTreatment);
            this.superTabControlPanel1.Controls.Add(this.txtDiagnostic);
            this.superTabControlPanel1.Controls.Add(this.txtPhysical_Exploration);
            this.superTabControlPanel1.Controls.Add(this.lblxReason);
            this.superTabControlPanel1.Controls.Add(this.lblxHead_Circunference);
            this.superTabControlPanel1.Controls.Add(this.lblxIMC);
            this.superTabControlPanel1.Controls.Add(this.lblxSize);
            this.superTabControlPanel1.Controls.Add(this.lblxWeight);
            this.superTabControlPanel1.Controls.Add(this.lblxName);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(760, 405);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.stiGeneral_Data;
            // 
            // txtFolio
            // 
            this.txtFolio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFolio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFolio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFolio.Border.Class = "TextBoxBorder";
            this.txtFolio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFolio.DisabledBackColor = System.Drawing.Color.White;
            this.txtFolio.Enabled = false;
            this.txtFolio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.ForeColor = System.Drawing.Color.Black;
            this.txtFolio.Location = new System.Drawing.Point(88, 51);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.PreventEnterBeep = true;
            this.txtFolio.Size = new System.Drawing.Size(268, 25);
            this.txtFolio.TabIndex = 22;
            this.txtFolio.WatermarkText = "Ingrese el folio....";
            this.txtFolio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFolio_KeyDown);
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 49);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 22);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "Folio:";
            // 
            // txtHead_Circunference
            // 
            this.txtHead_Circunference.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHead_Circunference.Border.Class = "TextBoxBorder";
            this.txtHead_Circunference.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHead_Circunference.DisabledBackColor = System.Drawing.Color.White;
            this.txtHead_Circunference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHead_Circunference.ForeColor = System.Drawing.Color.Black;
            this.txtHead_Circunference.Location = new System.Drawing.Point(88, 227);
            this.txtHead_Circunference.Name = "txtHead_Circunference";
            this.txtHead_Circunference.PreventEnterBeep = true;
            this.txtHead_Circunference.Size = new System.Drawing.Size(70, 25);
            this.txtHead_Circunference.TabIndex = 20;
            this.txtHead_Circunference.WatermarkText = "...";
            this.txtHead_Circunference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHead_Circunference_KeyPress);
            // 
            // txtIMC
            // 
            this.txtIMC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIMC.Border.Class = "TextBoxBorder";
            this.txtIMC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIMC.DisabledBackColor = System.Drawing.Color.White;
            this.txtIMC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.ForeColor = System.Drawing.Color.Black;
            this.txtIMC.Location = new System.Drawing.Point(88, 178);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.PreventEnterBeep = true;
            this.txtIMC.Size = new System.Drawing.Size(70, 25);
            this.txtIMC.TabIndex = 19;
            this.txtIMC.WatermarkText = "...";
            this.txtIMC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMC_KeyPress);
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSize.Border.Class = "TextBoxBorder";
            this.txtSize.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSize.DisabledBackColor = System.Drawing.Color.White;
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.Black;
            this.txtSize.Location = new System.Drawing.Point(88, 133);
            this.txtSize.Name = "txtSize";
            this.txtSize.PreventEnterBeep = true;
            this.txtSize.Size = new System.Drawing.Size(70, 25);
            this.txtSize.TabIndex = 18;
            this.txtSize.WatermarkText = "...";
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWeight.Border.Class = "TextBoxBorder";
            this.txtWeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWeight.DisabledBackColor = System.Drawing.Color.White;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.Location = new System.Drawing.Point(88, 89);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PreventEnterBeep = true;
            this.txtWeight.Size = new System.Drawing.Size(70, 25);
            this.txtWeight.TabIndex = 17;
            this.txtWeight.WatermarkText = "...";
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.DisabledBackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(88, 9);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(268, 25);
            this.txtName.TabIndex = 15;
            this.txtName.WatermarkText = "Ingrese el nombre del paciente...";
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblxTreatment
            // 
            this.lblxTreatment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxTreatment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxTreatment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxTreatment.Location = new System.Drawing.Point(388, 269);
            this.lblxTreatment.Name = "lblxTreatment";
            this.lblxTreatment.Size = new System.Drawing.Size(92, 19);
            this.lblxTreatment.TabIndex = 14;
            this.lblxTreatment.Text = "Tratamiento:";
            // 
            // lblxDiagnostic
            // 
            this.lblxDiagnostic.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxDiagnostic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxDiagnostic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxDiagnostic.Location = new System.Drawing.Point(388, 139);
            this.lblxDiagnostic.Name = "lblxDiagnostic";
            this.lblxDiagnostic.Size = new System.Drawing.Size(92, 19);
            this.lblxDiagnostic.TabIndex = 13;
            this.lblxDiagnostic.Text = "Diagnóstico:";
            // 
            // lblxPhysical_Exploration
            // 
            this.lblxPhysical_Exploration.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxPhysical_Exploration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxPhysical_Exploration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxPhysical_Exploration.Location = new System.Drawing.Point(388, 9);
            this.lblxPhysical_Exploration.Name = "lblxPhysical_Exploration";
            this.lblxPhysical_Exploration.Size = new System.Drawing.Size(92, 37);
            this.lblxPhysical_Exploration.TabIndex = 12;
            this.lblxPhysical_Exploration.Text = "Exploración \r\nfísica:";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtReason.Border.Class = "TextBoxBorder";
            this.txtReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReason.DisabledBackColor = System.Drawing.Color.White;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.Black;
            this.txtReason.Location = new System.Drawing.Point(88, 269);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PreventEnterBeep = true;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReason.Size = new System.Drawing.Size(268, 124);
            this.txtReason.TabIndex = 11;
            this.txtReason.WatermarkText = "Ingrese el motivo de la consulta...";
            this.txtReason.WordWrap = false;
            // 
            // txtTreatment
            // 
            this.txtTreatment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTreatment.Border.Class = "TextBoxBorder";
            this.txtTreatment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatment.DisabledBackColor = System.Drawing.Color.White;
            this.txtTreatment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatment.ForeColor = System.Drawing.Color.Black;
            this.txtTreatment.Location = new System.Drawing.Point(489, 269);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.PreventEnterBeep = true;
            this.txtTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTreatment.Size = new System.Drawing.Size(268, 124);
            this.txtTreatment.TabIndex = 10;
            this.txtTreatment.WatermarkText = "Ingrese el tratamiento del paciente...";
            this.txtTreatment.WordWrap = false;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiagnostic.Border.Class = "TextBoxBorder";
            this.txtDiagnostic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiagnostic.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiagnostic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostic.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnostic.Location = new System.Drawing.Point(489, 139);
            this.txtDiagnostic.Multiline = true;
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.PreventEnterBeep = true;
            this.txtDiagnostic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiagnostic.Size = new System.Drawing.Size(268, 124);
            this.txtDiagnostic.TabIndex = 9;
            this.txtDiagnostic.WatermarkText = "Ingrese el diagnóstico del paciente...";
            this.txtDiagnostic.WordWrap = false;
            // 
            // txtPhysical_Exploration
            // 
            this.txtPhysical_Exploration.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhysical_Exploration.Border.Class = "TextBoxBorder";
            this.txtPhysical_Exploration.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhysical_Exploration.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhysical_Exploration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysical_Exploration.ForeColor = System.Drawing.Color.Black;
            this.txtPhysical_Exploration.Location = new System.Drawing.Point(489, 9);
            this.txtPhysical_Exploration.Multiline = true;
            this.txtPhysical_Exploration.Name = "txtPhysical_Exploration";
            this.txtPhysical_Exploration.PreventEnterBeep = true;
            this.txtPhysical_Exploration.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPhysical_Exploration.Size = new System.Drawing.Size(268, 124);
            this.txtPhysical_Exploration.TabIndex = 8;
            this.txtPhysical_Exploration.WatermarkText = "Ingrese la exploración física del paciente...";
            this.txtPhysical_Exploration.WordWrap = false;
            // 
            // lblxReason
            // 
            this.lblxReason.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxReason.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxReason.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxReason.Location = new System.Drawing.Point(3, 269);
            this.lblxReason.Name = "lblxReason";
            this.lblxReason.Size = new System.Drawing.Size(53, 19);
            this.lblxReason.TabIndex = 6;
            this.lblxReason.Text = "Motivo:";
            // 
            // lblxHead_Circunference
            // 
            this.lblxHead_Circunference.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxHead_Circunference.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxHead_Circunference.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxHead_Circunference.Location = new System.Drawing.Point(3, 218);
            this.lblxHead_Circunference.Name = "lblxHead_Circunference";
            this.lblxHead_Circunference.Size = new System.Drawing.Size(86, 36);
            this.lblxHead_Circunference.TabIndex = 5;
            this.lblxHead_Circunference.Text = "Perímetro \r\ncefálico:";
            // 
            // lblxIMC
            // 
            this.lblxIMC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxIMC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxIMC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxIMC.Location = new System.Drawing.Point(3, 176);
            this.lblxIMC.Name = "lblxIMC";
            this.lblxIMC.Size = new System.Drawing.Size(75, 23);
            this.lblxIMC.TabIndex = 4;
            this.lblxIMC.Text = "IMC:";
            // 
            // lblxSize
            // 
            this.lblxSize.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxSize.Location = new System.Drawing.Point(3, 133);
            this.lblxSize.Name = "lblxSize";
            this.lblxSize.Size = new System.Drawing.Size(75, 19);
            this.lblxSize.TabIndex = 3;
            this.lblxSize.Text = "Talla:";
            // 
            // lblxWeight
            // 
            this.lblxWeight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxWeight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxWeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxWeight.Location = new System.Drawing.Point(3, 89);
            this.lblxWeight.Name = "lblxWeight";
            this.lblxWeight.Size = new System.Drawing.Size(75, 18);
            this.lblxWeight.TabIndex = 2;
            this.lblxWeight.Text = "Peso:";
            // 
            // lblxName
            // 
            this.lblxName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblxName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxName.Location = new System.Drawing.Point(3, 9);
            this.lblxName.Name = "lblxName";
            this.lblxName.Size = new System.Drawing.Size(75, 23);
            this.lblxName.TabIndex = 0;
            this.lblxName.Text = "Nombre:";
            // 
            // stiGeneral_Data
            // 
            this.stiGeneral_Data.AttachedControl = this.superTabControlPanel1;
            this.stiGeneral_Data.GlobalItem = false;
            this.stiGeneral_Data.Name = "stiGeneral_Data";
            this.stiGeneral_Data.Text = "Datos generales";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.superTabControl1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(760, 405);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.stiGraphics;
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel5);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(3, 3);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(754, 399);
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sptSize,
            this.sptIMC});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.Text = "data";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.chrSize);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(754, 374);
            this.superTabControlPanel4.TabIndex = 1;
            this.superTabControlPanel4.TabItem = this.sptSize;
            // 
            // chrSize
            // 
            chartArea1.Name = "ChartArea1";
            this.chrSize.ChartAreas.Add(chartArea1);
            this.chrSize.Location = new System.Drawing.Point(4, 4);
            this.chrSize.Name = "chrSize";
            this.chrSize.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chrSize.Size = new System.Drawing.Size(747, 367);
            this.chrSize.TabIndex = 0;
            this.chrSize.Text = "chart2";
            // 
            // sptSize
            // 
            this.sptSize.AttachedControl = this.superTabControlPanel4;
            this.sptSize.GlobalItem = false;
            this.sptSize.Name = "sptSize";
            this.sptSize.Text = "Talla";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Controls.Add(this.chrIMC);
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(754, 374);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.sptIMC;
            // 
            // chrIMC
            // 
            chartArea2.Name = "ChartArea1";
            this.chrIMC.ChartAreas.Add(chartArea2);
            this.chrIMC.Location = new System.Drawing.Point(4, 4);
            this.chrIMC.Name = "chrIMC";
            this.chrIMC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chrIMC.Size = new System.Drawing.Size(747, 367);
            this.chrIMC.TabIndex = 0;
            this.chrIMC.Text = "chart1";
            // 
            // sptIMC
            // 
            this.sptIMC.AttachedControl = this.superTabControlPanel5;
            this.sptIMC.GlobalItem = false;
            this.sptIMC.Name = "sptIMC";
            this.sptIMC.Text = "IMC";
            // 
            // stiGraphics
            // 
            this.stiGraphics.AttachedControl = this.superTabControlPanel2;
            this.stiGraphics.GlobalItem = false;
            this.stiGraphics.Name = "stiGraphics";
            this.stiGraphics.Text = "Gráficas";
            this.stiGraphics.Click += new System.EventHandler(this.stiGraphics_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(616, 469);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 24);
            this.cmdCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(697, 469);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 24);
            this.cmdSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Guardar";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(12, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 22);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "Fecha:";
            // 
            // lblMedicalQueryDate
            // 
            this.lblMedicalQueryDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblMedicalQueryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMedicalQueryDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalQueryDate.Location = new System.Drawing.Point(62, 4);
            this.lblMedicalQueryDate.Name = "lblMedicalQueryDate";
            this.lblMedicalQueryDate.Size = new System.Drawing.Size(108, 22);
            this.lblMedicalQueryDate.TabIndex = 24;
            // 
            // frmUpdateMedicalQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.lblMedicalQueryDate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.stcGeneral_Data);
            this.Controls.Add(this.statusBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateMedicalQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Nueva consulta médica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewMedicalQuery_FormClosing);
            this.Load += new System.EventHandler(this.frmNewMedicalQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stcGeneral_Data)).EndInit();
            this.stcGeneral_Data.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercentilTable)).EndInit();
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel1.PerformLayout();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrSize)).EndInit();
            this.superTabControlPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chtIMC_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chtSize_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxX8_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxX7_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxX6_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxX5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblxTreatment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtxTreatment_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxDiagnostic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtxDiagnostic_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxPhysical_exploration_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtxPhysical_exploration_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtxReason_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxReason_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxhHead_Circunference_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblxIMC_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxSize_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxDate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxWeight_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblxName_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem lblMessage;
        private DevComponents.DotNetBar.ProgressBarItem pgrSaving;
        private DevComponents.DotNetBar.LabelItem lblBlank;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem lblHour;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.SuperTabControl stcGeneral_Data;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem stiGeneral_Data;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem stiTable;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem stiGraphics;
        private DevComponents.DotNetBar.LabelX lblxName;
        private DevComponents.DotNetBar.LabelX lblxWeight;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatment;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiagnostic;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhysical_Exploration;
        private DevComponents.DotNetBar.LabelX lblxReason;
        private DevComponents.DotNetBar.LabelX lblxHead_Circunference;
        private DevComponents.DotNetBar.LabelX lblxIMC;
        private DevComponents.DotNetBar.LabelX lblxSize;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHead_Circunference;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIMC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSize;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWeight;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX lblxTreatment;
        private DevComponents.DotNetBar.LabelX lblxDiagnostic;
        private DevComponents.DotNetBar.LabelX lblxPhysical_Exploration;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReason;
        private DevComponents.DotNetBar.ButtonX cmdCancel;
        private DevComponents.DotNetBar.ButtonX cmdSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFolio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem sptIMC;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem sptSize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrIMC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSize;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPercentilTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardSize;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblMedicalQueryDate;
    }
}