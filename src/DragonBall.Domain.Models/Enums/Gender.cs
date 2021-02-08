using System.ComponentModel;
using System.Runtime.Serialization;

namespace DragonBall.Domain.Models.Enums
{
    public enum Gender
    {
        [Description("Masculino")]
        [EnumMember(Value = "Masculino")]
        Male = 1,

        [Description("Feminino")]
        [EnumMember(Value = "Feminino")]
        Famale = 2,

        [Description("Não definido")]
        [EnumMember(Value = "Não definido")]
        Undefined = 3,
    }
}
