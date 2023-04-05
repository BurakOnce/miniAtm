using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int bakiye = 2500;
            Console.WriteLine("Atm'ye hoşgeldiniz. Lütfen istediğiniz işlemi tuşlayınız.");
            while (b == 0)
            {
                

                
                Console.WriteLine("\n1-Bakiye Görüntüleme\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış");


                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Bakiyeniz =" + bakiye);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Yatıracağınız tutarı giriniz:");
                    int j = Convert.ToInt32(Console.ReadLine());
                    bakiye += j;
                    Console.WriteLine("Yeni Bakiye:" + bakiye);
                }
                else if (i == 3)
                {
                    int a = 0;
                    while (a == 0) {
                    Console.WriteLine("Çekeceğiniz tutarı giriniz:");
                    int p = Convert.ToInt32(Console.ReadLine());
                    if(p>bakiye)
                    {
                        Console.WriteLine("En fazla bakiyeniz kadar çekim yapabilirsiniz. Kredi imkanımız bulunmamakta.");
                    }
                        else { 
                    bakiye = bakiye-p;
                    Console.WriteLine("Yeni Bakiye:" + bakiye);
                            a++;
                        }
                    }
                }
                else if (i == 4)
                {
                    Console.WriteLine("Güle Güle");
                    b++;
                }

            }
        }
    }
}
