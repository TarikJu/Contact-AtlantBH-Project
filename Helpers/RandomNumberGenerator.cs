using System;


namespace Contacts.Helpers
{
    internal class RandomNumberGenerator
    {

        private static readonly Random rand = new Random();

        private static int GenerateRandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static string GenerateRandomNumericalString()
        {
            int randInt = GenerateRandomNumber(100000000, 999999999);
            long randInt100 = GenerateRandomNumber(1, 99);
            long randLong = (long)randInt * 100;
            randLong += randInt100;
            return randLong.ToString();
        }
    }
}
