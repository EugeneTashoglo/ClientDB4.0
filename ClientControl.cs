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
    public partial class ClientControl : UserControl
    {

        public ClientControl ()
        {
            InitializeComponent();
        }
        public string NameService
        {
            get { return labelNameService.Text; }
            set { labelNameService.Text = value; }
        }
        public string StartTime
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string CountFile
        {
            get { return Countfile.Text; }
            set { Countfile.Text = value; }
        }

        private void Countfile_Click ( object sender, EventArgs e )
        {

        }

        private void buttonopenfile_Click ( object sender, EventArgs e )
        {
            using (ModelDB db = new ModelDB())
            {
                // Получение идентификатора услуги клиента
                int clientServiceID = GetClientServiceID(); // Необходимо реализовать этот метод

                // Получение списка документов для выбранной услуги клиента
                var documents = db.DocumentByService.Where(d => d.ClientServiceID == clientServiceID).ToList();

                // Вывод документов или выполнение некоторого действия с ними
                foreach (var document in documents)
                {
                    // Пример: вывод пути к документу в сообщении
                    MessageBox.Show(document.DocumentPath);
                }
            }
        }private int GetClientServiceID()
        {
            // Реализовать логику получения идентификатора услуги клиента
            // Это может включать доступ к свойству или полю в вашем элементе управления
            // Для демонстрации вернем фиктивное значение
            return 1;
        }

    }
}
