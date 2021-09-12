
namespace AssignmentC
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label_selected = new System.Windows.Forms.Label();
            this.textBox_selectedID = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_studentRegistration = new System.Windows.Forms.Label();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label_contact = new System.Windows.Forms.Label();
            this.textBox_phNumber = new System.Windows.Forms.TextBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.radioButton_m = new System.Windows.Forms.RadioButton();
            this.radioButton_f = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Update.Location = new System.Drawing.Point(81, 1088);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(219, 88);
            this.Btn_Update.TabIndex = 51;
            this.Btn_Update.Text = "Update Selected";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label_selected
            // 
            this.label_selected.AutoSize = true;
            this.label_selected.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_selected.Location = new System.Drawing.Point(75, 958);
            this.label_selected.Name = "label_selected";
            this.label_selected.Size = new System.Drawing.Size(263, 32);
            this.label_selected.TabIndex = 50;
            this.label_selected.Text = "Selected Student Id";
            // 
            // textBox_selectedID
            // 
            this.textBox_selectedID.Location = new System.Drawing.Point(81, 1009);
            this.textBox_selectedID.Name = "textBox_selectedID";
            this.textBox_selectedID.Size = new System.Drawing.Size(107, 38);
            this.textBox_selectedID.TabIndex = 49;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_lastName.Location = new System.Drawing.Point(336, 330);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(267, 38);
            this.textBox_lastName.TabIndex = 48;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_lastName.Location = new System.Drawing.Point(330, 283);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(151, 32);
            this.label_lastName.TabIndex = 47;
            this.label_lastName.Text = "Last Name";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Delete.Location = new System.Drawing.Point(384, 1088);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(219, 88);
            this.Btn_Delete.TabIndex = 46;
            this.Btn_Delete.Text = "Delete Selected";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click_1);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 58;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(686, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1935, 893);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_studentRegistration
            // 
            this.label_studentRegistration.AutoSize = true;
            this.label_studentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentRegistration.Location = new System.Drawing.Point(107, 125);
            this.label_studentRegistration.Name = "label_studentRegistration";
            this.label_studentRegistration.Size = new System.Drawing.Size(479, 58);
            this.label_studentRegistration.TabIndex = 42;
            this.label_studentRegistration.Text = "Student Registration";
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Register.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Register.Location = new System.Drawing.Point(81, 692);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(522, 88);
            this.Btn_Register.TabIndex = 41;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click_1);
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_contact.Location = new System.Drawing.Point(75, 569);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(220, 32);
            this.label_contact.TabIndex = 40;
            this.label_contact.Text = "Contact Number";
            // 
            // textBox_phNumber
            // 
            this.textBox_phNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_phNumber.Location = new System.Drawing.Point(81, 614);
            this.textBox_phNumber.Name = "textBox_phNumber";
            this.textBox_phNumber.Size = new System.Drawing.Size(522, 38);
            this.textBox_phNumber.TabIndex = 39;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_gender.Location = new System.Drawing.Point(330, 425);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(110, 32);
            this.label_gender.TabIndex = 38;
            this.label_gender.Text = "Gender";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_age.Location = new System.Drawing.Point(75, 425);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(66, 32);
            this.label_age.TabIndex = 37;
            this.label_age.Text = "Age";
            // 
            // textBox_age
            // 
            this.textBox_age.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_age.Location = new System.Drawing.Point(81, 469);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(219, 38);
            this.textBox_age.TabIndex = 36;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_firstName.Location = new System.Drawing.Point(81, 330);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(219, 38);
            this.textBox_firstName.TabIndex = 35;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_firstName.Location = new System.Drawing.Point(75, 283);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(152, 32);
            this.label_firstName.TabIndex = 34;
            this.label_firstName.Text = "First Name";
            // 
            // radioButton_m
            // 
            this.radioButton_m.AutoSize = true;
            this.radioButton_m.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButton_m.Location = new System.Drawing.Point(336, 469);
            this.radioButton_m.Name = "radioButton_m";
            this.radioButton_m.Size = new System.Drawing.Size(114, 36);
            this.radioButton_m.TabIndex = 52;
            this.radioButton_m.TabStop = true;
            this.radioButton_m.Text = "Male";
            this.radioButton_m.UseVisualStyleBackColor = true;
            // 
            // radioButton_f
            // 
            this.radioButton_f.AutoSize = true;
            this.radioButton_f.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButton_f.Location = new System.Drawing.Point(456, 469);
            this.radioButton_f.Name = "radioButton_f";
            this.radioButton_f.Size = new System.Drawing.Size(147, 36);
            this.radioButton_f.TabIndex = 53;
            this.radioButton_f.TabStop = true;
            this.radioButton_f.Text = "Female";
            this.radioButton_f.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2662, 1256);
            this.Controls.Add(this.radioButton_f);
            this.Controls.Add(this.radioButton_m);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label_selected);
            this.Controls.Add(this.textBox_selectedID);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_studentRegistration);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.textBox_phNumber);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label_firstName);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label_selected;
        private System.Windows.Forms.TextBox textBox_selectedID;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_studentRegistration;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox textBox_phNumber;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.RadioButton radioButton_m;
        private System.Windows.Forms.RadioButton radioButton_f;
    }
}