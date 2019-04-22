using WpfDawg.Models;

namespace WpfDawg.ViewModels
{
    public class ViewModelDawg : ViewModelBase
    {
        Dawg Dawg;    

        public string Name
        {
            get { return Dawg.Name; }
            set {
                RaisePropertyChanged();
                Dawg.Name = value; }
        }

        public double Cost
        {
            get { return Dawg.Cost; }
            set {
                RaisePropertyChanged();
                Dawg.Cost = value; }
        }

        public bool IsVegan
        {
            get { return Dawg.IsVegan; }
            set {
                RaisePropertyChanged();
                Dawg.IsVegan = value; }
        }

        public ViewModelDawg(Dawg Dawg)
        {
            this.Dawg = Dawg;
        }


    }
}
