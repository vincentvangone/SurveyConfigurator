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


        //constructor calls setters
        //public Question(string quesText, string quesType)
        //{
        //   QuesText = quesText;
        //    QuesType = quesType;
    
        //}


        //public setter and getter for variables to be treated like public
        public string QuesText
        {
            get
            {
                return quesText;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(quesText)} must be a valid string.");
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
