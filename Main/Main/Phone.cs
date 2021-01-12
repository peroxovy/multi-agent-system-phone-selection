using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Phone
    {
        private int id;
        private string name;
        private int soldAmount;
        private double originalPrice;
        private double soldPrice;
        private int amount;
        private string displaySize;
        private string displayType;
        private string weight;
        private string battery;
        private string photos;
        private string waterproof;
        private string dualSim;
        private string usageType;
        public static List<Phone> phones;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int SoldAmount { get => soldAmount; set => soldAmount = value; }
        public int Amount { get => amount; set => amount = value; }
        public double OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public double SoldPrice { get => soldPrice; set => soldPrice = value; }
        public string DisplaySize { get => displaySize; set => displaySize = value; }
        public string DisplayType { get => displayType; set => displayType = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Battery { get => battery; set => battery = value; }
        public string Photos { get => photos; set => photos = value; }
        public string Waterproof { get => waterproof; set => waterproof = value; }
        public string DualSim { get => dualSim; set => dualSim = value; }
        public string UsageType { get => usageType; set => usageType = value; }

        public Phone()
        {
          
        }

        public Phone(Phone phone)
        {
            this.Name = phone.Get_Name();
            this.Id = phone.Get_Id();
            this.OriginalPrice = phone.Get_OriginalPrice();
            this.SoldAmount = phone.Get_SoldAmount();
            this.Amount = phone.Get_Amount();
            this.SoldPrice = phone.Get_SoldPrice();
            this.DisplaySize = phone.Get_DisplaySize();
            this.DisplayType = phone.Get_DisplayType();
            this.Weight = phone.Get_Weight();
            this.Battery = phone.Get_Battery();
            this.Photos = phone.Get_Photos();
            this.Waterproof = phone.Get_Waterproof();
            this.DualSim = phone.Get_DualSim();
            this.UsageType = phone.Get_UsageType();
        }

        public void LoadJson()
        {
            phones = new List<Phone>();
            using (StreamReader r = new StreamReader("telefony.json"))
            {
                string json = r.ReadToEnd();
                phones = JsonConvert.DeserializeObject<List<Phone>>(json);
            }
        }

        public List<Phone> Get_Phones()
        {
            return phones;
        }

        public void Set_Id(int Id)
        {
            this.Id = Id;
        }

        public void Set_Name(string name)
        {
            this.Name = name;
        }

        public void Set_SoldAmount(int soldamount)
        {
            this.SoldAmount = soldamount;
        }

        public void Set_Amount(int amount)
        {
            this.Amount = amount;
        }

        public void Set_OriginalPrice(double originalprice)
        {
            this.OriginalPrice = originalprice;
        }

        public void Set_SoldPrice(double soldprice)
        {
            this.SoldPrice = soldprice;
        }

        public void Set_DisplaySize(string display)
        {
            this.DisplaySize = display;
        }

        public void Set_DisplayType(string display)
        {
            this.DisplayType = display;
        }

        public void Set_Weight(string weight)
        {
            this.Weight = weight;
        }

        public void Set_Battery(string battery)
        {
            this.Battery = battery;
        }

        public void Set_Photos(string photos)
        {
            this.Photos = photos;
        }

        public void Set_Waterproof(string waterproof)
        {
            this.Waterproof = waterproof;
        }

        public void Set_DualSim(string dualsim)
        {
            this.DualSim = dualsim;
        }

        public void Set_UsageType(string usage)
        {
            this.UsageType = usage;
        }

        /*
         * 
         */

        public int Get_Id()
        {
            return this.Id;
        }

        public string Get_Name()
        {
            return this.Name;
        }

        public int Get_SoldAmount()
        {
            return this.SoldAmount;
        }

        public int Get_Amount()
        {
            return this.Amount;
        }

        public double Get_OriginalPrice()
        {
            return this.OriginalPrice;
        }

        public double Get_SoldPrice()
        {
            return this.SoldPrice;
        }

        public string Get_DisplaySize()
        {
            return this.DisplaySize;
        }

        public string Get_DisplayType()
        {
            return this.DisplayType;
        }

        public string Get_Weight()
        {
            return this.Weight;
        }

        public string Get_Battery()
        {
            return this.Battery;
        }

        public string Get_Photos()
        {
            return this.Photos;
        }

        public string Get_Waterproof()
        {
            return this.Waterproof;
        }

        public string Get_DualSim()
        {
            return this.DualSim;
        }

        public string Get_UsageType()
        {
            return this.UsageType;
        }

    }
}
