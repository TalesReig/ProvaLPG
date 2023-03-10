using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace TesteTraducao
{
    public class Idiomas
    {
        private readonly ResourceManager rm;
        private readonly CultureInfo ci;

        public Idiomas(string idioma)
        {
            rm = new ResourceManager("TesteTraducao.Resources.Strings", Assembly.GetExecutingAssembly());
            ci = CultureInfo.CreateSpecificCulture(idioma);
        }

        public string GetMensagem(string chave)
        {
            return rm.GetString(chave, ci);
        }
    }
}

