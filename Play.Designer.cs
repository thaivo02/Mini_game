using System.Reflection;

namespace Exercise1
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.btn_sound_off = new System.Windows.Forms.Button();
            this.btn_sound_on = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pic_quest = new System.Windows.Forms.PictureBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quest)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sound_off
            // 
            this.btn_sound_off.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sound_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_off.BackgroundImage")));
            this.btn_sound_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_off.Location = new System.Drawing.Point(11, 123);
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
            this.btn_sound_on.Location = new System.Drawing.Point(11, 69);
            this.btn_sound_on.Name = "btn_sound_on";
            this.btn_sound_on.Size = new System.Drawing.Size(42, 40);
            this.btn_sound_on.TabIndex = 2;
            this.btn_sound_on.UseVisualStyleBackColor = false;
            this.btn_sound_on.Click += new System.EventHandler(this.btn_sound_on_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is this?";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(11, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 40);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pic_quest
            // 
            this.pic_quest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_quest.Location = new System.Drawing.Point(110, 133);
            this.pic_quest.Name = "pic_quest";
            this.pic_quest.Size = new System.Drawing.Size(654, 331);
            this.pic_quest.TabIndex = 5;
            this.pic_quest.TabStop = false;
            // 
            // txt_answer
            // 
            this.txt_answer.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_answer.Location = new System.Drawing.Point(110, 505);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.PlaceholderText = "Your answer ...";
            this.txt_answer.Size = new System.Drawing.Size(654, 38);
            this.txt_answer.TabIndex = 6;
            this.txt_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_answer_KeyPress);
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
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 589);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.pic_quest);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_sound_on);
            this.Controls.Add(this.btn_sound_off);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English_game";
            this.Load += new System.EventHandler(this.Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_quest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_sound_off;
        private Button btn_sound_on;
        private Label label1;
        private Button btn_back;
        private PictureBox pic_quest;
        private TextBox txt_answer;
        private Button btn_exit;
    }
}