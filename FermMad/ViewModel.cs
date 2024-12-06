using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FermMad
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly Model1 Model;
        static public List<Ferm> _ferms;
        static public List<Animal> _animals;
        static public List<Player> _player_Progress;
        public List<Ferm> Ferms
        {
            get
            {
                return _ferms;
            }
            set
            {
                _ferms = value;
                Notify("Ferms");
            }
        }
        public List<Animal> Animals
        {
            get
            {
                return _animals;
            }
            set
            {
                _animals = value; Notify("Animals");
            }
        }

        public List<Player> Player_Progress
        {
            get { return _player_Progress; }
            set { _player_Progress = value; Notify("Player_Progress"); }
        }

        public ViewModel()
        {
            Model = new Model1();
            Animals = (from q in Model.Animals select q).ToList();
            Ferms = (from q in Model.Ferms select q).ToList();
            Player_Progress = (from q in Model.Player_Progress select q).ToList();
        }
        public void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public static ButtonCommands BuyFerm
        {
            get
            {
                return new ButtonCommands(() =>
                {
                    BuyElementsShop.BuyFerm(0);// вместо 0 поставить listBox.SelectedIndex
                });
            }
        }
        public static ButtonCommands BuyAnimal
        {
            get
            {
                return new ButtonCommands(() =>
                {
                    BuyElementsShop.BuyAnimal(0);// вместо 0 поставить listBox2.SelectedIndex
                });
            }
        }

    }
}
