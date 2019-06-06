using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_RabotaXML
{
    /// <summary>
    /// Методы работаем с БД SQLite
    /// </summary>
    class RabSql
    {
        /// <summary>
        /// Создание БД
        /// </summary>
        public string CraeteBDSQLite()
        {
            string logFile = "";
            //Проверка. Если файла нет он создается
            if (!File.Exists(@"mobiles.bd"))
            {
                logFile += $"{DateTime.Now}Создание БД\n";
                // создать базу данных, по указанному пути содаётся пустой файл базы данных
                SQLiteConnection.CreateFile(@"mobiles.bd");
                 
            }

            else
            {
                logFile += $"{DateTime.Now} База данных была ранее создана.\n";
            }
             
            SaveFile(logFile);

            return logFile;
        }


        public void ConnectBdSQLlite()
        {
            string logFile = "";
            string dbFileName = @"mobiles.bd";
            //Проверка. Если файла нет он создается
            try
            {

             
            SQLiteConnection qLiteConnection = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                logFile += $"{DateTime.Now} Соединение c БД установленно\n";
            }

            catch (Exception ex)
            {
                logFile += $"{DateTime.Now} Соединение c БД НЕ установленно\n {ex.ToString()}";
              
            }

        }

        /// <summary>
        /// Запись лога
        /// </summary>
        /// <param name="textLog">Текст который требуется записать</param>
        public static void SaveFile(string textLog)
        {
            string pathLog = @"log.txt";

            using (StreamWriter sw = new StreamWriter(pathLog, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(textLog);
            };

        }


    }
}
