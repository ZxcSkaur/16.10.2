using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Экземпляр класса для работы с БД
        model.Model1 database = new model.Model1();

        // Список для загрузки в него изначальных (не изменённых) данных
        List<Pavilion> pavilions = new List<Pavilion>();

        // Список для загрузки в него изменённых данных
        List<Pavilion> PavilionsChange = new List<Pavilion>();

        // Список для загрузки в него полей класса Pavilion
        List<string> pavilionsProp = new List<string>();
        private void loadStartData() // Загрузка данных списка в источник данных
        {
            pavilionBindingSource.DataSource = PavilionsChange;
            dataGridView1.DataSource = pavilionBindingSource;
        }
        private void loadDataCombo() // Загрузка данных в comboBoxOrderBy
        {
            // Загружаем поля
            pavilionsProp = typeof(Pavilion).GetProperties().Select(x => x.Name).ToList();
            // Удаляем поля - связи (если есть навигационные свойства)
            if (pavilionsProp.Count >= 2)
            {
                pavilionsProp.RemoveRange(pavilionsProp.Count - 2, 2);
            }
            // Загружаем полученные данные в comboBox1
            comboBox1.DataSource = pavilionsProp;
            // Выбираем первый элемент в comboBox1
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void LoadOrder() // Метод сортировки данных из списка
        {
            if (comboBox1.SelectedItem == null) return;

            // (условие) если checkBox1 Checked имеет значение true -->
            PavilionsChange = checkBox1.Checked ?
            // присваивается это значение списка -->
            PavilionsChange.OrderByDescending(p => p.GetType().GetProperties()
                .First(x => x.Name == comboBox1.SelectedItem.ToString()).GetValue(p)).ToList()
            // иначе это значение списка
            : PavilionsChange.OrderBy(p => p.GetType().GetProperties()
                .First(x => x.Name == comboBox1.SelectedItem.ToString()).GetValue(p)).ToList();

            loadStartData(); // <- выполнение метода загрузки данных
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружаем данные в списки из БД
            PavilionsChange = pavilions = database.Pavilion.ToList();
            // Вызываем методы загрузки
            loadStartData();
            loadDataCombo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Поиск pavilions по списку где поле Status содержится текст из textBox1
            PavilionsChange = pavilions.Where(x =>
                x.Status != null && x.Status.Contains(textBox1.Text)).ToList();
            // Вызываем метод сортировки данных
            LoadOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
