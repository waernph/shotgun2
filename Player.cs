class Player
{
    private string Name = "";
    private bool IsHuman = true;
    public string name
    {
        get { return name; }
        set { name = value; }
    }
    public bool isHuman
    {
        get { return isHuman; }
        set { isHuman = value; }
    }

    ShotsLeft shotsLeft = new ShotsLeft();
}
