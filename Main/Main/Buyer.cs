using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Main
{
    class Buyer
    {
        private int ID;
        public int ID_seller;
        public int SellerCounter = 0;
    
        public Buyer(int ID)
        {
            this.ID = ID;
            this.ID_seller = 0;
            this.SellerCounter++;
        }

        public int getID()
        {
            return this.ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public void setSellerCounter(int sellercounter)
        {
            this.SellerCounter = sellercounter;
        }

        public int getSellerCounter()
        {
            return this.SellerCounter;
        }

        public int getID_seller()
        {
            return this.ID_seller;
        }

        public void setID_seller(int ID_seller)
        {
            this.ID_seller = ID_seller;
        }

        public void createStockFile(List<Phone> phones)
        {
            string phonesJson = JsonConvert.SerializeObject(phones);

            string fileName = "foundItems" + this.getID() + ".json";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.WriteAllText(fileName, phonesJson);
        }

        public List<Phone> job(Criteria criteria, List<Seller> sellers, List<Buyer> buyers)
        {
            List<Phone> StockToShow = new List<Phone>();

            foreach(Seller seller in sellers)
            {
                if( this.ID_seller == seller.getID())
                {
                    StockToShow = seller.setCriteriaGetFound(criteria);
               }
            }
            //createStockFile(StockToShow);

            //Form2 form2 = new Form2(this.SellerCounter, this.ID, criteria,StockToShow);

            return StockToShow;
            /*
             * Phone phone = new Phone();
            List<Phone> phones = phone.Get_Phones();

            Random random = new Random();

            int howmuch = random.Next(phones.Count);

            List<Phone> found = new List<Phone>();
            List<int> f = new List<int>();
            for (int i=0; i< howmuch; i++)
            {
                int r = random.Next(howmuch);

                if (found.Contains(phones[r]))
                {
                    r = random.Next(howmuch);
                }
                else
                {
                    found.Add(phones[r]);
                } 
            }
             

            Form2 form = new Form2(this.getID(), criterias, found);

            List<Criteria> criteriaForBuyer = criterias;
             */
        }
    }
}
