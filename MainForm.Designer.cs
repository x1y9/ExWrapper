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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupCall = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRun = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupEmbed = new System.Windows.Forms.GroupBox();
            this.textEmbed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIcon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbShowConsole = new System.Windows.Forms.CheckBox();
            this.radioCall = new System.Windows.Forms.RadioButton();
            this.radioEmbed = new System.Windows.Forms.RadioButton();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.groupCall.SuspendLayout();
            this.groupEmbed.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCall
            // 
            this.groupCall.Controls.Add(this.btnOpen);
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
            this.groupCall.Size = new System.Drawing.Size(384, 221);
            this.groupCall.TabIndex = 0;
            this.groupCall.TabStop = false;
            this.groupCall.Text = "Call";
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(307, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(35, 32);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Working Dir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(134, 131);
            this.textDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(167, 28);
            this.textDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parameter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPara
            // 
            this.textPara.Location = new System.Drawing.Point(134, 78);
            this.textPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPara.Name = "textPara";
            this.textPara.Size = new System.Drawing.Size(167, 28);
            this.textPara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textRun
            // 
            this.textRun.Location = new System.Drawing.Point(134, 29);
            this.textRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRun.Name = "textRun";
            this.textRun.Size = new System.Drawing.Size(167, 28);
            this.textRun.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(728, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Exe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupEmbed
            // 
            this.groupEmbed.Controls.Add(this.textEmbed);
            this.groupEmbed.Enabled = false;
            this.groupEmbed.Location = new System.Drawing.Point(453, 95);
            this.groupEmbed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEmbed.Name = "groupEmbed";
            this.groupEmbed.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupEmbed.Size = new System.Drawing.Size(349, 221);
            this.groupEmbed.TabIndex = 6;
            this.groupEmbed.TabStop = false;
            this.groupEmbed.Text = "Embed";
            // 
            // textEmbed
            // 
            this.textEmbed.Location = new System.Drawing.Point(20, 29);
            this.textEmbed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmbed.Multiline = true;
            this.textEmbed.Name = "textEmbed";
            this.textEmbed.Size = new System.Drawing.Size(307, 172);
            this.textEmbed.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(72, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Icon File";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textIcon
            // 
            this.textIcon.Location = new System.Drawing.Point(197, 361);
            this.textIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textIcon.Name = "textIcon";
            this.textIcon.Size = new System.Drawing.Size(167, 28);
            this.textIcon.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(72, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Show Console";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbShowConsole
            // 
            this.cbShowConsole.AutoSize = true;
            this.cbShowConsole.Location = new System.Drawing.Point(197, 407);
            this.cbShowConsole.Name = "cbShowConsole";
            this.cbShowConsole.Size = new System.Drawing.Size(22, 21);
            this.cbShowConsole.TabIndex = 10;
            this.cbShowConsole.UseVisualStyleBackColor = true;
            // 
            // radioCall
            // 
            this.radioCall.AutoSize = true;
            this.radioCall.Checked = true;
            this.radioCall.Location = new System.Drawing.Point(80, 41);
            this.radioCall.Name = "radioCall";
            this.radioCall.Size = new System.Drawing.Size(150, 22);
            this.radioCall.TabIndex = 11;
            this.radioCall.TabStop = true;
            this.radioCall.Text = "Call External";
            this.radioCall.UseVisualStyleBackColor = true;
            // 
            // radioEmbed
            // 
            this.radioEmbed.AutoSize = true;
            this.radioEmbed.Location = new System.Drawing.Point(280, 41);
            this.radioEmbed.Name = "radioEmbed";
            this.radioEmbed.Size = new System.Drawing.Size(132, 22);
            this.radioEmbed.TabIndex = 12;
            this.radioEmbed.Text = "Embed batch";
            this.radioEmbed.UseVisualStyleBackColor = true;
            this.radioEmbed.CheckedChanged += new System.EventHandler(this.radioEmbed_CheckedChanged);
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.AutoSize = true;
            this.btnSelectIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectIcon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectIcon.Location = new System.Drawing.Point(370, 358);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(35, 32);
            this.btnSelectIcon.TabIndex = 7;
            this.btnSelectIcon.Text = "...";
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.btnSelectIcon);
            this.Controls.Add(this.radioEmbed);
            this.Controls.Add(this.radioCall);
            this.Controls.Add(this.cbShowConsole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupEmbed);
            this.Controls.Add(this.textIcon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupCall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ExWrapper 1.0";
            this.groupCall.ResumeLayout(false);
            this.groupCall.PerformLayout();
            this.groupEmbed.ResumeLayout(false);
            this.groupEmbed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbShowConsole;
        private System.Windows.Forms.RadioButton radioCall;
        private System.Windows.Forms.RadioButton radioEmbed;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSelectIcon;
    }
}