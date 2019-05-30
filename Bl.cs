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

            temXmlFail = $"Имя documen.DocumentElement: '{root.LocalName}'" ; // получение имя корневого элемента
            temXmlFail += Environment.NewLine;

            foreach (XmlNode node in root.ChildNodes) // получение дочерных узлов
            {
                temXmlFail += node.Name + ": " + node.InnerText;
                temXmlFail += Environment.NewLine;
                temXmlFail += "-----------------------------------";
                temXmlFail += Environment.NewLine;
            }


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

        public string GetDataFailXml2(string path)
        {
            string tempLog = "";
            // var reader = new XmlTextReader(path); // работаем  с xml
            var reader = new XmlDocument( );
            reader.Load(path); // получаем файл

            XmlElement xRoot = reader.DocumentElement; // получаем все элементы документа
            foreach (XmlNode xnode in xRoot) // считываем весь файл
            {
                

                if (xnode.Attributes.Count > 0)
                {
                    var attr = xnode.Attributes.GetNamedItem("ns:Documents");
                    
                    if (attr!= null) // ищем совпадения по нужному параметру
                    {
                        //tempLog +=$"= {reader.GetAttribute("wa:Note")}";
                        tempLog += $"123654{attr.Value}" ;
                    }

                 }
                
            }
            tempLog += $"Значение не установленно.";
            return tempLog;
        }

    }
}
