using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryConfigurator.Objects
{
    public class quesSmiley : Question
    {
        private int noOfSmileys;


        //public methods for noOfSmileys to be altered outside of the class
        public int NoOfSmileys
        {
            get
            {
                return noOfSmileys;
            }
            set
            {
                if (value > 5 || value <2)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(noOfSmileys)} must be between 2 and 5.");
                }
                noOfSmileys = value;
            }
        }


        //constructor
        //public quesSmiley(string quesText,string quesType, int noOfSmileys) :base(quesText, quesType)
        //{
        //    NoOfSmileys=noOfSmileys;
        //}
    }
}
