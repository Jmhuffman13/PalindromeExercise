using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
      
        public bool IsAPalindrome(string word)
        {
            // using a for loop to solve
            var reversed = "";

            for (int i = word.Length -1 ; i >= 0; i--)
            {
                reversed += word[i]; // reversed = reversed + word
            };

            if (reversed == word)
                return true;
            else
                return false;


        }
    }
}
