using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClientDB4._0
{
    public partial class ClientEdit : Form
    {
        public ClientEdit()
        {
            InitializeComponent();
        }


        private void ClientEdit_Load(object sender, EventArgs e)
        {
            LoadClientsData();
        }

        private void LoadClientsData()
        {
            using (var db = new ModelDB())
            {
                var clients = db.Client.Select(p => new
                {
                    FirstName=p.FirstName,
                    Patronymic = p.Patronymic,
                    LastName = p.LastName,
                    GenderCode = p.GenderCode,
                    Phone = p.Phone,
                    Birthday = p.Birthday,
                    RegistrationDate = p.RegistrationDate,
                    Email = p.Email,
                    PhotoClient = p.PhotoClient
                }).ToList();
                dataGridView1.DataSource = clients;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем выбранный файл
                    string selectedFile = openFileDialog.FileName;

                    // Копируем файл в папку Клиенты, если он еще там не находится
                    string destPath = Path.Combine(@"C:\Users\kbk.local\Desktop\WebApp\ClientDB4.0\bin\Debug\Клиенты", Path.GetFileName(selectedFile));
                    if (!File.Exists(destPath))
                    {
                        File.Copy(selectedFile, destPath);
                    }

                    // Отображаем изображение в pictureBox
                    pictureBoxPhoto.Image = Image.FromFile(destPath);

                    // Сохраняем относительный путь для последующего сохранения в БД
                    pictureBoxPhoto.Tag = @"Клиенты\" + Path.GetFileName(selectedFile);
                }
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new ModelDB())
            {
                var client = new Client
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Patronymic = txtPatronymic.Text,
                    GenderCode = selectedGender,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Birthday = dateTimePickerBirthday.Value,
                    // Установите остальные поля по необходимости
                    RegistrationDate=DateTime.Now,
                    PhotoClient = pictureBoxPhoto.Tag?.ToString()

                };

                db.Client.Add(client);
                db.SaveChanges();
            }

            MessageBox.Show("Клиент сохранен");
        }

        private void ClearFormFields()
        {
            // Очистка текстовых полей
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPatronymic.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            // Сброс выбора радио кнопок. Предполагаем, что один из них должен быть выбран по умолчанию
            radioButtonMale.Checked = true; // или false, если по умолчанию женский пол
            radioButtonFemale.Checked = false; // или true соответственно

            // Установка текущей даты для dateTimePicker
            dateTimePickerBirthday.Value = DateTime.Now;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearFormFields();

            // Оставляем пользователя на форме, не закрывая её
            // Если необходимо закрыть форму, можно вызвать this.Close();
        }


        private string selectedGender = "м"; // Предполагаем мужской пол по умолчанию

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                selectedGender = "м";
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                selectedGender = "ж";
            }
        }


        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }



        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPatronymic_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранные строки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Предполагаем, что первичный ключ пользователя хранится в первом столбце
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string userId = dataGridView1[0, selectedIndex].Value.ToString();

                using (var db = new ModelDB())
                {
                    // Находим пользователя в базе данных по его ID
                    var clientToDelete = db.Client.Find(userId);
                    if (clientToDelete != null)
                    {
                        db.Client.Remove(clientToDelete);
                        db.SaveChanges();

                        // Обновляем DataGridView
                        LoadClientsData();
                    }
                    else
                    {
                        MessageBox.Show("Выбранный клиент не найден в базе данных.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.");
            }
        }

    }
}
