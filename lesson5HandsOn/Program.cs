using System;

namespace lesson5HandsOn
{

    public class Person {
        string firstName;
        string lastName;
        int age;


        public string FirstName{
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }

        public string LastName{
            get {
                return lastName;
            }
            set {
                lastName = value;
            }
        }

        public int Age{
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        public Person() {
            firstName = "";
            lastName = "";
            age = 0;
        }

        public Person(string first, string last, int age) {
            if(age < 0) {
                Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                age = 0;
            }
            else {
                age = age;
            }
            firstName = first;
            lastName = last;
        }

        public void Introduce() {
            string sentence = FirstName + " " + LastName + " is " + Age + " years old.";

            Console.WriteLine(sentence);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person sally = new Person();
            sally.FirstName = "Sally";
            sally.LastName = "Suzane";
            sally.Age = 21;
            sally.Introduce();

            Person bob = new Person();
            bob.FirstName = "Bob";
            bob.LastName = "Ben";
            bob.Age = 23;
            bob.Introduce();
            
            Person emilia = new Person("Emilia", "Hill", 42);
            Person lucius = new Person("Lucius", "Hill", 45);

            emilia.Introduce();
            lucius.Introduce();

        }
    }
}
