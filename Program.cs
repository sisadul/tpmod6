
class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    Random rand = new Random();

    public SayaTubeVideo(string title) {
        this.title = title;
        this.id = rand.Next(10000,99999);
        this.playCount = 0;
    }
    public void increasePlayCount(int views)
    {
        this.playCount += views;
    }
    public void printVideoDetail()
    {
        Console.WriteLine("ID video: " + this.id);
        Console.WriteLine("Judul Video: " + this.title);
        Console.WriteLine("Jumlah View: " + this.playCount);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo tube = new SayaTubeVideo("Tutorial Design By Contract - Abdul Aziz Saepurohmat");
        tube.increasePlayCount(50000);
        tube.printVideoDetail();
    }
}
