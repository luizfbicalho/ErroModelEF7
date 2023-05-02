
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model.Configuracao
{
    [Table("CFGPerfil")]
    [DataContract]
    public class Perfil : IdentityRole<int> 
    {


        //[Display(Name = "Perfil Pai")]
        //[DataMember]
        //public virtual Perfil Pai { get; set; }

        [Display(Name = "Autorizações")]
        [DataMember]
        public virtual IList<Autorizacao> Autorizacoes { get; set; } = new List<Autorizacao>();



    }



}
