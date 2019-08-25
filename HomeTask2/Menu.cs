using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Menu
    {
        public void getMenu (Account account)
        {
            Console.WriteLine("1 - Balansa bax \n" +
                              "2 - Balans artir \n" +
                              "3 - Balansdan çıxariş \n" +
                              "4 - Hesab məlumatlarını dəyiş \n" +
                              "0 - Çıxış");
            Console.WriteLine("Menyunu daxil edin:");
            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            if (selectedMenu == 1)
            {
                Console.WriteLine("Sizin balansiniz:" + account.Amount);
            }
            if (selectedMenu == 2)
            {
                Console.WriteLine("Mebleg daxil edin:");
                string newAmount = Console.ReadLine();
                account.addAmount(newAmount);
            }
            if (selectedMenu == 3)
            {
                Console.WriteLine("Chixarish meblegini daxil edin:");
                string amount = Console.ReadLine();
                account.minusAmount(amount);
            }
            
            
            getMenu(account);
        }
    }
}
