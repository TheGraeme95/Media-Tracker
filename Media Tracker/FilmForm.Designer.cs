namespace Media_Tracker
{
    partial class FilmForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FilmTitleInput = new System.Windows.Forms.TextBox();
            this.FilmDateInput = new System.Windows.Forms.DateTimePicker();
            this.FilmRatingInput = new System.Windows.Forms.ComboBox();
            this.FilmSeenInput = new System.Windows.Forms.CheckBox();
            this.FilmOwnedInput = new System.Windows.Forms.CheckBox();
            this.FilmBlurayInput = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(152, 169);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 169);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FilmTitleInput
            // 
            this.FilmTitleInput.Location = new System.Drawing.Point(45, 12);
            this.FilmTitleInput.Name = "FilmTitleInput";
            this.FilmTitleInput.Size = new System.Drawing.Size(100, 20);
            this.FilmTitleInput.TabIndex = 2;
            // 
            // FilmDateInput
            // 
            this.FilmDateInput.Location = new System.Drawing.Point(72, 41);
            this.FilmDateInput.Name = "FilmDateInput";
            this.FilmDateInput.Size = new System.Drawing.Size(200, 20);
            this.FilmDateInput.TabIndex = 3;
            // 
            // FilmRatingInput
            // 
            this.FilmRatingInput.FormattingEnabled = true;
            this.FilmRatingInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.FilmRatingInput.Location = new System.Drawing.Point(56, 68);
            this.FilmRatingInput.MaxDropDownItems = 11;
            this.FilmRatingInput.Name = "FilmRatingInput";
            this.FilmRatingInput.Size = new System.Drawing.Size(69, 21);
            this.FilmRatingInput.TabIndex = 4;
            // 
            // FilmSeenInput
            // 
            this.FilmSeenInput.AutoSize = true;
            this.FilmSeenInput.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilmSeenInput.Location = new System.Drawing.Point(12, 95);
            this.FilmSeenInput.Name = "FilmSeenInput";
            this.FilmSeenInput.Size = new System.Drawing.Size(54, 17);
            this.FilmSeenInput.TabIndex = 5;
            this.FilmSeenInput.Text = "Seen:";
            this.FilmSeenInput.UseVisualStyleBackColor = true;
            // 
            // FilmOwnedInput
            // 
            this.FilmOwnedInput.AutoSize = true;
            this.FilmOwnedInput.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilmOwnedInput.Location = new System.Drawing.Point(12, 118);
            this.FilmOwnedInput.Name = "FilmOwnedInput";
            this.FilmOwnedInput.Size = new System.Drawing.Size(63, 17);
            this.FilmOwnedInput.TabIndex = 6;
            this.FilmOwnedInput.Text = "Owned:";
            this.FilmOwnedInput.UseVisualStyleBackColor = true;
            // 
            // FilmBlurayInput
            // 
            this.FilmBlurayInput.AutoSize = true;
            this.FilmBlurayInput.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilmBlurayInput.Location = new System.Drawing.Point(12, 141);
            this.FilmBlurayInput.Name = "FilmBlurayInput";
            this.FilmBlurayInput.Size = new System.Drawing.Size(63, 17);
            this.FilmBlurayInput.TabIndex = 7;
            this.FilmBlurayInput.Text = "BluRay:";
            this.FilmBlurayInput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Seen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rating:";
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmBlurayInput);
            this.Controls.Add(this.FilmOwnedInput);
            this.Controls.Add(this.FilmSeenInput);
            this.Controls.Add(this.FilmRatingInput);
            this.Controls.Add(this.FilmDateInput);
            this.Controls.Add(this.FilmTitleInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilmForm";
            this.Text = "Add Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox FilmTitleInput;
        private System.Windows.Forms.DateTimePicker FilmDateInput;
        private System.Windows.Forms.ComboBox FilmRatingInput;
        private System.Windows.Forms.CheckBox FilmSeenInput;
        private System.Windows.Forms.CheckBox FilmOwnedInput;
        private System.Windows.Forms.CheckBox FilmBlurayInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}