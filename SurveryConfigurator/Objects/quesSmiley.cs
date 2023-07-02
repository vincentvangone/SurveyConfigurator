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


        public quesSmiley(int noOfSmileysPara = 5)
        {
            noOfSmileys = noOfSmileysPara;
        }

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
                    throw new ArgumentOutOfRangeException("Please select number of smileys");
                }
                noOfSmileys = value;
            }
        }


        
    }
}
