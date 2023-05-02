using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Model.Configuracao
{
    [Table("CFGAutorizacao")]
    //[DataContract]
    public class Empreendimento:Autorizacao
    {
        //[StringLength(100)]
        //[DataMember]
        //public string? Codigo { get; set; }
        //[DataMember]

        //public bool ChatAssessoria { get; set; }
        ////[DataMember]
        ////public virtual Passo? PassoAssessoria { get; set; }
        //[DataMember]
        //public bool ChatCorretor { get; set; }
        ////[DataMember]
        ////public virtual Passo? PassoCorretor { get; set; }
        //[DataMember]
        //public bool LiberarAcessoCliente { get; set; }

        [DataMember]
        public virtual Praca? Praca { get; set; }

        //[DataMember]
        //[SubForm]
        //public virtual IList<EmpreendimentoAssessoria> Assessorias { get; set; } = new List<EmpreendimentoAssessoria>();
        //[Newtonsoft.Json.JsonIgnore]
        //public virtual IList<Indicador> Indicadores { get; set; } = new List<Indicador>();  
        //[DateOnly]
        //public DateTime? DataLancamento { get; set; }
    }
}
