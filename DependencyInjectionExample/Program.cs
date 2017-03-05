using System;
using Shared;
using System.Speech.Synthesis;

namespace DependencyInjectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            // Doesn't work - most probably not downloaded
            // synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);

            Student student; 
            var configAge = new Config();
            var ageLimit = int.Parse(configAge.AgeLimit);
            var sentinel = "y";
            int age;

            Console.WriteLine("\n***************\nStudent Creator\n***************");
            synth.Speak("Student Creator, Using Logger one");
            Console.WriteLine("\nAge Limit is: {0}\n", ageLimit);
            synth.Speak("Age Limit is" + ageLimit);

            while (sentinel.Equals("y"))
            {
                student = new Student(new LoggerOne(), configAge);

                Console.Write("Enter Students Name: ");
                synth.Speak("Enter Students Name: ");
                student.Name = Console.ReadLine();
                synth.Speak("You entered " + student.Name);

                Console.Write("Enter Students Age: ");
                synth.Speak("Enter Students Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                synth.Speak("You entered " + age);

                while (age < ageLimit)
                {
                    Console.Write("\nSorry too young! Enter Students Age: ");
                    synth.Speak("Sorry too young! Enter Students Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    synth.Speak("You entered " + age);
                }

                Console.WriteLine("\nNew Student Created\nName: {0} \nAge: {1}", student.Name, age);
                Console.Write("\nWould you like to add a student? y/n: ");
                synth.Speak("Would you like to add a student? enter y or n");
                sentinel = Console.ReadLine();
            }

            synth.Speak("Using Logger two");
            student = new Student(new LoggerTwo(), configAge);

            Console.Write("\nEnter Students Name: ");
            synth.Speak("Enter Students Name");
            student.Name = Console.ReadLine();
            synth.Speak("You entered " + student.Name);

            Console.Write("Enter Students Age: ");
            synth.Speak("Enter Students Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            synth.Speak("You entered " + age);

            Console.WriteLine("\nNew Student Created\nName: {0} \nAge: {1}", student.Name, age);
            synth.Speak("New Student Created, the name is " + student.Name + ", the age is " + age);

            synth.Speak("OK we've finished, Thank you");
            Console.ReadLine();
        }
    }
}
