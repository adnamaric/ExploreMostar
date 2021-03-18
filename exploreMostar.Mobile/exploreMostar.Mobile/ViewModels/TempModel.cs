using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace exploreMostar.Mobile.ViewModels
{
   public class TempModel :BaseViewModel
    {
        private readonly APIService _restorani = new APIService("Restorani");
        public ObservableCollection<Model.Restorani> Restorani{ get; set; } = new ObservableCollection<Model.Restorani>();
        public ICommand InitCommand { get; set; }
        public TempModel()
        {
           
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await _restorani.Get<IEnumerable<Model.Restorani>>(null);
            Restorani.Clear();
            foreach (var item in list)
            {
                Restorani.Add(item);
            }
        }
    }
}
