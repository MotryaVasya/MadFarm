using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public static class BuyElementsShop
    {
        Player player;
        public static Ferm BuyFerm(int index)
        {
            switch (index)
            {
                case 1:
                    if (player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index)
                        player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index);
                    return new ChickenFerm();
                    break;

                case 2:
                    if (player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index))
                        player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index);
                    return new PigFerm();
                    break;

                case 3:
                    if (player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index))
                        player.Money -= CheckMoneyBuyFerm(VievModel.Ferms, index);
                    return new CowFerm();
                    break;
            }
        }
        public static void BuyAnimal(int index)
        {
            switch (index)
            {
                case 1:
                    if (player.Money -= CheckMoneyBuy(ChickenFerm.ChickToAnim()))
                        player.Money -= CheckMoneyBuy(ChickenFerm.ChickToAnim());
                    return new Chicken();
                    break;

                case 2:
                    if (player.Money -= CheckMoneyBuy(PigFerm.PigkToAnim()))
                        player.Money -= CheckMoneyBuy(PigFerm.PigkToAnim());
                    return new Pig();
                    break;

                case 3:
                    if (player.Money -= CheckMoneyBuy(CowFerm.CowkToAnim()))
                        player.Money -= CheckMoneyBuy(CowFerm.CowkToAnim());
                    return new Cow();
                    break;
            }
        }
        private static int CheckMoneyBuy(List<Animal> list)
        {
            foreach (var item in list)
            {
                return item.PriceBuy;
            }
        }
        private static int CheckMoneyBuyFerm(List<Ferm> list)
        {
            foreach (var item in list)
            {
                return item._priceBuy;
            }
        }
        private static int CheckMoneyBuy(List<Animal> list)
        {
            foreach (var item in list)
            {
                return item._priceSell;
            }
        }
    }
}
