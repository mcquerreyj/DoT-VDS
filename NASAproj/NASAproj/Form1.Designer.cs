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
            this.makeButton = new System.Windows.Forms.Button();
            this.makeFileTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.loadFileTextBox = new System.Windows.Forms.TextBox();
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
            this.makeLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePane)).BeginInit();
            this.SuspendLayout();
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(788, 44);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 1;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // makeFileTextBox
            // 
            this.makeFileTextBox.Location = new System.Drawing.Point(615, 46);
            this.makeFileTextBox.Name = "makeFileTextBox";
            this.makeFileTextBox.Size = new System.Drawing.Size(167, 20);
            this.makeFileTextBox.TabIndex = 2;
            this.makeFileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(788, 109);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // loadFileTextBox
            // 
            this.loadFileTextBox.Location = new System.Drawing.Point(615, 109);
            this.loadFileTextBox.Name = "loadFileTextBox";
            this.loadFileTextBox.Size = new System.Drawing.Size(167, 20);
            this.loadFileTextBox.TabIndex = 5;
            // 
            // p1ComboBox
            // 
            this.p1ComboBox.FormattingEnabled = true;
            this.p1ComboBox.Location = new System.Drawing.Point(615, 322);
            this.p1ComboBox.Name = "p1ComboBox";
            this.p1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.p1ComboBox.TabIndex = 6;
            // 
            // p2ComboBox
            // 
            this.p2ComboBox.FormattingEnabled = true;
            this.p2ComboBox.Location = new System.Drawing.Point(742, 322);
            this.p2ComboBox.Name = "p2ComboBox";
            this.p2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.p2ComboBox.TabIndex = 7;
            // 
            // rewindButton
            // 
            this.rewindButton.Location = new System.Drawing.Point(658, 378);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(33, 23);
            this.rewindButton.TabIndex = 8;
            this.rewindButton.Text = "<<";
            this.rewindButton.UseVisualStyleBackColor = true;
            this.rewindButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(697, 378);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(39, 23);
            this.playPauseButton.TabIndex = 9;
            this.playPauseButton.Text = "> \\ | |";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(742, 378);
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
            this.imagePane.Size = new System.Drawing.Size(523, 422);
            this.imagePane.TabIndex = 13;
            this.imagePane.TabStop = false;
            // 
            // parameter1Label
            // 
            this.parameter1Label.AutoSize = true;
            this.parameter1Label.Location = new System.Drawing.Point(612, 306);
            this.parameter1Label.Name = "parameter1Label";
            this.parameter1Label.Size = new System.Drawing.Size(64, 13);
            this.parameter1Label.TabIndex = 14;
            this.parameter1Label.Text = "Parameter 1";
            // 
            // parameter2Label
            // 
            this.parameter2Label.AutoSize = true;
            this.parameter2Label.Location = new System.Drawing.Point(739, 306);
            this.parameter2Label.Name = "parameter2Label";
            this.parameter2Label.Size = new System.Drawing.Size(64, 13);
            this.parameter2Label.TabIndex = 15;
            this.parameter2Label.Text = "Parameter 2";
            this.parameter2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(655, 404);
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
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(571, 49);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(38, 13);
            this.makeLabel.TabIndex = 17;
            this.makeLabel.Text = "Name:";
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Location = new System.Drawing.Point(563, 114);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(46, 13);
            this.loadLabel.TabIndex = 18;
            this.loadLabel.Text = "Loaded:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.parameter2Label);
            this.Controls.Add(this.parameter1Label);
            this.Controls.Add(this.imagePane);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.rewindButton);
            this.Controls.Add(this.p2ComboBox);
            this.Controls.Add(this.p1ComboBox);
            this.Controls.Add(this.loadFileTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.makeFileTextBox);
            this.Controls.Add(this.makeButton);
            this.Name = "Form1";
            this.Text = "Vehicle Detection Comparison";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.TextBox makeFileTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox loadFileTextBox;
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
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label loadLabel;
    }
}

