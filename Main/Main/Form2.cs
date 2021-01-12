using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form2 : Form
    {
        public List<List<Phone>> ToShow = new List<List<Phone>>();
        public List<int> SellerId = new List<int>();
        public Criteria criteria = new Criteria();

        public Form2(int sellercounter, int agentid, Criteria criteria,List<Phone> phones)
        {
            // InitializeComponent();
            this.criteria = criteria;
            setToShow(sellercounter, agentid, phones);
           // Test(agentid, criterias,phones);
           // this.ShowDialog();
        }

        public Form2()
        {
            InitializeComponent();
            Test();
            this.ShowDialog();
        }

        public Form2(Criteria criteria, List<int> ids, List<List<Phone>> phones)
        {
             InitializeComponent();
            this.criteria = criteria;
            this.ToShow = phones;
            this.SellerId = ids;
            Test();
            this.ShowDialog();
            //setToShow(sellercounter, agentid, phones);
            // Test(agentid, criterias,phones);
            // this.ShowDialog();
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setToShow(int sellercounter, int agentid, List<Phone> phones)
        {
            if(SellerId.Count()== sellercounter)
            {
                new Form2();
            }
            else
            {
                SellerId.Add(agentid);
                ToShow.Add(phones);
            }
        }



        public void Test()
        {
            this.Text = "Znalezione telefony";
            //this.textBox1.Text =  Thread.CurrentThread.ManagedThreadId.ToString();
            //this.textBox1.Enabled = false;

                this.richTextBox1.AppendText("Cena minimalna: "+criteria.Get_MinPrice()+Environment.NewLine
                    +"Cena maksymalna: "+criteria.Get_MaxPrice()+ Environment.NewLine
                    +"Rozmiar ekranu telefonu: "+criteria.Get_DisplaySize()+ Environment.NewLine
                    + "Ekran dotykowy: " + criteria.Get_DisplayType() + Environment.NewLine
                    + "Waga: " + criteria.Get_Weight() + Environment.NewLine
                    + "Długość pracy na baterii: " + criteria.Get_Battery() + Environment.NewLine
                    + "Okazyjne robienie zdjęć: " + criteria.Get_Photos() + Environment.NewLine
                    + "Wodoodporność: " + criteria.Get_Photos() + Environment.NewLine
                    + "Dual SIM: " + criteria.Get_DualSim() + Environment.NewLine
                    + "Przeznaczenie: " + criteria.Get_Usage() + Environment.NewLine);
            int counter = 1;
            foreach (int ids in SellerId)
            {
                foreach (List<Phone> phones in ToShow)
                {
                    foreach(Phone phone in phones)
                    {
                        DataGridInit(counter, ids, phone.Get_Id(), phone.Get_Name(), phone.Get_DisplaySize(), phone.Get_DisplayType(), phone.Get_Weight(),
                            phone.Get_Battery(), phone.Get_Photos(), phone.Get_Waterproof(), phone.Get_DualSim(), phone.Get_UsageType(), phone.Get_OriginalPrice());
                        counter++;
                    }
                }
            }
            

            
           // foreach(Phone phone in phones)
          //  {
           //     DataGridInit(counter, (agentid+1),phone.Id,phone.Name);
                //counter++;
               // this.richTextBox2.AppendText("Nazwa: " + phone.Name + "" + Environment.NewLine);
         //   }
            
        }

        public void DataGridInit(int counter, int agentid, int phoneid, string name, string displaysize, string displaytype, string weight, string battery, string photos, string waterproof, string dualsim, string usage, double price)
        {
            dataGridView1.Rows.Add(counter, (agentid+1), phoneid, name, displaysize,  displaytype,  weight,  battery,  photos,  waterproof,  dualsim,  usage,  price);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string price = "";
            string lp = "";
            string agentid = "";

            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                name = (string)row.Cells["Nazwa"].Value;
                lp= (string)row.Cells["Lp"].Value.ToString();
                price = (string)row.Cells["Cena"].Value.ToString();
                agentid = (string)row.Cells["IDAgentKup"].Value.ToString();
            }

            Form3 form3 = new Form3(name, price, lp, agentid);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
