namespace COMP123_S2019_Lesson8A
{
    partial class Lab08Form
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InfogroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InfogroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(89, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lab08";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfogroupBox
            // 
            this.InfogroupBox.Controls.Add(this.AgeTextBox);
            this.InfogroupBox.Controls.Add(this.AgeLabel);
            this.InfogroupBox.Controls.Add(this.NameTextBox);
            this.InfogroupBox.Controls.Add(this.NameLabel);
            this.InfogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfogroupBox.Location = new System.Drawing.Point(20, 43);
            this.InfogroupBox.Name = "InfogroupBox";
            this.InfogroupBox.Size = new System.Drawing.Size(580, 103);
            this.InfogroupBox.TabIndex = 1;
            this.InfogroupBox.TabStop = false;
            this.InfogroupBox.Text = "Info";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(7, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(177, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(182, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(398, 38);
            this.NameTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(182, 64);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(398, 38);
            this.AgeTextBox.TabIndex = 3;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(32, 67);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(152, 31);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Enter Age:";
            // 
            // Submitbutton
            // 
            this.Submitbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbutton.Location = new System.Drawing.Point(457, 384);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(136, 45);
            this.Submitbutton.TabIndex = 2;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(14, 398);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 31);
            this.OutputLabel.TabIndex = 3;
            // 
            // Lab08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.InfogroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Lab08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InfogroupBox.ResumeLayout(false);
            this.InfogroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox InfogroupBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

