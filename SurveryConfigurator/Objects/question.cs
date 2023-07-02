using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryConfigurator.Objects
{
    public class Question
    {

        //private variable for code security
        
        private string quesText;
        private string quesType;


        //constructor initializes to invalid values to make sure theyre switched
        public Question(string quesTextt="", string quesTypee="")
        {
           quesType= quesTypee;
           quesText= quesTextt;


        }


        //public setter and getter for variables to be altered/retrieved out of class
        public string QuesText
        {
            get
            {
                return quesText;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentNullException("Question text, must be a valid string.");
                }
                quesText = value;
            }
        }


        //this shouldnt be validated because its set from the program - not user input
        public string QuesType
        {
            get
            {
                return quesType;
            }
            set
            {
                quesType = value;
            }
        }


    }
}
