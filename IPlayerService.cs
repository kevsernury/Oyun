using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaOdev5
{
    interface IPlayerService
    {
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        public void DeletePlayer(Player player);
        public bool IsValid(Player player);

    }
}
