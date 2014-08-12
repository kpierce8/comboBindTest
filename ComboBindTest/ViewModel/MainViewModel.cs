using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ComboBindTest.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows;

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
            _theList = new ObservableCollection<dataItem>();
            theList.Add(new dataItem(1, "tree"));
            theList.Add(new dataItem(2, "urban"));
            theList.Add(new dataItem(3, "grass"));
            theList.Add(new dataItem(3));
            theList.Add(new dataItem(1, "grass"));
            theList.Add(new dataItem(2));
            changeView = CollectionViewSource.GetDefaultView(theList);
            
            
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

               
                _myProperty = value;
                ((dataItem)changeView.CurrentItem).landCLass = value;
                RaisePropertyChanged(MyPropertyPropertyName);
                MessageBox.Show("yo4");
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
                                              
                                              dataItem thisDataItem = (dataItem)changeView.CurrentItem;
                                              theList[changeView.CurrentPosition].landCLass = int.Parse(changeAgent);
                                              RaisePropertyChanged(theListPropertyName);
                                        //      RaisePropertyChanged(changeViewPropertyName);
                                              changeView.Refresh();
                                             // RaisePropertyChanged(MyPropertyPropertyName);
                                          }));
            }
        }

        /// <summary>
        /// The <see cref="theList" /> property's name.
        /// </summary>
        public const string theListPropertyName = "theList";

        private ObservableCollection<dataItem> _theList;


        /// <summary>
        /// Sets and gets the theList property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<dataItem> theList
        {
            get
            {
                return _theList;
            }

            set
            {
                if (_theList == value)
                {
                    return;
                }

             //   RaisePropertyChanging(theListPropertyName);
                _theList = value;
                RaisePropertyChanged(theListPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="changeView" /> property's name.
        /// </summary>
        public const string changeViewPropertyName = "changeView";

        private ICollectionView _changeView;

        /// <summary>
        /// Sets and gets the changeView property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ICollectionView changeView
        {
            get
            {
                return _changeView;
            }

            set
            {
                if (_changeView == value)
                {
                    return;
                }

             //   RaisePropertyChanging(changeViewPropertyName);
                _changeView = value;
                RaisePropertyChanged(changeViewPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="Button1" /> property's name.
        /// </summary>
        public const string Button1PropertyName = "Button1";

        private bool _button1 = false;

        /// <summary>
        /// Sets and gets the Button1 property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool Button1
        {
            get
            {
                return _button1;
            }

            set
            {
                if (((dataItem)changeView.CurrentItem).landCLass.Equals("1"))
                {
                    _button1 = true;
                    RaisePropertyChanged(Button1PropertyName);
                }
                else
                {
                    _button1 = false;
                    RaisePropertyChanged(Button1PropertyName);
                } 

            }
        }

        /// <summary>
        /// The <see cref="Button2" /> property's name.
        /// </summary>
        public const string Button2PropertyName = "Button2";

        private bool _button2 = false;

        /// <summary>
        /// Sets and gets the Button2 property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool Button2
        {
            get
            {
                return _button2;
            }

            set
            {
                if (_button2 == value)
                {
                    return;
                }

                RaisePropertyChanging(Button2PropertyName);
                _button2 = value;
                RaisePropertyChanged(Button2PropertyName);
            }
        }
    }
}
