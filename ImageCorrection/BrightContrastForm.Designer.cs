namespace ImageCorrection
{
    partial class BrightContrastForm
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
            this.brightnessPanel = new System.Windows.Forms.Panel();
            this.contrastPanel = new System.Windows.Forms.Panel();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.brightHistPB = new System.Windows.Forms.PictureBox();
            this.brightnessTB = new System.Windows.Forms.TrackBar();
            this.contrastTB = new System.Windows.Forms.TrackBar();
            this.brightnessPanel.SuspendLayout();
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightHistPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTB)).BeginInit();
            this.SuspendLayout();
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.Controls.Add(this.brightnessTB);
            this.brightnessPanel.Controls.Add(this.brightHistPB);
            this.brightnessPanel.Controls.Add(this.brightnessLabel);
            this.brightnessPanel.Location = new System.Drawing.Point(12, 12);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.Size = new System.Drawing.Size(260, 186);
            this.brightnessPanel.TabIndex = 0;
            // 
            // contrastPanel
            // 
            this.contrastPanel.Controls.Add(this.contrastTB);
            this.contrastPanel.Controls.Add(this.contrastLabel);
            this.contrastPanel.Location = new System.Drawing.Point(12, 204);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.Size = new System.Drawing.Size(260, 110);
            this.contrastPanel.TabIndex = 1;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(4, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 0;
            this.brightnessLabel.Text = "Brightness";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(3, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(46, 13);
            this.contrastLabel.TabIndex = 1;
            this.contrastLabel.Text = "Contrast";
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.Location = new System.Drawing.Point(113, 320);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(75, 34);
            this.applyChangesButton.TabIndex = 2;
            this.applyChangesButton.Text = "OK";
            this.applyChangesButton.UseVisualStyleBackColor = true;
            // 
            // brightHistPB
            // 
            this.brightHistPB.Location = new System.Drawing.Point(7, 17);
            this.brightHistPB.Name = "brightHistPB";
            this.brightHistPB.Size = new System.Drawing.Size(250, 100);
            this.brightHistPB.TabIndex = 1;
            this.brightHistPB.TabStop = false;
            // 
            // brightnessTB
            // 
            this.brightnessTB.Location = new System.Drawing.Point(6, 129);
            this.brightnessTB.Minimum = -10;
            this.brightnessTB.Name = "brightnessTB";
            this.brightnessTB.Size = new System.Drawing.Size(250, 45);
            this.brightnessTB.TabIndex = 2;
            this.brightnessTB.Scroll += new System.EventHandler(this.brightnessTB_Scroll);
            // 
            // contrastTB
            // 
            this.contrastTB.Location = new System.Drawing.Point(5, 33);
            this.contrastTB.Minimum = -10;
            this.contrastTB.Name = "contrastTB";
            this.contrastTB.Size = new System.Drawing.Size(250, 45);
            this.contrastTB.TabIndex = 3;
            this.contrastTB.Scroll += new System.EventHandler(this.contrastTB_Scroll);
            // 
            // BrightContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.applyChangesButton);
            this.Controls.Add(this.contrastPanel);
            this.Controls.Add(this.brightnessPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BrightContrastForm";
            this.Text = "Brightness/Contrast";
            this.brightnessPanel.ResumeLayout(false);
            this.brightnessPanel.PerformLayout();
            this.contrastPanel.ResumeLayout(false);
            this.contrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightHistPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel brightnessPanel;
        private System.Windows.Forms.PictureBox brightHistPB;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.TrackBar brightnessTB;
        private System.Windows.Forms.TrackBar contrastTB;
    }
}