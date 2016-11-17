using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Support.V7.Widget;
using Xamarin.Forms;
using Plugin.Toasts;

namespace IFrame.Views.Dialogs
{
	public partial class InviteCode : PopupPage
    {
        bool SupportsClipboard { get; }

        public InviteCode()
	    {
	        InitializeComponent();
            CodeLabel.Text = "123456";
	    }

	    private void OnCopyButton(object sender, EventArgs e)
	    {
            CrossShare.Current.SetClipboardText("123456",null);
	        ShowToast(ToastNotificationType.Info);
            Navigation.PopPopupAsync();
        }

	    private void OnShareButton(object sender, EventArgs e)
	    {
            CrossShare.Current.ShareLink("http://motzcod.es", "Checkout my blog", "MotzCod.es");
            // Navigation.PopPopupAsync();
        }

        private async void ShowToast(ToastNotificationType type)
        {
            var notificator = DependencyService.Get<IToastNotificator>();
            bool tapped = await notificator.Notify(type, "复制完成", "快去分享吧!", TimeSpan.FromSeconds(1.5));
        }
    }
}
