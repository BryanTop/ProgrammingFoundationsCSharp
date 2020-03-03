using System;

namespace lesson8HandsOn
{
    interface Animal
    {
        void eat(string food);
    }
    interface Mammal: Animal
    {
        void speak(string sound);
        void run(int speed);
    }

    public class Cat: Mammal {

        public Cat () {

        }

        public void speak(string sound) {
            Console.WriteLine(sound);
        }

        public void run(int speed) {
            Console.WriteLine("Cats can run at a top speed of " + speed + " mph!");
        }

        public void eat(string food) {
            Console.WriteLine("Cats eat " + food);
        }
    }

    public class Dog: Mammal
    {
        public Dog () {

        }

        public void speak(string sound) {
            Console.WriteLine(sound);
        }

        public void run(int speed) {
            Console.WriteLine("Dogs can run at a top speed of " + speed + " mph!");
        }

        public void eat(string food) {
            Console.WriteLine("Dogs eat " + food);
        }
    }

    public class Cow: Mammal
    {
        public Cow() {

        }

        public void speak(string sound) {
            Console.WriteLine(sound);
        }

        public void run(int speed) {
            Console.WriteLine("Cows can run at a top speed of " + speed + " mph!");
        }

        public void eat(string food) {
            Console.WriteLine("Cows eat " + food);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat();
            Dog bear = new Dog();
            Cow momo = new Cow();

            tom.run(15);
            tom.speak("meow");
            tom.eat("mice");

            bear.run(5);
            bear.speak("bark");
            bear.eat("Bones");

            momo.run(12);
            momo.speak("moo");
            momo.eat("Grass");
        }
    }
}
