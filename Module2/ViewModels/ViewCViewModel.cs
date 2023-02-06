using FullApp1.Core.Mvvm;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.ViewModels
{
    public class ViewCViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewCViewModel()
        {
            Message = "View C from your Prism Module2";
        }
    }
}
