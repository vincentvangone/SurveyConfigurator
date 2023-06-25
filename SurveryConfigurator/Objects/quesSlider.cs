using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SurveryConfigurator.Objects
{
    public class quesSlider : Question
    {
        private int startValue;
        private int endValue;
        private string startCaption;
        private string endCaption;


        //public setters and getters
        public int StartValue{

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(startValue)} must be a positive integer.");
                }
                startValue = value;
                    
              }
            get {
                return startValue;
            }
        }

        public int EndValue
        {

            set
            {
                if (value < startValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(endValue)} must be higher than the start value.");
                }
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(endValue)} must be less than 100.");
                }
                endValue = value;

            }
            get
            {
                return endValue;
            }
        }



        public string StartCaption
        {

            set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(startCaption)} must be a valid string.");
                }
                if (value.Length>50)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(startCaption)} is too long.");
                }
                startCaption = value;

            }
            get
            {
                return startCaption;
            }
        }
        public string EndCaption
        {

            set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(endCaption)} must be a valid string.");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(endCaption)} is too long.");
                }
                endCaption = value;

            }
            get
            {
                return endCaption;
            }
        }

       // public quesSlider(string quesText, string quesType, int startValue=0,int endValue=100, string startCaption="min", string endCaption="max") : base(quesText, quesType)
       // {
       //     StartValue = startValue;
       //
       // }

    }
}
