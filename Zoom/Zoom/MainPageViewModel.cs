using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoom
{
    public class MainPageViewModel:INotifyPropertyChanged 
    {
        public MainPageViewModel()
        {
            this.Wallpapers = new List<MainPageModel>
            {
                new MainPageModel
                {
                    ImageUri = "/Assets/corrode.jpg"
                }
            };
        }
 
        public event PropertyChangedEventHandler PropertyChanged;
 
        public List<MainPageModel> Wallpapers { get; private set; }

        private double pageWidth;
        private double pageHeight;

        public double PageWidth
        {
            get
            {
                return this.pageWidth;
            }
            set
            {
                if (this.pageWidth != value)
                {
                    this.pageWidth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double PageHeight
        {
            get
            {
                return this.pageHeight;
            }
            set
            {
                if (this.pageHeight != value)
                {
                    this.pageHeight = value;
                    NotifyPropertyChanged();
                }
            }
        }
 
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
    }
}
