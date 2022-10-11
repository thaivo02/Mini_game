using System.Reflection;

namespace Exercise1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_sound_off = new System.Windows.Forms.Button();
            this.btn_sound_on = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_dict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.SeaShell;
            this.btn_start.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(551, 531);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(293, 47);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_sound_off
            // 
            this.btn_sound_off.BackColor = System.Drawing.Color.Lavender;
            this.btn_sound_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_off.BackgroundImage")));
            this.btn_sound_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_off.Location = new System.Drawing.Point(12, 122);
            this.btn_sound_off.Name = "btn_sound_off";
            this.btn_sound_off.Size = new System.Drawing.Size(42, 40);
            this.btn_sound_off.TabIndex = 2;
            this.btn_sound_off.UseVisualStyleBackColor = false;
            this.btn_sound_off.Click += new System.EventHandler(this.btn_sound_off_Click);
            // 
            // btn_sound_on
            // 
            this.btn_sound_on.BackColor = System.Drawing.Color.Lavender;
            this.btn_sound_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_on.BackgroundImage")));
            this.btn_sound_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_on.Location = new System.Drawing.Point(12, 70);
            this.btn_sound_on.Name = "btn_sound_on";
            this.btn_sound_on.Size = new System.Drawing.Size(42, 40);
            this.btn_sound_on.TabIndex = 2;
            this.btn_sound_on.UseVisualStyleBackColor = false;
            this.btn_sound_on.Click += new System.EventHandler(this.btn_sound_on_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SeaShell;
            this.btn_exit.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(54, 531);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(293, 47);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_dict
            // 
            this.btn_dict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dict.BackgroundImage")));
            this.btn_dict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dict.ForeColor = System.Drawing.Color.Black;
            this.btn_dict.Location = new System.Drawing.Point(12, 12);
            this.btn_dict.Name = "btn_dict";
            this.btn_dict.Size = new System.Drawing.Size(40, 42);
            this.btn_dict.TabIndex = 3;
            this.btn_dict.UseVisualStyleBackColor = true;
            this.btn_dict.Click += new System.EventHandler(this.btn_dict_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.btn_dict);
            this.Controls.Add(this.btn_sound_on);
            this.Controls.Add(this.btn_sound_off);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English_game";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_start;
        private Button btn_sound_off;
        private Button btn_sound_on;
        private Button btn_exit;
        private Button btn_dict;
    }
}