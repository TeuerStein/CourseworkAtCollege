
namespace CourseworkAtCollege
{
    partial class ResultOfOrdering
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.passportData = new System.Windows.Forms.Label();
            this.telephoneNumber = new System.Windows.Forms.Label();
            this.dateOfTheEndOfTheContract = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(383, 50);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(35, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "label1";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(383, 98);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(35, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "label2";
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(383, 148);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(35, 13);
            this.fatherName.TabIndex = 2;
            this.fatherName.Text = "label3";
            // 
            // passportData
            // 
            this.passportData.AutoSize = true;
            this.passportData.Location = new System.Drawing.Point(383, 200);
            this.passportData.Name = "passportData";
            this.passportData.Size = new System.Drawing.Size(35, 13);
            this.passportData.TabIndex = 3;
            this.passportData.Text = "label4";
            // 
            // telephoneNumber
            // 
            this.telephoneNumber.AutoSize = true;
            this.telephoneNumber.Location = new System.Drawing.Point(383, 248);
            this.telephoneNumber.Name = "telephoneNumber";
            this.telephoneNumber.Size = new System.Drawing.Size(35, 13);
            this.telephoneNumber.TabIndex = 4;
            this.telephoneNumber.Text = "label5";
            // 
            // dateOfTheEndOfTheContract
            // 
            this.dateOfTheEndOfTheContract.AutoSize = true;
            this.dateOfTheEndOfTheContract.Location = new System.Drawing.Point(383, 296);
            this.dateOfTheEndOfTheContract.Name = "dateOfTheEndOfTheContract";
            this.dateOfTheEndOfTheContract.Size = new System.Drawing.Size(35, 13);
            this.dateOfTheEndOfTheContract.TabIndex = 5;
            this.dateOfTheEndOfTheContract.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ResultOfOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateOfTheEndOfTheContract);
            this.Controls.Add(this.telephoneNumber);
            this.Controls.Add(this.passportData);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "ResultOfOrdering";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Labels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label passportData;
        private System.Windows.Forms.Label telephoneNumber;
        private System.Windows.Forms.Label dateOfTheEndOfTheContract;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}