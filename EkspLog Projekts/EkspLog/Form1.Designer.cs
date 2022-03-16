
namespace EkspLog
{
    partial class Form1
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
            this.lab1 = new System.Windows.Forms.Label();
            this.butLog = new System.Windows.Forms.Button();
            this.butExp = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(217, 9);
            this.lab1.Name = "lab1";
            this.lab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab1.Size = new System.Drawing.Size(366, 56);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Izvēlaties tēmu";
            this.lab1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butLog
            // 
            this.butLog.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLog.Location = new System.Drawing.Point(193, 233);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(430, 72);
            this.butLog.TabIndex = 1;
            this.butLog.Text = "Logaritmi";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // butExp
            // 
            this.butExp.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExp.Location = new System.Drawing.Point(193, 134);
            this.butExp.Name = "butExp";
            this.butExp.Size = new System.Drawing.Size(430, 72);
            this.butExp.TabIndex = 2;
            this.butExp.Text = "Eksponentvienādojumi";
            this.butExp.UseVisualStyleBackColor = true;
            this.butExp.Click += new System.EventHandler(this.butExp_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(12, 399);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(106, 39);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "Iziet";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butHelp
            // 
            this.butHelp.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHelp.Location = new System.Drawing.Point(748, 398);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(40, 40);
            this.butHelp.TabIndex = 4;
            this.butHelp.Text = "?";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author: A. Svarinskis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butExp);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "EkspLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button butExp;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butHelp;
        private System.Windows.Forms.Label label1;
    }
}

