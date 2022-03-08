
namespace EkspLog
{
    partial class Form2
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
            this.butBack = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butBack
            // 
            this.butBack.Font = new System.Drawing.Font("Arial", 30F);
            this.butBack.Location = new System.Drawing.Point(299, 352);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(213, 70);
            this.butBack.TabIndex = 4;
            this.butBack.Text = "Atpakaļ";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // lab2
            // 
            this.lab2.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(12, 9);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(776, 137);
            this.lab2.TabIndex = 5;
            this.lab2.Text = "Šī programma uzdod eksponentvienādojumu un logaritmu piemērus.";
            this.lab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab3
            // 
            this.lab3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.Location = new System.Drawing.Point(12, 118);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(776, 137);
            this.lab3.TabIndex = 6;
            this.lab3.Text = "Piemērus ir jāatrisina, un jāievada pareizās atbildes. Kļūdas gadījumos tiks atkl" +
    "ātas pareizās atbildes un risinājumu soļi.";
            this.lab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.butBack);
            this.Name = "Form2";
            this.Text = "EkspLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
    }
}