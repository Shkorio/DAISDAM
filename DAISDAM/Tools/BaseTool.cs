using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAISDAM.Tools
{
    internal class BaseTool : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SignalChanged([CallerMemberName] string trop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(trop));
        }
    }
}
