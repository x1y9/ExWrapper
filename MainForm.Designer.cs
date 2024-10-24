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
            this.groupCall.Location = new System.Drawing.Point(56, 79);
            this.groupCall.Name = "groupCall";
            this.groupCall.Size = new System.Drawing.Size(310, 233);
            this.groupCall.TabIndex = 0;
            this.groupCall.TabStop = false;
            this.groupCall.Text = "Call";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Working Dir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(119, 148);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(149, 25);
            this.textDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parameter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPara
            // 
            this.textPara.Location = new System.Drawing.Point(119, 104);
            this.textPara.Name = "textPara";
            this.textPara.Size = new System.Drawing.Size(149, 25);
            this.textPara.TabIndex = 2;
            this.textPara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textRun
            // 
            this.textRun.Location = new System.Drawing.Point(119, 63);
            this.textRun.Name = "textRun";
            this.textRun.Size = new System.Drawing.Size(149, 25);
            this.textRun.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupEmbed
            // 
            this.groupEmbed.Controls.Add(this.textEmbed);
            this.groupEmbed.Location = new System.Drawing.Point(403, 79);
            this.groupEmbed.Name = "groupEmbed";
            this.groupEmbed.Size = new System.Drawing.Size(310, 233);
            this.groupEmbed.TabIndex = 6;
            this.groupEmbed.TabStop = false;
            this.groupEmbed.Text = "Embed";
            this.groupEmbed.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textEmbed
            // 
            this.textEmbed.Location = new System.Drawing.Point(29, 62);
            this.textEmbed.Multiline = true;
            this.textEmbed.Name = "textEmbed";
            this.textEmbed.Size = new System.Drawing.Size(256, 111);
            this.textEmbed.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupEmbed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupCall);
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