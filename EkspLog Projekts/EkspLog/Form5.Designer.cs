
namespace EkspLog
{
    partial class FormLog1
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
            this.labLog1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLog1 = new System.Windows.Forms.TextBox();
            this.butLog1Back = new System.Windows.Forms.Button();
            this.butLog1Next = new System.Windows.Forms.Button();
            this.butLog1Check = new System.Windows.Forms.Button();
            this.labLog1answer = new System.Windows.Forms.Label();
            this.labLog1yn = new System.Windows.Forms.Label();
            this.butLog1Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLog1
            // 
            this.labLog1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLog1.Location = new System.Drawing.Point(12, 107);
            this.labLog1.Name = "labLog1";
            this.labLog1.Size = new System.Drawing.Size(250, 70);
            this.labLog1.TabIndex = 0;
            this.labLog1.Text = "log 2 (8) =";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Uzdevums";
            // 
            // textLog1
            // 
            this.textLog1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog1.Location = new System.Drawing.Point(268, 108);
            this.textLog1.Multiline = true;
            this.textLog1.Name = "textLog1";
            this.textLog1.Size = new System.Drawing.Size(132, 57);
            this.textLog1.TabIndex = 2;
            // 
            // butLog1Back
            // 
            this.butLog1Back.Font = new System.Drawing.Font("Arial", 16F);
            this.butLog1Back.Location = new System.Drawing.Point(142, 390);
            this.butLog1Back.Name = "butLog1Back";
            this.butLog1Back.Size = new System.Drawing.Size(131, 48);
            this.butLog1Back.TabIndex = 5;
            this.butLog1Back.Text = "Atpakaļ";
            this.butLog1Back.UseVisualStyleBackColor = true;
            this.butLog1Back.Click += new System.EventHandler(this.butLog1Back_Click);
            // 
            // butLog1Next
            // 
            this.butLog1Next.Font = new System.Drawing.Font("Arial", 16F);
            this.butLog1Next.Location = new System.Drawing.Point(671, 380);
            this.butLog1Next.Name = "butLog1Next";
            this.butLog1Next.Size = new System.Drawing.Size(117, 58);
            this.butLog1Next.TabIndex = 6;
            this.butLog1Next.Text = "Nākamais uzdevums";
            this.butLog1Next.UseVisualStyleBackColor = true;
            // 
            // butLog1Check
            // 
            this.butLog1Check.Font = new System.Drawing.Font("Arial", 30F);
            this.butLog1Check.Location = new System.Drawing.Point(575, 107);
            this.butLog1Check.Name = "butLog1Check";
            this.butLog1Check.Size = new System.Drawing.Size(213, 70);
            this.butLog1Check.TabIndex = 7;
            this.butLog1Check.Text = "Pārbaudīt";
            this.butLog1Check.UseVisualStyleBackColor = true;
            this.butLog1Check.Click += new System.EventHandler(this.butLog1Check_Click);
            // 
            // labLog1answer
            // 
            this.labLog1answer.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLog1answer.Location = new System.Drawing.Point(12, 177);
            this.labLog1answer.Name = "labLog1answer";
            this.labLog1answer.Size = new System.Drawing.Size(175, 183);
            this.labLog1answer.TabIndex = 8;
            this.labLog1answer.Text = "log 2 (8) = x 2^x = 8   2^x =2^3    x = 3";
            // 
            // labLog1yn
            // 
            this.labLog1yn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLog1yn.Location = new System.Drawing.Point(406, 107);
            this.labLog1yn.Name = "labLog1yn";
            this.labLog1yn.Size = new System.Drawing.Size(158, 83);
            this.labLog1yn.TabIndex = 12;
            this.labLog1yn.Text = "...";
            // 
            // butLog1Main
            // 
            this.butLog1Main.Font = new System.Drawing.Font("Arial", 16F);
            this.butLog1Main.Location = new System.Drawing.Point(5, 390);
            this.butLog1Main.Name = "butLog1Main";
            this.butLog1Main.Size = new System.Drawing.Size(131, 48);
            this.butLog1Main.TabIndex = 13;
            this.butLog1Main.Text = "Uz sākumu";
            this.butLog1Main.UseVisualStyleBackColor = true;
            this.butLog1Main.Click += new System.EventHandler(this.butLog1Main_Click);
            // 
            // FormLog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butLog1Main);
            this.Controls.Add(this.labLog1yn);
            this.Controls.Add(this.labLog1answer);
            this.Controls.Add(this.butLog1Check);
            this.Controls.Add(this.butLog1Next);
            this.Controls.Add(this.butLog1Back);
            this.Controls.Add(this.textLog1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labLog1);
            this.Name = "FormLog1";
            this.Text = "Matemātikas uzdevumi";
            this.Load += new System.EventHandler(this.FormLog1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLog1;
        private System.Windows.Forms.Button butLog1Back;
        private System.Windows.Forms.Button butLog1Next;
        private System.Windows.Forms.Button butLog1Check;
        private System.Windows.Forms.Label labLog1answer;
        private System.Windows.Forms.Label labLog1yn;
        private System.Windows.Forms.Button butLog1Main;
    }
}