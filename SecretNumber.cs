using System;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
            public const int MaxNumberOfGuesses = 7;

            private int _count;
            private int _number;

            public SecretNumber()
            {
                //åkalla initialize för att initiera fälten
                Initialize();
            }

            // Metod som initierar fältens värden
            public void Initialize()
            {
                _count = 0;
                Random myRandom = new Random();
                _number = myRandom.Next(1, 100);
            }

            public bool MakeGuess(int number)
            {
                bool guess = false;

                // Om gissningen inte är i intervallet 1-100 kastas undantag
                if (number > 100 || number < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Höjer _count tills max antal gissningar nåtts
                if (_count < MaxNumberOfGuesses)
                {
                    _count++;                    
                } 
                else
                {
                    throw new ApplicationException();
                }

                // Meddelar om värdet är för högt eller för lågt
                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                }
                else if (number > _number)
                {
                    Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                }
                //Meddelar om värder är rätt
                else
                {
                    Console.WriteLine("Rätt gissat! Du klarade det på {0} försök", _count);
                    guess = true;
                }

                // Meddelar det hemliga talet om användaren har slut på gissningar  
                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Det hemliga talet är {0}", _number);
                }              
                return guess;
            }
    }
}
