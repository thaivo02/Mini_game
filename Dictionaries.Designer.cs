namespace English_game
{
    partial class Dictionaries
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
            this.grid_dict = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dict)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_dict
            // 
            this.grid_dict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dict.Location = new System.Drawing.Point(0, 0);
            this.grid_dict.Name = "grid_dict";
            this.grid_dict.ReadOnly = true;
            this.grid_dict.RowHeadersWidth = 51;
            this.grid_dict.RowTemplate.Height = 29;
            this.grid_dict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_dict.Size = new System.Drawing.Size(546, 563);
            this.grid_dict.TabIndex = 0;
            // 
            // Dictionaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 563);
            this.Controls.Add(this.grid_dict);
            this.Name = "Dictionaries";
            this.Text = "Dictionaries";
            ((System.ComponentModel.ISupportInitialize)(this.grid_dict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grid_dict;
    }
}