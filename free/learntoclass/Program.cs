namespace learntoclass
{
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat()
        {
            Console.WriteLine("eat");
        }

        public void Sleep()
        {
            Console.WriteLine("sleep");
        }
    }


    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("bark");
        }

    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meow");
        }
    }

    class Program
    {
        static void 문제18()
        {
            Random random = new Random();
            List<int> number = new List<int>();
            List<int> lotto = new List<int>();
            int num = 0;

            for(int i = 1; i < 46; i++)
            {
                number.Add(i);
            }

            while(true)
            {
                num = number[random.Next(number.Count)];
                if(!lotto.Contains(num))
                {
                    lotto.Add(num);
                    if(lotto.Count == 6)
                    {
                        break;
                    }
                }
            }

            foreach(int item in lotto)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            문제18();

            Animal dog = new Dog();
            Animal cat = new Cat();

            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();

            foreach (var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat()
            };

            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if(item is Dog)
                {
                    ((Dog)item).Bark();
                }
                if(item is Cat)
                {
                    ((Cat)item).Meow();
                }

                if (item is Dog)
                {
                    (item as Dog).Bark();
                }
                if (item is Cat)
                {
                    (item as Cat).Meow();
                }
            }
        }
        
          
            
    }


}