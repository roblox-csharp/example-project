namespace Client
{
    public static class Game
    {
        [Native]
        public static void Main()
        {
            Instance[] instances = [Services.Workspace];
            instances[0].Clone();
        }
    }
}
   