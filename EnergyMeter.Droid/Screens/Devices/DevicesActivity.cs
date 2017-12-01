using Android.App;

namespace EnergyMeter.Droid.Screens.Devices {
  [Activity(Label = "Energy meter", MainLauncher = true)]
  public partial class DevicesActivity : ActivityBase {
    protected override void OnAfterCreate() {
      SetContentView(Resource.Layout.Devices);
      
      ActionBar.Title = "Zařízení";
    }
  }
}