using System;
using System.Windows.Forms;
using Lib_1;

namespace pract_1
{
    public partial class Form1 : Form
    {

        string message1 = "Филяк, ИСП-31, вариант 1. Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10. ";
        string message2 = "Пока эта сумма не превышает некоторого К. Вывести на экран сгенерированные числа, значение суммы, и кол-во сген чисел.";
        int limitNumber;
        string genNumbers;
        int summ;
        int kolNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void UseFunction_Click(object sender, EventArgs e)
        {
            limitNumber = (int)maxOutCount.Value;
            if(limitNumber != 0)
            {
                MyGenerator.GenericAndAnswer(limitNumber, out genNumbers, out summ, out kolNumbers);
                randomNumbers.Text = genNumbers;
                amountNumbers.Text = kolNumbers.ToString();
                summNumbers.Text = summ.ToString();
            }
            else
            {
                MessageBox.Show("Введите значения.");
            }
            
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message1 + message2);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxOutCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
