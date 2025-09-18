
class Random
{
    private char RandomChoice;
    public char randomChoice
    {
        get { return RandomChoice; }
        set { RandomChoice = value; }
    }

    private static char ComputerChoice()
    {
        Random rnd = new Random();
        ShotsLeft shotsLeft = new ShotsLeft();

        string choices = "ssllbbhhhh";

        if (shotsLeft.Shots == 0)
        {
            int index = rnd.Next(2, 4);
            return choices[index];
        }
        else if (shotsLeft.Shots > 0 && shotsLeft.Shots < 3)
        {
            int index = rnd.Next(0, 5);
            return choices[index];
        }
        else
        {
            int index = rnd.Next(5, 9);
            return choices[index];
        }
    }
}
