
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
            this.creatingButton = new System.Windows.Forms.Button();
            this.changingButton = new System.Windows.Forms.Button();
            this.deletingButton = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPage_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.орендованіАвтоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.списокЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новеЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartOfContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.FirstName,
            this.LastName,
            this.FatherName,
            this.PassportData,
            this.PhoneNumber,
            this.NameOfCar,
            this.StartOfContract,
            this.EndOfContract});
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 259);
            this.dataGridView1.TabIndex = 0;
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
            this.changingButton.Click += new System.EventHandler(this.changingButton_Click);
            // 
            // deletingButton
            // 
            this.deletingButton.Location = new System.Drawing.Point(269, 374);
            this.deletingButton.Name = "deletingButton";
            this.deletingButton.Size = new System.Drawing.Size(75, 23);
            this.deletingButton.TabIndex = 3;
            this.deletingButton.Text = "Видалити";
            this.deletingButton.UseVisualStyleBackColor = true;
            this.deletingButton.Click += new System.EventHandler(this.deletingButton_Click);
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
            this.textBox1.Location = new System.Drawing.Point(578, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пошук за ім\'ям";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(697, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainPage_button
            // 
            this.mainPage_button.Location = new System.Drawing.Point(524, 374);
            this.mainPage_button.Name = "mainPage_button";
            this.mainPage_button.Size = new System.Drawing.Size(75, 23);
            this.mainPage_button.TabIndex = 8;
            this.mainPage_button.Text = "Головна";
            this.mainPage_button.UseVisualStyleBackColor = true;
            this.mainPage_button.Click += new System.EventHandler(this.mainPage_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.DescriptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.орендованіАвтоToolStripMenuItem,
            this.toolStripSeparator1,
            this.списокЗамовленьToolStripMenuItem,
            this.toolStripSeparator2,
            this.вихідToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // орендованіАвтоToolStripMenuItem
            // 
            this.орендованіАвтоToolStripMenuItem.Name = "орендованіАвтоToolStripMenuItem";
            this.орендованіАвтоToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.орендованіАвтоToolStripMenuItem.Text = "Орендовані авто";
            this.орендованіАвтоToolStripMenuItem.Click += new System.EventHandler(this.orderedCarsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // списокЗамовленьToolStripMenuItem
            // 
            this.списокЗамовленьToolStripMenuItem.Name = "списокЗамовленьToolStripMenuItem";
            this.списокЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.списокЗамовленьToolStripMenuItem.Text = "Список замовлень";
            this.списокЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.AllInfoAboutOrdersToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новеЗамовленняToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // новеЗамовленняToolStripMenuItem
            // 
            this.новеЗамовленняToolStripMenuItem.Name = "новеЗамовленняToolStripMenuItem";
            this.новеЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.новеЗамовленняToolStripMenuItem.Text = "Нове замовлення";
            this.новеЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.OrderedNewCarToolStripMenuItem_Click);
            // 
            // DescriptionToolStripMenuItem
            // 
            this.DescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.DescriptionToolStripMenuItem.Name = "DescriptionToolStripMenuItem";
            this.DescriptionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.DescriptionToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // idClient
            // 
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Ім`я";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Прізвище";
            this.LastName.Name = "LastName";
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "По батькові";
            this.FatherName.Name = "FatherName";
            // 
            // PassportData
            // 
            this.PassportData.HeaderText = "Паспортні дані";
            this.PassportData.Name = "PassportData";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефону";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // NameOfCar
            // 
            this.NameOfCar.HeaderText = "Машина";
            this.NameOfCar.Name = "NameOfCar";
            // 
            // StartOfContract
            // 
            this.StartOfContract.HeaderText = "Дата початку контракта";
            this.StartOfContract.Name = "StartOfContract";
            // 
            // EndOfContract
            // 
            this.EndOfContract.HeaderText = "Дата закінчення контракту";
            this.EndOfContract.Name = "EndOfContract";
            // 
            // AllInfoAboutOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPage_button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.deletingButton);
            this.Controls.Add(this.changingButton);
            this.Controls.Add(this.creatingButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllInfoAboutOrders";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button creatingButton;
        private System.Windows.Forms.Button changingButton;
        private System.Windows.Forms.Button deletingButton;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button mainPage_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem орендованіАвтоToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem списокЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новеЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartOfContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfContract;
    }
}