namespace D_0507
{
    enum ClassType
    {
        None = 0,
        knight = 1,
        Archer = 2,
        Magician = 3,
    }

    

    internal class main
    {
        
        static void Main(string[] args)
        {
            
            ChooseClass();

        }

        #region choose Char
        static ClassType ChooseClass()
        {
            
            Console.Write("직업선택 : ");
            string input = Console.ReadLine();
            ClassType playerClass = new ClassType();

            switch (input)
            {
                case "1":
                    playerClass = ClassType.knight;
                    Console.Write($"직업은 : {playerClass}");
                    break;
                case "2":
                    playerClass = ClassType.Archer;
                    Console.Write($"직업은 : {playerClass}");
                    break;
                case "3":
                    playerClass = ClassType.Magician;
                    Console.Write($"직업은 : {playerClass}");
                    break;
                default:
                    playerClass = ClassType.None;
                    Console.WriteLine("지정되지 않은 값");
                    break;
            }
            return playerClass;
        }
        #endregion
    }

}