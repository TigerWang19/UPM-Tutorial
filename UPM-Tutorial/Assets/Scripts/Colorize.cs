using UnityEngine;

namespace Unknow.Colorful
{
    public static class Colorize
    {
        public static string Tint(this string str, Color color)
        {
            var tag = ColorUtility.ToHtmlStringRGB(color);
            return $"<color=#{tag}>{str}</color>";
        }
    }
}