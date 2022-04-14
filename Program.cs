using System;
class Marksheet
{
    public string Name { get; set; }
    public int Rollno { get; set; }

    public int TotalMark { get; set; }
    public int ObtainedMark { get; set; }
    public float Percentage { get; set; }

}

class Program
{
    static void Main(string[] args)
    {

        Marksheet[] arr = new Marksheet[5];
        arr[0] = new Marksheet() { Name = "Ram", Rollno = 110, TotalMark = 600, ObtainedMark = 490, Percentage = (arr[0].ObtainedMark / (float)arr[0].TotalMark) * 100 };

   

        arr[1] = new Marksheet();
        arr[1].Name = "Krishn";
        arr[1].Rollno = 10;
        arr[1].TotalMark = 500;
        arr[1].ObtainedMark = 345;
        arr[1].Percentage = (arr[1].ObtainedMark / (float)arr[1].TotalMark) * 100;

        Marksheet ob = new Marksheet();
        ob.Name = "john";
        ob.Rollno = 20;
        ob.TotalMark = 800;
        ob.ObtainedMark = 600;
        ob.Percentage = (arr[2].ObtainedMark / (float)arr[2].TotalMark) * 100;
        arr[2] = new Marksheet();
        arr[2] = ob;

        foreach (Marksheet item in arr)
        {

            Console.WriteLine("Students Data {0} {1} {2} {3} {4} ", item.Name, item.Rollno, item.TotalMark, item.ObtainedMark, item.Percentage);
        }
        Console.ReadKey();
    

    }
}