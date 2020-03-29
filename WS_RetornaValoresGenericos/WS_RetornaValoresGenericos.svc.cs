using System;
using System.Collections.Generic;
using System.Globalization;
using WS_RetornaValoresGenericos.Class;

namespace WS_RetornaValoresGenericos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : WS_RetornaValoresGenericosSample
    {
        public List<ObjetoGenerico> obtieneListaObjeto()
        {
            try
            {

                List<ObjetoGenerico> listaObjetoGenerico = new List<ObjetoGenerico>();
                ObjetoGenerico objecto = new ObjetoGenerico();
                int recorre = 50;
                for (int i = 0; i < recorre; i++)
                {
                    objecto.id = i;
                    objecto.postId = i + 1000;
                    objecto.name = String.Format("nombre generico {0}", i);
                    objecto.email = String.Format("correogenerico{0}@webservices.cl", i);
                    objecto.body = @"est natus enim nihil est dolore omnis voluptatem numquam\net omnis " +
                                    "occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum " +
                                    "voluptatem reiciendis et";
                    listaObjetoGenerico.Add(objecto);
                }
                return listaObjetoGenerico;

            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return null;
            }
        }

        public string obtieneDiaActual()
        {
            try
            {
                CultureInfo ci = new CultureInfo("Es-Es");

                string diaActual = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();

                return diaActual;
            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return null;
            }

        }
    }
}
