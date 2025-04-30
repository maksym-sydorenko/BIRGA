namespace Birga
{
    partial class mainForm
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
            this.pnParamerters = new System.Windows.Forms.Panel();
            this.ntPointsSelection = new System.Windows.Forms.Button();
            this.pbLoadChart = new System.Windows.Forms.ProgressBar();
            this.btStartDetection = new System.Windows.Forms.Button();
            this.btLoadModel = new System.Windows.Forms.Button();
            this.btClearLog = new System.Windows.Forms.Button();
            this.btSaveModel = new System.Windows.Forms.Button();
            this.btTrainModel = new System.Windows.Forms.Button();
            this.lbxCharts = new System.Windows.Forms.ListBox();
            this.btLoadCharts = new System.Windows.Forms.Button();
            this.pnCharts = new System.Windows.Forms.Panel();
            this.fpCharts = new ScottPlot.WinForms.FormsPlot();
            this.pnLog = new System.Windows.Forms.Panel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.pnParamerters.SuspendLayout();
            this.pnCharts.SuspendLayout();
            this.pnLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnParamerters
            // 
            this.pnParamerters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnParamerters.Controls.Add(this.ntPointsSelection);
            this.pnParamerters.Controls.Add(this.pbLoadChart);
            this.pnParamerters.Controls.Add(this.btStartDetection);
            this.pnParamerters.Controls.Add(this.btLoadModel);
            this.pnParamerters.Controls.Add(this.btClearLog);
            this.pnParamerters.Controls.Add(this.btSaveModel);
            this.pnParamerters.Controls.Add(this.btTrainModel);
            this.pnParamerters.Controls.Add(this.lbxCharts);
            this.pnParamerters.Controls.Add(this.btLoadCharts);
            this.pnParamerters.Location = new System.Drawing.Point(4, 4);
            this.pnParamerters.Name = "pnParamerters";
            this.pnParamerters.Size = new System.Drawing.Size(200, 740);
            this.pnParamerters.TabIndex = 0;
            // 
            // ntPointsSelection
            // 
            this.ntPointsSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntPointsSelection.Location = new System.Drawing.Point(3, 571);
            this.ntPointsSelection.Name = "ntPointsSelection";
            this.ntPointsSelection.Size = new System.Drawing.Size(193, 23);
            this.ntPointsSelection.TabIndex = 4;
            this.ntPointsSelection.Text = "Train Data View";
            this.ntPointsSelection.UseVisualStyleBackColor = true;
            this.ntPointsSelection.Click += new System.EventHandler(this.ntPointsSelection_Click);
            // 
            // pbLoadChart
            // 
            this.pbLoadChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoadChart.Location = new System.Drawing.Point(4, 513);
            this.pbLoadChart.Name = "pbLoadChart";
            this.pbLoadChart.Size = new System.Drawing.Size(189, 23);
            this.pbLoadChart.TabIndex = 2;
            // 
            // btStartDetection
            // 
            this.btStartDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartDetection.Location = new System.Drawing.Point(4, 687);
            this.btStartDetection.Name = "btStartDetection";
            this.btStartDetection.Size = new System.Drawing.Size(193, 23);
            this.btStartDetection.TabIndex = 8;
            this.btStartDetection.Text = "Start detection";
            this.btStartDetection.UseVisualStyleBackColor = true;
            this.btStartDetection.Click += new System.EventHandler(this.btStartDetection_Click);
            // 
            // btLoadModel
            // 
            this.btLoadModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadModel.Location = new System.Drawing.Point(4, 658);
            this.btLoadModel.Name = "btLoadModel";
            this.btLoadModel.Size = new System.Drawing.Size(193, 23);
            this.btLoadModel.TabIndex = 7;
            this.btLoadModel.Text = "Load Model";
            this.btLoadModel.UseVisualStyleBackColor = true;
            this.btLoadModel.Click += new System.EventHandler(this.btLoadModel_Click);
            // 
            // btClearLog
            // 
            this.btClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearLog.Location = new System.Drawing.Point(4, 714);
            this.btClearLog.Name = "btClearLog";
            this.btClearLog.Size = new System.Drawing.Size(193, 23);
            this.btClearLog.TabIndex = 9;
            this.btClearLog.Text = "Clear Log";
            this.btClearLog.UseVisualStyleBackColor = true;
            this.btClearLog.Click += new System.EventHandler(this.btClearLog_Click);
            // 
            // btSaveModel
            // 
            this.btSaveModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveModel.Location = new System.Drawing.Point(3, 629);
            this.btSaveModel.Name = "btSaveModel";
            this.btSaveModel.Size = new System.Drawing.Size(193, 23);
            this.btSaveModel.TabIndex = 6;
            this.btSaveModel.Text = "Save Model";
            this.btSaveModel.UseVisualStyleBackColor = true;
            this.btSaveModel.Click += new System.EventHandler(this.btSaveModel_Click);
            // 
            // btTrainModel
            // 
            this.btTrainModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTrainModel.Location = new System.Drawing.Point(3, 600);
            this.btTrainModel.Name = "btTrainModel";
            this.btTrainModel.Size = new System.Drawing.Size(193, 23);
            this.btTrainModel.TabIndex = 5;
            this.btTrainModel.Text = "Train Model";
            this.btTrainModel.UseVisualStyleBackColor = true;
            this.btTrainModel.Click += new System.EventHandler(this.btTrainModel_Click);
            // 
            // lbxCharts
            // 
            this.lbxCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCharts.FormattingEnabled = true;
            this.lbxCharts.ItemHeight = 16;
            this.lbxCharts.Location = new System.Drawing.Point(4, 39);
            this.lbxCharts.Name = "lbxCharts";
            this.lbxCharts.Size = new System.Drawing.Size(193, 468);
            this.lbxCharts.TabIndex = 1;
            this.lbxCharts.SelectedIndexChanged += new System.EventHandler(this.lbxCharts_SelectedIndexChanged);
            // 
            // btLoadCharts
            // 
            this.btLoadCharts.Location = new System.Drawing.Point(4, 9);
            this.btLoadCharts.Name = "btLoadCharts";
            this.btLoadCharts.Size = new System.Drawing.Size(193, 23);
            this.btLoadCharts.TabIndex = 0;
            this.btLoadCharts.Text = "Load Charts";
            this.btLoadCharts.UseVisualStyleBackColor = true;
            this.btLoadCharts.Click += new System.EventHandler(this.btLoadCharts_Click);
            // 
            // pnCharts
            // 
            this.pnCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCharts.Controls.Add(this.fpCharts);
            this.pnCharts.Location = new System.Drawing.Point(210, 4);
            this.pnCharts.Name = "pnCharts";
            this.pnCharts.Size = new System.Drawing.Size(772, 643);
            this.pnCharts.TabIndex = 1;
            // 
            // fpCharts
            // 
            this.fpCharts.DisplayScale = 0F;
            this.fpCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCharts.Location = new System.Drawing.Point(0, 0);
            this.fpCharts.Name = "fpCharts";
            this.fpCharts.Size = new System.Drawing.Size(772, 643);
            this.fpCharts.TabIndex = 0;
            // 
            // pnLog
            // 
            this.pnLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLog.Controls.Add(this.rtbLog);
            this.pnLog.Location = new System.Drawing.Point(210, 653);
            this.pnLog.Name = "pnLog";
            this.pnLog.Size = new System.Drawing.Size(772, 91);
            this.pnLog.TabIndex = 2;
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(772, 91);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // renderTimer
            // 
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 756);
            this.Controls.Add(this.pnLog);
            this.Controls.Add(this.pnCharts);
            this.Controls.Add(this.pnParamerters);
            this.Name = "mainForm";
            this.Text = "Birga";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pnParamerters.ResumeLayout(false);
            this.pnCharts.ResumeLayout(false);
            this.pnLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnParamerters;
        private System.Windows.Forms.Panel pnCharts;
        private ScottPlot.WinForms.FormsPlot fpCharts;
        private System.Windows.Forms.Button btTrainModel;
        private System.Windows.Forms.ListBox lbxCharts;
        private System.Windows.Forms.Button btLoadCharts;
        private System.Windows.Forms.Panel pnLog;
        private System.Windows.Forms.Button btLoadModel;
        private System.Windows.Forms.Button btClearLog;
        private System.Windows.Forms.Button btSaveModel;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btStartDetection;
        private System.Windows.Forms.ProgressBar pbLoadChart;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Button ntPointsSelection;
    }
}

