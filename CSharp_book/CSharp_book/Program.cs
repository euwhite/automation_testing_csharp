using System;
using System.Linq;

namespace CSharp_book
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("\nPlease enter age:");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter the count of teeth:");
            var numberOfTeeth = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many children?");
            var childrenCount = int.Parse(Console.ReadLine()); // как защититься от стриги или нуля?

            // New Person
            Person p = new Person("Vasil",12);

            int num = p.LuckyNumber(numberOfTeeth, age, childrenCount);


            Console.WriteLine("The Lucky Number of {0} is {1}", name, num);
        }
    }

    class Person
    {   
        // Fields
        private string name;
        int numberOfTeeth;
        int age;
        int childrenCount;

        public Person(string name, int age){
            this.age = age;
            this.name = name;
            
        }

        // If only numberOfTeeth and age has beed entered
        public int LuckyNumber(int numberOfTeeth, int age)
        {
            return (numberOfTeeth * age);
        }

        // If User enter childrenCount
        public int LuckyNumber(int numberOfTeeth, int age, int childrenCount)
        {
            if (childrenCount <= 0)
            {
                return (numberOfTeeth * age);
            }
            //else if (childrenCount == null)
            //{
            //    return (numberOfTeeth * age);
            //}
            else
            {
                return (numberOfTeeth * age / childrenCount);
            }
        }
    }
}


// как задать "he" или "she" в зависимости от того, ввели "men" или "woman". Нужны две зависимые переменные?
// почему отображаются желтые подсказки выше?














    //class Animal
    //{
    //    //Поля
    //    public string kindOfAnimal; public string name;
    //    public int numberOfLegs; public int height;
    //    public int length;
    //    public string color;
    //    bool hasTail;
    //    protected bool isMammal; private bool spellingCorrect; //Методы

    //    // Открытый метод, получающий информацию о том, чем питается животное 
    //    public string GetFoodInfo()
    //    {
    //        // Представим, что здесь расположен код, выполняющий поиск по базе данных ...
    //    }

    //    // Закрытый метод для проверки правильности написания вида животного 
    //    private void SpellingCorrect()
    //    {
    //        // Представим, что здесь расположен код для проверки правописания ...
    //    }

    //    // Защищенный метод, определяет существование данного вида животного
    //    protected bool IsValidAnimalType()
    //    {
    //        //код для проверки существующих видов животных ...
    //    }
    //}

    //class Zoo
    //{
    //    Animal a = new Animal();
    //    a.name = “Kangaroo”; 
    //    string food;
    //    bool animalExists;

    //    // Следующий код будет выполнен успешно, поскольку классу “Zoo” разрешено 
    //    // обращаться к открытым методам в классе “Animal”

    //    food = a.GetFoodInfo(); // Вызов открытого метода
    //    // Обе следующие строки НЕ будут выполнены, поскольку классу “Zoo”
    //}