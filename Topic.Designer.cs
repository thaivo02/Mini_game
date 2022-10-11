using System.Reflection;

namespace Exercise1
{
    partial class Topic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topic));
            this.btn_sound_off = new System.Windows.Forms.Button();
            this.btn_sound_on = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_fruit = new System.Windows.Forms.Button();
            this.btn_vehicle = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_animal = new System.Windows.Forms.Button();
            this.fruit = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.Label();
            this.household = new System.Windows.Forms.Label();
            this.animal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sound_off
            // 
            this.btn_sound_off.BackColor = System.Drawing.Color.LightGreen;
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
            this.btn_sound_on.BackColor = System.Drawing.Color.LightGreen;
            this.btn_sound_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_on.BackgroundImage")));
            this.btn_sound_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_on.Location = new System.Drawing.Point(12, 70);
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
            this.label1.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(285, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE A TOPIC";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SeaShell;
            this.btn_exit.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(54, 531);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(293, 47);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 40);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_fruit
            // 
            this.btn_fruit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fruit.BackgroundImage")));
            this.btn_fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fruit.Location = new System.Drawing.Point(89, 96);
            this.btn_fruit.Name = "btn_fruit";
            this.btn_fruit.Size = new System.Drawing.Size(346, 160);
            this.btn_fruit.TabIndex = 5;
            this.btn_fruit.UseVisualStyleBackColor = true;
            this.btn_fruit.Click += new System.EventHandler(this.btn_fruit_Click);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vehicle.BackgroundImage")));
            this.btn_vehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vehicle.Location = new System.Drawing.Point(518, 96);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Size = new System.Drawing.Size(346, 160);
            this.btn_vehicle.TabIndex = 5;
            this.btn_vehicle.UseVisualStyleBackColor = true;
            this.btn_vehicle.Click += new System.EventHandler(this.btn_vehicle_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_color.BackgroundImage")));
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color.Location = new System.Drawing.Point(89, 309);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(346, 160);
            this.btn_color.TabIndex = 5;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_animal
            // 
            this.btn_animal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_animal.BackgroundImage")));
            this.btn_animal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_animal.Location = new System.Drawing.Point(518, 309);
            this.btn_animal.Name = "btn_animal";
            this.btn_animal.Size = new System.Drawing.Size(346, 160);
            this.btn_animal.TabIndex = 5;
            this.btn_animal.UseVisualStyleBackColor = true;
            this.btn_animal.Click += new System.EventHandler(this.btn_animal_Click);
            // 
            // fruit
            // 
            this.fruit.AutoSize = true;
            this.fruit.BackColor = System.Drawing.Color.Transparent;
            this.fruit.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fruit.ForeColor = System.Drawing.Color.Black;
            this.fruit.Location = new System.Drawing.Point(203, 259);
            this.fruit.Name = "fruit";
            this.fruit.Size = new System.Drawing.Size(118, 36);
            this.fruit.TabIndex = 6;
            this.fruit.Text = "Fruits";
            // 
            // vehicle
            // 
            this.vehicle.AutoSize = true;
            this.vehicle.BackColor = System.Drawing.Color.Transparent;
            this.vehicle.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicle.ForeColor = System.Drawing.Color.Black;
            this.vehicle.Location = new System.Drawing.Point(624, 259);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(148, 36);
            this.vehicle.TabIndex = 6;
            this.vehicle.Text = "Vehicles";
            // 
            // household
            // 
            this.household.AutoSize = true;
            this.household.BackColor = System.Drawing.Color.Transparent;
            this.household.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.household.ForeColor = System.Drawing.Color.Black;
            this.household.Location = new System.Drawing.Point(121, 472);
            this.household.Name = "household";
            this.household.Size = new System.Drawing.Size(287, 36);
            this.household.TabIndex = 6;
            this.household.Text = "Household things";
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.BackColor = System.Drawing.Color.Transparent;
            this.animal.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.animal.ForeColor = System.Drawing.Color.Black;
            this.animal.Location = new System.Drawing.Point(624, 472);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(139, 36);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.household);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.fruit);
            this.Controls.Add(this.btn_animal);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_vehicle);
            this.Controls.Add(this.btn_fruit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_sound_on);
            this.Controls.Add(this.btn_sound_off);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Topic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English_game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_sound_off;
        private Button btn_sound_on;
        private Label label1;
        private Button btn_exit;
        private Button btn_back;
        private Button btn_fruit;
        private Button btn_vehicle;
        private Button btn_color;
        private Button btn_animal;
        private Label fruit;
        private Label vehicle;
        private Label household;
        private Label animal;
    }
}