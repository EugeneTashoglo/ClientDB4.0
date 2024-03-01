using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        private string selectedGender = "м"; 
        private Client selectedClient;
        private List<int> selectedTags = new List<int>();
        public ClientEdit()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            LoadTags();

        }
        private void ClientEdit_Load ( object sender, EventArgs e )
        {

            LoadClientsData();
      
        }

        private void LoadClientsData ()
        {
            using (var db = new ModelDB())
            {
                var clients = db.Client.Select(p => new
                {
                    FirstName = p.FirstName,
                    Patronymic = p.Patronymic,
                    LastName = p.LastName,
                    Gender = p.Gender,
                    Phone = p.Phone,
                    Birthday = p.Birthday,
                    RegistrationDate = p.RegistrationDate,
                    Email = p.Email,
                    PhotoClient = p.PhotoClient
                }).ToList();
                dataGridView1.DataSource = clients;
            }
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
                    string selectedFile = openFileDialog.FileName;
                    string destPath = Path.Combine(@"C:\Users\kbk.local\Desktop\WebApp\ClientDB4.0\bin\Debug\Клиенты", Path.GetFileName(selectedFile));
                    if (!File.Exists(destPath))
                    {
                        File.Copy(selectedFile, destPath);
                    }
                    pictureBoxPhoto.Image = Image.FromFile(destPath);
                    pictureBoxPhoto.Tag = @"Клиенты\" + Path.GetFileName(selectedFile);
                }
            }
        }
       

        private void buttonSave_Click ( object sender, EventArgs e )
        {
            using (var db = new ModelDB())
            {
                var client = db.Client.FirstOrDefault(c => c.Email == txtEmail.Text);
                bool isNewClient = client == null;
                if (isNewClient)
                {
                    client = new Client();
                    client.LastName = txtLastName.Text; // Устанавливаем LastName только для нового клиента
                }
                client.FirstName = txtFirstName.Text;
                client.Patronymic = textBoxPatrom.Text;
                client.Gender = selectedGender;
                client.Phone = txtPhone.Text;
                client.Email = txtEmail.Text;
                client.Birthday = dateTimePickerBirthday.Value.Date;
                client.RegistrationDate = dateTimePickerReg.Value.Date; // Установка даты регистрации
                if (pictureBoxPhoto.Tag != null)
                {
                    client.PhotoClient = pictureBoxPhoto.Tag.ToString();
                }
                if (isNewClient)
                {
                    db.Client.Add(client);
                }
                db.SaveChanges();
            }
            LoadClientsData();
        }




        private void delete_Click ( object sender, EventArgs e )
        {
          
        }

        private void ClearFormFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            textBoxPatrom.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            radioButtonMale.Checked = true; 
            radioButtonFemale.Checked = false; 
            dateTimePickerBirthday.Value = DateTime.Now;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

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
        private void update_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }
        private void txtLastName_TextChanged ( object sender, EventArgs e )
        {

        }

        private void txtEmail_TextChanged ( object sender, EventArgs e )
        {

        }

        private void txtPhone_TextChanged ( object sender, EventArgs e )
        {

        }

        private void dateTimePickerBirthday_ValueChanged ( object sender, EventArgs e )
        {

        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label9_Click ( object sender, EventArgs e )
        {

        }

     


        private void dateTimePickerBirthday_ValueChanged_1 ( object sender, EventArgs e )
        {

        }



        private void dataGridView1_SelectionChanged ( object sender, EventArgs e )
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtLastName.Text = row.Cells["LastName"].Value != null ? row.Cells["LastName"].Value.ToString() : string.Empty;
                txtFirstName.Text = row.Cells["FirstName"].Value != null ? row.Cells["FirstName"].Value.ToString() : string.Empty;
                textBoxPatrom.Text = row.Cells["Patronymic"].Value != null ? row.Cells["Patronymic"].Value.ToString() : string.Empty;
                selectedGender = row.Cells["Gender"].Value != null ? row.Cells["Gender"].Value.ToString() : string.Empty;
                radioButtonMale.Checked = selectedGender == "м";
                radioButtonFemale.Checked = selectedGender == "ж";
                txtEmail.Text = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString() : string.Empty;
                txtPhone.Text = row.Cells["Phone"].Value != null ? row.Cells["Phone"].Value.ToString() : string.Empty;

                // Проверяем, не является ли значение ячейки "Birthday" null, прежде чем преобразовать его в DateTime.
                if (row.Cells["Birthday"].Value != null && DateTime.TryParse(row.Cells["Birthday"].Value.ToString(), out DateTime birthday))
                {
                    dateTimePickerBirthday.Value = birthday;
                }
                else
                {
                    // Если значение ячейки "Birthday" null или не может быть преобразовано в DateTime, устанавливаем значение DateTimePicker по умолчанию.
                    dateTimePickerBirthday.Value = DateTime.Today;
                }

                // Проверяем, не является ли значение ячейки "PhotoClient" null, прежде чем пытаться загрузить изображение.
                string photoPath = row.Cells["PhotoClient"].Value != null ? row.Cells["PhotoClient"].Value.ToString() : string.Empty;
                if (!string.IsNullOrEmpty(photoPath))
                {
                    pictureBoxPhoto.Image = Image.FromFile(Path.Combine(@"C:\Users\kbk.local\Desktop\WebApp\ClientDB4.0\bin\Debug", photoPath));
                }
                else
                {

                    pictureBoxPhoto.Image = null; // Оставьте pictureBoxPhoto.Image пустым
                }

                using (var db = new ModelDB())
                {
                    selectedClient = db.Client.FirstOrDefault(c => c.Email == txtEmail.Text);
                }
                using (var db = new ModelDB())
                {
                    selectedClient = db.Client.Include(c => c.TagOfClient).FirstOrDefault(c => c.Email == txtEmail.Text);

                    if (selectedClient != null)
                    {
                        // Очистка CheckBox'ов перед установкой новых значений
                        checkBoxgreen.Checked = false;
                        checkBoxred.Checked = false;
                        checkBoxyellow.Checked = false;
                        checkBoxblack.Checked = false;

                        // Перебор всех TagOfClient для выбранного клиента и установка CheckBox'ов
                        foreach (var tagOfClient in selectedClient.TagOfClient)
                        {
                            switch (tagOfClient.TagID)
                            {
                                case 5:
                                    checkBoxgreen.Checked = true;
                                    break;
                                case 6:
                                    checkBoxred.Checked = true;
                                    break;
                                case 7:
                                    checkBoxyellow.Checked = true;
                                    break;
                                case 8:
                                    checkBoxblack.Checked = true;
                                    break;
                            }
                        }
                    }
                }
            }
        }
          

       


        




    


        
      private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void btnSaveTags_Click ( object sender, EventArgs e )
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Сначала выберите клиента.");
                return;
            }

            UpdateSelectedTags(); // Убедитесь, что список selectedTags актуален.

            using (var db = new ModelDB()) // Замените ModelDB на актуальное имя вашего DbContext
            {
                // Получение максимального IDTagOfClient, чтобы установить новый уникальный ID
                int maxId = db.TagOfClient.Any() ? db.TagOfClient.Max(x => x.IDTagOfClient) : 0;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Получение существующих тегов клиента
                        var existingTags = db.TagOfClient.Where(tc => tc.Client.LastName == selectedClient.LastName).ToList();

                        // Удаление существующих тегов клиента
                        db.TagOfClient.RemoveRange(existingTags);
                        db.SaveChanges();

                        // Добавление новых тегов
                        foreach (var tagId in selectedTags)
                        {
                            var tagOfClient = new TagOfClient
                            {
                                IDTagOfClient = ++maxId, // Увеличиваем maxId для каждой новой записи
                                LastName = selectedClient.LastName,
                                TagID = tagId
                            };
                            db.TagOfClient.Add(tagOfClient);
                        }

                        // Сохранение новых связей в базе данных
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Произошла ошибка при сохранении тегов: " + ex.Message);
                    }
                }
            }
        }




        private void UpdateSelectedTags ()
        {
            selectedTags.Clear(); // Очищаем список перед обновлением
            if (checkBoxgreen.Checked) selectedTags.Add(5); // ID тега для зеленого цвета
            if (checkBoxred.Checked) selectedTags.Add(6); // ID тега для красного цвета
            if (checkBoxyellow.Checked) selectedTags.Add(7); // ID тега для желтого цвета
            if (checkBoxblack.Checked) selectedTags.Add(8); // ID тега для черного цвета
        }
        private void LoadTags ()
        {
            // Загрузите теги из БД, если необходимо
        }

        private void checkBoxgreen_CheckedChanged ( object sender, EventArgs e )
        {
            UpdateSelectedTags();
        }

        private void checkBoxred_CheckedChanged ( object sender, EventArgs e )
        {
            UpdateSelectedTags();
        }

        private void checkBoxyellow_CheckedChanged ( object sender, EventArgs e )
        {
            UpdateSelectedTags();
        }

        private void checkBoxblack_CheckedChanged ( object sender, EventArgs e )
        {
            UpdateSelectedTags();
        }
    }
}

