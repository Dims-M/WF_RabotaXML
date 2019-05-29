using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WF_RabotaXML
{
    /// <summary>
    /// Логика работы
    /// </summary>
  public  class Bl
    {

        public string GetDataFailXml(string path)
        {
            XmlDocument documen = new XmlDocument(); // обьект для работы с файлом

            documen.Load(path); // прочитать файл.

            string temXmlFail = documen.InnerText; // показывает весь текст

            return temXmlFail;

        }


    }
}
