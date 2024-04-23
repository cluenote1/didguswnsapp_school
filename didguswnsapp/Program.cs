using GiftBoxManagerNamespace;

namespace didguswnsapp
{
     
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("시작 부분");

            int money = 10000;
            Console.WriteLine(money);
            SetMoney(money);
            Console.WriteLine(money);

            GiftBox giftBox = new GiftBox()
            {
                Money = 10000
            };
            Console.WriteLine(giftBox.Money);
            SetGiftBox(giftBox);
            Console.WriteLine(giftBox.Money);


        }

        static void SetMoney(int needMoney) 
        {
            needMoney = 30000;
        }

        static void SetGiftBox(GiftBox info)
        {
            info.Money = 50000;
        }



    }
}



