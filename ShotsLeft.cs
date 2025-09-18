class ShotsLeft
{
    private int shots;
    public int Shots
    {
        get { return shots; }
        set { shots = value; }
    }

    private void shotFired()
    {
        Shots -= shots;
    }
    private void loadedShot()
    {
        Shots += shots;
    }
}
