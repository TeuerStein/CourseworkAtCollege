
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
            this.mainPage_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.typeOfCar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(383, 29);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(35, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "label1";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(383, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(35, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "label2";
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(383, 105);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(35, 13);
            this.fatherName.TabIndex = 2;
            this.fatherName.Text = "label3";
            // 
            // passportData
            // 
            this.passportData.AutoSize = true;
            this.passportData.Location = new System.Drawing.Point(383, 142);
            this.passportData.Name = "passportData";
            this.passportData.Size = new System.Drawing.Size(35, 13);
            this.passportData.TabIndex = 3;
            this.passportData.Text = "label4";
            // 
            // telephoneNumber
            // 
            this.telephoneNumber.AutoSize = true;
            this.telephoneNumber.Location = new System.Drawing.Point(383, 185);
            this.telephoneNumber.Name = "telephoneNumber";
            this.telephoneNumber.Size = new System.Drawing.Size(35, 13);
            this.telephoneNumber.TabIndex = 4;
            this.telephoneNumber.Text = "label5";
            // 
            // dateOfTheEndOfTheContract
            // 
            this.dateOfTheEndOfTheContract.AutoSize = true;
            this.dateOfTheEndOfTheContract.Location = new System.Drawing.Point(383, 223);
            this.dateOfTheEndOfTheContract.Name = "dateOfTheEndOfTheContract";
            this.dateOfTheEndOfTheContract.Size = new System.Drawing.Size(35, 13);
            this.dateOfTheEndOfTheContract.TabIndex = 5;
            this.dateOfTheEndOfTheContract.Text = "label6";
            // 
            // mainPage_button
            // 
            this.mainPage_button.Location = new System.Drawing.Point(202, 349);
            this.mainPage_button.Name = "mainPage_button";
            this.mainPage_button.Size = new System.Drawing.Size(75, 23);
            this.mainPage_button.TabIndex = 6;
            this.mainPage_button.Text = "Головна";
            this.mainPage_button.UseVisualStyleBackColor = true;
            this.mainPage_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(543, 349);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // typeOfCar
            // 
            this.typeOfCar.AutoSize = true;
            this.typeOfCar.Location = new System.Drawing.Point(383, 260);
            this.typeOfCar.Name = "typeOfCar";
            this.typeOfCar.Size = new System.Drawing.Size(35, 13);
            this.typeOfCar.TabIndex = 9;
            this.typeOfCar.Text = "label1";
            // 
            // ResultOfOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeOfCar);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.mainPage_button);
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
        private System.Windows.Forms.Button mainPage_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label typeOfCar;
    }
}