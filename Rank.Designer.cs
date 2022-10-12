using System.Reflection;

namespace Exercise1
{
    partial class Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            this.btn_sound_off = new System.Windows.Forms.Button();
            this.btn_sound_on = new System.Windows.Forms.Button();
            this.btn_topic = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.txt_third = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sound_off
            // 
            this.btn_sound_off.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sound_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_off.BackgroundImage")));
            this.btn_sound_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_off.Location = new System.Drawing.Point(12, 70);
            this.btn_sound_off.Name = "btn_sound_off";
            this.btn_sound_off.Size = new System.Drawing.Size(42, 40);
            this.btn_sound_off.TabIndex = 2;
            this.btn_sound_off.UseVisualStyleBackColor = false;
            this.btn_sound_off.Click += new System.EventHandler(this.btn_sound_off_Click);
            // 
            // btn_sound_on
            // 
            this.btn_sound_on.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sound_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_on.BackgroundImage")));
            this.btn_sound_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_on.Location = new System.Drawing.Point(12, 70);
            this.btn_sound_on.Name = "btn_sound_on";
            this.btn_sound_on.Size = new System.Drawing.Size(42, 40);
            this.btn_sound_on.TabIndex = 2;
            this.btn_sound_on.UseVisualStyleBackColor = false;
            this.btn_sound_on.Click += new System.EventHandler(this.btn_sound_on_Click);
            // 
            // btn_topic
            // 
            this.btn_topic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_topic.BackgroundImage")));
            this.btn_topic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_topic.Location = new System.Drawing.Point(12, 12);
            this.btn_topic.Name = "btn_topic";
            this.btn_topic.Size = new System.Drawing.Size(42, 40);
            this.btn_topic.TabIndex = 10;
            this.btn_topic.Click += new System.EventHandler(this.btn_topic_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(846, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(42, 40);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rank.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rank.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_rank.Location = new System.Drawing.Point(262, 59);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(335, 60);
            this.lbl_rank.TabIndex = 11;
            this.lbl_rank.Text = "HIGH SCORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(154, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "First place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(154, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(154, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Third place";
            // 
            // txt_first
            // 
            this.txt_first.BackColor = System.Drawing.Color.MistyRose;
            this.txt_first.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_first.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_first.Location = new System.Drawing.Point(598, 163);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(63, 34);
            this.txt_first.TabIndex = 12;
            this.txt_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_second
            // 
            this.txt_second.BackColor = System.Drawing.Color.MistyRose;
            this.txt_second.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_second.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_second.Location = new System.Drawing.Point(598, 228);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(63, 34);
            this.txt_second.TabIndex = 12;
            this.txt_second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_third
            // 
            this.txt_third.BackColor = System.Drawing.Color.MistyRose;
            this.txt_third.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_third.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_third.Location = new System.Drawing.Point(598, 290);
            this.txt_third.Name = "txt_third";
            this.txt_third.Size = new System.Drawing.Size(63, 34);
            this.txt_third.TabIndex = 12;
            this.txt_third.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.txt_third);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_topic);
            this.Controls.Add(this.btn_sound_on);
            this.Controls.Add(this.btn_sound_off);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English_game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_sound_off;
        private Button btn_sound_on;
        private Button btn_topic;
        private Button btn_exit;
        private Label lbl_rank;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_first;
        private TextBox txt_second;
        private TextBox txt_third;
    }
}