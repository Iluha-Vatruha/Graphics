using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // считывем значения из настроек
            txtRound.Text = Properties.Settings.Default.txtRound.ToString();
            txtSquare.Text = Properties.Settings.Default.txtSquare.ToString();
            txtSentence.Text = Properties.Settings.Default.txtSentence.ToString();
            txtNumber.Text = Properties.Settings.Default.txtNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int roundBoard, squareBoard;
            try
            {
                roundBoard = int.Parse(this.txtRound.Text);
                squareBoard = int.Parse(this.txtSquare.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }

            
            var round = int.Parse(this.txtRound.Text);
            var square = int.Parse(this.txtSquare.Text);

            Properties.Settings.Default.txtRound = round;
            Properties.Settings.Default.txtSquare = square;
            Properties.Settings.Default.Save();

            // выведем сообщение о сравнимости заработка
            MessageBox.Show(Logic.roundsAndSquares(round, square));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int numBoard;
            try
            {
                numBoard = int.Parse(this.txtNumber.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }

            int num = int.Parse(this.txtNumber.Text);

            Properties.Settings.Default.txtNumber = num;
            Properties.Settings.Default.Save();

            // выведем сообщение о сравнимости заработка
            MessageBox.Show(Logic.lineOfNumbers(num));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentenceBoard;
            try
            {
                sentenceBoard = (this.txtRound.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }

            string sentence = this.txtSentence.Text;
            Properties.Settings.Default.txtSentence = sentence;
            Properties.Settings.Default.Save();


            // выведем сообщение о сравнимости заработка
            MessageBox.Show("Процент букв в предложении: " + Logic.findMatches(sentence).ToString() + "%");
        }
    }
    public class Logic
    {
        public static int findMatches(string input)
        {
            int matches = 0;
            const string library = "abcdefghijklmnopqrstuvwxyzQWERTYUIOPASDFGHJKLZXCVBNM";

            foreach (char i in input.ToLower())
            {
                if (library.Contains(i))
                {
                    matches++;
                }
            }
            float val1 = input.Length;
            float val2 = matches;
            float val3 = val2 /= val1;
            val3 *= 100;
            int percent = Convert.ToInt32(val3);
            return percent;
        }

        public static string roundsAndSquares(double S1, double S2)
        {
            const double P = 3.14;
            double r = Math.Sqrt(S1 / P);
            double a = Math.Sqrt(S2);
            string message1 = "";
            string message2 = "";

            if (S1 == 0 || S2 == 0)
            {
                message1 = "Ошибка. Введено недопустимое значение";
            }
            else
            {
                if (S1 == S2)
                {
                    message1 = "Круг и квадрат имеют одинаковую площадь и могут поместиться друг в друге";
                }
                else
                {
                    if (r <= a / 2)
                    {
                        message1 = "Круг поместится в квадрате ";
                    }
                    else
                    {
                        message1 = "Круг не поместится в квадрате ";
                    }
                    if (a <= 2 * r)
                    {
                        message2 = "Квадрат поместится в круге";
                    }
                    else
                    {
                        message2 = "Квадрат не поместится в круге";
                    }
                }
            }

            return message1 + message2;
        }

        public static string lineOfNumbers(int number)
        {
            int i = 1;
            int square = 1;
            int bigger = 0;
            string line = "";

            for (int j = 1; square <= number; j++)
            {
                i++;
                square = i * i;
            }


            for (int j = 1; j < i + 1; j++)
            {
                bigger = (j * j);
            }
            /*
            Console.WriteLine("Первое число, большее " + number + " - это: " + bigger);
            Console.WriteLine("Сформированный ряд предшествующих чисел:");
            */
            for (int j = 1; j < i; j++)
            {
                line += Convert.ToString(j * j) + ", ";
            }
            line += Convert.ToString(bigger);

            return line;
        }
    }
}
