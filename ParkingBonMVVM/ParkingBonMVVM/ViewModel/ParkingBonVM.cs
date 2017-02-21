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
        private Model.ParkingBon parkingBonValue;


        public DateTime Datum
        {
            get { return parkingBonValue.Datum; }
            set
            {
                parkingBonValue.Datum = value;
                RaisePropertyChanged("Datum");
            }
        }

        public DateTime Begintijd
        {
            get { return parkingBonValue.Begintijd; }
            set
            {
                parkingBonValue.Begintijd = value;
                RaisePropertyChanged("Begintijd");
            }
        }


        public Decimal Bedrag
        {
            get { return parkingBonValue.Bedrag; }
            set
            {
                parkingBonValue.Bedrag = value;
                RaisePropertyChanged("Bedrag");
            }
        }

        public DateTime Eindtijd
        {
            get { return parkingBonValue.Eindtijd; }
            set
            {
                parkingBonValue.Eindtijd = value;
                RaisePropertyChanged("Eindtijd");
            }
        }

    */
        public ParkingBonVM(Model.ParkingBon parkingbon)
        {
            this.parkingBonValue = parkingbon;
        }





    }
}
