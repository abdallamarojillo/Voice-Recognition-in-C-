namespace InformerR
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lecturer = new System.Windows.Forms.TextBox();
            this.dayt = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.venue = new System.Windows.Forms.TextBox();
            this.unitname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::InformerR.Properties.Resources.Edit_Property_16px;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lecturer);
            this.groupBox2.Controls.Add(this.dayt);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.venue);
            this.groupBox2.Controls.Add(this.unitname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(390, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "    ADD CLASS ACTIVITIES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(122, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "label8";
            // 
            // lecturer
            // 
            this.lecturer.ForeColor = System.Drawing.Color.Teal;
            this.lecturer.Location = new System.Drawing.Point(135, 222);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(166, 20);
            this.lecturer.TabIndex = 10;
            this.lecturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dayt
            // 
            this.dayt.ForeColor = System.Drawing.Color.Teal;
            this.dayt.Location = new System.Drawing.Point(135, 185);
            this.dayt.Name = "dayt";
            this.dayt.Size = new System.Drawing.Size(166, 20);
            this.dayt.TabIndex = 9;
            this.dayt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time
            // 
            this.time.ForeColor = System.Drawing.Color.Teal;
            this.time.Location = new System.Drawing.Point(135, 141);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(166, 20);
            this.time.TabIndex = 8;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DAY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LECTURER";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "ADD ACTIVITY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // venue
            // 
            this.venue.ForeColor = System.Drawing.Color.Teal;
            this.venue.Location = new System.Drawing.Point(135, 98);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(166, 20);
            this.venue.TabIndex = 3;
            this.venue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitname
            // 
            this.unitname.ForeColor = System.Drawing.Color.Teal;
            this.unitname.Location = new System.Drawing.Point(135, 46);
            this.unitname.Name = "unitname";
            this.unitname.Size = new System.Drawing.Size(166, 20);
            this.unitname.TabIndex = 2;
            this.unitname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "VENUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "UNIT TITLE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::InformerR.Properties.Resources.Add_User_Male_16px;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(45, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   ADD USER TO SYSTEM";
            // 
            // button1
            // 
            this.button1.Image = global::InformerR.Properties.Resources.Reviewer_Male_16px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(65, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD USER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Teal;
            this.password.Location = new System.Drawing.Point(135, 105);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(166, 20);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.Color.Teal;
            this.username.Location = new System.Drawing.Point(135, 49);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(166, 20);
            this.username.TabIndex = 2;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::InformerR.Properties.Resources.Key_16px;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "     PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::InformerR.Properties.Resources.User_16px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "   USERNAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1114, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Informer";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lecturer;
        private System.Windows.Forms.TextBox dayt;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox venue;
        private System.Windows.Forms.TextBox unitname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}