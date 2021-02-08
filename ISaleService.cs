using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    interface ISaleService
    {
        void Sale(Player player);
        public void SaleWithCampaign(Player player, Campaign campaign);

    }
}
