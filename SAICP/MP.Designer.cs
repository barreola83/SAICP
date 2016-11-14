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
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.mnuTesting = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuNewClinicalRecord = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuQueryClinicalRecords = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuNewMedicalQuery = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mnuClinicalGraphicTracing = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem8 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem9 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem10 = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.statusBar.Size = new System.Drawing.Size(970, 22);
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
            this.pnlModules.Size = new System.Drawing.Size(946, 461);
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
            this.metroTileItem4,
            this.mnuClinicalGraphicTracing,
            this.itemContainer2});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "Gestión integral de expedientes clínicos";
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
            this.metroTileItem5,
            this.metroTileItem6,
            this.metroTileItem7,
            this.metroTileItem8,
            this.itemContainer3});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.TitleText = "Gestión básica de contabilidad";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.ItemSpacing = 3;
            this.itemContainer3.MultiLine = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem9,
            this.metroTileItem10,
            this.mnuTesting});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.TitleText = "Administración de agenda";
            // 
            // mnuTesting
            // 
            this.mnuTesting.Name = "mnuTesting";
            this.mnuTesting.SymbolColor = System.Drawing.Color.Empty;
            this.mnuTesting.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.mnuTesting.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnuTesting.TitleText = "Pruebas";
            this.mnuTesting.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuTesting.Click += new System.EventHandler(this.mnuTesting_Click);
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
            // metroTileItem4
            // 
            this.metroTileItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem4.Image = global::SAICP.Properties.Resources.BC;
            this.metroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TitleText = "Búsqueda de consulas médicas";
            this.metroTileItem4.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
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
            // metroTileItem5
            // 
            this.metroTileItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem5.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem5.Image")));
            this.metroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem5.TitleText = "Registro de ingresos";
            this.metroTileItem5.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem6.Image = global::SAICP.Properties.Resources.CICC;
            this.metroTileItem6.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem6.TitleText = "Consulta de ingresos";
            this.metroTileItem6.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem7.Image = global::SAICP.Properties.Resources.RE;
            this.metroTileItem7.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem7.TitleText = "Registro de egresos";
            this.metroTileItem7.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem8
            // 
            this.metroTileItem8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem8.Image = global::SAICP.Properties.Resources.CE;
            this.metroTileItem8.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem8.Name = "metroTileItem8";
            this.metroTileItem8.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem8.TitleText = "Consulta de egresos";
            this.metroTileItem8.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem9
            // 
            this.metroTileItem9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem9.Image = global::SAICP.Properties.Resources.RACM;
            this.metroTileItem9.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem9.Name = "metroTileItem9";
            this.metroTileItem9.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem9.TitleText = "Nueva cita médica";
            this.metroTileItem9.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem10
            // 
            this.metroTileItem10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileItem10.Image = global::SAICP.Properties.Resources.CMCM;
            this.metroTileItem10.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem10.Name = "metroTileItem10";
            this.metroTileItem10.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.metroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem10.TitleText = "Consulta de citas médicas";
            this.metroTileItem10.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 503);
            this.Controls.Add(this.pnlModules);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Sistema de administración integral para consultorios pediátricos";
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
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem8;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem9;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem10;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuClinicalGraphicTracing;
        private DevComponents.DotNetBar.Metro.MetroTileItem mnuTesting;
    }
}