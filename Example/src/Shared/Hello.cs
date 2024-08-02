namespace Shared
{
    public static class Hello
    {
        [Native]
        public static void SayHello()
        {
            print("Hello C#!");
        }
    }
}