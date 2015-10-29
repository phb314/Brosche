using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChangerAPI
{
    public interface IPlayer
    {
        String NameFirst { get; }

        String NameLast { get; }

        int PlayerNumber { get; }

        IList<EPlayerPosition> Positions { get; }

        EThrowsHand Throws { get; }

        EBatsHand Bats { get; }
    }
}
