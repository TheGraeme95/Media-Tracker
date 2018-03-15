namespace Media_Tracker
{
    partial class UserCreation
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
            this.Okaybutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.UserCreationInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Okaybutton
            // 
            this.Okaybutton.Location = new System.Drawing.Point(198, 38);
            this.Okaybutton.Name = "Okaybutton";
            this.Okaybutton.Size = new System.Drawing.Size(180, 23);
            this.Okaybutton.TabIndex = 0;
            this.Okaybutton.Text = "Ok";
            this.Okaybutton.UseVisualStyleBackColor = true;
            this.Okaybutton.Click += new System.EventHandler(this.Okaybutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(12, 38);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(180, 23);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // UserCreationInputBox
            // 
            this.UserCreationInputBox.Location = new System.Drawing.Point(139, 10);
            this.UserCreationInputBox.Name = "UserCreationInputBox";
            this.UserCreationInputBox.Size = new System.Drawing.Size(186, 20);
            this.UserCreationInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Username Here:";            
            // 
            // UserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserCreationInputBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Okaybutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserCreation";
            this.Text = "Enter Username";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okaybutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TextBox UserCreationInputBox;
        private System.Windows.Forms.Label label1;
    }
}