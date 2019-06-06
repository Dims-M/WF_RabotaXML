using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_RabotaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Кнопка пуск
        private void Button1_Click(object sender, EventArgs e)
        {
            // Zapuskator();
            RabotaSQLite();
        }

        void Zapuskator()
        {
            Bl bl = new Bl();
            // label1.Text = bl.GetDataFailXml(@"lastRestsShop.xml");
            // textBox1.Text = bl.GetDataFailXml(@"lastRestsShop.xml");
            // label1.Text = bl.GetDataFailXml(@"ne_prinatieTTN.xml"); 

            //textBox1.Text = bl.GetDataFailXml(@"ne_prinatieTTN.xml");
            // textBox1.Text = bl.GetDataFailXml(@"WayBillAct_v3.xml");
            textBox1.Text += bl.GetDataFailXml2("WayBillAct_v3-41.xml");
           // textBox1.Text += bl.GetDataFailXml2("books.xml");
            // bl.GetDataFailXml2("users.xml");
        }

        void RabotaSQLite()
        {
            RabSql rabSql = new RabSql();
           label1.Text =  rabSql.CraeteBDSQLite();

        }

        //очистиить
        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }
        //
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
