using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign, double discount);
    }
}