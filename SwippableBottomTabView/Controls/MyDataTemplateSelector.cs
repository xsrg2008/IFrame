using IFrame.ViewModels.Messages;
using IFrame.Views;
using IFrame.Views.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IFrame.Controls
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public MyDataTemplateSelector()
        {
            // Retain instances!
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutcomingCell));
        }
        
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as MessageViewModel;
            if (messageVm == null)
                return null;
            return messageVm.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
        }

        private readonly DataTemplate incomingDataTemplate;
        private readonly DataTemplate outgoingDataTemplate;
    }
}
