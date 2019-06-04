using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
          //  Zapuskator();
            ZapuskatorSer();
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

        /// <summary>
        /// Запуск методов для работы с сериализацией.
        /// </summary>
        void ZapuskatorSer()
        {
            //Сейрилизуем в формате xml
            // XmlSerializer serializer = new XmlSerializer(typeof(Bl));

            Bl primerSeri = new Bl();

            Job_XmlSerializer(primerSeri);

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

        void Job_XmlSerializer(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Object));


            using (FileStream stream = new FileStream("Serializer.xml",FileMode.Create,FileAccess.Write))
            {
                serializer.Serialize(stream, obj);

            };
            label1.Text = "Обьект серилизован";
        }
    }
}
 