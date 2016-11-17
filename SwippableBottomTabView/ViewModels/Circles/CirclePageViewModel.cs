using IFrame.Views.Circles;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IFrame.ViewModels.Circles
{
    class CirclePageViewModel : BaseViewModel, ICarouselViewModel
    {
        public ContentView View
        {
            get { return new CirclePage(); }
        }

        public string Title
        {
            get
            {
                return "医友圈";
            }
        }
    }
}
