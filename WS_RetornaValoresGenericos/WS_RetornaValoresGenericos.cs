using System.Collections.Generic;
using System.ServiceModel;
using WS_RetornaValoresGenericos.Class;

namespace WS_RetornaValoresGenericos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface WS_RetornaValoresGenericosSample
    {

        [OperationContract]
        List<ObjetoGenerico> obtieneListaObjeto();

        [OperationContract]
        string obtieneDiaActual();

    }
}
