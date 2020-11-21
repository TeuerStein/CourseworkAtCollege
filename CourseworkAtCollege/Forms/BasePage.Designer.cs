
namespace CourseworkAtCollege
{
    partial class BasePage
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
            this.next_page_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.first_part_of_base_text = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.second_part_of_base_text = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_part_of_base_text
            // 
            this.first_part_of_base_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.first_part_of_base_text.Location = new System.Drawing.Point(100, 164);
            this.first_part_of_base_text.Name = "first_part_of_base_text";
            this.first_part_of_base_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.first_part_of_base_text.Size = new System.Drawing.Size(620, 30);
            this.first_part_of_base_text.TabIndex = 2;
            this.first_part_of_base_text.Text = "Доброго дня! Вас вітає компанія прокату авто \"Extra Drive\"";
            // 
            // second_part_of_base_text
            // 
            this.second_part_of_base_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.second_part_of_base_text.Location = new System.Drawing.Point(270, 199);
            this.second_part_of_base_text.Name = "second_part_of_base_text";
            this.second_part_of_base_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.second_part_of_base_text.Size = new System.Drawing.Size(280, 30);
            this.second_part_of_base_text.TabIndex = 4;
            this.second_part_of_base_text.Text = "Очікуємо вашого вибору!";
            // 
            // next_page_button
            // 
            this.next_page_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.next_page_button.Location = new System.Drawing.Point(170, 320);
            this.next_page_button.Name = "next_page_button";
            this.next_page_button.Size = new System.Drawing.Size(140, 30);
            this.next_page_button.TabIndex = 0;
            this.next_page_button.Text = "БойНекстДоур";
            this.next_page_button.UseVisualStyleBackColor = true;
            this.next_page_button.Click += new System.EventHandler(this.next_page_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit_button.Location = new System.Drawing.Point(510, 320);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 30);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
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
            this.menuStrip1.TabIndex = 3;
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
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.second_part_of_base_text);
            this.Controls.Add(this.first_part_of_base_text);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.next_page_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BasePage";
            this.Text = "БазоваСторінка";
            this.Load += new System.EventHandler(this.first_part_of_base_text_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_page_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label first_part_of_base_text;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescriptionToolStripMenuItem;
        private System.Windows.Forms.Label second_part_of_base_text;
    }
}

