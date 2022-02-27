using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visit_list
{
   public partial class FormMain : Form
   {
      private readonly AppDBContext db = new();
      public FormMain()
      {
         InitializeComponent();

         dataGridView1.Columns.Add("Id", "Id");
         dataGridView1.Columns.Add("Name", "Name");
         dataGridView1.Columns.Add("Surname", "Surname");
         dataGridView1.Columns.Add("Birthday", "Birthday");
         foreach (var visit in db.Visits.ToList())
         {
            dataGridView1.Columns.Add($"{visit.Date.Date}", $"{visit.Date.Date}");
         }

         dataGridView2.Columns.Add("Id", "Id");
         dataGridView2.Columns.Add("Name", "Name");
         dataGridView2.Columns.Add("Surname", "Surname");
         dataGridView2.Columns.Add("Birthday", "Birthday");
         foreach (var visit in db.Visits.ToList())
         {
            dataGridView2.Columns.Add($"{visit.Date.Date}", $"{visit.Date.Date}");
         }

         DataUpdate();
      }
      private void search_button_Click(object sender, EventArgs e)
      {
         var birthday = new DateTime();
         if (birthday_textBox_main.Text != "")
         {
            try
            {
               birthday = DateTime.Parse(birthday_textBox_main.Text);
            }
            catch (FormatException)
            {
               MessageBox.Show("Некорректное значение даты.");

               birthday_textBox_main.Clear();
               birthday_textBox_main.Focus();
               return;
            }
         }
         dataGridView1.Rows.Clear();

         try
         {
            foreach (var student in db.Students
            .Where(p => // Нужно исправить.
               (name_textBox_main.Text != "" && p.Name == name_textBox_main.Text) ||
               (surname_textBox_main.Text != "" && p.Surname == surname_textBox_main.Text) ||
               (birthday_textBox_main.Text != "" && p.Birthday == birthday))
            .ToList())
            {
               object[] value =
               {
                  student.Id,
                  student.Name,
                  student.Surname,
                  student.Birthday
               };
               dataGridView1.Rows.Add(value);
            }
         }
         catch (Exception exception)
         {
            MessageBox.Show(exception.Message);
         }
      }

      private async void edit_button_Click(object sender, EventArgs e)
      {
         Student student;
         try
         {
            student = db.Students.FirstOrDefault(p => p.Id == int.Parse(id_select_textBox.Text));
         }
         catch (Exception)
         {
            MessageBox.Show("Вы ввели несуществующий id");

            id_select_textBox.Clear();
            id_select_textBox.Focus();

            return;
         }
         
         var visit = new Visit()
         {
            Student_id = student.Id,
            Date = dateTimePicker1.Value,
            Attend = attendButton_true.Checked
         };

         await db.Visits.AddAsync(visit);
         await db.SaveChangesAsync();

         DataUpdate();
      }

      private void update_button_Click(object sender, EventArgs e)
      {
         DataUpdate();
      }

      private async void append_button_Click(object sender, EventArgs e)
      {
         string name;
         try
         {
            if (string.IsNullOrWhiteSpace(name_textBox_edit.Text)) { throw new ArgumentNullException(); }
            else { name = name_textBox_edit.Text; }
         }
         catch (ArgumentNullException)
         {
            MessageBox.Show("Введите имя.");

            name_textBox_edit.Focus();
            return;
         }

         string surname;
         try
         {
            if (string.IsNullOrWhiteSpace(surname_textBox_edit.Text)) { throw new ArgumentNullException(); }
            else { surname = surname_textBox_edit.Text; }
         }
         catch (ArgumentNullException)
         {
            MessageBox.Show("Введите Фамилию.");

            surname_textBox_edit.Focus();
            return;
         }

         DateTime birthday;
         try
         {
            if (DateTime.Parse(birthday_textBox_edit.Text) >= DateTime.Now) { throw new FormatException(); }

            birthday = DateTime.Parse(birthday_textBox_edit.Text);
         }
         catch (FormatException)
         {
            MessageBox.Show("Введите корректное значение даты рождения.");

            birthday_textBox_edit.Clear();
            birthday_textBox_edit.Focus();
            return;
         }

         var student = new Student()
         {
            Name = name,
            Surname = surname,
            Birthday = birthday
         };
         await db.Students.AddAsync(student);
         await db.SaveChangesAsync();

         object[] values =
         {
            name,
            surname,
            birthday
         };
         dataGridView2.Rows.Add(values);

         DataUpdate();
      }

      private async void delete_button_Click(object sender, EventArgs e)
      {
         try
         {
            var student = db.Students.FirstOrDefault(p => p.Id == int.Parse(id_select_textBox.Text));

            db.Students.Remove(student);
            await db.SaveChangesAsync();
         }
         catch (Exception)
         {
            MessageBox.Show("Вы ввели несуществующий id.");

            id_select_textBox.Clear();
            id_select_textBox.Focus();
            return;
         }

         DataUpdate();
      }

      private void DataUpdate()
      {
         dataGridView1.Rows.Clear();
         dataGridView2.Rows.Clear();

         
         foreach (var student in db.Students.ToList())
         {
            var values = new List<object>
            {
               student.Id,
               student.Name,
               student.Surname,
               student.Birthday
            };
            for (var i = 0; i < db.Visits.Where(p => p.Student_id == student.Id).ToList().Count; i++)
            {
               var visit = db.Visits.Where(p => p.Student_id == student.Id).ToList();
               values.Add(visit[i].Attend);
            }

            dataGridView1.Rows.Add(values.ToArray());
            dataGridView2.Rows.Add(values.ToArray());
         }
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}