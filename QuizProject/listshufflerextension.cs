using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizProject
{
    /// <summary>
    /// Class for shuffling lists
    /// </summary>
    /// <typeparam name="T">The type of list to shuffle</typeparam>
    public static class ListShufflerExtensionMethods
    {
        //for getting random values
        private static Random _rnd = new Random();

        /// <summary>
        /// Shuffles the contents of a list
        /// </summary>
        /// <typeparam name="T">The type of the list to sort</typeparam>
        /// <param name="listToShuffle">The list to shuffle</param>
        /// <param name="numberOfTimesToShuffle">How many times to shuffle the list, by default this is 5 times</param>
        public static void Shuffle<T>(this List<T> listToShuffle, int numberOfTimesToShuffle = 5)
        {
            //make a new list of the wanted type
            List<T> newList = new List<T>();

            //for each time we want to shuffle
            for (int i = 0; i < numberOfTimesToShuffle; i++)
            {
                //while there are still items in our list
                while (listToShuffle.Count > 0)
                {
                    //get a random number within the list
                    int index = _rnd.Next(listToShuffle.Count);

                    //add the item at that position to the new list
                    newList.Add(listToShuffle[index]);

                    //and remove it from the old list
                    listToShuffle.RemoveAt(index);
                }

                //then copy all the items back in the old list again
                listToShuffle.AddRange(newList);

                //and clear the new list
                //to make ready for next shuffling
                newList.Clear();
            }
        }
    }
}
