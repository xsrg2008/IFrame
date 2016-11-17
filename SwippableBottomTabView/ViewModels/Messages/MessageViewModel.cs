using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.ViewModels.Messages
{
    public class MessageViewModel :　BaseMessageViewModel
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; RaisePropertyChanged(); }
        }

        private DateTime messageDateTime;

        public DateTime MessagDateTime
        {
            get { return messageDateTime; }
            set { messageDateTime = value; RaisePropertyChanged(); }
        }

        private bool isIncoming;

        public bool IsIncoming
        {
            get { return isIncoming; }
            set { isIncoming = value; RaisePropertyChanged(); }
        }

        public bool HasAttachement
        {
            get { return !string.IsNullOrEmpty(photo); }//attachementUrl
        }

        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; RaisePropertyChanged(); }
        }
        /*
        private string attachementUrl;

        public string AttachementUrl
        {
            get { return attachementUrl; }
            set { attachementUrl = value; RaisePropertyChanged(); }
        }*/
    }
}
