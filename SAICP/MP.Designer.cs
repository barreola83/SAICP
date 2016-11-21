namespace SAICP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlModules = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mnuNewClinicalRecord = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryClinicalRecords = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuNewMedicalQuery = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryMedicalQuerys = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuClinicalGraphicTracing = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mnuNewEarmingRecord = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryEarningRecords = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuNewExpenseRecord = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryExpenseRecords = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.cntDiary = new DevComponents.DotNetBar.ItemContainer();
            this.mnuNewMedicalDate = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryMedicalDates = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.lblBlank,
            this.lblDate,
            this.lblHour});
            this.statusBar.Location = new System.Drawing.Point(0, 481);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(965, 22);
            this.statusBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Text = "Bienvenido";
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
            // pnlModules
            // 
            // 
            // 
            // 
            this.pnlModules.BackgroundStyle.Class = "MetroTilePanel";
            this.pnlModules.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlModules.ContainerControlProcessDialogKey = true;
            this.pnlModules.DragDropSupport = true;
            this.pnlModules.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.pnlModules.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.pnlModules.Location = new System.Drawing.Point(13, 13);
            this.pnlModules.Name = "pnlModules";
            this.pnlModules.Size = new System.Drawing.Size(1002, 461);
            this.pnlModules.TabIndex = 1;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 3;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnuNewClinicalRecord,
            this.mnuQueryClinicalRecords,
            this.mnuNewMedicalQuery,
            this.mnuQueryMedicalQuerys,
            this.mnuClinicalGraphicTracing,
            this.itemContainer2});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "Gestión integral de expedientes clínicos";
            // 
            // mnuNewClinicalRecord
            // 
            this.mnuNewClinicalRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuNewClinicalRecord.Image = global::SAICP.Properties.Resources.NEC;
            this.mnuNewClinicalRecord.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuNewClinicalRecord.Name = "mnuNewClinicalRecord";
            this.mnuNewClinicalRecord.SymbolColor = System.Drawing.Color.Empty;
            this.mnuNewClinicalRecord.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mnuNewClinicalRecord.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuNewClinicalRecord.TitleText = "Nuevo expediente clínico";
            this.mnuNewClinicalRecord.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuNewClinicalRecord.Click += new System.EventHandler(this.mnuNewClinicalRecord_Click);
            // 
            // mnuQueryClinicalRecords
            // 
            this.mnuQueryClinicalRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuQueryClinicalRecords.Image = global::SAICP.Properties.Resources.CMEC;
            this.mnuQueryClinicalRecords.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuQueryClinicalRecords.Name = "mnuQueryClinicalRecords";
            this.mnuQueryClinicalRecords.SymbolColor = System.Drawing.Color.Empty;
            this.mnuQueryClinicalRecords.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.mnuQueryClinicalRecords.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuQueryClinicalRecords.TitleText = "Consulta de expedientes clínicos";
            this.mnuQueryClinicalRecords.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuQueryClinicalRecords.Click += new System.EventHandler(this.mnuQueryClinicalRecords_Click);
            // 
            // mnuNewMedicalQuery
            // 
            this.mnuNewMedicalQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuNewMedicalQuery.Image = global::SAICP.Properties.Resources.RNC;
            this.mnuNewMedicalQuery.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuNewMedicalQuery.Name = "mnuNewMedicalQuery";
            this.mnuNewMedicalQuery.SymbolColor = System.Drawing.Color.Empty;
            this.mnuNewMedicalQuery.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.mnuNewMedicalQuery.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuNewMedicalQuery.TitleText = "Nueva consulta médica";
            this.mnuNewMedicalQuery.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuNewMedicalQuery.Click += new System.EventHandler(this.mnuNewMedicalQuery_Click);
            // 
            // mnuQueryMedicalQuerys
            // 
            this.mnuQueryMedicalQuerys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuQueryMedicalQuerys.Image = global::SAICP.Properties.Resources.BC;
            this.mnuQueryMedicalQuerys.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuQueryMedicalQuerys.Name = "mnuQueryMedicalQuerys";
            this.mnuQueryMedicalQuerys.SymbolColor = System.Drawing.Color.Empty;
            this.mnuQueryMedicalQuerys.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mnuQueryMedicalQuerys.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuQueryMedicalQuerys.TitleText = "Búsqueda de consulas médicas";
            this.mnuQueryMedicalQuerys.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuQueryMedicalQuerys.Click += new System.EventHandler(this.mnuQueryMedicalQuerys_Click);
            // 
            // mnuClinicalGraphicTracing
            // 
            this.mnuClinicalGraphicTracing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuClinicalGraphicTracing.Image = global::SAICP.Properties.Resources.SCG;
            this.mnuClinicalGraphicTracing.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuClinicalGraphicTracing.Name = "mnuClinicalGraphicTracing";
            this.mnuClinicalGraphicTracing.SymbolColor = System.Drawing.Color.Empty;
            this.mnuClinicalGraphicTracing.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Maroon;
            // 
            // 
            // 
            this.mnuClinicalGraphicTracing.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuClinicalGraphicTracing.TitleText = "Seguimiento clínico gráfico";
            this.mnuClinicalGraphicTracing.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuClinicalGraphicTracing.Click += new System.EventHandler(this.mnuClinicalGraphicTracing_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 3;
            this.itemContainer2.MultiLine = true;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnuNewEarmingRecord,
            this.mnuQueryEarningRecords,
            this.mnuNewExpenseRecord,
            this.mnuQueryExpenseRecords,
            this.cntDiary});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.TitleText = "Gestión básica de contabilidad";
            // 
            // mnuNewEarmingRecord
            // 
            this.mnuNewEarmingRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuNewEarmingRecord.Image = ((System.Drawing.Image)(resources.GetObject("mnuNewEarmingRecord.Image")));
            this.mnuNewEarmingRecord.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuNewEarmingRecord.Name = "mnuNewEarmingRecord";
            this.mnuNewEarmingRecord.SymbolColor = System.Drawing.Color.Empty;
            this.mnuNewEarmingRecord.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.mnuNewEarmingRecord.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuNewEarmingRecord.TitleText = "Registro de ingresos";
            this.mnuNewEarmingRecord.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuNewEarmingRecord.Click += new System.EventHandler(this.mnuNewEarmingRecord_Click);
            // 
            // mnuQueryEarningRecords
            // 
            this.mnuQueryEarningRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuQueryEarningRecords.Image = global::SAICP.Properties.Resources.CICC;
            this.mnuQueryEarningRecords.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuQueryEarningRecords.Name = "mnuQueryEarningRecords";
            this.mnuQueryEarningRecords.SymbolColor = System.Drawing.Color.Empty;
            this.mnuQueryEarningRecords.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mnuQueryEarningRecords.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuQueryEarningRecords.TitleText = "Consulta de ingresos";
            this.mnuQueryEarningRecords.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuQueryEarningRecords.Click += new System.EventHandler(this.mnuQueryEarningRecords_Click);
            // 
            // mnuNewExpenseRecord
            // 
            this.mnuNewExpenseRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuNewExpenseRecord.Image = global::SAICP.Properties.Resources.RE;
            this.mnuNewExpenseRecord.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuNewExpenseRecord.Name = "mnuNewExpenseRecord";
            this.mnuNewExpenseRecord.SymbolColor = System.Drawing.Color.Empty;
            this.mnuNewExpenseRecord.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.mnuNewExpenseRecord.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuNewExpenseRecord.TitleText = "Registro de egresos";
            this.mnuNewExpenseRecord.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuNewExpenseRecord.Click += new System.EventHandler(this.mnuNewExpenseRecord_Click);
            // 
            // mnuQueryExpenseRecords
            // 
            this.mnuQueryExpenseRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuQueryExpenseRecords.Image = global::SAICP.Properties.Resources.CE;
            this.mnuQueryExpenseRecords.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuQueryExpenseRecords.Name = "mnuQueryExpenseRecords";
            this.mnuQueryExpenseRecords.SymbolColor = System.Drawing.Color.Empty;
            this.mnuQueryExpenseRecords.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mnuQueryExpenseRecords.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuQueryExpenseRecords.TitleText = "Consulta de egresos";
            this.mnuQueryExpenseRecords.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuQueryExpenseRecords.Click += new System.EventHandler(this.mnuQueryExpenseRecords_Click);
            // 
            // cntDiary
            // 
            // 
            // 
            // 
            this.cntDiary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cntDiary.FixedSize = new System.Drawing.Size(450, 90);
            this.cntDiary.ItemSpacing = 3;
            this.cntDiary.MultiLine = true;
            this.cntDiary.Name = "cntDiary";
            this.cntDiary.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnuNewMedicalDate,
            this.mnuQueryMedicalDates});
            // 
            // 
            // 
            this.cntDiary.TitleStyle.Class = "MetroTileGroupTitle";
            this.cntDiary.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cntDiary.TitleText = "Administración de agenda";
            // 
            // mnuNewMedicalDate
            // 
            this.mnuNewMedicalDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuNewMedicalDate.Image = global::SAICP.Properties.Resources.RACM;
            this.mnuNewMedicalDate.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuNewMedicalDate.Name = "mnuNewMedicalDate";
            this.mnuNewMedicalDate.SymbolColor = System.Drawing.Color.Empty;
            this.mnuNewMedicalDate.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.mnuNewMedicalDate.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuNewMedicalDate.TitleText = "Nueva cita médica";
            this.mnuNewMedicalDate.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuNewMedicalDate.Click += new System.EventHandler(this.mnuNewMedicalDate_Click);
            // 
            // mnuQueryMedicalDates
            // 
            this.mnuQueryMedicalDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnuQueryMedicalDates.Image = global::SAICP.Properties.Resources.CMCM;
            this.mnuQueryMedicalDates.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.mnuQueryMedicalDates.Name = "mnuQueryMedicalDates";
            this.mnuQueryMedicalDates.SymbolColor = System.Drawing.Color.Empty;
            this.mnuQueryMedicalDates.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.mnuQueryMedicalDates.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuQueryMedicalDates.TitleText = "Consulta de citas médicas";
            this.mnuQueryMedicalDates.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuQueryMedicalDates.Click += new System.EventHandler(this.mnuQueryMedicalDates_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 503);
            this.Controls.Add(this.pnlModules);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Sistema de administración integral para consultorios pediátricos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem lblMessage;
        private DevComponents.DotNetBar.LabelItem lblBlank;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem lblHour;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.Metro.MetroTilePanel pnlModules;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuNewClinicalRecord;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuQueryClinicalRecords;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuNewMedicalQuery;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuQueryMedicalQuerys;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuNewEarmingRecord;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuQueryEarningRecords;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuNewExpenseRecord;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuQueryExpenseRecords;
        private DevComponents.DotNetBar.ItemContainer cntDiary;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuNewMedicalDate;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuQueryMedicalDates;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuClinicalGraphicTracing;
    }
}