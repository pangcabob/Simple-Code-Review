using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    public class Salutation

    {
        /// <summary>
        /// The Salutation class represents something that can say hello or goodbye
        /// </summary>
        #region Properties and Fields -What the Salutation objects will "Look like"
        //Fields
        private string _Greeting;
        private string _Farewell;
        #endregion

        #region Constructor and Methods- How the Salutation objects will "believe"
        /// <summary>
        /// Instantiates a Salutation object with appropriate messages
        /// </summary>
        /// <param name="greetingMessage">The message to use when greeting</param>
        /// <param name="farewellMessage">The message to use to say goodbye</param>
        public Salutation(string greetingMessage, string farewellMessage)
        {
            _Greeting = greetingMessage;
            _Farewell = farewellMessage;
        }
       

        public string Greet()
        {
            return _Greeting;
        }

        public string SayFarewell()
        {
            return _Farewell;
        }
        #endregion
    }
}
