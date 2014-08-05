using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ComboBindTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
            }
        }

        /// <summary>
        /// The <see cref="MyProperty" /> property's name.
        /// </summary>
        public const string MyPropertyPropertyName = "MyProperty";

        private int _myProperty = 0;

        /// <summary>
        /// Sets and gets the MyProperty property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int MyProperty
        {
            get
            {
                return _myProperty;
            }

            set
            {
                if (_myProperty == value)
                {
                    return;
                }

                RaisePropertyChanging(MyPropertyPropertyName);
                _myProperty = value;
                RaisePropertyChanged(MyPropertyPropertyName);
            }
        }


        private RelayCommand<string> _myCommand;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand<string> MyCommand
        {
            get
            {
                return _myCommand
                    ?? (_myCommand = new RelayCommand<string>(
                                          changeAgent =>
                                          {
                                              MyProperty = int.Parse(changeAgent);
                                          }));
            }
        }

    }
}
