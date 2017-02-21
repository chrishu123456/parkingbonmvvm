using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBonMVVM.ViewModel
{
    public class ParkingBonVM : ViewModelBase
    {
        private Model.DatumBon datumBonValue;


        public DateTime Datum
        {
            get { return datumBonValue.Datum; }
            set
            {
                datumBonValue.Datum = value;
                RaisePropertyChanged("Datum");
            }
        }

        public DateTime Begintijd
        {
            get { return datumBonValue.Begintijd; }
            set
            {
                datumBonValue.Begintijd = value;
                RaisePropertyChanged("Begintijd");
            }
        }


        public Decimal Bedrag
        {
            get { return datumBonValue.Bedrag; }
            set
            {
                datumBonValue.Bedrag = value;
                RaisePropertyChanged("Bedrag");
            }
        }

        public DateTime Eindtijd
        {
            get { return datumBonValue.Eindtijd; }
            set
            {
                datumBonValue.Eindtijd = value;
                RaisePropertyChanged("Eindtijd");
            }
        }

    */
        public ParkingBonVM(Model.DatumBon datumbon)
        {
            this.datumBonValue = datumbon;
        }





    }
}
