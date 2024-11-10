using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Visual_Programming.WPTBWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод для разделения строки на слова по нажатию кнопки
        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            // Очищаем ListBox перед добавлением новых элементов
            WordsListBox.Items.Clear();

            // Получаем текст из TextBox
            string inputText = InputTextBox.Text;

            // Разделяем текст на слова, используя пробел в качестве разделителя
            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Добавляем каждое слово в ListBox
            foreach (string word in words)
            {
                WordsListBox.Items.Add(word);
            }

            // Обновляем метку с количеством слов
            ReversedSentenceLabel.Content = $"Количество слов: {words.Length}";
        }

        // Метод для перестановки слов в обратном порядке по нажатию кнопки
        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string inputText = InputTextBox.Text;

            // Разделяем текст на слова и переставляем их в обратном порядке
            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string reversedSentence = string.Join(" ", words.Reverse());

            // Выводим перевернутое предложение в Label
            ReversedSentenceLabel.Content = reversedSentence;
        }
    }
}
