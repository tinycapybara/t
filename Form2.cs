using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace t
{
    public partial class Form2 : Form
    {
        // Список для хранения данных о студентах и их оценках
        //private List<string> studentGrades = new List<string>();
        private List<int> grades = new List<int>();
        private List<string> students = new List<string>();
        private List<DateTime> dates = new List<DateTime>();

        public Form2()
        {
            InitializeComponent();
        }
        // Обработчик для кнопки "Добавить оценку"
        private void btnAddGrade_Click_1(object sender, EventArgs e)
        {
            string studentName = txtName.Text;  //извлекает фамилию студента из текстового поля
            int grade = (int)numGrade.Value;    
            DateTime gradeDate = dateTimePicker.Value;

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Введите имя студента.");
                return;
            }

            // Добавляем данные в списки
            students.Add(studentName);
            grades.Add(grade);
            dates.Add(gradeDate);

            // Очистка полей ввода
            txtName.Clear();
            numGrade.Value = 0;
            dateTimePicker.Value = DateTime.Now;

            // Обновление списка оценок на форме
            UpdateGradeList();
        }

        // Обновление списка оценок на форме
        private void UpdateGradeList()
        {
            listBoxGrades.Items.Clear();//очищаем список, чтобы добавить обновлённые данные
            for (int i = 0; i < students.Count; i++)//перебирает все элементы в списке студентов 
            {
                listBoxGrades.Items.Add($"{students[i]} - {grades[i]} - {dates[i].ToShortDateString()}");
            }//dates[i].ToShortDateString() — это преобразует дату в строку вида "dd.MM.yyyy"
        }

        // Обработчик для кнопки "Анализировать"
        private void btnAnalyze_Click_1(object sender, EventArgs e)
        {
            // Проверяем, есть ли оценки
            if (grades.Count == 0)
            {
                MessageBox.Show("Нет оценок для анализа.");
                return;
            }

            //создание словаря, который будет хранить для каждого студента его список оценок
            Dictionary<string, List<int>> studentGradesDict = new Dictionary<string, List<int>>();

            // Заполняем словарь оценками студентов
            for (int i = 0; i < students.Count; i++)
            {
                string student = students[i];
                int grade = grades[i];

                ////проверяем, есть ли уже в словаре запись для этого студента
                if (!studentGradesDict.ContainsKey(student)) 
                {//если нет, создаем новую запись для этого студента с пустым списком оценок
                    studentGradesDict[student] = new List<int>();
                }
                //добавляем оценку в список оценок этого студента
                studentGradesDict[student].Add(grade);
                
            }

            // Переменные для хранения лучшего студента
            string bestStudent = "";
            double bestAverageGrade = -1;  // Начальное значение для лучшей средней оценки

            // Формируем строку для вывода средней оценки каждого студента
            string resultMessage = "Средние оценки студентов:\n";

            foreach (var student in studentGradesDict)//начинаем проходить по всем записям в словаре
            {
                string studentName = student.Key;
                List<int> gradesForStudent = student.Value;//список оценок

                // Вычисляем среднюю оценку
                double averageGrade = gradesForStudent.Average();

                // Добавляем среднюю оценку в строку
               // resultMessage += $"{studentName}: {averageGrade:F2}\n";

                // Проверяем, если эта средняя оценка лучше, чем у текущего лучшего студента
                if (averageGrade > bestAverageGrade)
                {
                    bestAverageGrade = averageGrade;
                    bestStudent = studentName;
                }
            }

            // Добавляем информацию о лучшем студенте
            resultMessage += $"\nЛучший ученик: {bestStudent} с средней оценкой: {bestAverageGrade:F2}";

            // Показываем сообщение
            MessageBox.Show(resultMessage);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                // Проверка первой буквы на заглавную
                if (!char.IsUpper(txtName.Text[0]))
                {
                    // Если первая буква не заглавная, то исправляем ее
                    txtName.Text = char.ToUpper(txtName.Text[0]) + txtName.Text.Substring(1);
                    // Устанавливаем курсор в конец текста
                    txtName.SelectionStart = txtName.Text.Length;
                }

                // Проверка на наличие цифр и знаков
                foreach (char c in txtName.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        // Если найдена цифра или знак, то удаляем ее
                        txtName.Text = txtName.Text.Replace(c.ToString(), "");
                        // Устанавливаем курсор в конец текста
                        txtName.SelectionStart = txtName.Text.Length;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxGrades.SelectedIndex != -1)
            {
                int index = listBoxGrades.SelectedIndex;

                // Удаляем данные из списков
                students.RemoveAt(index);
                grades.RemoveAt(index);
                dates.RemoveAt(index);

                // Обновляем список
                UpdateGradeList();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }
    }
}