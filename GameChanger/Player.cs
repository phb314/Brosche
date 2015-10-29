using GameChangerAPI;
using System;
using System.Collections.Generic;

namespace GameChanger
{
    public class Player : IPlayer
    {
        #region IPlayer
        public EBatsHand Bats { get; set; }

        public string NameFirst { get; set; }

        public string NameLast { get; set; }

        public int PlayerNumber { get; set; }

        public IList<EPlayerPosition> Positions { get; set; }

        public EThrowsHand Throws { get; set; }
        #endregion
    }
}
