internal class program
{
    public enum buah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung
    }
    public class kodebuah
    {
        
        public static string kode(buah buahh)
        {
            string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", };
            return kodebuah[(int)buahh];
        }
    }

    public static void Main(string[] args)
    {
        buah buahnya = buah.Apel;
        string kodee = kodebuah.kode(buahnya);
        System.Console.WriteLine("Buah: " + buahnya + "\nKode Buah: " + kodee);
    }
}

