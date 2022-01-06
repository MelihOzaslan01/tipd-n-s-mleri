using System;

namespace tipdönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion (Bilinçsiz dönüşüm)

            global::System.Console.WriteLine("***** İmplicit Conversion *****");

            byte a = 5; 
            sbyte b = 20;
            short c = 45;

            int d  = a+ b + c;
            global::System.Console.WriteLine("d: " + d);

            long h = d;
            global::System.Console.WriteLine("h: " + h) ;

            float f = d;
            global::System.Console.WriteLine("f: " + f);


            string e = "Melih ÖZASLAN";
            char s = 'a';
            object g = e+s+d;
            global::System.Console.WriteLine("g:" + g);

            // Explicit Conversion
            global::System.Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte z = (byte)x;
            global::System.Console.WriteLine("z: " + z);

            int i = 100;
            byte q= (byte)i;
            global::System.Console.WriteLine("q: " + q);

            float w = 10.2f;
            byte v= (byte)w;
            global::System.Console.WriteLine("v: " + v );


            // ToString Methodu 
            global::System.Console.WriteLine("***** To String Methodu *****");
            int uu = 6;
            string ii = uu.ToString();
            global::System.Console.WriteLine("ii: " + ii);


            string zz = 12.5f.ToString();
            global::System.Console.WriteLine("zz: " + zz);


            // System.Convert 
            global::System.Console.WriteLine("***** System.Convert *****");

            string s1 = "12", s2 = "30";
            int sayi1,sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            global::System.Console.WriteLine("Toplam: " + Toplam);



            // Parse Methodu 

            global::System.Console.WriteLine("***** Parse Methodu *****");

            ParseMethod();


            



        }

        public static void ParseMethod() 
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;


            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            global::System.Console.WriteLine("rakam1: " + rakam1);
            global::System.Console.WriteLine("double1: " + double1);
             



                    
        }

    }
}
