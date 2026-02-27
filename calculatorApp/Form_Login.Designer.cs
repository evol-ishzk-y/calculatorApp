namespace calculatorApp
{
    partial class Form_Login
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
            label1 = new Label();
            label2 = new Label();
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 158);
            label1.Name = "label1";
            label1.Size = new Size(161, 48);
            label1.TabIndex = 0;
            label1.Text = "ユーザー名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 346);
            label2.Name = "label2";
            label2.Size = new Size(151, 48);
            label2.TabIndex = 1;
            label2.Text = "パスワード";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(333, 151);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(566, 55);
            userTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(333, 343);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(566, 55);
            passTextBox.TabIndex = 3;
            passTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(674, 514);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(225, 69);
            loginButton.TabIndex = 4;
            loginButton.Text = "ログイン";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 656);
            Controls.Add(loginButton);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Login";
            Text = "Form_Login";
            Load += Form_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userTextBox;
        private TextBox passTextBox;
        private Button loginButton;
    }
}