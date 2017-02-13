using Android.App;
using Android.OS;
using Android.Widget;

namespace CicloVidaActivities
{
    [Activity(Label = "ResultActivity")]
    public class ResultActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Result);

            var lblResultado = FindViewById<TextView>(Resource.Id.lblResultado);
            var numero = Intent.GetIntExtra("Numero", 1);

            if (numero % 2 == 0)
            {
                lblResultado.Text = $"O número {numero} é Par!";
                return;
            }

            lblResultado.Text = $"O número {numero} é Impar!";
        }
    }
}