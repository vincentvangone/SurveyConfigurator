using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryConfigurator.Objects
{
    public class quesStars : Question
    {
        private int noOfStars;

        public int NoOfStars
        {
            get
            {
                return noOfStars;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(noOfStars)} must be selected.");
                }
                noOfStars = value;
            }
        }

        //constructor
        //public quesStars(string quesText, string quesType, int noOfStars) : base(quesText, quesType)
        //{
        //    NoOfStars = noOfStars;
        //}


    }
}
