using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Random ax = new Random();
            int x = Convert.ToInt32(textBox1.Text);
            String[] b = new String[] { " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ч", "ц", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", ",", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", ".", "?", "!", ";", ":", "[", "]", "{", "}", "(", ")", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "_", "=", "+", "-", "/", "*", "", "'", "&", "^", "%", "$", "#", "@", "№", "~", "`", " " };
            int i = 0;
            while (i < x)
            {                
                int a = ax.Next(159);
                textBox2.Text = textBox2.Text + b[a];
                i++;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}