using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDB4._0
{
    public partial class Form1 : Form
    {
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10; // Размер страницы, количество записей на одной странице
        public Form1()
        {
                InitializeComponent();
                LoadDataFromDatabase();


            comboBox1.SelectedIndex = 0;
        }

      
        private void LoadDataFromDatabase ()
        {
            using (ModelDB db = new ModelDB())
            {
                try
                {
                    var skipAmount = ( currentPage - 1 ) * pageSize;

                    // Построение запроса для получения данных из базы данных
                    var query = db.Client.Join(db.ClientService,
                  client => client.LastName, // Предполагаем, что это имя столбца первичного ключа в таблице Client
                  service => service.LastName,
                  ( client, service ) => new
                  {
                      FirstName = client.FirstName,
                      LastName = client.LastName,
                      Patronymic = client.Patronymic,
                      Email = client.Email,
                      Phone = client.Phone,
                      Birthday = client.Birthday,
                      GenderCode = client.Gender,
                      PhotoClient = client.PhotoClient // Предполагаем, что это поле с фотографией в таблице Client
                  });


                    // Сортировка по фамилии перед пропуском записей
                    query = query.OrderBy(client => client.LastName);

                    // Вычисление общего количества страниц
                    totalPages = (int)Math.Ceiling((double)query.Count() / pageSize);

                    // Пропуск записей и взятие размера страницы
                    var list = query.Skip(skipAmount).Take(pageSize).ToList();

                    // Отображение данных в dataGridView1
                    dataGridView1.DataSource = list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (ModelDB db = new ModelDB())
            {
                string searchText = textBox1.Text.ToLower();
                var filteredList = db.Client.Join(db.ClientService,
                    u => u.LastName,
                    c => c.LastName,
                    (u, c) => new
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        GenderCode = u.Gender,
                        Patronymic = u.Patronymic,
                        Phone = u.Phone,
                        Birthday = u.Birthday,
                        Email = u.Email
                    })
                    .Where(client => client.FirstName.ToLower().Contains(searchText) ||
                                     client.LastName.ToLower().Contains(searchText) ||
                                     client.Patronymic.ToLower().Contains(searchText) ||
                                     client.Phone.Contains(searchText) ||
                                     client.Email.ToLower().Contains(searchText))
                    .ToList();

                dataGridView1.DataSource = filteredList;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) FilterData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) FilterData();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) FilterData();
        }


        private void FilterData()
        {
            using (ModelDB db = new ModelDB())
            {
                string searchText = textBox1.Text.ToLower();
                string genderFilter = "";

                if (radioButton1.Checked) // Мужской пол
                    genderFilter = "м";
                else if (radioButton2.Checked) // Женский пол
                    genderFilter = "ж";

                int selectedOption = comboBox1.SelectedIndex;

                var baseQuery = db.Client.Join(db.ClientService,
                    u => u.LastName,
                    c => c.LastName,
                    (u, c) => new ClientData
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        GenderCode = u.Gender,
                        Patronymic = u.Patronymic,
                        Phone = u.Phone,
                        Birthday = u.Birthday,
                        Email = u.Email
                    });

                switch (selectedOption)
                {
                    case 0:
                        baseQuery = baseQuery
                            .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                             (client.FirstName.ToLower().Contains(searchText) ||
                                              client.LastName.ToLower().Contains(searchText) ||
                                              client.Patronymic.ToLower().Contains(searchText) ||
                                              client.Phone.Contains(searchText) ||
                                              client.Email.ToLower().Contains(searchText)));
                        break;
                    case 1:
                        baseQuery = baseQuery
                            .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                             (client.FirstName.ToLower().Contains(searchText) ||
                                              client.LastName.ToLower().Contains(searchText) ||
                                              client.Patronymic.ToLower().Contains(searchText) ||
                                              client.Phone.Contains(searchText) ||
                                              client.Email.ToLower().Contains(searchText)))
                            .Take(10);
                        break;
                    case 2:
                        baseQuery = baseQuery
                            .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                             (client.FirstName.ToLower().Contains(searchText) ||
                                              client.LastName.ToLower().Contains(searchText) ||
                                              client.Patronymic.ToLower().Contains(searchText) ||
                                              client.Phone.Contains(searchText) ||
                                              client.Email.ToLower().Contains(searchText)))
                            .Take(50);
                        break;
                    case 3:
                        baseQuery = baseQuery
                            .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                             (client.FirstName.ToLower().Contains(searchText) ||
                                              client.LastName.ToLower().Contains(searchText) ||
                                              client.Patronymic.ToLower().Contains(searchText) ||
                                              client.Phone.Contains(searchText) ||
                                              client.Email.ToLower().Contains(searchText)))
                            .Take(200);
                        break;
                }

                var filteredList = baseQuery.ToList(); // Выполняем запрос и получаем результат

                dataGridView1.DataSource = filteredList; // Обновляем источник данных для dataGridView1
            }
        }

        public class ClientData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string GenderCode { get; set; }
            public string Patronymic { get; set; }
            public string Phone { get; set; }
            public DateTime? Birthday { get; set; }
            public string Email { get; set; }
        }

        private List<ClientData> GetFilteredList(ModelDB db, string searchText, string genderFilter, int selectedOption)
        {
            var baseQuery = db.Client.Join(db.ClientService,
                u => u.LastName,
                c => c.LastName,
                (u, c) => new ClientData
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    GenderCode = u.Gender,
                    Patronymic = u.Patronymic,
                    Phone = u.Phone,
                    Birthday = u.Birthday,
                    Email = u.Email
                });

            switch (selectedOption)
            {
                case 0:
                    return baseQuery
                        .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                         (client.FirstName.ToLower().Contains(searchText) ||
                                          client.LastName.ToLower().Contains(searchText) ||
                                          client.Patronymic.ToLower().Contains(searchText) ||
                                          client.Phone.Contains(searchText) ||
                                          client.Email.ToLower().Contains(searchText)))
                        .ToList(); // Все записи
                case 1:
                    return baseQuery
                        .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                         (client.FirstName.ToLower().Contains(searchText) ||
                                          client.LastName.ToLower().Contains(searchText) ||
                                          client.Patronymic.ToLower().Contains(searchText) ||
                                          client.Phone.Contains(searchText) ||
                                          client.Email.ToLower().Contains(searchText)))
                        .Take(10)
                        .ToList(); // Первые 10 записей
                case 2:
                    return baseQuery
                        .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                         (client.FirstName.ToLower().Contains(searchText) ||
                                          client.LastName.ToLower().Contains(searchText) ||
                                          client.Patronymic.ToLower().Contains(searchText) ||
                                          client.Phone.Contains(searchText) ||
                                          client.Email.ToLower().Contains(searchText)))
                        .Take(50)
                        .ToList(); // Первые 50 записей
                case 3:
                    return baseQuery
                        .Where(client => (genderFilter == "" || client.GenderCode == genderFilter) &&
                                         (client.FirstName.ToLower().Contains(searchText) ||
                                          client.LastName.ToLower().Contains(searchText) ||
                                          client.Patronymic.ToLower().Contains(searchText) ||
                                          client.Phone.Contains(searchText) ||
                                          client.Email.ToLower().Contains(searchText)))
                        .Take(200)
                        .ToList(); // Первые 200 записей
                default:
                    return new List<ClientData>(); // Пустой список по умолчанию
            }
        }



        private void back_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataFromDatabase();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataFromDatabase();
            }
        }

        private void btnFormVisit_Click ( object sender, EventArgs e )
        {

    
        }



        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {
           
        }

        private void dataGridView1_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Далее можно обращаться к ячейкам этой строки, например:
                // Получаем значение в первой ячейке выбранной строки
                string valueInFirstCell = selectedRow.Cells[1].Value.ToString();
                using (ModelDB db=new ModelDB())
                {
                    Client client = db.Client.Where(p => p.LastName == valueInFirstCell).FirstOrDefault();
                    VisitForm vf = new VisitForm(client);
                    vf.Show();
                }

                // Можно продолжить работать с другими ячейками выбранной строки
            }
            else
            {
                // Сообщаем пользователю, что ничего не выбрано
                MessageBox.Show("Выберите строку в DataGridView.");
            }
        }
    }
}