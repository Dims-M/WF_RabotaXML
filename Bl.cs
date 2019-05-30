using System;
using System.Collections.Generic;
using System.IO;
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
            string temXmlFail = "";

            XmlNode root = documen.DocumentElement;  //в обьект запысаваем корневой главный рут документа 

            temXmlFail = $"Имя documen.DocumentElement: '{root.LocalName}'";



            //*********************************
            #region Тестовой код НЕ использовать!
            //  temXmlFail = documen.InnerText; // показывает весь текст
            //temXmlFail += documen.InnerXml;

            //using (FileStream stream = new FileStream(path, FileMode.Open)) // поток для чтения файла 
            //{
            //    XmlTextReader xmlReader = new XmlTextReader(stream); // обьект для раб с Xml

            //      while (xmlReader.Read() )
            //    {
            //        temXmlFail += 
            //        $"\n{xmlReader.NodeType} " +
            //        $"\n{xmlReader.Name} " +
            //        $"\n{xmlReader.Value} ";
            //    }  
            //}
            #endregion
            //*********************************


            temXmlFail += "\t\n";

           

            return temXmlFail;

        }


    }
}
