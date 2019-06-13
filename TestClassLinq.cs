using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_RabotaXML
{
    /// <summary>
    /// Тестовой класс
    /// </summary>
  public  class TestClassLinq
    {

        string[] planet =
        {
            "Меркурий",
            "Венера",
            "Земля",
            "Марс",
            "Юпитер",
            "Сатурн",
            "Уран",
            "Нептун"
        };


        string[] arr2 =
        {
            "Земля",
            "Плутон",
            "Цецера"
        };



        public string VivodLista(List<string> list)
        {
            string tempdata = "Содержимое списка: \n";

            foreach (var tempList in list)
            {
                tempdata += tempList;
                tempdata += "\n";
            }

            return tempdata;
        }

    }
}
