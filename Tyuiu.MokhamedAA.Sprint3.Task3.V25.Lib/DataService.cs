using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MokhamedAA.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            bool previousLetter = false;
            foreach (char c in value)
            {
                if (c == item)
                {
                    if (previousLetter)
                    {
                        count++;
                        previousLetter = false;
                    }
                    else
                    {
                        previousLetter = true;
                    }
                }
                else
                {
                    previousLetter = false;
                }
            }
            return count;
        }
    }
}
