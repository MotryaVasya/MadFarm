using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    class Manager
    {
        private static Manager instance;
        
        public static Manager getInstance(int money, int corm, int min_count_corm)
        {
            if (instance == null)
                instance = new Manager(model);
            return instance;
        }

        static private List<IFerm> _ferms;
        static private int _money;
        static private int _corm;
        static private int _min_count_corm;

        public Manager(int money, int corm, int min_count_corm)
        {
            Money = money;
            Corm = corm;
            Min_count_corm = min_count_corm;
        }

        static public List<IFerm> Ferms { get => _ferms; set => _ferms = value; }
        public int Money { get => _money; set => _money = value; }
        public int Corm { get => _corm; set => _corm = value; }
        public int Min_count_corm { get => _min_count_corm; set => _min_count_corm = value; }

    }
}
