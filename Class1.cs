namespace WordLib
{
    public class Class1
    {

    }

    public class Worder
    {
        public int CountLetters(string word)
        {
            // Initialize a counter for letters
            int letterCount = 0;

            // Loop through each character in the word
            foreach (char c in word)
            {
                // Check if the character is a letter (assuming only ASCII letters)
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    // Increment the counter for each letter found
                    letterCount++;
                }
            }

            // Return the count of letters in the word
            return letterCount;
        }

        public bool IsPalindrome(string input)
        {
            // Remove spaces and convert to lowercase for a case-insensitive comparison
            string cleanedInput = input.Replace(" ", "").ToLower();

            // Initialize pointers for comparing characters from both ends of the string
            int left = 0;
            int right = cleanedInput.Length - 1;

            // Compare characters moving inwards from both ends
            while (left < right)
            {
                if (cleanedInput[left] != cleanedInput[right])
                {
                    return false; // If characters don't match, it's not a palindrome
                }
                // Move the pointers towards the middle
                left++;
                right--;
            }
            return true; // If the loop completes, it's a palindrome
        }
    }
}