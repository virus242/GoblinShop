namespace GoblinShop
{
    partial class AuthUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingUp = new System.Windows.Forms.Label();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.SingUp);
            this.panel1.Controls.Add(this.buttonSingIn);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 406);
            this.panel1.TabIndex = 0;
            // 
            // SingUp
            // 
            this.SingUp.AutoSize = true;
            this.SingUp.BackColor = System.Drawing.Color.Transparent;
            this.SingUp.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.SingUp.Location = new System.Drawing.Point(114, 338);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(123, 43);
            this.SingUp.TabIndex = 4;
            this.SingUp.Text = "SingUp";
            this.SingUp.Click += new System.EventHandler(this.SingUp_Click);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.buttonSingIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.buttonSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingIn.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.buttonSingIn.Location = new System.Drawing.Point(93, 276);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(157, 50);
            this.buttonSingIn.TabIndex = 3;
            this.buttonSingIn.Text = "SingIN";
            this.buttonSingIn.UseVisualStyleBackColor = false;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click_1);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.PasswordBox.Location = new System.Drawing.Point(71, 202);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(203, 47);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.NameBox.Location = new System.Drawing.Point(71, 120);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 47);
            this.NameBox.TabIndex = 1;
            this.NameBox.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth";
            // 
            // AuthUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 406);
            this.Controls.Add(this.panel1);
            this.Name = "AuthUser";
            this.Text = "AuthUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthUser_FormClosed);
            this.Load += new System.EventHandler(this.AuthUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Label SingUp;
    }
}