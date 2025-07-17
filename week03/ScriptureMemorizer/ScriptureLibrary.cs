class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _rand;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _rand = new Random();

        // Add your scriptures here
        AddScripture(new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        AddScripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        AddScripture(new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy.");
        AddScripture(new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God.");
    }

    private void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        int index = _rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
}