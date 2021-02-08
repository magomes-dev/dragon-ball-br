using System.ComponentModel;
using System.Runtime.Serialization;

namespace DragonBall.Domain.Models.Enums
{
    public enum Race
    {
        [Description("Terráqueo")]
        [EnumMember(Value = "Terráqueo")]
        Earthling = 1,

        [Description("Saiyan")]
        [EnumMember(Value = "Saiyan")]
        Saiyan = 2,
    }
}
