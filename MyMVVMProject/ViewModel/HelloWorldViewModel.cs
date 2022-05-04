using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyMVVMProject.Model;

namespace MyMVVMProject.ViewModel
{
    //implements iNotifyPropertyChanged interface to support bindings
    public class HelloWorldViewModel
    {
        private string helloString;

        public event PropertyChangedEventHandler PropertyChanged;

        public string HelloString
        {
            get
            {
                return helloString;
            }
            set
            {
                helloString = value;
                OnPropertyChanged();
            }
        }

        //Raises OnPropertychangedEvent when property changes
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public HelloWorldViewModel()
        {
            HelloWorldModel helloWorldModel = new HelloWorldModel();
            helloString = helloWorldModel.ImportantInfo;
        }
    }
}
