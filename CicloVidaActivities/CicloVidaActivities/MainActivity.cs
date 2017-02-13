using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace CicloVidaActivities
{
    [Activity(Label = "CicloVidaActivities", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var txtNumero = FindViewById<EditText>(Resource.Id.txtNumero);
            var cmdVerificar = FindViewById<Button>(Resource.Id.cmdVerificar);


            cmdVerificar.Click += delegate
            {
                using (var resultActivity = new Intent(this, typeof(ResultActivity)))
                {
                    resultActivity.PutExtra("Numero", int.Parse(txtNumero.Text));
                    StartActivity(resultActivity);
                }
            };
        }
    }
}

