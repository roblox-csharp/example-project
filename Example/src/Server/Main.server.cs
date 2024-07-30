using Roblox;

namespace Server
{
    public static class Game
    {
        public static void Main()
        {
            foreach (Player player in Services.Players.GetPlayers())
            {
                player.CharacterAdded.Connect(c => {
                    var t = true;
                    t = c is Model abc;
                    if (t)
                    { // THIS IS THE BAD LINE
                        Console.WriteLine("Player Character found!");
                    }
                    else
                    {
                        Console.WriteLine("Player is not a character!");
                    }
                });
            };
        }
    }
}