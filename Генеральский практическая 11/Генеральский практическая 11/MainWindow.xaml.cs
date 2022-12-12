using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Генеральский_практическая_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterLine(object sender, RoutedEventArgs e)
        {
            string a = "aa aba abba abbba abca abea";
            Regex regex = new Regex(@"ab*a");// * любое количество совпадений или их отсутствие,относится к предыдущему элементу
            MatchCollection match = regex.Matches(a);//Коллекция объектов,кладём в него наши строки(string a)
            for (int i = 0; i < match.Count; i++)
            {
                MessageBox.Show(match[i].ToString());
            }
        }
        private void FindLine(object sender, RoutedEventArgs e)
        {
            string a = tbFindLine.Text;
            Regex regex = new Regex(@"a[\d]a");// \d это любая цифра,квадратные скобки это любой из символов,указанный в них
            MatchCollection match = regex.Matches(a);//Коллекция объектов,кладём в него наши строки(string a)
            for (int i = 0; i < match.Count; i++)
            {

                MessageBox.Show(match[i].ToString());
            }
        }

        private void About_Programm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5. Дана строка 'aa aba abba abbba abca abea'. " +
                "Напишите регулярное выражение, \r\nкоторое найдет строки aa, aba, abba, abbba." +
                "\r\nДана строка 'a1a a2a a3a a4a a5a aba aca'. " +
                "Напишите регулярное выражение, которое \r\nнайдет строки, в которых по краям стоят буквы 'a', а между ними одна цифра.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
