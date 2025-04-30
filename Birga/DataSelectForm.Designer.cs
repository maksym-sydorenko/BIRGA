namespace Birga
{
    partial class DataSelectForm
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
            this.lbxNegative = new System.Windows.Forms.ListBox();
            this.lbxPositive = new System.Windows.Forms.ListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btRemovePos = new System.Windows.Forms.Button();
            this.btRemoveNeg = new System.Windows.Forms.Button();
            this.trbPointsTemplate = new System.Windows.Forms.TrackBar();
            this.lbPtTmplt = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbPointsTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxNegative
            // 
            this.lbxNegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxNegative.FormattingEnabled = true;
            this.lbxNegative.ItemHeight = 16;
            this.lbxNegative.Location = new System.Drawing.Point(12, 150);
            this.lbxNegative.Name = "lbxNegative";
            this.lbxNegative.Size = new System.Drawing.Size(464, 100);
            this.lbxNegative.TabIndex = 5;
            // 
            // lbxPositive
            // 
            this.lbxPositive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPositive.FormattingEnabled = true;
            this.lbxPositive.ItemHeight = 16;
            this.lbxPositive.Location = new System.Drawing.Point(12, 28);
            this.lbxPositive.Name = "lbxPositive";
            this.lbxPositive.Size = new System.Drawing.Size(464, 100);
            this.lbxPositive.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(337, 321);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(139, 31);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(482, 321);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(139, 31);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRemovePos
            // 
            this.btRemovePos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemovePos.Location = new System.Drawing.Point(482, 28);
            this.btRemovePos.Name = "btRemovePos";
            this.btRemovePos.Size = new System.Drawing.Size(139, 31);
            this.btRemovePos.TabIndex = 8;
            this.btRemovePos.Text = "Remove Positive";
            this.btRemovePos.UseVisualStyleBackColor = true;
            this.btRemovePos.Click += new System.EventHandler(this.btRemovePos_Click);
            // 
            // btRemoveNeg
            // 
            this.btRemoveNeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemoveNeg.Location = new System.Drawing.Point(482, 150);
            this.btRemoveNeg.Name = "btRemoveNeg";
            this.btRemoveNeg.Size = new System.Drawing.Size(139, 31);
            this.btRemoveNeg.TabIndex = 9;
            this.btRemoveNeg.Text = "RemoveNeg";
            this.btRemoveNeg.UseVisualStyleBackColor = true;
            this.btRemoveNeg.Click += new System.EventHandler(this.btRemoveNeg_Click);
            // 
            // trbPointsTemplate
            // 
            this.trbPointsTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbPointsTemplate.Location = new System.Drawing.Point(12, 256);
            this.trbPointsTemplate.Name = "trbPointsTemplate";
            this.trbPointsTemplate.Size = new System.Drawing.Size(609, 56);
            this.trbPointsTemplate.TabIndex = 10;
            this.trbPointsTemplate.Scroll += new System.EventHandler(this.trbPointsTemplate_Scroll);
            // 
            // lbPtTmplt
            // 
            this.lbPtTmplt.AutoSize = true;
            this.lbPtTmplt.Location = new System.Drawing.Point(12, 306);
            this.lbPtTmplt.Name = "lbPtTmplt";
            this.lbPtTmplt.Size = new System.Drawing.Size(112, 16);
            this.lbPtTmplt.TabIndex = 11;
            this.lbPtTmplt.Text = "Points in template";
            // 
            // btLoad
            // 
            this.btLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoad.Location = new System.Drawing.Point(192, 321);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(139, 31);
            this.btLoad.TabIndex = 12;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // DataSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 364);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.lbPtTmplt);
            this.Controls.Add(this.trbPointsTemplate);
            this.Controls.Add(this.btRemoveNeg);
            this.Controls.Add(this.btRemovePos);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbxNegative);
            this.Controls.Add(this.lbxPositive);
            this.Name = "DataSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data For Train";
            ((System.ComponentModel.ISupportInitialize)(this.trbPointsTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNegative;
        private System.Windows.Forms.ListBox lbxPositive;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRemovePos;
        private System.Windows.Forms.Button btRemoveNeg;
        private System.Windows.Forms.TrackBar trbPointsTemplate;
        private System.Windows.Forms.Label lbPtTmplt;
        private System.Windows.Forms.Button btLoad;
    }
}