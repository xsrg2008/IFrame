using IFrame.Views.Friends;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace IFrame.ViewModels.Messages
{
    public class CreateMulChatViewModel
    {
        public ObservableCollection<NameInfo> FriendList { get; set; }

        public class NameInfo
        {
            public string Id { get; set; }

            public string Name { get; set; }     

            public string Hospital { get; set; }

            public string Profession { get; set; }  //科室

            public bool IsSelected { get; set; }

            public string Icon { get; set; }  //被选择图标

        }

        public CreateMulChatViewModel()
        {
            FriendList = new ObservableCollection<NameInfo>();

            FriendList.Add(new NameInfo()
            {
                Id = "00001",
                Name = "刘医生",
                Hospital = "北医三院",
                Profession = "皮肤科",
                IsSelected = false,
                Icon = ""
            });
            FriendList.Add(new NameInfo()
            {
                Id = "00002",
                Name = "吴医生",
                Hospital = "北京天坛医院",
                Profession = "内科",
                IsSelected = false,
                Icon = ""
            });
            FriendList.Add(new NameInfo()
            {
                Id = "00003",
                Name = "孙医生",
                Hospital = "北京天坛医院",
                Profession = "内科",
                IsSelected = false,
                Icon = ""
            });
            FriendList.Add(new NameInfo()
            {
                Id = "00004",
                Name = "张医生",
                Hospital = "北京协和医院",
                Profession = "神经科",
                IsSelected = false,
                Icon = ""
            });
            FriendList.Add(new NameInfo()
            {
                Id = "00005",
                Name = "赵医生",
                Hospital = "北京协和医院",
                Profession = "神经科",
                IsSelected = false,
                Icon = ""
            });
        }
    }
}

