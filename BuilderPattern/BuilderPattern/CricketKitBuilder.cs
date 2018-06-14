using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CricketKitBuilder
    {
        List<ICricketKit> cricketKit = new List<ICricketKit>();

        public void AddToCricketKit(ICricketKit kitItem)
        {
            cricketKit.Add(kitItem);
        }

        public void DisplayMyCricketKit()
        {
            foreach (var kitItem in cricketKit)
            {
                Console.WriteLine("Name: " + kitItem.ShowName() + ", Sponsor: " + kitItem.ShowSponsor().ShowSponsor());
            }
        }
    }
}
