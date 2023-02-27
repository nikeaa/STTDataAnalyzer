using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STTDataAnalyzer.Models.PlayerData
{
    public partial class CrewSlot
    {
        public IOrderedEnumerable<Crew> PossibleCards;
        public Crew SelectedCard;
    }
}
