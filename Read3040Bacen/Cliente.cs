using System.Collections.Generic;
using System.Xml.Serialization;

namespace Read3040Bacen
{
    [XmlRoot("Cli")]
    public class Cliente
    {
        [XmlAttribute("Tp")]
        public string Tp;

        [XmlAttribute("Cd")]
        public string Cd;

        [XmlAttribute("Autorzc")]
        public string Autorzc;

        [XmlAttribute("PorteCli")]
        public string PorteCli;

        [XmlAttribute("TpCtrl")]
        public string TpCtrl;

        [XmlAttribute("IniRelactCli")]
        public string IniRelactCli;

        [XmlAttribute("CongEcon")]
        public string CongEcon;

        [XmlAttribute("ClassCli")]
        public string ClassCli;

        [XmlElement("Op")]
        public List<Operacao> operacoes;

    }
}
