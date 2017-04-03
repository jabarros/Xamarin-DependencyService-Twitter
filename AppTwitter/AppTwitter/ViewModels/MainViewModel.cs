using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTwitter
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }

        private async Task ExecuteTwitterCommand()
        {
            DependencyService.Get<ITwitter>().OpenTwitter();
        }


        #region Commands

        Command twitterCommand;
        public Command TwitterCommand
        {
            get
            {
                return twitterCommand ??
                    (twitterCommand = new Command(async () => await ExecuteTwitterCommand()));
            }
        }

        #endregion
    }
}
