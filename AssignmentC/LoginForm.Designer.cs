
namespace AssignmentC
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sign In";
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_signin.Location = new System.Drawing.Point(268, 569);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(391, 76);
            this.btn_signin.TabIndex = 16;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(268, 489);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(391, 38);
            this.textBox_password.TabIndex = 15;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(262, 444);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(139, 32);
            this.label_password.TabIndex = 14;
            this.label_password.Text = "Password";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(268, 379);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(391, 38);
            this.textBox_email.TabIndex = 13;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(262, 330);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(198, 32);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "Email Address";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
    }
}

