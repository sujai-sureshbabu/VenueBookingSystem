using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using VenueBookingSystem.Launcher.VenueService;
using VenueBookingSystem.Launcher.Commands;
using System.Windows.Input;
using System.Windows;

namespace VenueBookingSystem.Launcher.ViewModels
{
    public class SmallVenueViewModel : INotifyPropertyChanged
    {

        public SmallVenueViewModel()
        {
            PopulateSeatDetails();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }


        #region Enabling Properties
        private bool? _seatA1;
        public bool? SeatA1
        {
            get
            {
                return _seatA1;
            }
            set
            {
                _seatA1 = value;
                OnPropertyChanged("SeatA1");
            }

        }

        private bool? _seatA2;
        public bool? SeatA2
        {
            get
            {
                return _seatA2;
            }
            set
            {
                _seatA2 = value;
                OnPropertyChanged("SeatA2");
            }

        }       

        private bool? _seatA3;
        public bool? SeatA3
        {
            get
            {
                return _seatA3;
            }
            set
            {
                _seatA3 = value;
                OnPropertyChanged("SeatA3");
            }

        }

        private bool? _seatA4;
        public bool? SeatA4
        {
            get
            {
                return _seatA4;
            }
            set
            {
                _seatA4 = value;
                OnPropertyChanged("SeatA4");
            }

        }

        private bool? _seatA5;
        public bool? SeatA5
        {
            get
            {
                return _seatA5;
            }
            set
            {
                _seatA5 = value;
                OnPropertyChanged("SeatA5");
            }

        }

        private bool? _seatA6;
        public bool? SeatA6
        {
            get
            {
                return _seatA6;
            }
            set
            {
                _seatA6 = value;
                OnPropertyChanged("SeatA6");
            }

        }

        private bool? _seatB1;
        public bool? SeatB1
        {
            get
            {
                return _seatB1;
            }
            set
            {
                _seatB1 = value;
                OnPropertyChanged("SeatB1");
            }

        }

        private bool? _seatB2;
        public bool? SeatB2
        {
            get
            {
                return _seatB2;
            }
            set
            {
                _seatB2 = value;
                OnPropertyChanged("SeatB2");
            }

        }

        private bool? _seatB3w;
        public bool? SeatB3w
        {
            get
            {
                return _seatB3w;
            }
            set
            {
                _seatB3w = value;
                OnPropertyChanged("SeatB3w");
            }

        }

        private bool? _seatB4;
        public bool? SeatB4
        {
            get { return _seatB4; }
            set
            {
                _seatB4 = value;
                OnPropertyChanged("SeatB4");
            }
        }

        private bool? _seatB5;
        public bool? SeatB5
        {
            get { return _seatB5; }
            set
            {
                _seatB5 = value;
                OnPropertyChanged("SeatB5");
            }
        }

        private bool? _seatB6;
        public bool? SeatB6
        {
            get { return _seatB6; }
            set
            {
                _seatB6 = value;
                OnPropertyChanged("SeatB6");
            }
        }

        private bool? _seatC1;
        public bool? SeatC1
        {
            get { return _seatC1; }
            set
            {
                _seatC1 = value;
                OnPropertyChanged("SeatC1");
            }
        }

        private bool? _seatC2;
        public bool? SeatC2
        {
            get { return _seatC2; }
            set
            {
                _seatC2 = value;
                OnPropertyChanged("SeatC2");
            }
        }

        private bool? _seatC3;
        public bool? SeatC3
        {
            get { return _seatC3; }
            set
            {
                _seatC3 = value;
                OnPropertyChanged("SeatC3");
            }
        }

        private bool? _seatC4;
        public bool? SeatC4
        {
            get { return _seatC4; }
            set
            {
                _seatC4 = value;
                OnPropertyChanged("SeatC4");
            }
        }

        private bool? _seatC5;
        public bool? SeatC5
        {
            get { return _seatC5; }
            set
            {
                _seatC5 = value;
                OnPropertyChanged("SeatC5");
            }
        }

        private bool? _seatC6;
        public bool? SeatC6
        {
            get { return _seatC6; }
            set
            {
                _seatC6 = value;
                OnPropertyChanged("SeatC6");
            }
        }

        #endregion

        #region Selection properties
        private bool? _seatA1Selected =false;
        public bool? SeatA1Selected
        {
            get
            { return _seatA1Selected; }
            set
            {
                _seatA1Selected = value;
                OnPropertyChanged("SeatA1Selected");
            }
        }

        private bool? _seatA2Selected = false;
        public bool? SeatA2Selected
        {
            get
            {  return _seatA2Selected; }
            set
            {
                _seatA2Selected = value;
                OnPropertyChanged("SeatA2Selected");
            }
        }

