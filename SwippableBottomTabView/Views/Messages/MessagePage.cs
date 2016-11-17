using IFrame.Controls;
using IFrame.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IFrame.Views.Messages
{
    public class MessagePage : ContentPage
    {
        public MessagePage()
        {
            Title = "Monkey Chat";
            var _messagePageViewModel = new MessagePageViewModel();
            var MessagesListView = new ListView()
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                ItemTemplate = new MyDataTemplateSelector(),
                ItemsSource = _messagePageViewModel.Messages,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                //SelectedItem = "" 
            };

            var MessageEntry = new Entry()
            {
                Keyboard = Keyboard.Chat,
                HeightRequest = 25,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            MessageEntry.SetBinding(Entry.TextProperty, "OutGoingText");

            var SentButton = new Button()
            {
                Text = "发送",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Command = _messagePageViewModel.SendCommand
            };

            var MessageControls = new Grid()
            {
                Padding = 5,
                BackgroundColor = Color.FromHex("efeff4"),
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) },
                }
            };
            MessageControls.Children.Add(MessageEntry,0,0);
            MessageControls.Children.Add(SentButton, 0, 1);

            var ChatLayout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    MessagesListView,
                    MessageControls
                }
            };

            Content = ChatLayout;

         }


    }
}
