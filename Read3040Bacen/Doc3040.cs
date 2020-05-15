using System.Collections.Generic;
using System.Xml.Serialization;

namespace Read3040Bacen
{
    public class Doc3040
    {
        [XmlAttribute("DtBase")]
        public string DtBase;

        [XmlAttribute("CNPJ")]
        public string CNPJ;

        [XmlAttribute("Remessa")]
        public string Remessa;

        [XmlAttribute("Parte")]
        public string Parte;

        [XmlAttribute("TpArq")]
        public string TpArq;

        [XmlAttribute("NomeResp")]
        public string NomeResp;

        [XmlAttribute("EmailResp")]
        public string EmailResp;

        [XmlAttribute("TelResp")]
        public string TelResp;

        [XmlAttribute("TotalCli")]
        public string TotalCli;

        [XmlElement("Cli")]
        public List<Cliente> clientes;

        [XmlElement("Agreg")]
        public List<Agregacao> agregacoes;
    }
}
