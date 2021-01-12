using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Main
{
    public partial class Form1 : Form
    {
        string[] ArrWeights = new string[] { "Ważne", "Średnie", "Obojętne" };
        string[] ArrDisplaySize = new string[] { "Mały", "Średni", "Duży" };
        string[] ArrYesNo = new string[] { "Tak", "Nie" };
        string[] ArrPhoneWeight = new string[] { "Mała", "Średnia", "Duża" };
        string[] ArrBattery = new string[] { "Krótka", "Średnia", "Długa" };
        string[] ArrUsage = new string[] { "Duża ilość aplikacji", "Duża ilość robionych zdjęć", "Przeglądanie Internetu" };
        public Thread thread;
        private Buyer buyer;
        private Seller seller;
        private List<Buyer> buyers;
        private List<Seller> sellers;
        public List<Thread> threads;
        private Criteria criteria;
        //private List<Criteria> criterias;
        private Phone phone;
        private List<Phone> phones;
        public int BuyerAmount = 0;
        public int SellerAmount = 0;
        public static int id=-1;
        private delegate void SafeCallDelegate(string text);

        public List<List<Phone>> ToShow = new List<List<Phone>>();
        public List<int> SellerId = new List<int>();

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDisplaySize.Items.AddRange(ArrDisplaySize);
            comboBoxDisplaySize.SelectedIndex = 0;
            comboBoxWeightDisplaySize.Items.AddRange(ArrWeights);
            comboBoxWeightDisplaySize.SelectedIndex = 0;

            comboBoxScreenType.Items.AddRange(ArrYesNo);
            comboBoxScreenType.SelectedIndex = 0;
            comboBoxWeightScreenType.Items.AddRange(ArrWeights);
            comboBoxWeightScreenType.SelectedIndex = 0;

            comboBoxWeight.Items.AddRange(ArrPhoneWeight);
            comboBoxWeight.SelectedIndex = 0;
            comboBoxWeightWeight.Items.AddRange(ArrWeights);
            comboBoxWeightWeight.SelectedIndex = 0;

            comboBoxBattery.Items.AddRange(ArrBattery);
            comboBoxBattery.SelectedIndex = 0;
            comboBoxWeightBattery.Items.AddRange(ArrWeights);
            comboBoxWeightBattery.SelectedIndex = 0;

            comboBoxPhotos.Items.AddRange(ArrYesNo);
            comboBoxPhotos.SelectedIndex = 0;
            comboBoxWeightPhotos.Items.AddRange(ArrWeights);
            comboBoxWeightPhotos.SelectedIndex = 0;

            comboBoxWaterproof.Items.AddRange(ArrYesNo);
            comboBoxWaterproof.SelectedIndex = 0;
            comboBoxWeightWaterproof.Items.AddRange(ArrWeights);
            comboBoxWeightWaterproof.SelectedIndex = 0;

            comboBoxDualSim.Items.AddRange(ArrYesNo);
            comboBoxDualSim.SelectedIndex = 0;
            comboBoxWeightDualSim.Items.AddRange(ArrWeights);
            comboBoxWeightDualSim.SelectedIndex = 0;

            comboBoxUsage.Items.AddRange(ArrUsage);
            comboBoxUsage.SelectedIndex = 0;
            comboBoxWeightUsage.Items.AddRange(ArrWeights);
            comboBoxWeightUsage.SelectedIndex = 0;
        }

        public void LoadJson()
        {
            phones = new List<Phone>();
            using (StreamReader r = new StreamReader("telefony.json"))
            {
                string json = r.ReadToEnd();
                this.phones = JsonConvert.DeserializeObject<List<Phone>>(json);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            BuyerAmount = int.Parse(textBoxBuyerAmount.Text);
            SellerAmount = int.Parse(textBoxSellerAmount.Text);

            LoadJson();
            
            Set_Criteria();

            createAgents();

            addThreads();

            setSeller();

            setStock();

            randomStock();

            saveStock();

            Run(BuyerAmount, SellerAmount);
        }

        private void setSeller()
        {
            int i = 0;
            foreach(Buyer buyer in buyers)
            {
                buyer.setID_seller(i);
                i++;
                if(i>=SellerAmount + 1)
                {
                    buyer.setID_seller(-1);
                }
            }
        }

        private void setStock()
        {
            foreach(Seller seller in sellers)
            {
                seller.setStock(phones);
            }
        }

        private void saveStock()
        {
            foreach (Seller seller in sellers)
            {
                seller.createStockFile();
            }
        }

        private void createAgents()
        {
            buyers = new List<Buyer>();
            sellers = new List<Seller>();
            threads = new List<Thread>();

            for (int i = 0; i < BuyerAmount; i++)
            {
                id++;
                buyers.Add(new Buyer(i));
            }

            for (int i = 0; i < SellerAmount; i++)
            {
                id++;
                sellers.Add(new Seller(i));
            }
        }

        private void addThreads()
        {
            foreach (Buyer buyer in buyers)
            {
                threads.Add(new Thread(() => { SellerId.Add(buyer.getID()); ToShow.Add(buyer.job(criteria, sellers, buyers)); }));
            }

            foreach (Seller seller in sellers)
            {
                threads.Add(new Thread(() => seller.job()));
            }
        }

        private void randomStock()
        {
            double price, percent  = 0;
            int PriceMin, PriceMax = 0;

            foreach (Seller seller in sellers)
            {
                foreach (Phone phone in seller.Stock)
                {
                    price = phone.Get_OriginalPrice();
                    percent = price * 0.1;
                    PriceMin = (int) (price - percent);
                    PriceMax = (int)(price + percent);
                    phone.Set_OriginalPrice(RandomNumber(PriceMin, PriceMax));
                    phone.Set_Amount(RandomNumber(0, 10));
                }
            }
        }

        private void Set_Criteria()
        {
            this.criteria = new Criteria();
            this.criteria.Set_MinPrice(double.Parse(textBoxPriceFrom.Text));
            this.criteria.Set_MaxPrice(double.Parse(textBoxPriceTo.Text));
            this.criteria.Set_DisplaySize(comboBoxDisplaySize.Text);
            this.criteria.Set_DisplayType(comboBoxScreenType.Text);
            this.criteria.Set_Weight(comboBoxWeight.Text);
            this.criteria.Set_Usage(comboBoxUsage.Text);
            this.criteria.Set_Battery(comboBoxBattery.Text);
            this.criteria.Set_Photos(comboBoxPhotos.Text);
            this.criteria.Set_Waterproof(comboBoxWaterproof.Text);
            this.criteria.Set_DualSim(comboBoxDualSim.Text);
        }

        private void setSeller(List<Buyer> buyers, List<Seller> sellers)
        {
            int i = 0;

            foreach (Buyer buyer in buyers)
            {
                buyer.setID_seller(i);
                i++;
                if (i >= BuyerAmount + 1)
                {
                    buyer.setID_seller(-1);
                }
            }
        }



        void Run(int BuyerAmount, int SellerAmount)
        {
          
            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Form2 form2 = new Form2(criteria, SellerId, ToShow);
        }

    }
}
