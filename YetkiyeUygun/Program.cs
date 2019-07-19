using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetkiyeUygun.Methods;

namespace YetkiyeUygun
{
    class Program
    {
        public class Range
        {
            public int start;
            public int end;
            public Range(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }
        public class Role
        {
            public int id;
            public List<Range> ranges;
        }
        public static string str = String.Empty;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Şifrelenecek metini giriniz (20 Karakter Boyutunda!): ");
                str = Console.ReadLine();
            }
            while (str.Length != 20); //20 karakter değilse yeni veri iste
            str = Sifreleme.Encrypt(str, "sblw-3hn8-sqoy19");
            Console.WriteLine("Şifreli metin: " + str);
            Console.WriteLine("değişmiş metin: " + str.Replace('O', '?').Replace('0', '&').Replace('I', '{').Replace('l', '}').Replace('1', '%'));

            //Rolleri örnekle
            Role role1 = new Role();
            Role role2 = new Role();
            Role role3 = new Role();
            Role role4 = new Role();
            Role role5 = new Role();

            //Özellikleri
            role1.id = 1;
            role2.id = 2;
            role3.id = 3;
            role4.id = 4;
            role5.id = 5;

            //Görülecek değerleri belirle
            Range R1range1 = new Range(0, 3);
            Range R2range1 = new Range(0, 5);
            Range R3range1 = new Range(5, 12);
            Range R4range1 = new Range(3, 10);
            Range R4range2 = new Range(15, 17);
            Range R5range1 = new Range(0, 19);

            //Değerler için liste oluştur
            role1.ranges = new List<Range>();
            role2.ranges = new List<Range>();
            role3.ranges = new List<Range>();
            role4.ranges = new List<Range>();
            role5.ranges = new List<Range>();

            //Değer aralıklarını listelere ekle
            role1.ranges.Add(R1range1);
            role2.ranges.Add(R2range1);
            role3.ranges.Add(R3range1);
            role4.ranges.Add(R4range1);
            role4.ranges.Add(R4range2);
            role5.ranges.Add(R5range1);

            //Ekran çıktıları 
            Console.WriteLine("\n####################################ROLE1#################################################");
            Console.WriteLine("role1: {0}, {1} aralığını görüntüleyebilir.\nGörüntülenecek metin: {2}", R1range1.start.ToString(), R1range1.end.ToString(), Ayir.Parcala(str.Replace('?', 'O').Replace('&', '0').Replace('{', 'I').Replace('}', 'l').Replace('%', '1'), role1).ToString());
            Console.WriteLine("\n####################################ROLE2#################################################");
            Console.WriteLine("role2: {0}, {1} aralığını görüntüleyebilir.\nGörüntülenecek metin: {2}", R2range1.start.ToString(), R2range1.end.ToString(), Ayir.Parcala(str.Replace('?', 'O').Replace('&', '0').Replace('{', 'I').Replace('}', 'l').Replace('%', '1'), role2).ToString());
            Console.WriteLine("\n####################################ROLE3#################################################");
            Console.WriteLine("role3: {0}, {1} aralığını görüntüleyebilir.\nGörüntülenecek metin: {2}", R3range1.start.ToString(), R3range1.end.ToString(), Ayir.Parcala(str.Replace('?', 'O').Replace('&', '0').Replace('{', 'I').Replace('}', 'l').Replace('%', '1'), role3).ToString());
            Console.WriteLine("\n####################################ROLE4#################################################");
            Console.WriteLine("role4: {0}, {1} aralığını ve {2}, {3} aralığını görüntüleyebilir.\nGörüntülenecek metin: {4}", R4range1.start.ToString(), R4range1.end.ToString(), R4range2.start.ToString(), R4range2.end.ToString(), Ayir.Parcala(str.Replace('?', 'O').Replace('&', '0').Replace('{', 'I').Replace('}', 'l').Replace('%', '1'), role4).ToString());
            Console.WriteLine("\n####################################ROLE5#################################################");
            Console.WriteLine("role5: {0}, {1} aralığını görüntüleyebilir.\nGörüntülenecek metin: {2}", R5range1.start.ToString(), R5range1.end.ToString(), Ayir.Parcala(str.Replace('?', 'O').Replace('&', '0').Replace('{', 'I').Replace('}', 'l').Replace('%', '1'), role5).ToString());
            Console.WriteLine("\n###########################################################################################");
                
            Console.ReadKey();

        }
    }
}
