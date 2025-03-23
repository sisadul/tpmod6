using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    Random rand = new Random();
    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh kosong");
        Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 karakter");

        this.title = title;
        this.id = rand.Next(10000, 99999);
        this.playCount = 0;
    }
    public void increasePlayCount(int views)
    {
        Debug.Assert(views <= 10000000, "Jumlah view harus antara 1 hingga 10.000.000");
        try
        {
            checked
            {
                this.playCount += views;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("melebihi batas");
            this.playCount = int.MaxValue;
        }
    }
    public int getPlayCount()
    {
        return this.playCount;
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
        try
        {
            SayaTubeVideo tube = new SayaTubeVideo("Tutorial Design By Contract - Abdul Aziz Saepurohmat");
            tube.printVideoDetail();
            Console.WriteLine();

            for (int i = 0; i < 1000; i++)
            {
                tube.increasePlayCount(10000000);
                tube.printVideoDetail();
                Console.WriteLine();

                if (tube.getPlayCount() == int.MaxValue)
                {
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error! " + e.Message);
        }
    }
}
