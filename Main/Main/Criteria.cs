using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Criteria
    {
        public double MinPrice;
        public double MaxPrice;
        public string DisplaySize;
        public string DisplayType;
        public string Weight;
        public string Battery;
        public string Photos;
        public string Waterproof;
        public string DualSim;
        public string Usage;


        public Criteria()
        {

        }

        public void Set_MinPrice(double minprice)
        {
            this.MinPrice = minprice;
        }

        public void Set_MaxPrice(double maxprice)
        {
            this.MaxPrice = maxprice;
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

        public void Set_Usage(string usage)
        {
            this.Usage = usage;
        }

        /*
         * 
         */

        public double Get_MinPrice()
        {
            return this.MinPrice;
        }

        public double Get_MaxPrice()
        {
            return this.MaxPrice;
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

        public string Get_Usage()
        {
            return this.Usage;
        }

    }
}
