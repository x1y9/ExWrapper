namespace ExWrapper
{
    partial class MainForm
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
            this.groupCall = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRun = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupEmbed = new System.Windows.Forms.GroupBox();
            this.textEmbed = new System.Windows.Forms.TextBox();
            this.groupCall.SuspendLayout();
            this.groupEmbed.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCall
            // 
            this.groupCall.Controls.Add(this.label3);
            this.groupCall.Controls.Add(this.textDir);
            this.groupCall.Controls.Add(this.label2);
            this.groupCall.Controls.Add(this.textPara);
            this.groupCall.Controls.Add(this.label1);
            this.groupCall.Controls.Add(this.textRun);
            this.groupCall.Location = new System.Drawing.Point(63, 95);
            this.groupCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCall.Name = "groupCall";
            this.groupCall.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupCall.Size = new System.Drawing.Size(349, 280);
            this.groupCall.TabIndex = 0;
            this.groupCall.TabStop = false;
            this.groupCall.Text = "Call";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Working Dir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(134, 178);
            this.textDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(167, 28);
            this.textDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parameter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPara
            // 
            this.textPara.Location = new System.Drawing.Point(134, 125);
            this.textPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPara.Name = "textPara";
            this.textPara.Size = new System.Drawing.Size(167, 28);
            this.textPara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textRun
            // 
            this.textRun.Location = new System.Drawing.Point(134, 76);
            this.textRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRun.Name = "textRun";
            this.textRun.Size = new System.Drawing.Size(167, 28);
            this.textRun.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(777, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupEmbed
            // 
            this.groupEmbed.Controls.Add(this.textEmbed);
            this.groupEmbed.Location = new System.Drawing.Point(453, 95);
            this.groupEmbed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEmbed.Name = "groupEmbed";
            this.groupEmbed.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEmbed.Size = new System.Drawing.Size(349, 280);
            this.groupEmbed.TabIndex = 6;
            this.groupEmbed.TabStop = false;
            this.groupEmbed.Text = "Embed";
            // 
            // textEmbed
            // 
            this.textEmbed.Location = new System.Drawing.Point(33, 74);
            this.textEmbed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmbed.Multiline = true;
            this.textEmbed.Name = "textEmbed";
            this.textEmbed.Size = new System.Drawing.Size(288, 132);
            this.textEmbed.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.groupEmbed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupCall);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ExWrapper";
            this.groupCall.ResumeLayout(false);
            this.groupCall.PerformLayout();
            this.groupEmbed.ResumeLayout(false);
            this.groupEmbed.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textEmbed;

        private System.Windows.Forms.GroupBox groupCall;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDir;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPara;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupEmbed;
        private System.Windows.Forms.TextBox textRun;

        #endregion
    }
}