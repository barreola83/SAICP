namespace SAICP
{
    partial class frmClinicalGraphicTracing
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClinicalGraphicTracing));
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmdBack = new DevComponents.DotNetBar.ButtonX();
            this.cmdSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.labelX64 = new DevComponents.DotNetBar.LabelX();
            this.cmbSearchBy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.byFolio = new DevComponents.Editors.ComboItem();
            this.byName = new DevComponents.Editors.ComboItem();
            this.chrGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraphic)).BeginInit();
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
            this.statusBar.Location = new System.Drawing.Point(0, 427);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(816, 22);
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
            // cmdBack
            // 
            this.cmdBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBack.AutoSize = true;
            this.cmdBack.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.Location = new System.Drawing.Point(720, 393);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(84, 28);
            this.cmdBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "Regresar";
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSearch.AutoSize = true;
            this.cmdSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(572, 21);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 28);
            this.cmdSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdSearch.TabIndex = 78;
            this.cmdSearch.Text = "Buscar";
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.Location = new System.Drawing.Point(339, 21);
            this.txtSearchBy.MaxLength = 12;
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(227, 27);
            this.txtSearchBy.TabIndex = 77;
            this.txtSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBy_KeyPress);
            // 
            // labelX64
            // 
            this.labelX64.AutoSize = true;
            // 
            // 
            // 
            this.labelX64.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX64.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX64.Location = new System.Drawing.Point(125, 21);
            this.labelX64.Name = "labelX64";
            this.labelX64.Size = new System.Drawing.Size(81, 24);
            this.labelX64.TabIndex = 76;
            this.labelX64.Text = "Buscar por:";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSearchBy.DisplayMember = "Text";
            this.cmbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.ForeColor = System.Drawing.Color.Black;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.ItemHeight = 20;
            this.cmbSearchBy.Items.AddRange(new object[] {
            this.byFolio,
            this.byName});
            this.cmbSearchBy.Location = new System.Drawing.Point(212, 21);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(121, 26);
            this.cmbSearchBy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSearchBy.TabIndex = 75;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // byFolio
            // 
            this.byFolio.Text = "Folio";
            // 
            // byName
            // 
            this.byName.Text = "Nombre";
            // 
            // chrGraphic
            // 
            chartArea1.Name = "ChartArea1";
            this.chrGraphic.ChartAreas.Add(chartArea1);
            this.chrGraphic.Location = new System.Drawing.Point(13, 55);
            this.chrGraphic.Name = "chrGraphic";
            this.chrGraphic.Size = new System.Drawing.Size(791, 332);
            this.chrGraphic.TabIndex = 79;
            this.chrGraphic.Text = "chart1";
            // 
            // frmClinicalGraphicTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 449);
            this.Controls.Add(this.chrGraphic);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.labelX64);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClinicalGraphicTracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Seguimiento clínico gráfico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClinicalGraphicTracing_FormClosing);
            this.Load += new System.EventHandler(this.frmClinicalGraphicTracing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGraphic)).EndInit();
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
        private DevComponents.DotNetBar.ButtonX cmdBack;
        private DevComponents.DotNetBar.ButtonX cmdSearch;
        private System.Windows.Forms.TextBox txtSearchBy;
        private DevComponents.DotNetBar.LabelX labelX64;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSearchBy;
        private DevComponents.Editors.ComboItem byFolio;
        private DevComponents.Editors.ComboItem byName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraphic;
    }
}