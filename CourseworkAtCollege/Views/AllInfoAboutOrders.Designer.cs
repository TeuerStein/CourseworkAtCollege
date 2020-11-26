
namespace CourseworkAtCollege
{
    partial class AllInfoAboutOrders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.clietId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clietId,
            this.firstName,
            this.lastName,
            this.fatherName,
            this.passportData,
            this.EndOfContract,
            this.phoneNumber,
            this.typeOfCar});
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(646, 374);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // clietId
            // 
            this.clietId.HeaderText = "ID";
            this.clietId.Name = "clietId";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Ім`я";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Прізвище";
            this.lastName.Name = "lastName";
            // 
            // fatherName
            // 
            this.fatherName.HeaderText = "По батькові";
            this.fatherName.Name = "fatherName";
            // 
            // passportData
            // 
            this.passportData.HeaderText = "Паспортні дані";
            this.passportData.Name = "passportData";
            // 
            // EndOfContract
            // 
            this.EndOfContract.HeaderText = "Дата закінчення контракту";
            this.EndOfContract.Name = "EndOfContract";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Номер телефону";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // typeOfCar
            // 
            this.typeOfCar.HeaderText = "Клас машини";
            this.typeOfCar.Name = "typeOfCar";
            // 
            // AllInfoAboutOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllInfoAboutOrders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AllInfoAboutOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfCar;
    }
}