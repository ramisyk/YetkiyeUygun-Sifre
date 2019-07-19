using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetkiyeUygun.Methods
{
    class Ayir
    {
        public static string Parcala(string SifreliMetin, Program.Role role)
        {
            string Metin = Sifreleme.Decrypt(SifreliMetin, "sblw-3hn8-sqoy19");
            string YetkiDahilinde = string.Empty;
            foreach (var item in role.ranges)
            {
                int fark = item.end - item.start + 1;
                YetkiDahilinde += Metin.Substring(item.start, fark) + " ";
            }
            return YetkiDahilinde;
        }
    }
}
