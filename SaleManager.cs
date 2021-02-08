using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    class SaleManager:ISaleService
    {
        public void Sale(Player player)
        {
            Console.WriteLine("Satın alma başarılı");
        }
        public void SaleWithCampaign(Player player, Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası ile yüzde " + campaign.Discount + " indirimli satın alma başarılı");
        }
    }
}
