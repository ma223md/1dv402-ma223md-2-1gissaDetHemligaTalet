using System;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
            public const int MaxNumberOfGuesses = 7;

            // _count räknar antalet gissningar som gjorts, om makeguess kallats 7ggr
            private int _count;

            // _number innehåller det hemliga talet
            private int _number;

            // konstruktor SecretNumber()
            public SecretNumber()
            {
                //åkalla initialize för att initiera fälten
                Initialize();
            }

            // Initialize = publik metod som initierar fältens värden
            public void Initialize()
            {
                _count = 0;
                Random myRandom = new Random();
                _number = myRandom.Next(1, 100);
            }

            public bool MakeGuess(int number)
            {
                // Meddelar om värdet är rätt, för högt eller för lågt
                if (number == _number)
                {
                    Console.WriteLine("Rätt gissat! Du klarade det på {0} försök", _count);
                }

                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", number, _count);
                }

                if (number > _number)
                {
                    Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", number, _count);
                }
                // Höjer _count tills max antal gissningar nåtts
                if (_count < MaxNumberOfGuesses)
                {
                    _count++;
                }

                // Meddelar det hemliga talet om användaren har slut på gissningar
                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Det hemliga talet är {0}", _number);
                }
                return true;
            }
    }
}
