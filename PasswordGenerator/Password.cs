using System;

namespace PasswordGenerator
{
    class Password
    {
        Random thisRandom = new Random();

        public string getPassword()
        {
            string result = "";

            result += getDigit();
            result += getUpperCase();
            for (int x = 0; x < 12; x++)
            {
                result += getLowerCase();
            }
            result += getSpecial();

            return result;
        }

        string getUpperCase()
        {
            string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            return chooser(upper);
        }

        string getLowerCase()
        {
            string lower = "abcdefghjknmpqrstuvwxyz";
            return chooser(lower);
        }

        string getDigit()
        {
            string digits = "23456789";
            return chooser(digits);
        }

        string getSpecial()
        {
            string special = "!@#$%^&*()";
            return chooser(special);
        }

        string chooser(string input)
        {
            int length = input.Length;
            int choice = thisRandom.Next(0, length);
            return input.Substring(choice, 1);
        }

    }
}

