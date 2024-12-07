using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class ChickenFerm : Ferm
    {
        private static List<Chicken> _chickens;
        private int _priceFerm;
        private static int _maxCountAnimals;


        public List<Animal> Animals
        {
            get
            {
                return ChickToAnim(_chickens);
            }
            set
            {
                Animals = value;
            }
        }
        public override int MaxCountAnimals
        {
            get
            {
                return _maxCountAnimals;
            }
            set
            {
                _maxCountAnimals = 1000000;
            }

        }
        public override int PriceFerm
        {
            get
            {
                return _priceFerm;
            }
            set
            {
                _priceFerm = 100;
            }
        }
        public override string GetInfo()
        {
            return $"Вместимость загона: {MaxCountAnimals}";
        }


        public ChickenFerm(int priceFrem, List<Chicken> chickens)
        {
            PriceFerm = priceFrem;
            Animals = ChickToAnim(chickens);
        }
        public static List<Chicken> Chickens { get => _chickens; set => _chickens = value; }
        public static List<Animal> ChickToAnim(List<Chicken> chickens)
        {
            List<Animal> animals = new List<Animal>();
            foreach (var chik in chickens)
            {
                animals.Add(chik);
            }
            return animals;
        }
    }
}
