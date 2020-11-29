
namespace CourseworkAtCollege
{
    partial class MultipleChooserPage
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
            this.order = new System.Windows.Forms.Button();
            this.OrderedCars = new System.Windows.Forms.Button();
            this.ListsOfOrdering = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPage_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(137, 181);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(98, 55);
            this.order.TabIndex = 0;
            this.order.Text = "Оренда";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // OrderedCars
            // 
            this.OrderedCars.Location = new System.Drawing.Point(323, 183);
            this.OrderedCars.Name = "OrderedCars";
            this.OrderedCars.Size = new System.Drawing.Size(145, 53);
            this.OrderedCars.TabIndex = 1;
            this.OrderedCars.Text = "Орендовані авто";
            this.OrderedCars.UseVisualStyleBackColor = true;
            // 
            // ListsOfOrdering
            // 
            this.ListsOfOrdering.Location = new System.Drawing.Point(553, 181);
            this.ListsOfOrdering.Name = "ListsOfOrdering";
            this.ListsOfOrdering.Size = new System.Drawing.Size(132, 55);
            this.ListsOfOrdering.TabIndex = 2;
            this.ListsOfOrdering.Text = "Список замовлень";
            this.ListsOfOrdering.UseVisualStyleBackColor = true;
            this.ListsOfOrdering.Click += new System.EventHandler(this.ListsOfOrdering_Click);
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
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // DescriptionToolStripMenuItem
            // 
            this.DescriptionToolStripMenuItem.Name = "DescriptionToolStripMenuItem";
            this.DescriptionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.DescriptionToolStripMenuItem.Text = "Довідка";
            // 
            // mainPage_button
            // 
            this.mainPage_button.Location = new System.Drawing.Point(357, 402);
            this.mainPage_button.Name = "mainPage_button";
            this.mainPage_button.Size = new System.Drawing.Size(75, 23);
            this.mainPage_button.TabIndex = 7;
            this.mainPage_button.Text = "Головна";
            this.mainPage_button.UseVisualStyleBackColor = true;
            this.mainPage_button.Click += new System.EventHandler(this.mainPage_button_Click);
            // 
            // MultipleChooserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.mainPage_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ListsOfOrdering);
            this.Controls.Add(this.OrderedCars);
            this.Controls.Add(this.order);
            this.Name = "MultipleChooserPage";
            this.Text = "Multiple Chooser Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button OrderedCars;
        private System.Windows.Forms.Button ListsOfOrdering;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescriptionToolStripMenuItem;
        private System.Windows.Forms.Button mainPage_button;
    }
}