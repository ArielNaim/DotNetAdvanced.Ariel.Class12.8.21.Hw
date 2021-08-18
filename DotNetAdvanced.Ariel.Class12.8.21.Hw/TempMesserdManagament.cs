using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced.Ariel.Class12._8._21.Hw
{
    public class TempMesserdManagament
    {
        public string[] citis = { "Ramot Naftaly", "Yaffo", "Moran" };
        public int counter { get; set; }
        public TempMessureds[] tempMessureds = new TempMessureds[28];
        public void Add(TempMessureds tempSample)
        {
            Random rndCityTemp = new Random();
            tempSample.Temp = rndCityTemp.Next(24, 40) + rndCityTemp.NextDouble();
            tempSample.City = citis[rndCityTemp.Next(citis.Length)];
            tempSample.Date = counter + 1;
            tempMessureds[counter] = tempSample;
            counter++;
        }
        #region סעיפים 1 ו 2
        public double this[int date]
        {
            get
            {
                if (date > counter - 1)
                {
                    throw new ArgumentException("");
                }
                return tempMessureds[date - 1].Temp;
            }
        }

        /* public TempMessureds this[int date] // לא ניתן לקיים את שני האינקסים יחד מאחר ושניהם משתשמים באותו משתנה 
         {
             get
             {
                 if (date > counter - 1)
                 {
                     throw new ArgumentException("");
                 }
                 return tempMessureds[date - 1];
             }
         } */
        #endregion

        #region סעיף 3 
        public string this[string city]
        {
            get
            {
                foreach (TempMessureds temp in tempMessureds)
                {
                    if (city == temp.City)
                    {
                        return temp.City;
                    }
                }
                throw new ArgumentException("Not in the listed citis");
            }
        }
        #endregion

        #region סעיף 4
        public bool this[string city, int date]
        {
            get
            {
                foreach (TempMessureds temp in tempMessureds)
                {
                    if (temp.City == city && temp.Date == date)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion
    }

}