        private bool? _seatA3Selected = false;
        public bool? SeatA3Selected
        {
            get
            {
                return _seatA3Selected;
            }
            set
            {
                _seatA3Selected = value;
                OnPropertyChanged("SeatA3Selected");
            }

        }
        private bool? _seatA4Selected = false;
        public bool? SeatA4Selected
        {
            get
            {
                return _seatA4Selected;
            }
            set
            {
                _seatA4Selected = value;
                OnPropertyChanged("SeatA4Selected");
            }

        }

        private bool? _seatA5Selected = false;
        public bool? SeatA5Selected
        {
            get
            {
                return _seatA5Selected;
            }
            set
            {
                _seatA5Selected = value;
                OnPropertyChanged("SeatA5Selected");
            }

        }

        private bool? _seatA6Selected = false;
        public bool? SeatA6Selected
        {
            get
            {
                return _seatA6Selected;
            }
            set
            {
                _seatA6Selected = value;
                OnPropertyChanged("SeatA6Selected");
            }

        }

        private bool? _seatB1Selected = false;
        public bool? SeatB1Selected
        {
            get
            {
                return _seatB1Selected;
            }
            set
            {
                _seatB1Selected = value;
                OnPropertyChanged("SeatB1Selected");
            }
        }

        private bool? _seatB2Selected = false;
        public bool? SeatB2Selected
        {
            get
            {
                return _seatB2Selected;
            }
            set
            {
                _seatB2Selected = value;
                if(_seatB2Selected == true && SeatB3wSelected!= true)
                {
                    SeatB3wSelected = true;
                }
                if (_seatB2Selected == false && SeatB3wSelected != false)
                {
                    SeatB3wSelected = false;
                }
                OnPropertyChanged("SeatB2Selected");
            }
        }

        private bool? _seatB3wSelected = false;
        public bool? SeatB3wSelected
        {
            get
            {
                return _seatB3wSelected;
            }
            set
            {
                _seatB3wSelected = value;
                if(_seatB3wSelected == true && SeatB2Selected !=true)
                {
                    SeatB2Selected = true;
                }
                if (_seatB3wSelected == false && SeatB2Selected != false)
                {
                    SeatB2Selected = false;
                }
                OnPropertyChanged("SeatB3wSelected");
            }
        }

        private bool? _seatB4Selected = false;
        public bool? SeatB4Selected
        {
            get
            {
                return _seatB4Selected;
            }
            set
            {
                _seatB4Selected = value;
                OnPropertyChanged("SeatB4Selected");
            }
        }

        private bool? _seatB5Selected = false;
        public bool? SeatB5Selected
        {
            get
            {
                return _seatB5Selected;
            }
            set
            {
                _seatB5Selected = value;
                if (_seatB5Selected == true && SeatB6wSelected != true)
                {
                    SeatB6wSelected = true;
                }
                if (_seatB5Selected == false && SeatB6wSelected != false)
                {
                    SeatB6wSelected = false;
                }
                OnPropertyChanged("SeatB5Selected");
            }
        }

        private bool? _seatB6wSelected = false;
        public bool? SeatB6wSelected
        {
            get
            {
                return _seatB6wSelected;
            }
            set
            {
                _seatB6wSelected = value;
                if (_seatB6wSelected == true && SeatB5Selected != true)
                {
                    SeatB5Selected = true;
                }
                if (_seatB6wSelected == false && SeatB5Selected != false)
                {
                    SeatB5Selected = false;
                }
                OnPropertyChanged("SeatB6wSelected");
            }
        }
        private bool? _seatC1Selected = false;
        public bool? SeatC1Selected
        {
            get
            {  return _seatC1Selected; }
            set
            {
                _seatC1Selected = value;
                OnPropertyChanged("SeatC1Selected");
            }
        }

        private bool? _seatC2Selected = false;
        public bool? SeatC2Selected
        {
            get
            { return _seatC2Selected; }
            set
            {
                _seatC2Selected = value;
                OnPropertyChanged("SeatC2Selected");
            }
        }

        private bool? _seatC3Selected = false;
        public bool? SeatC3Selected
        {
            get
            { return _seatC3Selected; }
            set
            {
                _seatC3Selected = value;
                OnPropertyChanged("SeatC3Selected");
            }
        }

        private bool? _seatC4Selected = false;
        public bool? SeatC4Selected
        {
            get
            { return _seatC4Selected; }
            set
            {
                _seatC4Selected = value;
                OnPropertyChanged("SeatC4Selected");
            }
        }

        private bool? _seatC5Selected = false;
        public bool? SeatC5Selected
        {
            get
            { return _seatC5Selected; }
            set
            {
                _seatC5Selected = value;
                OnPropertyChanged("SeatC5Selected");
            }
        }

        private bool? _seatC6Selected = false;
        public bool? SeatC6Selected
        {
            get
            { return _seatC6Selected; }
            set
            {
                _seatC6Selected = value;
                OnPropertyChanged("SeatC6Selected");
            }
        }

