using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtprototype.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public String Video { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Video = "intro_tour_video_1080.mp4";
        }
    }
}
