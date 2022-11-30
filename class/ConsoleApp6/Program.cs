class Program
{
    static void Main(string[] args)
    {
        ExcelentPupil a = new ExcelentPupil();
        GoodPupil b = new GoodPupil();
        BadPupil c = new BadPupil();

        ClassRoom class1 = new ClassRoom(a, b, c, c);
        ClassRoom class2 = new ClassRoom(a, b);
        Console.Read();
    }
}

abstract class Pupil
{
    public abstract string Study();
    public abstract string Read();
    public abstract string Write();
    public abstract string Relax();
}

class ExcelentPupil : Pupil
{
    public override string Read()
    {
        return "читає чудово";
    }
    public override string Study()
    {
        return "вчится чудово";
    }
    public override string Write()
    {
        return "пише чудово";
    }
    public override string Relax()
    {
        return "відпочиває чудово";
    }
}
class GoodPupil : Pupil
{
    public override string Read()
    {
        return "читає добре";
    }
    public override string Study()
    {
        return "вчится добре";
    }
    public override string Write()
    {
        return "пише добре";
    }
    public override string Relax()
    {
        return "відпочиває добре";
    }
}
class BadPupil : Pupil
{
    public override string Read()
    {
        return "читає погано";
    }
    public override string Study()
    {
        return "вчится погано";
    }
    public override string Write()
    {
        return "пише погано";
    }
    public override string Relax()
    {
        return "відпочіває погано";
    }
}

class ClassRoom
{
    Pupil pupil_1;
    Pupil pupil_2;
    Pupil pupil_3;
    Pupil pupil_4;
    Pupil[] pupils = new Pupil[4];

    public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
    {
        this.pupil_1 = pupil_1;
        this.pupil_2 = pupil_2;
        this.pupil_3 = pupil_3;
        this.pupil_4 = pupil_4;


        Console.WriteLine($"1 учень {pupil_1.Read()}, {pupil_1.Study()}, {pupil_1.Write()}, {pupil_1.Relax()}");
        Console.WriteLine($"2 учень {pupil_2.Read()}, {pupil_2.Study()}, {pupil_2.Write()}, {pupil_2.Relax()}");
        Console.WriteLine($"3 учень {pupil_3.Read()}, {pupil_3.Study()}, {pupil_3.Write()}, {pupil_3.Relax()}");
        Console.WriteLine($"4 учень {pupil_4.Read()}, {pupil_4.Study()}, {pupil_4.Write()}, {pupil_4.Relax()}");

        pupils[0] = this.pupil_1;
        pupils[1] = this.pupil_2;
        pupils[2] = this.pupil_3;
        pupils[3] = this.pupil_4;

        GetInfo();

    }
    public ClassRoom(Pupil pupil_1, Pupil pupil_2)
    {
        this.pupil_1 = pupil_1;
        this.pupil_2 = pupil_2;

        Console.WriteLine($"1 учень {pupil_1.Read()}, {pupil_1.Study()}, {pupil_1.Write()}, {pupil_1.Relax()}");
        Console.WriteLine($"2 учень {pupil_2.Read()}, {pupil_2.Study()}, {pupil_2.Write()}, {pupil_2.Relax()}");
        Console.WriteLine($"Про 3 и 4 ученів нічого невідомо");

        pupils[0] = pupil_1;
        pupils[1] = pupil_2;

        GetInfo();

    }
    public void GetInfo()
    {
        byte numOfExlecent = 0, numOfGood = 0, numOfBad = 0;
    }
}
