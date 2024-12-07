using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FermMad
{
    public partial class FormShop : Form
    {
        new ListBox listBox2 = new ListBox();
        new TextBox textBox1 = new TextBox();
        public FormShop()
        {
            InitializeComponent();
            listBox1.Items.Add("Постройки");
            listBox1.Items.Add("Животные");
            listBox1.Items.Add("Корма");
        }


        private void CheckClickElementFromListBox(string Text)
        {
            switch (Text)
            {
                #region Все записи
                case "Постройки":
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Ферма коров");
                    listBox2.Items.Add("Ферма свиней");
                    listBox2.Items.Add("Ферма куриц");
                    break;
                case "Животные":
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Курицы");
                    listBox2.Items.Add("Свиньи");
                    listBox2.Items.Add("Коровы");
                    break;
                case "Корма":
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Корм");
                    break;
                #endregion

                #region Фермы
                case "Ферма коров":
                    textBox1.Clear();
                    //ViewModel._ferms.Add(BuyElementsShop.BuyFerm(listBox2.SelectedIndex++));
                    break;
                case "Ферма свиней":
                    textBox1.Clear();
                    //ViewModel._ferms.Add(BuyElementsShop.BuyFerm(listBox2.SelectedIndex++));
                    break;
                case "Ферма куриц":
                    textBox1.Clear();
                    //ViewModel._ferms.Add(BuyElementsShop.BuyFerm(listBox2.SelectedIndex++));
                    break;
                #endregion
                
                #region Животные
                case "Курицы":
                    //ViewModel._animals.Add(BuyElementsShop.BuyAnimal(listBox2.SelectedIndex++));
                    break;
                case "Свиньи":
                    //ViewModel._animals.Add(BuyElementsShop.BuyAnimal(listBox2.SelectedIndex++));
                    break;
                case "Коровы":
                    //ViewModel._animals.Add(BuyElementsShop.BuyAnimal(listBox2.SelectedIndex++));
                    break;
                #endregion
                
                #region Корм
                case "Корм":
                    //ViewModel.BuyCorm.ToString(BuyElementsShop.BuyCorm(listBox2.SelectedIndex));
                    break;
                #endregion
            }
            if (listBox2.Items.Count > 0)
            {
                SetPositionForListBox2(listBox2);
                Controls.Add(listBox2);
            }
            SetPositionForTextBox1(textBox1);
            Controls.Add(textBox1);

        }

        private void SetPositionForTextBox1(TextBox textBox1)
        {
            textBox1.Left = listBox2.Right + 1;
            textBox1.Top = listBox2.Top;
        }

        private void SetPositionForListBox2(ListBox listBox2)
        {
            listBox2.Left = listBox1.Right + 1;
            listBox2.Top = listBox1.Top;
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckClickElementFromListBox(listBox1.SelectedItem.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string element =listBox2.SelectedItem.ToString();
            int count;
            if (int.TryParse(textBox1.Text, out count))
            {
                MessageBox.Show($"Вы купили {count} {element}.");
            }
            else
            {
                MessageBox.Show("Ошибка!Введите корректное число.");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.CloseFormShop();
        }
    }
}
