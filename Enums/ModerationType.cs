using System.ComponentModel;

namespace MyBlog.Enums
{
    public enum ModerationType
    {
        [Description("Political Content")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drug References")]
        Drugs,
        [Description("Threatening Content")]
        Threatening,
        [Description("Sexual Content/Harassment")]
        Sexual,
        [Description("Hateful Content")]
        Hatespeech,
        [Description("Shaming")]
        Shaming
    }
}
