
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
            this.clietId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingButton = new System.Windows.Forms.Button();
            this.changingButton = new System.Windows.Forms.Button();
            this.DeletingButton = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            // creatingButton
            // 
            this.creatingButton.Location = new System.Drawing.Point(72, 374);
            this.creatingButton.Name = "creatingButton";
            this.creatingButton.Size = new System.Drawing.Size(75, 23);
            this.creatingButton.TabIndex = 1;
            this.creatingButton.Text = "Додати";
            this.creatingButton.UseVisualStyleBackColor = true;
            this.creatingButton.Click += new System.EventHandler(this.creatingButton_Click);
            // 
            // changingButton
            // 
            this.changingButton.Location = new System.Drawing.Point(171, 374);
            this.changingButton.Name = "changingButton";
            this.changingButton.Size = new System.Drawing.Size(75, 23);
            this.changingButton.TabIndex = 2;
            this.changingButton.Text = "Редагувати";
            this.changingButton.UseVisualStyleBackColor = true;
            this.changingButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeletingButton
            // 
            this.DeletingButton.Location = new System.Drawing.Point(269, 374);
            this.DeletingButton.Name = "DeletingButton";
            this.DeletingButton.Size = new System.Drawing.Size(75, 23);
            this.DeletingButton.TabIndex = 3;
            this.DeletingButton.Text = "Видалити";
            this.DeletingButton.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пошук за ім\'ям";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Пошук";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AllInfoAboutOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.DeletingButton);
            this.Controls.Add(this.changingButton);
            this.Controls.Add(this.creatingButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllInfoAboutOrders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AllInfoAboutOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button creatingButton;
        private System.Windows.Forms.Button changingButton;
        private System.Windows.Forms.Button DeletingButton;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfCar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}