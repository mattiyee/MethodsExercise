using System;

namespace MethodsExercise
{
    class Program
    {
        public static void IntroductionFeeling()
        {
            string characterFeeling;
            characterFeeling = "Yes";
            if (characterFeeling == "Yes")
            {
                Console.WriteLine($"Come quickly then, let me help you inside.");
            }
            else
            {
                Console.WriteLine($"Ah, very well then. Well, let me show you inside at least, I'll give you some food.");
            }

            Console.WriteLine($"Anyways, how old are you?");
        }

        public static void FamilyAnswer()
        {
            string familyAnswer;
            familyAnswer = "Yes";
            if (familyAnswer == "Yes")
            {
                Console.WriteLine($"Good to hear! How many family members do you have?");

                int memberAnswer = int.Parse(Console.ReadLine());

                Console.WriteLine($"You have {memberAnswer} family members? I have 3, my wife, my daughter, and my granddaughter.");
            }
            else
            {
                Console.WriteLine($"I see. I have a family though, my wife, my daughter, and my granddaughter.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello traveler! What is your name?");

            string characterName;
            characterName = Console.ReadLine();

            Console.WriteLine($"Hello {characterName}, where are you from?");

            string characterLocation;
            characterLocation = Console.ReadLine();

            Console.WriteLine($"I see you are from {characterLocation}, you must have come a long way eh? Are you tired?");

            IntroductionFeeling();

            int characterAge;
            characterAge = int.Parse(Console.ReadLine());

            if (characterAge < 19)
            {
                Console.WriteLine($"You are young for a traveler. What are you doing out there?");

                string responseOneV1 = Console.ReadLine();

                Console.WriteLine("Ah, I see, very interesting.");
            }
            else
            {
                Console.WriteLine("As I expected for a traveler. You seem strong. What are your goals?");

                string responseOneV2 = Console.ReadLine();

                Console.WriteLine("Ah, fine goals you have.");
            }

            int birthYear = BirthYear(characterAge, 2021);

            Console.WriteLine($"You say that you are {characterAge} years old. So, you were born in {birthYear}, correct?");

            string answerOne;
            answerOne = Console.ReadLine();

            int guideAge = GuideAge(characterAge, 2);

            Console.WriteLine($"Man, you are much younger than me. I am twice your age! I am {guideAge} years old.");
            Console.WriteLine($"Do you have family?");

            FamilyAnswer();

            int daughterAge = DaughterAge(characterAge, 3);
            int granddaughterAge = GrandaughterAge(characterAge, 2, 2);

            Console.WriteLine($"My daughter is about your age. She is {daughterAge} years old. My granddaughter on the other hand, is much younger. She is {granddaughterAge} years old.");
            Console.WriteLine("Maybe I will introduce you to them one time.");
        }
        public static int BirthYear(int num1, int num2)
        {
            return num2 - num1;
        }

        public static int GuideAge(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int DaughterAge(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int GrandaughterAge(int num1, int num2, int num3)
        {
            return num1 / num2 + num3;
        }
    }   
}
