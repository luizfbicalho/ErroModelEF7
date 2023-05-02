
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Model.Configuracao
{
    [Table("CFGIdentidade")]
    [DataContract]
    public class Identidade : IdentityUser<int>
    {

    }
}
