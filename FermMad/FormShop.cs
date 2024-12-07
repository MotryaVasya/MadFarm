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
            listBox1.Items.Add[0];
            listBox1.Items.Add[1];
            listBox1.Items.Add[2];
           
        }
        private void FormShop_Load(object sender, EventArgs e)
        {
            ShopElements(textBox1.Text);
            ShopElements(listBox2.Text);
        }

        private void ShopElements(string Text)
        {
            switch(Text)
            {
                case "Постройки":
                    listBox2.Items.Add("Ферма коров");
                    listBox2.Items.Add("Ферма свиней");
                    listBox2.Items.Add("Ферма куриц");
                    listBox2.Items.Clear();
                    break;
                case "Животные":
                    listBox2.Items.Add("Курицы");
                    listBox2.Items.Add("Свиньи");
                    listBox2.Items.Add("Коровы");
                    listBox2.Items.Clear();
                    break;
                case "Корм":
                    listBox2.Items.Add("Корм");
                    listBox2.Items.Clear();
                    break;
                case "ПокупкаФермы":
                    ViewModel.BuyFerm.GetType(BuyElementsShop.BuyFerm(listBox2.SelectedIndex));
                    break;
                case "ПокупкаЖивотных":
                    ViewModel._ferms.Add(BuyElementsShop.BuyAnimal(listBox2.SelectedIndex));
                    break;
                case "ПокупкаКорма":
                    ViewModel.BuyCorm.ToString(BuyElementsShop.BuyCorm(listBox2.SelectedIndex));
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
