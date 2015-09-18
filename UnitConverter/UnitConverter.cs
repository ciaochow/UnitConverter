using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class UnitConverter
    {
        private decimal _ftocelsius;
        private decimal _ftokelvin;
        private decimal _celsiustokelvin;
        private decimal _celsiustof;
        private decimal _kelvintof;
        private decimal _kelvintocelsius;
        
        private decimal _gallontopint;
        private decimal _litretogallon;
        private decimal _litretoPint;
        private decimal _gallontolitre;
        private decimal _pinttogallon;
        private decimal _pinttolitre;

        private decimal _lbtodollar;

        public decimal pinttolitre
        {
            get { return _pinttolitre * .4731m; }
            set { _pinttolitre = value; }
        }

        public decimal pinttogallon
        {
            get { return _pinttogallon * .125m; }
            set { _pinttogallon = value; }
        }

        public decimal gallontolitre
        {
            get { return _gallontolitre * 3.785m; }
            set { _gallontolitre = value; }
        }

        public decimal litretoPint
        {
            get { return _litretoPint * 2.113m; }
            set { _litretoPint = value; }
        }

        public decimal litretogallon
        {
            get { return _litretogallon * .2641m; }
            set { _litretogallon = value; }
        }

        public decimal kelvintocelsius
        {
            get { return _kelvintocelsius - 273.15m; }
            set { _kelvintocelsius = value; }
        }

        public decimal kelvintof
        {
            get { return _kelvintof * 9 / 5 - 459.67m; }
            set { _kelvintof = value; }
        }

        public decimal celsiustof
        {
            get { return _celsiustof * (9 / 5) + 32m; }
            set { _celsiustof = value; }
        }

        public decimal celsiustokelvin
        {
            get { return _celsiustokelvin + 273.15m; }
            set { _celsiustokelvin = value; }
        }

        public decimal ftokelvin
        {
            get { return (_ftokelvin + 459.67m) * (5 / 9); }
            set { _ftokelvin = value; }
        }

        public decimal ftocelsius
        {
            get { return (_ftocelsius - 32) * (5 / 9m); }
            set { _ftocelsius = value; }
        }

        public decimal gallontopint
        {
            get { return _gallontopint * 8; }
            set { _gallontopint = value; }
        }

        public decimal lbtodollar
        {
            get { return _lbtodollar * 1.53m; }
            set { _lbtodollar = value; }
        }
    }
}
