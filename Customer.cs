using System;

namespace CustomerInformation
{
    public class Customer 
    {
 
        #region private methods
        /// <summary>
        /// Method to generate a new customer number using epoch time
        /// </summary>
        /// <returns>int customer number</returns>
        private int generateCustomerNumber()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int id = (int)t.TotalSeconds;
            return id;
        }
        #endregion

        
    }
}
