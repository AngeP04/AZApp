public class WishList
{
    public List<string> TopPriority = new List<string>();
    public List<string> Want = new List<string>();
    public List<string> Have = new List<string>();

    public WishList()
    {

    }

    public void TPAddPC(string PC)
    {
        TopPriority.Add(PC);
    }

    public void WAddPC(string PC)
    {
        Want.Add(PC);
    }

    public void HAddPC(string PC)
    {
        Have.Add(PC);
    }

    public WishList PathLists()
    {
        var basePath = "wwwroot/ImagesATEEZ/";
        WishList paths = new WishList();
        paths.TopPriority = TopPriority.Select(name => Path.Combine(basePath, name.Substring(name.Count() - 3, 3), name.Substring(0, name.Count() - 3) + ".png")).ToList();
        paths.Want = Want.Select(name => Path.Combine(basePath, name.Substring(name.Count() - 3, 3), name.Substring(0, name.Count() - 3) + ".png")).ToList();
        paths.Have = Have.Select(name => Path.Combine(basePath, name.Substring(name.Count() - 3, 3), name.Substring(0, name.Count() - 3) + ".png")).ToList();
        return paths;
    }
}