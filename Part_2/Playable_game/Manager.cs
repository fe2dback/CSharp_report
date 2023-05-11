namespace Playable_game
{
    class Manager
    {
        static void Main(string[] args)
        {
            onGame play = new onGame();
            while (true)
            {
                play.start();
            }
            /*
            Car car = new Car("14하5099");
            car.SetInTime();
            car.Park();
            car.SetOutTime();
            car.FeeSettle();
            */
        }
    }
}