        #endregion



        private List<VenueSeatingDetails> SeatsInVenue()
        {
            using (VenueService.ServiceClient v = new ServiceClient())
            {
                var r = v.GetSeatingDetails();
                return r.ToList();
            }
        }

        private void PopulateSeatDetails()
        {
            var seatDetails = SeatsInVenue();

            if (seatDetails.Count > 0)
            {
                SeatA1 = seatDetails[0].isAvailable;
                SeatA2 = seatDetails[1].isAvailable;
                SeatA3 = seatDetails[2].isAvailable;
                SeatA4 = seatDetails[3].isAvailable;
                SeatA5 = seatDetails[4].isAvailable;
                SeatA6 = seatDetails[5].isAvailable;
                SeatB1 = seatDetails[6].isAvailable;
                SeatB2 = seatDetails[7].isAvailable;
                SeatB3w = seatDetails[8].isAvailable;
                SeatB4 = seatDetails[9].isAvailable;
                SeatB5 = seatDetails[10].isAvailable;
                SeatB6 = seatDetails[11].isAvailable;
                SeatC1 = seatDetails[12].isAvailable;
                SeatC2 = seatDetails[13].isAvailable;
                SeatC3 = seatDetails[14].isAvailable;
                SeatC4 = seatDetails[15].isAvailable;
                SeatC5 = seatDetails[16].isAvailable;
                SeatC6 = seatDetails[17].isAvailable;

            }
            
        }

        private void BookSeats()
        {
            using (VenueService.ServiceClient v = new ServiceClient())
            {
                string success;
                List<string> selectedSeats = new List<string>();

                if (SeatA1Selected == true)
                {
                    selectedSeats.Add("A1");
                    SeatA1Selected = false;
                }               

                if (SeatA2Selected == true)
                {
                    selectedSeats.Add("A2");
                    SeatA2Selected = false;
                }

                if(SeatA3Selected == true)
                {
                    selectedSeats.Add("A3");
                    SeatA3Selected = false;
                }
                if (SeatA4Selected == true)
                {
                    selectedSeats.Add("A4");
                    SeatA4Selected = false;
                }

                if (SeatA5Selected == true)
                {
                    selectedSeats.Add("A5");
                    SeatA5Selected = false;
                }
                if (SeatA6Selected == true)
                {
                    selectedSeats.Add("A6");
                    SeatA6Selected = false;
                }

                if (SeatB1Selected == true)
                {
                    selectedSeats.Add("B1");
                    SeatB1Selected = false;
                }
                if (SeatB2Selected == true && SeatB3wSelected == true)
                {
                    selectedSeats.Add("B2");
                    selectedSeats.Add("B3w");
                    SeatB2Selected = false;
                    SeatB3wSelected = false;
                }

                if (SeatB4Selected == true)
                {
                    selectedSeats.Add("B4");
                    SeatB4Selected = false;
                }
                if (SeatB5Selected == true && SeatB6wSelected == true)
                {
                    selectedSeats.Add("B5");
                    selectedSeats.Add("B6w");
                    SeatB5Selected = false;
                    SeatB6wSelected = false;
                }

                if (SeatC1Selected == true)
                {
                    selectedSeats.Add("C1");
                    SeatC1Selected = false;
                }

                if (SeatC2Selected == true)
                {
                    selectedSeats.Add("C2");
                    SeatC2Selected = false;
                }

                if (SeatC3Selected == true)
                {
                    selectedSeats.Add("C3");
                    SeatC3Selected = false;
                }

                if (SeatC4Selected == true)
                {
                    selectedSeats.Add("C4");
                    SeatC4Selected = false;
                }

                if (SeatC5Selected == true)
                {
                    selectedSeats.Add("C5");
                    SeatC5Selected = false;
                }

                if (SeatC6Selected == true)
                {
                    selectedSeats.Add("C6");
                    SeatC6Selected = false;
                }

                if(selectedSeats.Count >3)
                {
                    MessageBox.Show("Only Max 3 Seats allowed to book at a time!First 3 seat selections will be processed.");
                }
                if (selectedSeats.Count() > 3)
                {
                    selectedSeats.RemoveRange(3, selectedSeats.Count() - 3);
                }

                success = v.BookVenueSeats(selectedSeats.ToArray());

                if(success == "Success")
                {
                    PopulateSeatDetails();
                    MessageBox.Show("Congradulations !Your Seats are booked");
                }
            }

        }

        private ICommand _bookseatcommand;
        public ICommand BookSeatCommand
        {
            get
            {
                if (_bookseatcommand == null)
                {
                    _bookseatcommand = new RelayCommand(
                        p => true,
                        p => this.BookSeats());
                }
                return _bookseatcommand;
            }
        }

        
    }
}
