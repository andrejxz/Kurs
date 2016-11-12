namespace Kurs
{
	partial class MainForm
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
			if (disposing && (components != null)) {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.категорииТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.аРМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.кассирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.аРМToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(866, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// таблицыToolStripMenuItem
			// 
			this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииТоваровToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.складToolStripMenuItem,
            this.продажиToolStripMenuItem});
			this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
			this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.таблицыToolStripMenuItem.Text = "Таблицы";
			// 
			// категорииТоваровToolStripMenuItem
			// 
			this.категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
			this.категорииТоваровToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.категорииТоваровToolStripMenuItem.Text = "Категории товаров";
			this.категорииТоваровToolStripMenuItem.Click += new System.EventHandler(this.категорииТоваровToolStripMenuItem_Click);
			// 
			// товарыToolStripMenuItem
			// 
			this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
			this.товарыToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.товарыToolStripMenuItem.Text = "Товары";
			this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
			// 
			// складToolStripMenuItem
			// 
			this.складToolStripMenuItem.Name = "складToolStripMenuItem";
			this.складToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.складToolStripMenuItem.Text = "Склад";
			// 
			// продажиToolStripMenuItem
			// 
			this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
			this.продажиToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.продажиToolStripMenuItem.Text = "Продажи";
			// 
			// аРМToolStripMenuItem
			// 
			this.аРМToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кассирToolStripMenuItem});
			this.аРМToolStripMenuItem.Name = "аРМToolStripMenuItem";
			this.аРМToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.аРМToolStripMenuItem.Text = "АРМ";
			// 
			// кассирToolStripMenuItem
			// 
			this.кассирToolStripMenuItem.Name = "кассирToolStripMenuItem";
			this.кассирToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.кассирToolStripMenuItem.Text = "Кассир";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 335);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "АРМ Менеджер по продажам";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem категорииТоваровToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem аРМToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem кассирToolStripMenuItem;
	}
}