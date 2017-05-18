using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Abstract
{
    public enum Type : byte { ACOUSTIC, ELECTRIC }
    public enum Builder : byte { FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY }
    public enum Wood : byte { INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE, HEBAN, CEDAR, OAK, ALDER, SITKA }
    public enum Style : byte { A, F }

    public static class EnumsExtrension
    {
        public static string ToString(this Type type)
        {
            switch(type)
            {
                case Type.ACOUSTIC:
                    return "Akustyczna";
                case Type.ELECTRIC:
                    return "Elektryczna";
                default:
                    return string.Empty;
            }
        }

        public static string ToString(this Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.COLLINGS:
                    return "Collings";
                case Builder.OLSON:
                    return "Olson";
                case Builder.RYAN:
                    return "Ryan";
                case Builder.PRS:
                    return "Prs";
                case Builder.ANY:
                default:
                    return string.Empty;
            }
        }

        public static string ToString(this Wood wood)
        {
            switch (wood)
            {
                case Wood.INDIAN_ROSEWOOD:
                    return "Palisander indyjski";
                case Wood.BRAZILIAN_ROSEWOOD:
                    return "Palisander brazylijski";
                case Wood.MAHOGANY:
                    return "Mahoń";
                case Wood.MAPLE:
                    return "Klon";
                case Wood.HEBAN:
                    return "Heban";
                case Wood.CEDAR:
                    return "Cedar";
                case Wood.OAK:
                    return "Olcha";
                case Wood.ALDER:
                    return "Alder";
                case Wood.SITKA:
                    return "Sitka";
                default:
                    return string.Empty;
            }
        }
    }
}
