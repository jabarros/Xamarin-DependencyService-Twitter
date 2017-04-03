using Android.App;
using Android.Content;
using Android.Net;
using AppTwitter;
using AppTwitter.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(AppTwitter.Droid.TwitterDroid))]
namespace AppTwitter.Droid
{
    public class TwitterDroid : ITwitter
    {
        public void OpenTwitter()
        {
            Intent twitterIntent = null;

            twitterIntent = new Intent(Intent.ActionView, Uri.Parse("https://twitter.com/intent/tweet?hashtags=AppTwitter"));

            Xamarin.Forms.Forms.Context.StartActivity(twitterIntent);
        }
    }
}