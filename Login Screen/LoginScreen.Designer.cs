namespace Login_Screen
{
    partial class LoginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(242, 173);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(117, 20);
            this.passBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(242, 103);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(117, 20);
            this.nameBox.TabIndex = 6;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(117, 173);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(104, 23);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(117, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 23);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Username:";
            // 
            // failLabel
            // 
            this.failLabel.Location = new System.Drawing.Point(118, 253);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(299, 23);
            this.failLabel.TabIndex = 8;
            this.failLabel.Text = "Login failed. Please check your details and try again.";
            this.failLabel.Visible = false;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(186, 213);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(109, 28);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Button goButton;
    }
}
