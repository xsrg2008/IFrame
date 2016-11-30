using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.Views.Cells;
using Xamarin.Forms;
using static IFrame.ViewModels.Messages.CreateMulChatViewModel;

namespace IFrame.Views.Messages
{
	public partial class CreateMulChat : ContentPage
	{
		public CreateMulChat ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
            NameList.ItemTemplate = new DataTemplate(typeof(NameListCell));
        }

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnCreate(object sender, EventArgs e)
	    {
            DisplayAlert("创建群聊", "跳转到群聊界面", "确定");
            Navigation.PopAsync();
        }

	    private void OnNameTapped(object sender, ItemTappedEventArgs e)
	    {
            var item = (NameInfo)e.Item;
            if (item == null)
                return;
            else
            {
                if (item.IsSelected)
                {
                    item .IsSelected = false;
                    item.Icon = "";
                }
                else
                {
                    item.IsSelected = true;
                    item.Icon = "@drawable/name_checked";
                }
                NameList.ItemTemplate = new DataTemplate(typeof(NameListCell)); // Update Page
            }
            
            NameList.SelectedItem = null;
        }
	}
}
