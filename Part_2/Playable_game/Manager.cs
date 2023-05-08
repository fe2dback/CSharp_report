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
            
        }
    }
}