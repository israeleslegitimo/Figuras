using System.Text;
using System.Configuration;

namespace WindowsFormsApp1
{
    public class appConfig
    {
        public static void Establecervalor(string pLlave,string pValor)
        {
            //crar objeto configuracion
            Configuration config=ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //borrar la configuracion actual
            config.AppSettings.Settings.Remove(pLlave);
            //Guardar cambios
            config.Save(ConfigurationSaveMode.Modified);
            //forzar la recarga d ela seccion
            ConfigurationManager.RefreshSection("appsettings");
            //guardar la configuracion
            config.AppSettings.Settings.Add(pLlave, pValor);
            //Guardar cambios
            config.Save(ConfigurationSaveMode.Modified);
            //forzar la recarga d ela seccion
            ConfigurationManager.RefreshSection("appsettings");


        }
        public static string RecuperarValor(string pLlave,string pPredeterminado)
        {
            string retorno = ConfigurationManager.AppSettings[pLlave];
            if (retorno == null) { retorno = pPredeterminado; }
            return retorno;
        }
    }
}
