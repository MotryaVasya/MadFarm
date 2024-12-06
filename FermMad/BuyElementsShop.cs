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
        public static void BuyFerm(int index)
        {
            switch (index)
            {
                case 1:
                    if ((Player.Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        Player.Money -= CheckMoneyBuyFerm(_ferms);
                        _ferms.Add(new ChickenFerm(35, new List<Chicken>(), 3));
                    }
                    break;

                case 2:
                    if ((Player.Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        Player.Money -= CheckMoneyBuyFerm(_ferms);
                        _ferms.Add(new PigFerm(35, new List<Pig>(), 3));
                    }
                    break;

                case 3:
                    if ((Player.Money -= CheckMoneyBuyFerm(_ferms)) >= CheckMoneyBuyFerm(_ferms))
                    {
                        Player.Money -= CheckMoneyBuyFerm(_ferms);
                        _ferms.Add(new CowFerm(35, new List<Cow>(), 3));
                    }
                    break;
            }
        }
        public static void BuyAnimal(int index)
        {
            switch (index)
            {
                case 1:
                    if ((Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 1))) >= 0)
                    {
                        Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 1));
                        _animals.Add(new Chicken());
                    }
                    break;

                case 2:
                    if ((Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 2))) >= 0)
                    {
                        Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 2));
                        _animals.Add(new Pig());
                    }
                    break;

                case 3:
                    if ((Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 3))) >= 0)
                    {
                        Player.Money -= CheckMoneyBuyAnimal(SelectFerm(_ferms, 3));
                        _animals.Add(new Cow());
                    }
                    break;
            }
        }


        private static Ferm ferm;
        private static Ferm SelectFerm(List<Ferm> ferms, int v)
        {
            switch (v)
            {
                case 1:
                    foreach (var item in ferms)
                    {
                        if (item is ChickenFerm)
                        {
                            ferm = item;
                        }
                    }
                    break;
                case 2:
                    foreach (var item in ferms)
                    {
                        if (item is PigFerm)
                        {
                            ferm = item;
                        }
                    }
                    break;
                case 3:
                    foreach (var item in ferms)
                    {
                        if (item is CowFerm)
                        {
                            ferm = item;
                        }
                    }
                    break;
            }
            return ferm;
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
