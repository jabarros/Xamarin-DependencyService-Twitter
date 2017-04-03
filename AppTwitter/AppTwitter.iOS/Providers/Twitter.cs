using System;
using Social;
using UIKit;
using AppTwitter;
using AppTwitter.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(AppTwitter.iOS.TwitterIos))]

namespace AppTwitter.iOS
{
    public class TwitterIos : ITwitter
    {
        public TwitterIos()
        {
        }

        public void OpenTwitter()
        {
            var slComposr = SLComposeViewController.FromService(SLServiceType.Twitter);

            if (SLComposeViewController.IsAvailable(SLServiceKind.Twitter))
            {
                slComposr.SetInitialText("#AppTwitter");

                slComposr.CompletionHandler += (result) =>
                {
                    UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
                };

                UIWindow window = UIApplication.SharedApplication.KeyWindow;
                UIViewController viewController = window.RootViewController;
                if (viewController == null)
                {
                    while (viewController.PresentedViewController != null)
                        viewController = viewController.PresentedViewController;
                }
                viewController.PresentViewController(slComposr, true, null);
            }
        }
    }
}
