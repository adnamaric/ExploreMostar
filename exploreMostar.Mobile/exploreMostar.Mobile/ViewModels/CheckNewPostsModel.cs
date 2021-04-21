using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
    public class CheckNewPostsModel : BaseViewModel
    {
        private readonly APIService _objave = new APIService("Objava");

        public CheckNewPostsModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Objava> objave { get; set; } = new ObservableCollection<Model.Objava>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _objave.Get<IList<Model.Objava>>(null);
            objave.Clear();
            var temp = 0;
            foreach(var objava in list)
            {
                objava.Rbr = ++temp;
                objave.Add(objava);
            }
        }
    }
}
