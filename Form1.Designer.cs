namespace homeswork
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
            checkbuton = new Button();
            passwd = new TextBox();
            clickexit = new Button();
            SuspendLayout();
            // 
            // checkbuton
            // 
            checkbuton.BackColor = SystemColors.HighlightText;
            checkbuton.Location = new Point(320, 305);
            checkbuton.Name = "checkbuton";
            checkbuton.Size = new Size(125, 51);
            checkbuton.TabIndex = 0;
            checkbuton.Text = "Login";
            checkbuton.UseVisualStyleBackColor = false;
            checkbuton.Click += checkbuton_Click;
            // 
            // passwd
            // 
            passwd.ForeColor = SystemColors.InactiveCaption;
            passwd.Location = new Point(241, 168);
            passwd.Name = "passwd";
            passwd.Size = new Size(204, 27);
            passwd.TabIndex = 1;
            passwd.UseSystemPasswordChar = true;
            // 
            // clickexit
            // 
            clickexit.Location = new Point(524, 305);
            clickexit.Name = "clickexit";
            clickexit.Size = new Size(126, 51);
            clickexit.TabIndex = 2;
            clickexit.Text = "Exit";
            clickexit.UseVisualStyleBackColor = true;
            clickexit.Click += clickexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(729, 450);
            Controls.Add(clickexit);
            Controls.Add(passwd);
            Controls.Add(checkbuton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkbuton;
        private TextBox passwd;
        private Button clickexit;
    }
}
