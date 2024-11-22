namespace AuthTestWinApi
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            textBoxDomain = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            textBoxURL = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 192);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Kerb Auth";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 192);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "NTLM Auth";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDomain
            // 
            textBoxDomain.Location = new Point(102, 78);
            textBoxDomain.Name = "textBoxDomain";
            textBoxDomain.Size = new Size(280, 31);
            textBoxDomain.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "Domain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 124);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 5;
            label2.Text = "User";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(102, 118);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(280, 31);
            textBoxUserName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 161);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(102, 155);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(280, 31);
            textBoxPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 46);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 8;
            label4.Text = "URL";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(102, 43);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(280, 31);
            textBoxURL.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 291);
            Controls.Add(textBoxURL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUserName);
            Controls.Add(label1);
            Controls.Add(textBoxDomain);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Win Auth Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxDomain;
        private Label label1;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label4;
        private TextBox textBoxURL;
    }
}
