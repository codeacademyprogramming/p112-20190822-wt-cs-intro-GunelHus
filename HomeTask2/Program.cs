using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Menu menu = new Menu();

            Console.WriteLine("Hesab yaratmaq ucun ashagidaki melumatlari daxil edin");
            Console.WriteLine("Ad:");
            account.Name = Console.ReadLine();
            Console.WriteLine("Soyad:");
            account.Surname = Console.ReadLine();
            Console.WriteLine("Shexsiyyet vesiqesinin seriya nomresi:");
            account.Id = Convert.ToInt32(Console.ReadLine());
            account.Amount = 0.0;

            menu.getMenu(account);
        }


        
    }
}
