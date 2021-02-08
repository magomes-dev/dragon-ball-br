using System.ComponentModel;
using System.Runtime.Serialization;

namespace DragonBall.Domain.Models.Enums
{
    public enum Sagas
    {
        [Description("Dragon Ball")]
        [EnumMember(Value = "Dragon Ball")]
        DB = 1,

        [Description("Dragon Ball Z")]
        [EnumMember(Value = "Dragon Ball Z")]
        Z = 2,

        [Description("Dragon Ball GT")]
        [EnumMember(Value = "Dragon Ball GT")]
        GT = 3,

        [Description("Dragon Ball Super")]
        [EnumMember(Value = "Dragon Ball Super")]
        Super = 4,

        [Description("Dragon Ball Heroes")]
        [EnumMember(Value = "Dragon Ball Heroes")]
        Heroes = 5
    }
}
