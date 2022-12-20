using Prism.Mvvm;
using Prism.Navigation;

namespace FullApp1.Core.Mvvm
{
    public interface ICommonData
    {
        string Title { get; set; }
    }
    public class TabClientProxy
    {
        public ICommonData CommonData { get; set; }
        public object Content { get; set; }
    }
    public abstract class ViewModelBase : BindableBase, IDestructible, ICommonData
    {
        protected ViewModelBase()
        {

        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public virtual void Destroy()
        {

        }
    }
}
