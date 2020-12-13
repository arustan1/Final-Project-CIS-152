namespace FinalProjectRustan
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.TextBox();
            this.admitBtn = new System.Windows.Forms.Button();
            this.queueBox = new System.Windows.Forms.RichTextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.helpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.submitBtn.Location = new System.Drawing.Point(26, 347);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(201, 347);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 29);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(26, 50);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(56, 20);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name: ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(137, 47);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(158, 27);
            this.nameBox.TabIndex = 0;
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Location = new System.Drawing.Point(26, 105);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(59, 20);
            this.priorityLbl.TabIndex = 4;
            this.priorityLbl.Text = "Priority:";
            // 
            // priorityBox
            // 
            this.priorityBox.Location = new System.Drawing.Point(137, 102);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(158, 27);
            this.priorityBox.TabIndex = 4;
            // 
            // admitBtn
            // 
            this.admitBtn.Location = new System.Drawing.Point(403, 47);
            this.admitBtn.Name = "admitBtn";
            this.admitBtn.Size = new System.Drawing.Size(234, 29);
            this.admitBtn.TabIndex = 7;
            this.admitBtn.Text = "&Admit Next Patient";
            this.admitBtn.UseVisualStyleBackColor = true;
            this.admitBtn.Click += new System.EventHandler(this.admitBtn_Click);
            // 
            // queueBox
            // 
            this.queueBox.Location = new System.Drawing.Point(389, 102);
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(263, 274);
            this.queueBox.TabIndex = 12;
            this.queueBox.Text = "";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLbl.Location = new System.Drawing.Point(26, 163);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 20);
            this.errorLbl.TabIndex = 0;
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.helpLbl.Location = new System.Drawing.Point(137, 132);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(126, 20);
            this.helpLbl.TabIndex = 13;
            this.helpLbl.Text = "[A-D] A is highest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 411);
            this.Controls.Add(this.helpLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.admitBtn);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.submitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label priorityLbl;
        private System.Windows.Forms.TextBox priorityBox;
        private System.Windows.Forms.Button admitBtn;
        private System.Windows.Forms.RichTextBox queueBox;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label helpLbl;
    }
}

