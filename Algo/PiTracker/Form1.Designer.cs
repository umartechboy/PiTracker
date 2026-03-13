namespace PiTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imageSourceC = new TextBox();
            browseC = new Button();
            seqSourceC = new RadioButton();
            camSourceC = new RadioButton();
            startC = new Button();
            frameC = new PictureBox();
            seekbarC = new TrackBar();
            playedC = new CheckBox();
            consoleC = new TextBox();
            hoverCoordsC = new Label();
            ((System.ComponentModel.ISupportInitialize)frameC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seekbarC).BeginInit();
            SuspendLayout();
            // 
            // imageSourceC
            // 
            imageSourceC.Location = new Point(12, 14);
            imageSourceC.Margin = new Padding(2);
            imageSourceC.Name = "imageSourceC";
            imageSourceC.Size = new Size(422, 23);
            imageSourceC.TabIndex = 0;
            imageSourceC.Text = "F:\\Github\\PiTracker\\Algo\\20260311_132636_frames";
            // 
            // browseC
            // 
            browseC.Location = new Point(437, 12);
            browseC.Margin = new Padding(2);
            browseC.Name = "browseC";
            browseC.Size = new Size(78, 20);
            browseC.TabIndex = 1;
            browseC.Text = "Browse";
            browseC.UseVisualStyleBackColor = true;
            // 
            // seqSourceC
            // 
            seqSourceC.AutoSize = true;
            seqSourceC.Checked = true;
            seqSourceC.Location = new Point(12, 59);
            seqSourceC.Margin = new Padding(2);
            seqSourceC.Name = "seqSourceC";
            seqSourceC.Size = new Size(76, 19);
            seqSourceC.TabIndex = 2;
            seqSourceC.TabStop = true;
            seqSourceC.Text = "Sequence";
            seqSourceC.UseVisualStyleBackColor = true;
            // 
            // camSourceC
            // 
            camSourceC.AutoSize = true;
            camSourceC.Location = new Point(102, 59);
            camSourceC.Margin = new Padding(2);
            camSourceC.Name = "camSourceC";
            camSourceC.Size = new Size(66, 19);
            camSourceC.TabIndex = 2;
            camSourceC.Text = "Camera";
            camSourceC.UseVisualStyleBackColor = true;
            // 
            // startC
            // 
            startC.Location = new Point(437, 36);
            startC.Margin = new Padding(2);
            startC.Name = "startC";
            startC.Size = new Size(78, 40);
            startC.TabIndex = 1;
            startC.Text = "Start";
            startC.UseVisualStyleBackColor = true;
            startC.Click += startC_Click;
            // 
            // frameC
            // 
            frameC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frameC.BackgroundImageLayout = ImageLayout.Zoom;
            frameC.Location = new Point(12, 83);
            frameC.Name = "frameC";
            frameC.Size = new Size(746, 472);
            frameC.TabIndex = 3;
            frameC.TabStop = false;
            frameC.MouseMove += frameC_MouseMove;
            // 
            // seekbarC
            // 
            seekbarC.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seekbarC.Location = new Point(12, 561);
            seekbarC.Name = "seekbarC";
            seekbarC.Size = new Size(731, 45);
            seekbarC.TabIndex = 4;
            // 
            // playedC
            // 
            playedC.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            playedC.AutoSize = true;
            playedC.Checked = true;
            playedC.CheckState = CheckState.Checked;
            playedC.Location = new Point(743, 561);
            playedC.Name = "playedC";
            playedC.Size = new Size(15, 14);
            playedC.TabIndex = 5;
            playedC.UseVisualStyleBackColor = true;
            // 
            // consoleC
            // 
            consoleC.Location = new Point(764, 83);
            consoleC.Multiline = true;
            consoleC.Name = "consoleC";
            consoleC.Size = new Size(166, 502);
            consoleC.TabIndex = 6;
            // 
            // hoverCoordsC
            // 
            hoverCoordsC.Location = new Point(651, 59);
            hoverCoordsC.Name = "hoverCoordsC";
            hoverCoordsC.Size = new Size(107, 21);
            hoverCoordsC.TabIndex = 7;
            hoverCoordsC.Text = "--";
            hoverCoordsC.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 597);
            Controls.Add(hoverCoordsC);
            Controls.Add(consoleC);
            Controls.Add(playedC);
            Controls.Add(seekbarC);
            Controls.Add(frameC);
            Controls.Add(camSourceC);
            Controls.Add(seqSourceC);
            Controls.Add(startC);
            Controls.Add(browseC);
            Controls.Add(imageSourceC);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)frameC).EndInit();
            ((System.ComponentModel.ISupportInitialize)seekbarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imageSourceC;
        private Button browseC;
        private RadioButton seqSourceC;
        private RadioButton camSourceC;
        private Button startC;
        private PictureBox frameC;
        private TrackBar seekbarC;
        private CheckBox playedC;
        private TextBox consoleC;
        private Label hoverCoordsC;
    }
}
