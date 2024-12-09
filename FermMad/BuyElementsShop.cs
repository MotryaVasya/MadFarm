using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class BuyElementsShop : ViewModel
    {
        private static Ferm ferm;
        public static Ferm BuyFerm(int index)
        {
            switch (index)
            {
                case 1:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms);
                        ferm = (new ChickenFerm(35, new List<Chicken>()));
                    }
                    break;

                case 2:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms);
                        ferm = (new PigFerm(35, new List<Pig>()));
                    }
                    break;

                case 3:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyFerm(_ferms);
                        ferm = (new CowFerm(35, new List<Cow>()));
                    }
                    break;
            }
            return ferm;
        }

        private static Animal animal;
        public static Animal BuyAnimal(int index)
        {
            switch (index)
            {
                case 1:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 1))) >= 0)
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 1));
                        animal = (new Chicken());
                    }
                    break;

                case 2:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 2))) >= 0)
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 2));
                        animal = (new Pig());
                    }
                    break;

                case 3:
                    if ((GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 3))) >= 0)
                    {
                        GetLastPlayerProgress().Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 3));
                        animal = (new Cow());
                    }
                    break;
            }
            return animal;
        }


        private static Ferm selectedFerm;
        private static Ferm SelectFerm(List<Ferm> ferms, int v)
        {
            switch (v)
            {
                case 1:
                    foreach (var item in ferms)
                    {
                        if (item is ChickenFerm)
                        {
                            selectedFerm = item;
                        }
                    }
                    break;
                case 2:
                    foreach (var item in ferms)
                    {
                        if (item is PigFerm)
                        {
                            selectedFerm = item;
                        }
                    }
                    break;
                case 3:
                    foreach (var item in ferms)
                    {
                        if (item is CowFerm)
                        {
                            selectedFerm = item;
                        }
                    }
                    break;
            }
            return selectedFerm;
        }

        private static int CheckMoneyBuyAnimal(Ferm ferm)
        {
            foreach (var item in ferm.Animals)
            {
                return item.PriceBuy;
            }
            return 0;
        }
        private static int CheckMoneyBuyFerm(List<Ferm> list)
        {
            foreach (var item in list)
            {
                return item.PriceFerm;
            }
            return 0;
        }
    }
}
