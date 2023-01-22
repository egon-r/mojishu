using Kawazu;
using UnityEngine;

namespace Games.Shared.Util
{
    public static class JPConvert
    {
        public static KawazuConverter Converter;

        static JPConvert()
        {
            Converter = new KawazuConverter(Application.dataPath + "/Shared/Resources/IpaDic");
        }

        public static string KanaToRomaji(string kana)
        {
            return AsyncHelpers.RunSync<string>(() => Converter.Convert(kana, To.Romaji));
        }
    }
}