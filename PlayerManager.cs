using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    class PlayerManager
    {
        public void AddPlayer(Player player)
        {
            if (IsValid(player))
            {
                Console.WriteLine(player.Name + " " + player.LastName + " adlı oyuncu eklenmiştir");
            }
            else
                Console.WriteLine("Kimlik bilgileri geçersiz");
        }

        public void UpdatePlayer(Player player) //güncellenecek bilgiler parametre olarak aylanır
        {
            Console.WriteLine(player.Name + player.LastName + " adlı oyuncu bilgileri güncellenmiştir");
        }

        public void DeletePlayer(Player player) //sadece id'yide parametre olarak alabilir.
        {
            Console.WriteLine(player.Name + player.LastName + " adlı oyuncu silinmiştir");
        }

        public bool IsValid(Player player)//mernis kontrolünü servisi kaydederken aldığım hatadan dolayı yapamadım
        {
            return true;
        }
    }
}
