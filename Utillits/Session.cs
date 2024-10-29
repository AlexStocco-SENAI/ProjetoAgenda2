using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Utillits
{
    static class Session
    {
        public static bool EstaLogado {  get; set; }
        public static string Nome { get; set; }
        public static string Login { get; set; }
    }
}
