using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didguswnsapp;

namespace GiftBoxManagerNamespace
{
    class GiftBoxManager
    {
        public void SetInit()
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000, ITEM_GRADE.NORMAL);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000, ITEM_GRADE.RARE);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000, ITEM_GRADE.UNIQUE);
            Console.WriteLine($"addressC : letter : {addressC.Letter} item : {addressC.Grade}");
        }

        private static GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE itemGrade)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = itemGrade
            };

            return addressA;
        }

       
    }
}
