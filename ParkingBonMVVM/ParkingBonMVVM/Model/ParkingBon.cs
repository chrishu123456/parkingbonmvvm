using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBonMVVM.Model
{
    public class ParkingBon
    {
        public DateTime Datum { get; set; }

        public DateTime Begintijd { get; set; }

        public decimal Bedrag { get; set; }

        public DateTime Eindtijd { get; set; }

        public ParkingBon(DateTime datum, DateTime begintijd, decimal bedrag, DateTime eindtijd)
        {
            this.Datum = datum;
            this.Begintijd = begintijd;
            this.Bedrag = bedrag;
            this.Eindtijd = eindtijd;
        }
    }
}
