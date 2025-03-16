using System.Diagnostics.CodeAnalysis;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo User " + user);
    }
}

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
public class Program
{
    public static void Main()
    {
        {
            HaloGeneric sapa = new HaloGeneric();
            sapa.SapaUser("Pieter");
        }
        DataGeneric<String> dataNIM = new DataGeneric<string>("103022330111");
        dataNIM.PrintData();
    }

}