using Xamarin.Forms;
using IFrame.Models;
using System.Collections.ObjectModel;
using IFrame.Views.Messages;

namespace IFrame.ViewModels.Messages
{
    class TalkPageViewModel : BaseViewModel, ICarouselViewModel
    {
        public ObservableCollection<ChatInfo> ChatInformations { get; set; }
        public ContentView View
        {
            get { return new TalkPage(); }
        }
        
        public TalkPageViewModel()
        {
            ChatInformations = new ObservableCollection<ChatInfo>();

            ChatInformations.Add(new ChatInfo()
            {
                Name = "刘医生",
                TalkInfo = "看下这个案例",
                TalkTime = "19:20",
                UnreadNum = "3",
                FriendPhoto = "@drawable/doctor"
            });
        }

    }
}