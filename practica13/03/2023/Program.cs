class Dominoes
{
        int x;
        int y;
    public Dominoes(int uno, int dos)
    {
        x = uno;
        y = dos;
    }


public static int operator + (Dominoes dom1, Dominoes dom2)
{
    return dom1.x + dom1.y + dom2.x + dom2.y;
}



}
internal class Program
{
    private static void Main(string[] args)
    {
        Dominoes domino1 = new Dominoes(1,3);
        Dominoes domino2 = new Dominoes(4,3);
        Dominoes.Equals(domino1, domino2);
        Console.WriteLine(domino1 + domino2);
    }
}