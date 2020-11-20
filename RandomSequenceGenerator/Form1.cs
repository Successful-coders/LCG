using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSequenceGenerator
{
    public partial class Form1 : Form
    {
        private GeneratorParameters generatorParams;


        public Form1()
        {
            InitializeComponent();
        }


        private void MultiCgButton_Click(object sender, EventArgs e)
        {
            GeneratorParameters multiParams = new GeneratorParameters(generatorParams.length, generatorParams.x0, generatorParams.a, 0);

            int[] randomSequence = Generator.CreateSequence(multiParams);

            infoBox.WriteLine();
            infoBox.WriteLine("Полученная МКГ последовательность:");
            foreach (var item in randomSequence)
            {
                infoBox.Text += (item + " ");
            }
        }
        private void MixedCgButton_Click(object sender, EventArgs e)
        {
            int[] randomSequence = Generator.CreateSequence(generatorParams);

            infoBox.WriteLine();
            infoBox.WriteLine("Полученная СКГ последовательность:");
            foreach (var item in randomSequence)
            {
                infoBox.Text += (item + " ");
            }
        }
        private void readDataButton_Click(object sender, EventArgs e)
        {
            if (openData.ShowDialog() == DialogResult.OK)//Заупуск окно выбора файла
            {
                try
                {
                    var filePath = openData.FileName;//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        int[] fileContent = str.ReadToEnd().Split('\n').Select(int.Parse).ToArray();
                        generatorParams = new GeneratorParameters(fileContent[0], fileContent[1], fileContent[2], fileContent[3]);

                        infoBox.WriteLine("Загружены параметры:");
                        infoBox.WriteLine("Длина: " + generatorParams.length);
                        infoBox.WriteLine("x0: " + generatorParams.x0);
                        infoBox.WriteLine("a: " + generatorParams.a);
                        infoBox.WriteLine("c: " + generatorParams.c);
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
