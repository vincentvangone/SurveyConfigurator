using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryConfigurator.Objects
{
    public class quesStars : Question
    {
        //only additional variable is no of stars
        private int noOfStars;


        //constructor
        public quesStars(int noOfStars = 5) 
        {
            NoOfStars = noOfStars;
        }

        
        //setter and getter
        public int NoOfStars
        {
            get
            {
                return noOfStars;
            }
            set
            {
                //this value is set by default to 5 and the user can only choose one of the given values, no need for validation
                noOfStars = value;
            }
        }

        


    }
}
