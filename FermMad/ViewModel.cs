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
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Model1 Model;
        List<Ferm> _ferms;
        List<Animal> _animals;
        List<Player> _player_Progress;
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
    }
}
