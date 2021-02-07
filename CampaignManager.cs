using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    class CampaignManager
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı " + " kampanya eklenmiştir");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı "  + " kampanya silinmiştir");
        }

        public void UpdateCampaign(Campaign campaign, double discount) //burada başka bir parametre ile güncellenecek şey belirlenebilir
        {
            campaign.Discount = discount;
            Console.WriteLine(campaign.Name + " adlı " +  " kampanya indirimi " + discount +" olarak güncellenmiştir");
        }
    }
}
