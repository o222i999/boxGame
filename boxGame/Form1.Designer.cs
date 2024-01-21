namespace boxGame
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mdBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.ezBtn = new System.Windows.Forms.Button();
            this.scoreGB = new System.Windows.Forms.GroupBox();
            this.changeDifficultyBtn = new System.Windows.Forms.Button();
            this.endlessBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.scoreGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(323, 240);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(154, 44);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Visible = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box.BackColor = System.Drawing.Color.Red;
            this.box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box.Location = new System.Drawing.Point(693, 323);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(50, 50);
            this.box.TabIndex = 1;
            this.box.UseVisualStyleBackColor = false;
            this.box.Visible = false;
            this.box.Click += new System.EventHandler(this.box_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "choose a difficulty, then click start to begin,\r\nthe objective of this game is to" +
    " locate and click the red\r\nsquare as quick as you can while not clicking the bac" +
    "kground.\r\n10 points = win\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "score:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // scoreTB
            // 
            this.scoreTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTB.Location = new System.Drawing.Point(108, 11);
            this.scoreTB.Name = "scoreTB";
            this.scoreTB.ReadOnly = true;
            this.scoreTB.Size = new System.Drawing.Size(56, 38);
            this.scoreTB.TabIndex = 4;
            this.scoreTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreTB.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(323, 379);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(154, 44);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.mdBtn);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.hardBtn);
            this.groupBox1.Controls.Add(this.ezBtn);
            this.groupBox1.Location = new System.Drawing.Point(139, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // mdBtn
            // 
            this.mdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdBtn.Location = new System.Drawing.Point(148, 17);
            this.mdBtn.Name = "mdBtn";
            this.mdBtn.Size = new System.Drawing.Size(101, 35);
            this.mdBtn.TabIndex = 8;
            this.mdBtn.Text = "medium";
            this.mdBtn.UseVisualStyleBackColor = true;
            this.mdBtn.Click += new System.EventHandler(this.mdBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(414, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "insane";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.insaneBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.Location = new System.Drawing.Point(278, 17);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(92, 35);
            this.hardBtn.TabIndex = 9;
            this.hardBtn.Text = "hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // ezBtn
            // 
            this.ezBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezBtn.Location = new System.Drawing.Point(17, 17);
            this.ezBtn.Name = "ezBtn";
            this.ezBtn.Size = new System.Drawing.Size(92, 35);
            this.ezBtn.TabIndex = 7;
            this.ezBtn.Text = "easy";
            this.ezBtn.UseVisualStyleBackColor = true;
            this.ezBtn.Click += new System.EventHandler(this.ezBtn_Click);
            // 
            // scoreGB
            // 
            this.scoreGB.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.scoreGB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreGB.Controls.Add(this.label2);
            this.scoreGB.Controls.Add(this.scoreTB);
            this.scoreGB.Location = new System.Drawing.Point(304, 12);
            this.scoreGB.Name = "scoreGB";
            this.scoreGB.Size = new System.Drawing.Size(184, 57);
            this.scoreGB.TabIndex = 11;
            this.scoreGB.TabStop = false;
            this.scoreGB.Visible = false;
            // 
            // changeDifficultyBtn
            // 
            this.changeDifficultyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDifficultyBtn.Location = new System.Drawing.Point(323, 138);
            this.changeDifficultyBtn.Name = "changeDifficultyBtn";
            this.changeDifficultyBtn.Size = new System.Drawing.Size(154, 68);
            this.changeDifficultyBtn.TabIndex = 12;
            this.changeDifficultyBtn.Text = "change difficulty";
            this.changeDifficultyBtn.UseVisualStyleBackColor = true;
            this.changeDifficultyBtn.Visible = false;
            this.changeDifficultyBtn.Click += new System.EventHandler(this.changeDifficultyBtn_Click);
            // 
            // endlessBtn
            // 
            this.endlessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlessBtn.Location = new System.Drawing.Point(323, 310);
            this.endlessBtn.Name = "endlessBtn";
            this.endlessBtn.Size = new System.Drawing.Size(154, 44);
            this.endlessBtn.TabIndex = 13;
            this.endlessBtn.Text = "endless";
            this.endlessBtn.UseVisualStyleBackColor = true;
            this.endlessBtn.Visible = false;
            this.endlessBtn.Click += new System.EventHandler(this.endlessBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalBtn.Location = new System.Drawing.Point(323, 310);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(154, 44);
            this.normalBtn.TabIndex = 14;
            this.normalBtn.Text = "normal mode";
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Visible = false;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 467);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.box);
            this.Controls.Add(this.endlessBtn);
            this.Controls.Add(this.changeDifficultyBtn);
            this.Controls.Add(this.scoreGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "box game";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.scoreGB.ResumeLayout(false);
            this.scoreGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ezBtn;
        private System.Windows.Forms.Button mdBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox scoreGB;
        private System.Windows.Forms.Button changeDifficultyBtn;
        private System.Windows.Forms.Button endlessBtn;
        private System.Windows.Forms.Button normalBtn;
    }
}

