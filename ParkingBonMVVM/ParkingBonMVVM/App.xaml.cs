using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ParkingBonMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Model.DatumBon pbmod = new Model.DatumBon();
            ParkingBon.ParkingBonWindow pbv = new ParkingBon.ParkingBonWindow();
            pbv.DataContext = pbmod;
            pbv.Show();
        }
    }
}
