using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StaticVsDynamicResource
{
    public partial class StaticVsDynamicPage : ContentPage
    {
        public StaticVsDynamicPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    Resources["currentDateTime"] = DateTime.Now.ToString();
                    return true;
                });
        }
    }
}
