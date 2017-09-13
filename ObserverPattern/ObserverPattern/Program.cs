using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //subject
    class Stock
    {
        public string Name { get; set; }
        private ArrayList _financiers;
        private decimal _lotValue;

        public decimal LotValue
        {
            get
            {
                return _lotValue;
            }
            set
            {
                _lotValue = value;
                Notify();

            }
        }
        public void Notify()
        {
            foreach (Financier financier in _financiers)
            {
                financier.HaberVer(this);
            }
        }
        public Stock()
        {
            _financiers = new ArrayList();
        }
        public void Subscribe(IFinancier financier)
        {
            _financiers.Add(financier);
        }
        public void Unsubscribe(IFinancier financier)
        {
            _financiers.Remove(financier);
        }
    }
    //observer
    interface IFinancier
    {
        void HaberVer(Stock stock);
    }
    
    //concreteObserver
    class Financier : IFinancier
    {
        public string Name { get; set; }
        #region Financier Members
        public void HaberVer(Stock stock)
        {
            Console.WriteLine("{0} Merhaba, {1} hissesinin lot değeri {2} olarak güncellendi.", Name , stock.Name, stock.LotValue.ToString());
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stock azonDemir = new Stock { Name = "Azon Demir Kimya", LotValue = 12.3M};
            Financier xYatırım = new Financier { Name="X Yatırım Şirketi"};
            azonDemir.Subscribe(xYatırım);

            Financier yYatırım = new Financier { Name = "Y Yatırım Şirketi" };
            azonDemir.Subscribe(yYatırım);

            Financier zBank = new Financier { Name = "Z Bankası" };
            azonDemir.Subscribe(zBank);

            Console.WriteLine("{0} değerinin güncel lot değeri {1}",azonDemir.Name,azonDemir.LotValue.ToString());
            azonDemir.LotValue += 1;
            Console.Read();
        } 
    }
}
