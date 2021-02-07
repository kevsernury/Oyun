using System;

namespace KodlamaOdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.Name = "Aslı";
            player.LastName = "Kara";
            player.NationalityId = "11111111111";

            PlayerManager playerManager = new PlayerManager();
            playerManager.AddPlayer(player);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "İlk deneme";
            campaign.Discount = 15;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(player);
            saleManager.SaleWithCampaign(player, campaign);

            campaignManager.UpdateCampaign(campaign, 20);

            saleManager.SaleWithCampaign(player, campaign);
            
            

        }
    }
}
