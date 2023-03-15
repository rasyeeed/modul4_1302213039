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

    public enum status
    {
        Jongkok,
        Berdiri,
        Tengkurap,
        Terbang
    }

    public enum action
    {
        TombolW,
        TombolX,
        TombolS
    }

    public class Posisikaraktergame
    {
        public status current = status.Berdiri;
        public class Transisi
        {
            public status stateawal;
            public status stateakhir;
            public action trigger;
            public Transisi(status stateawal, status stateakhir, action trigger)
            {
                this.stateawal = stateawal;
                this.trigger = trigger;
                this.stateakhir = stateakhir;
            }
        }
        Transisi[] transi =
        {
            new Transisi(status.Jongkok,status.Berdiri,action.TombolW),
            new Transisi(status.Jongkok,status.Tengkurap,action.TombolS),
            new Transisi(status.Berdiri,status.Terbang,action.TombolW),
            new Transisi(status.Berdiri,status.Jongkok,action.TombolS),
            new Transisi(status.Terbang,status.Jongkok,action.TombolX),
            new Transisi(status.Terbang,status.Berdiri,action.TombolS),
            new Transisi(status.Tengkurap,status.Jongkok,action.TombolW),
        };
        private status getstateberikut(status stateawal, action trigger)
        {
            status stateakhir = stateawal;
            for(int i = 0; i < transi.Length; i++)
            {
                Transisi ubah = transi[i];
                if (stateawal == ubah.stateawal && trigger == ubah.trigger) 
                {
                    stateakhir = ubah.stateakhir;
                }
            }
            return stateakhir;
        }

        public void triggeraktif(action trigger)
        {
            current = getstateberikut(current, trigger);
            if (trigger == action.TombolS)
            {
                Console.WriteLine("--tombol arah bawah ditekan--");
            } else if (trigger == action.TombolW)
            {
                Console.WriteLine("--tombol arah atas ditekan--");
            }
            else
            {
                Console.Write("");
            }
            Console.WriteLine("Posisi sekarang: " + current + "\n");
        }
    }

    public static void Main(string[] args)
    {
        buah buahnya = buah.Apel;
        string kodee = kodebuah.kode(buahnya);
        System.Console.WriteLine("Buah: " + buahnya + "\nKode Buah: " + kodee);

        Posisikaraktergame chara = new Posisikaraktergame();
        chara.triggeraktif(action.TombolW);
        chara.triggeraktif(action.TombolX);
        chara.triggeraktif(action.TombolW);
        chara.triggeraktif(action.TombolW);
        chara.triggeraktif(action.TombolS);
    }
}

