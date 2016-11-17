using IFrame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels;
using Xamarin.Forms;
using IFrame.Views.Friends;
using IFrame.ViewModels.Messages;

namespace IFrame.Views.Messages
{
	public partial class TalkPage : ContentView
	{
		public TalkPage ()
		{
			InitializeComponent ();
            BindingContext = new TalkPageViewModel();
        }

	    private void OnAddChat(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new AddFriendPage());
        }

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
            Navigation.PushAsync(new MessagePage());
            ChatList.SelectedItem = null;
        }
	}
}
