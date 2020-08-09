using System;

namespace SuperTimeSheet.Classes
{
    public class NumberUtilities
    {
        /// <summary>
        /// Checks if string is a valid double value
        /// </summary>
        /// <param name="valueToCheck">input string to check & validate for double value</param>
        /// <returns>true if string contains valid double value</returns>
        public static bool IsValidDouble(string valueToCheck)
        {
            try
            {
                double doubleValue = Convert.ToDouble(valueToCheck);
                return true;
            }
            catch (FormatException fmtEx)
            {
                return false;
            }
        }
    }
}
