namespace visit_list
{
   partial class FormMain
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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.update_button = new System.Windows.Forms.Button();
         this.birthday_textBox_main = new System.Windows.Forms.TextBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.search_button = new System.Windows.Forms.Button();
         this.surname_textBox_main = new System.Windows.Forms.TextBox();
         this.name_textBox_main = new System.Windows.Forms.TextBox();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.id_select_textBox = new System.Windows.Forms.TextBox();
         this.delete_button = new System.Windows.Forms.Button();
         this.append_button = new System.Windows.Forms.Button();
         this.attendButton_false = new System.Windows.Forms.RadioButton();
         this.attendButton_true = new System.Windows.Forms.RadioButton();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.edit_button = new System.Windows.Forms.Button();
         this.birthday_textBox_edit = new System.Windows.Forms.TextBox();
         this.surname_textBox_edit = new System.Windows.Forms.TextBox();
         this.name_textBox_edit = new System.Windows.Forms.TextBox();
         this.dataGridView2 = new System.Windows.Forms.DataGridView();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(800, 450);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.update_button);
         this.tabPage1.Controls.Add(this.birthday_textBox_main);
         this.tabPage1.Controls.Add(this.dataGridView1);
         this.tabPage1.Controls.Add(this.search_button);
         this.tabPage1.Controls.Add(this.surname_textBox_main);
         this.tabPage1.Controls.Add(this.name_textBox_main);
         this.tabPage1.Location = new System.Drawing.Point(4, 24);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(792, 422);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Список обучающихся";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // update_button
         // 
         this.update_button.Location = new System.Drawing.Point(709, 391);
         this.update_button.Name = "update_button";
         this.update_button.Size = new System.Drawing.Size(75, 23);
         this.update_button.TabIndex = 6;
         this.update_button.Text = "Обновить";
         this.update_button.UseVisualStyleBackColor = true;
         this.update_button.Click += new System.EventHandler(this.update_button_Click);
         // 
         // birthday_textBox_main
         // 
         this.birthday_textBox_main.Location = new System.Drawing.Point(218, 393);
         this.birthday_textBox_main.Name = "birthday_textBox_main";
         this.birthday_textBox_main.PlaceholderText = "Дата Рождения";
         this.birthday_textBox_main.Size = new System.Drawing.Size(100, 23);
         this.birthday_textBox_main.TabIndex = 1;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(6, 6);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 25;
         this.dataGridView1.Size = new System.Drawing.Size(780, 381);
         this.dataGridView1.TabIndex = 5;
         this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // search_button
         // 
         this.search_button.Location = new System.Drawing.Point(628, 391);
         this.search_button.Name = "search_button";
         this.search_button.Size = new System.Drawing.Size(75, 23);
         this.search_button.TabIndex = 4;
         this.search_button.Text = "Найти";
         this.search_button.UseVisualStyleBackColor = true;
         this.search_button.Click += new System.EventHandler(this.search_button_Click);
         // 
         // surname_textBox_main
         // 
         this.surname_textBox_main.Location = new System.Drawing.Point(112, 393);
         this.surname_textBox_main.Name = "surname_textBox_main";
         this.surname_textBox_main.PlaceholderText = "Фамилия";
         this.surname_textBox_main.Size = new System.Drawing.Size(100, 23);
         this.surname_textBox_main.TabIndex = 1;
         // 
         // name_textBox_main
         // 
         this.name_textBox_main.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.name_textBox_main.Location = new System.Drawing.Point(6, 393);
         this.name_textBox_main.Name = "name_textBox_main";
         this.name_textBox_main.PlaceholderText = "Имя";
         this.name_textBox_main.Size = new System.Drawing.Size(100, 23);
         this.name_textBox_main.TabIndex = 0;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.id_select_textBox);
         this.tabPage2.Controls.Add(this.delete_button);
         this.tabPage2.Controls.Add(this.append_button);
         this.tabPage2.Controls.Add(this.attendButton_false);
         this.tabPage2.Controls.Add(this.attendButton_true);
         this.tabPage2.Controls.Add(this.dateTimePicker1);
         this.tabPage2.Controls.Add(this.edit_button);
         this.tabPage2.Controls.Add(this.birthday_textBox_edit);
         this.tabPage2.Controls.Add(this.surname_textBox_edit);
         this.tabPage2.Controls.Add(this.name_textBox_edit);
         this.tabPage2.Controls.Add(this.dataGridView2);
         this.tabPage2.Location = new System.Drawing.Point(4, 24);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(792, 422);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Редактирование";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // id_select_textBox
         // 
         this.id_select_textBox.Location = new System.Drawing.Point(8, 362);
         this.id_select_textBox.Name = "id_select_textBox";
         this.id_select_textBox.PlaceholderText = "Id";
         this.id_select_textBox.Size = new System.Drawing.Size(161, 23);
         this.id_select_textBox.TabIndex = 14;
         // 
         // delete_button
         // 
         this.delete_button.Location = new System.Drawing.Point(8, 391);
         this.delete_button.Name = "delete_button";
         this.delete_button.Size = new System.Drawing.Size(161, 23);
         this.delete_button.TabIndex = 13;
         this.delete_button.Text = "Удалить учащегося";
         this.delete_button.UseVisualStyleBackColor = true;
         this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
         // 
         // append_button
         // 
         this.append_button.Location = new System.Drawing.Point(609, 6);
         this.append_button.Name = "append_button";
         this.append_button.Size = new System.Drawing.Size(75, 23);
         this.append_button.TabIndex = 11;
         this.append_button.Text = "Добавить";
         this.append_button.UseVisualStyleBackColor = true;
         this.append_button.Click += new System.EventHandler(this.append_button_Click);
         // 
         // attendButton_false
         // 
         this.attendButton_false.AutoSize = true;
         this.attendButton_false.Location = new System.Drawing.Point(6, 60);
         this.attendButton_false.Name = "attendButton_false";
         this.attendButton_false.Size = new System.Drawing.Size(99, 19);
         this.attendButton_false.TabIndex = 10;
         this.attendButton_false.TabStop = true;
         this.attendButton_false.Text = "Отсутствовал";
         this.attendButton_false.UseVisualStyleBackColor = true;
         // 
         // attendButton_true
         // 
         this.attendButton_true.AutoSize = true;
         this.attendButton_true.Location = new System.Drawing.Point(6, 35);
         this.attendButton_true.Name = "attendButton_true";
         this.attendButton_true.Size = new System.Drawing.Size(108, 19);
         this.attendButton_true.TabIndex = 9;
         this.attendButton_true.TabStop = true;
         this.attendButton_true.Text = "Присутствовал";
         this.attendButton_true.UseVisualStyleBackColor = true;
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.Location = new System.Drawing.Point(6, 7);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(163, 23);
         this.dateTimePicker1.TabIndex = 8;
         // 
         // edit_button
         // 
         this.edit_button.Location = new System.Drawing.Point(690, 6);
         this.edit_button.Name = "edit_button";
         this.edit_button.Size = new System.Drawing.Size(96, 23);
         this.edit_button.TabIndex = 7;
         this.edit_button.Text = "Редактировать";
         this.edit_button.UseVisualStyleBackColor = true;
         this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
         // 
         // birthday_textBox_edit
         // 
         this.birthday_textBox_edit.Location = new System.Drawing.Point(387, 7);
         this.birthday_textBox_edit.Name = "birthday_textBox_edit";
         this.birthday_textBox_edit.PlaceholderText = "Дата Рождения";
         this.birthday_textBox_edit.Size = new System.Drawing.Size(100, 23);
         this.birthday_textBox_edit.TabIndex = 3;
         // 
         // surname_textBox_edit
         // 
         this.surname_textBox_edit.Location = new System.Drawing.Point(281, 7);
         this.surname_textBox_edit.Name = "surname_textBox_edit";
         this.surname_textBox_edit.PlaceholderText = "Фамилия";
         this.surname_textBox_edit.Size = new System.Drawing.Size(100, 23);
         this.surname_textBox_edit.TabIndex = 2;
         // 
         // name_textBox_edit
         // 
         this.name_textBox_edit.Location = new System.Drawing.Point(175, 7);
         this.name_textBox_edit.Name = "name_textBox_edit";
         this.name_textBox_edit.PlaceholderText = "Имя";
         this.name_textBox_edit.Size = new System.Drawing.Size(100, 23);
         this.name_textBox_edit.TabIndex = 1;
         this.name_textBox_edit.Tag = "";
         // 
         // dataGridView2
         // 
         this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView2.Location = new System.Drawing.Point(175, 36);
         this.dataGridView2.Name = "dataGridView2";
         this.dataGridView2.RowTemplate.Height = 25;
         this.dataGridView2.Size = new System.Drawing.Size(611, 380);
         this.dataGridView2.TabIndex = 0;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tabControl1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "FormMain";
         this.Text = "Учет посещаемости";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button search_button;
      private System.Windows.Forms.TextBox surname_textBox_main;
      private System.Windows.Forms.TextBox name_textBox_main;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.RadioButton attendButton_false;
      private System.Windows.Forms.RadioButton attendButton_true;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.Button edit_button;
      private System.Windows.Forms.TextBox birthday_textBox_edit;
      private System.Windows.Forms.TextBox surname_textBox_edit;
      private System.Windows.Forms.TextBox name_textBox_edit;
      private System.Windows.Forms.DataGridView dataGridView2;
      private System.Windows.Forms.TextBox birthday_textBox_main;
      private System.Windows.Forms.Button update_button;
      private System.Windows.Forms.Button append_button;
      private System.Windows.Forms.Button delete_button;
      private System.Windows.Forms.TextBox id_select_textBox;
   }
}