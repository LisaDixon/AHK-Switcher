namespace AHK_switcher
{
    partial class AHKSwitcher1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.labelBrowse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAHKSelector = new System.Windows.Forms.ComboBox();
            this.btnStartAHK = new System.Windows.Forms.Button();
            this.btnStopAHK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(250, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 35);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(14, 63);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(228, 20);
            this.txtFileLocation.TabIndex = 1;
            // 
            // labelBrowse
            // 
            this.labelBrowse.AutoSize = true;
            this.labelBrowse.Location = new System.Drawing.Point(11, 37);
            this.labelBrowse.Name = "labelBrowse";
            this.labelBrowse.Size = new System.Drawing.Size(252, 13);
            this.labelBrowse.TabIndex = 2;
            this.labelBrowse.Text = "Click below to locate AHK directory or enter location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select AHK from list";
            // 
            // cmbAHKSelector
            // 
            this.cmbAHKSelector.FormattingEnabled = true;
            this.cmbAHKSelector.Location = new System.Drawing.Point(14, 179);
            this.cmbAHKSelector.Name = "cmbAHKSelector";
            this.cmbAHKSelector.Size = new System.Drawing.Size(228, 21);
            this.cmbAHKSelector.TabIndex = 6;
            // 
            // btnStartAHK
            // 
            this.btnStartAHK.Location = new System.Drawing.Point(250, 177);
            this.btnStartAHK.Name = "btnStartAHK";
            this.btnStartAHK.Size = new System.Drawing.Size(86, 35);
            this.btnStartAHK.TabIndex = 7;
            this.btnStartAHK.Text = "Start AHK";
            this.btnStartAHK.UseVisualStyleBackColor = true;
            this.btnStartAHK.Click += new System.EventHandler(this.btnStartAHK_Click);
            // 
            // btnStopAHK
            // 
            this.btnStopAHK.Location = new System.Drawing.Point(250, 218);
            this.btnStopAHK.Name = "btnStopAHK";
            this.btnStopAHK.Size = new System.Drawing.Size(86, 34);
            this.btnStopAHK.TabIndex = 8;
            this.btnStopAHK.Text = "Stop AHK";
            this.btnStopAHK.UseVisualStyleBackColor = true;
            this.btnStopAHK.Click += new System.EventHandler(this.btnStopAHK_Click);
            // 
            // AHKSwitcher1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 283);
            this.Controls.Add(this.btnStopAHK);
            this.Controls.Add(this.btnStartAHK);
            this.Controls.Add(this.cmbAHKSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBrowse);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.btnBrowse);
            this.Name = "AHKSwitcher1";
            this.Text = "AHKSwitcher1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label labelBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAHKSelector;
        private System.Windows.Forms.Button btnStartAHK;
        private System.Windows.Forms.Button btnStopAHK;
    }
}