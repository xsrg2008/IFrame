using IFrame.ViewModels;
using IFrame.ViewModels.Circles;
using IFrame.Views;
using IFrame.Views.Friends;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IFrame.Views.Circles
{
    class CirclePage : ContentView
    {
        public CirclePage()
        {
            BackgroundColor = Color.FromRgb(245, 245, 245);

            CirclePageViewModel _circleViewModel = new CirclePageViewModel();

            BoxView box = new BoxView
            {
                Color = Color.FromHex("ffdda0"),
                WidthRequest = 55,
                HeightRequest = 55,
            };

            var label = new Label()
            {
                TextColor = Color.White,
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 55,
                BackgroundColor = Color.FromHex("ffdda0"),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            label.SetBinding<CirclePageViewModel>(Label.TextProperty, vm => vm.Title);

            Button _addTalk = new Button
            {
                Image = "@drawable/add",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.FromHex("ffdda0"),
                WidthRequest = 55,
                BorderRadius = 0
            };
            _addTalk.Clicked += OnButtonClicked;


            StackLayout FriendLayout = new StackLayout
            {

                Spacing = 0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    box,
                    label,
                    _addTalk
                }

            };

        
            Content = FriendLayout;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AddFriendPage());

        }

    }
}
