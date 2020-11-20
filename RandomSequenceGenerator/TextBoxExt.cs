using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSequenceGenerator
{
    static class TextBoxExt//Расширение для класса TextBox
    {
        public static void WriteLine(this TextBox textBox)//Печатает пустеую строку
        {
            textBox.Text += Environment.NewLine;
        }
        public static void WriteLine(this TextBox textBox, string line)//Печатает line на строке и делает переход на новую
        {
            textBox.Text += line + Environment.NewLine;
        }
    }
}
