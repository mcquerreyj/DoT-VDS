namespace NASAproj
{
    partial class Form1
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
            this.dataButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.p1ComboBox = new System.Windows.Forms.ComboBox();
            this.p2ComboBox = new System.Windows.Forms.ComboBox();
            this.rewindButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.imagePane = new System.Windows.Forms.PictureBox();
            this.parameter1Label = new System.Windows.Forms.Label();
            this.parameter2Label = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePane)).BeginInit();
            this.SuspendLayout();
            // 
            // dataButton
            // 
            this.dataButton.Location = new System.Drawing.Point(574, 64);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(75, 23);
            this.dataButton.TabIndex = 1;
            this.dataButton.Text = "Data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Location = new System.Drawing.Point(724, 64);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(75, 23);
            this.pictureButton.TabIndex = 4;
            this.pictureButton.Text = "Pictures";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // p1ComboBox
            // 
            this.p1ComboBox.FormattingEnabled = true;
            this.p1ComboBox.Location = new System.Drawing.Point(574, 173);
            this.p1ComboBox.Name = "p1ComboBox";
            this.p1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.p1ComboBox.Sorted = true;
            this.p1ComboBox.TabIndex = 6;
            // 
            // p2ComboBox
            // 
            this.p2ComboBox.FormattingEnabled = true;
            this.p2ComboBox.Location = new System.Drawing.Point(724, 173);
            this.p2ComboBox.Name = "p2ComboBox";
            this.p2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.p2ComboBox.Sorted = true;
            this.p2ComboBox.TabIndex = 7;
            // 
            // rewindButton
            // 
            this.rewindButton.Location = new System.Drawing.Point(602, 256);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(33, 23);
            this.rewindButton.TabIndex = 8;
            this.rewindButton.Text = "<<";
            this.rewindButton.UseVisualStyleBackColor = true;
            this.rewindButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(641, 256);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(39, 23);
            this.playPauseButton.TabIndex = 9;
            this.playPauseButton.Text = "> \\ | |";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(686, 256);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(33, 23);
            this.forwardButton.TabIndex = 10;
            this.forwardButton.Text = ">>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // imagePane
            // 
            this.imagePane.Location = new System.Drawing.Point(5, 5);
            this.imagePane.Name = "imagePane";
            this.imagePane.Size = new System.Drawing.Size(538, 422);
            this.imagePane.TabIndex = 13;
            this.imagePane.TabStop = false;
            // 
            // parameter1Label
            // 
            this.parameter1Label.AutoSize = true;
            this.parameter1Label.Location = new System.Drawing.Point(571, 157);
            this.parameter1Label.Name = "parameter1Label";
            this.parameter1Label.Size = new System.Drawing.Size(64, 13);
            this.parameter1Label.TabIndex = 14;
            this.parameter1Label.Text = "Parameter 1";
            // 
            // parameter2Label
            // 
            this.parameter2Label.AutoSize = true;
            this.parameter2Label.Location = new System.Drawing.Point(721, 157);
            this.parameter2Label.Name = "parameter2Label";
            this.parameter2Label.Size = new System.Drawing.Size(64, 13);
            this.parameter2Label.TabIndex = 15;
            this.parameter2Label.Text = "Parameter 2";
            this.parameter2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(571, 405);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(574, 353);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 17;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.parameter2Label);
            this.Controls.Add(this.parameter1Label);
            this.Controls.Add(this.imagePane);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.rewindButton);
            this.Controls.Add(this.p2ComboBox);
            this.Controls.Add(this.p1ComboBox);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.dataButton);
            this.Name = "Form1";
            this.Text = "Vehicle Detection Comparison";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.ComboBox p1ComboBox;
        private System.Windows.Forms.ComboBox p2ComboBox;
        private System.Windows.Forms.Button rewindButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.PictureBox imagePane;
        private System.Windows.Forms.Label parameter1Label;
        private System.Windows.Forms.Label parameter2Label;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button helpButton;
    }
}

