using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Main
{
    class Seller
    {
        private int ID;

        public List<Phone> Stock;
        public List<Phone> StockToShow;
        public Criteria Criteria;
        private Phone phone;
        public int SellerCounter = 0;
        public int phonesShown;
        public int negotiated;
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public Seller(int ID)
        {
            this.ID = ID;
            this.Stock = new List<Phone>();
            this.StockToShow = new List<Phone>();
            this.Criteria= new Criteria();
            this.phonesShown = 0;
            this.negotiated = -1;
            //LoadJson();
           // randomStock(this.Stock);
            //string phonesJson = JsonConvert.SerializeObject(this.Stock);
           // createStockFile(phonesJson);
            this.SellerCounter++;
        }

        
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public int getID()
        {
            return this.ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public void setStock(List<Phone> phones)
        {
            int stocksize = phones.Count();

            double p = stocksize * 0.75;

            int percent = (int) Math.Ceiling(p);

            List<int> f = new List<int>();

            int randId=0;

            for(int i=0; i<percent; i++)
             {
                randId = RandomNumber(1, percent);
                if (f.Contains(randId))
                {
                    randId = RandomNumber(1, percent);
                }
                else
                {
                    f.Add(randId);
                }
             }
            

            foreach (Phone phone in phones)
            {
                if (f.Contains(phone.Get_Id()))
                {
                    this.Stock.Add(new Phone(phone));
                }
            }
        }

        public List<Phone> Get_Stock()
        {
            return Stock;
        }

        public void createStockFile()
        {
            string phonesJson = JsonConvert.SerializeObject(this.Stock);

            string fileName = "sellerStock" + this.getID() + ".json";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.WriteAllText(fileName, phonesJson);
        }

        public void randomStock(List<Phone> Stock)
        {

            double currentStockCount = Stock.Count;
            
            double price = 0;

            double newStockCountTmp = currentStockCount * 0.75;

            int newStockCount = (int) Math.Floor(newStockCountTmp);

            double percent = 0;

            int amount = 0;

            int rand = -1;
           
           
            foreach (Phone phone in Stock)
            {
                amount = RandomNumber(0, 15);

                rand = RandomNumber(0, 1);

                Console.WriteLine(rand);

                price = phone.Get_OriginalPrice();

                percent = price * 0.1;
                
               if (rand == 0)
               {
                    price -= percent*0.1;
               }
                else if(rand == 1)
                {
                    price += percent*0.1;
                }
                phone.Set_OriginalPrice(price);
                phone.Set_SoldAmount(amount);

               // percent = 0;
               // price = 0;
            }
             

        }

        public List<Phone> setCriteriaGetFound(Criteria criteria)
        {
            this.Criteria = criteria;
            this.StockToShow.Clear();

            foreach(Phone phone in Stock)
            {
                if(searchMatching(criteria, phone))
                {
                    this.StockToShow.Add(phone);
                }
            }

            return this.StockToShow;
        }

        public bool searchMatching(Criteria criteria, Phone phone)
        {
            if (criteria.Get_Battery().ToUpper() == phone.Get_Battery().ToUpper()) { } else { return false; }
            if (criteria.Get_Battery().ToUpper() ==  phone.Get_Battery().ToUpper()) { } else { return false; }
            if (criteria.Get_DisplaySize().ToUpper() == phone.Get_DisplaySize().ToUpper()) { } else { return false; }
            if (criteria.Get_DisplayType().ToUpper() == phone.Get_DisplayType().ToUpper()) { } else { return false; }
            if (criteria.Get_DualSim().ToUpper() == phone.Get_DualSim().ToUpper()) { } else { return false; }
            if (criteria.Get_Photos().ToUpper() == phone.Get_Photos().ToUpper()) { } else { return false; }
            if (criteria.Get_Usage().ToUpper() == phone.Get_UsageType().ToUpper()) { } else { return false; }
            if (criteria.Get_Waterproof().ToUpper() == phone.Get_Waterproof().ToUpper()) { } else { return false; }
            if (criteria.Get_Weight().ToUpper() == phone.Get_Weight().ToUpper()) { } else { return false; }
            if(criteria.Get_MinPrice() <= phone.Get_OriginalPrice() && criteria.Get_MaxPrice() >= phone.Get_OriginalPrice()) { } else { return false; }

            return true;
        }

        public void job()
        {
           //phone = new Phone();
            //this.Stock = phone.Get_Phones();

           // randomStock(this.Stock);

            

        }

    }
}
