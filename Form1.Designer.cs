namespace WinForms_Test
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
            btnPush = new Button();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            btnPush.Location = new Point(163, 162);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(170, 65);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPush);
            Name = "Form1";
            Text = "TestForGitHub";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPush;
    }
}