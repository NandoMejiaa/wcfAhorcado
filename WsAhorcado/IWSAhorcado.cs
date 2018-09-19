using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WsAhorcado
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSAhorcado
    {

        [OperationContract]
        Palabra ObtenerPalabra();

        [OperationContract]
        Palabra ValidarLetra(string Letra, string Palabra, string PalabraGuion, string VidasRestantes);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Palabra {
        [DataMember]
        public string nuevaPalabra { get; set; }
        [DataMember]
        public string nuevaPalabraGuion { get; set; }
        [DataMember]
        public string vidasRestantes { get; set; }
        [DataMember]
        public string mensaje { get; set; }

    }

}
