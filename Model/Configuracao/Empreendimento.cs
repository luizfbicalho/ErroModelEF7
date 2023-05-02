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


        [DataMember]
        public virtual Praca? Praca { get; set; }

    }
}
