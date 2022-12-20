using FullApp1.Core.Mvvm;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
       
        public ViewAViewModel()
        {
            Title = "View A from your Prism Module 1";
        }
    }
}
