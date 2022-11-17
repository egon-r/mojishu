using System.Collections.Generic;
using System.Linq;

namespace Games.Shared.Data
{
    public enum KanaType
    {
        HIRAGANA,
        KATAKANA
    }

    public enum KanaRow
    {
        VOWEL_ROW,
        K_ROW,
        K_ROW_DIAGRAPH,
        G_ROW,
        G_ROW_DIAGRAPH,
        S_ROW,
        S_ROW_DIAGRAPH,
        Z_ROW,
        Z_ROW_DIAGRAPH,
        T_ROW,
        T_ROW_DIAGRAPH,
        D_ROW,
        D_ROW_DIAGRAPH,
        N_ROW,
        N_ROW_DIAGRAPH,
        H_ROW,
        H_ROW_DIAGRAPH,
        B_ROW,
        B_ROW_DIAGRAPH,
        P_ROW,
        P_ROW_DIAGRAPH,
        M_ROW,
        M_ROW_DIAGRAPH,
        R_ROW,
        R_ROW_DIAGRAPH,
        Y_ROW,
        W_ROW,
    }

    public class KanaInfo
    {
        public string Latin;
        public KanaType Type;
        public KanaRow Row;

        public KanaInfo(string latin, KanaType type, KanaRow row)
        {
            Latin = latin;
            Type = type;
            Row = row;
        }
    }

    public static class KanaDictionary
    {
        public static Dictionary<string, KanaInfo> GetKanaBy(params KanaType[] types)
        {
            return AllKana.Where(kv => types.Contains(kv.Value.Type)).ToDictionary(
                kv => kv.Key, kv => kv.Value
            );
        }

        public static Dictionary<string, KanaInfo> GetKanaBy(KanaRow row)
        {
            return AllKana.Where(kv => kv.Value.Row == row).ToDictionary(
                kv => kv.Key, kv => kv.Value
            );
        }
        
        public static Dictionary<string, KanaInfo> GetKanaBy(KanaType type)
        {
            return AllKana.Where(kv => kv.Value.Type == type).ToDictionary(
                kv => kv.Key, kv => kv.Value
            );
        }

        public static Dictionary<string, KanaInfo> GetKanaBy(params KanaRow[] rows)
        {
            return AllKana.Where(kv => rows.Contains(kv.Value.Row)).ToDictionary(
                kv => kv.Key, kv => kv.Value
            );
        }

        public static Dictionary<string, KanaInfo> GetKanaBy(KanaType[] types, KanaRow[] rows)
        {
            return AllKana.Where(kv => types.Contains(kv.Value.Type) && rows.Contains(kv.Value.Row))
                .ToDictionary(
                    kv => kv.Key, kv => kv.Value
                );
        }
        
        public static Dictionary<string, KanaInfo> GetKanaBy(KanaType type, params KanaRow[] rows)
        {
            return AllKana.Where(kv => kv.Value.Type == type && rows.Contains(kv.Value.Row))
                .ToDictionary(
                    kv => kv.Key, kv => kv.Value
                );
        }
        
        public static Dictionary<string, KanaInfo> GetKanaBy(KanaRow row, params KanaType[] types)
        {
            return AllKana.Where(kv => types.Contains(kv.Value.Type) && kv.Value.Row == row)
                .ToDictionary(
                    kv => kv.Key, kv => kv.Value
                );
        }

        public static Dictionary<string, KanaInfo> GetKanaBy(KanaType type, KanaRow row)
        {
            return AllKana.Where(kv => kv.Value.Row == row && kv.Value.Type == type)
                .ToDictionary(
                    kv => kv.Key, kv => kv.Value
                );
        }

        public static Dictionary<string, KanaInfo> AllKana = new()
        {
            { "ア", new KanaInfo("A", KanaType.KATAKANA, KanaRow.VOWEL_ROW) },
            { "イ", new KanaInfo("I", KanaType.KATAKANA, KanaRow.VOWEL_ROW) },
            { "ウ", new KanaInfo("U", KanaType.KATAKANA, KanaRow.VOWEL_ROW) },
            { "エ", new KanaInfo("E", KanaType.KATAKANA, KanaRow.VOWEL_ROW) },
            { "オ", new KanaInfo("O", KanaType.KATAKANA, KanaRow.VOWEL_ROW) },
            { "あ", new KanaInfo("A", KanaType.HIRAGANA, KanaRow.VOWEL_ROW) },
            { "い", new KanaInfo("I", KanaType.HIRAGANA, KanaRow.VOWEL_ROW) },
            { "う", new KanaInfo("U", KanaType.HIRAGANA, KanaRow.VOWEL_ROW) },
            { "え", new KanaInfo("E", KanaType.HIRAGANA, KanaRow.VOWEL_ROW) },
            { "お", new KanaInfo("O", KanaType.HIRAGANA, KanaRow.VOWEL_ROW) },

            { "カ", new KanaInfo("Ka", KanaType.KATAKANA, KanaRow.K_ROW) },
            { "キ", new KanaInfo("Ki", KanaType.KATAKANA, KanaRow.K_ROW) },
            { "ク", new KanaInfo("Ku", KanaType.KATAKANA, KanaRow.K_ROW) },
            { "ケ", new KanaInfo("Ke", KanaType.KATAKANA, KanaRow.K_ROW) },
            { "コ", new KanaInfo("Ko", KanaType.KATAKANA, KanaRow.K_ROW) },
            { "か", new KanaInfo("Ka", KanaType.HIRAGANA, KanaRow.K_ROW) },
            { "き", new KanaInfo("Ki", KanaType.HIRAGANA, KanaRow.K_ROW) },
            { "く", new KanaInfo("Ku", KanaType.HIRAGANA, KanaRow.K_ROW) },
            { "け", new KanaInfo("Ke", KanaType.HIRAGANA, KanaRow.K_ROW) },
            { "こ", new KanaInfo("Ko", KanaType.HIRAGANA, KanaRow.K_ROW) },

            { "キャ", new KanaInfo("Kya", KanaType.KATAKANA, KanaRow.K_ROW_DIAGRAPH) },
            { "キュ", new KanaInfo("Kyu", KanaType.KATAKANA, KanaRow.K_ROW_DIAGRAPH) },
            { "キョ", new KanaInfo("Kyo", KanaType.KATAKANA, KanaRow.K_ROW_DIAGRAPH) },
            { "きゃ", new KanaInfo("Kya", KanaType.HIRAGANA, KanaRow.K_ROW_DIAGRAPH) },
            { "きゅ", new KanaInfo("Kyu", KanaType.HIRAGANA, KanaRow.K_ROW_DIAGRAPH) },
            { "きょ", new KanaInfo("Kyo", KanaType.HIRAGANA, KanaRow.K_ROW_DIAGRAPH) },

            { "ガ", new KanaInfo("Ga", KanaType.KATAKANA, KanaRow.G_ROW) },
            { "ギ", new KanaInfo("Gi", KanaType.KATAKANA, KanaRow.G_ROW) },
            { "グ", new KanaInfo("Gu", KanaType.KATAKANA, KanaRow.G_ROW) },
            { "ゲ", new KanaInfo("Ge", KanaType.KATAKANA, KanaRow.G_ROW) },
            { "ゴ", new KanaInfo("Go", KanaType.KATAKANA, KanaRow.G_ROW) },
            { "が", new KanaInfo("Ga", KanaType.HIRAGANA, KanaRow.G_ROW) },
            { "ぎ", new KanaInfo("Gi", KanaType.HIRAGANA, KanaRow.G_ROW) },
            { "ぐ", new KanaInfo("Gu", KanaType.HIRAGANA, KanaRow.G_ROW) },
            { "げ", new KanaInfo("Ge", KanaType.HIRAGANA, KanaRow.G_ROW) },
            { "ご", new KanaInfo("Go", KanaType.HIRAGANA, KanaRow.G_ROW) },

            { "ギャ", new KanaInfo("Gya", KanaType.KATAKANA, KanaRow.G_ROW_DIAGRAPH) },
            { "ギュ", new KanaInfo("Gyu", KanaType.KATAKANA, KanaRow.G_ROW_DIAGRAPH) },
            { "ギョ", new KanaInfo("Gyo", KanaType.KATAKANA, KanaRow.G_ROW_DIAGRAPH) },
            { "ぎゃ", new KanaInfo("Gya", KanaType.HIRAGANA, KanaRow.G_ROW_DIAGRAPH) },
            { "ぎゅ", new KanaInfo("Gyu", KanaType.HIRAGANA, KanaRow.G_ROW_DIAGRAPH) },
            { "ぎょ", new KanaInfo("Gyo", KanaType.HIRAGANA, KanaRow.G_ROW_DIAGRAPH) },

            { "サ", new KanaInfo("Sa", KanaType.KATAKANA, KanaRow.S_ROW) },
            { "シ", new KanaInfo("Shi", KanaType.KATAKANA, KanaRow.S_ROW) },
            { "ス", new KanaInfo("Su", KanaType.KATAKANA, KanaRow.S_ROW) },
            { "セ", new KanaInfo("Se", KanaType.KATAKANA, KanaRow.S_ROW) },
            { "ソ", new KanaInfo("So", KanaType.KATAKANA, KanaRow.S_ROW) },
            { "さ", new KanaInfo("Sa", KanaType.HIRAGANA, KanaRow.S_ROW) },
            { "し", new KanaInfo("Shi", KanaType.HIRAGANA, KanaRow.S_ROW) },
            { "す", new KanaInfo("Su", KanaType.HIRAGANA, KanaRow.S_ROW) },
            { "せ", new KanaInfo("Se", KanaType.HIRAGANA, KanaRow.S_ROW) },
            { "そ", new KanaInfo("So", KanaType.HIRAGANA, KanaRow.S_ROW) },

            { "シャ", new KanaInfo("Sha", KanaType.KATAKANA, KanaRow.S_ROW_DIAGRAPH) },
            { "シュ", new KanaInfo("Shu", KanaType.KATAKANA, KanaRow.S_ROW_DIAGRAPH) },
            { "ショ", new KanaInfo("Sho", KanaType.KATAKANA, KanaRow.S_ROW_DIAGRAPH) },
            { "しゃ", new KanaInfo("Sha", KanaType.HIRAGANA, KanaRow.S_ROW_DIAGRAPH) },
            { "しゅ", new KanaInfo("Shu", KanaType.HIRAGANA, KanaRow.S_ROW_DIAGRAPH) },
            { "しょ", new KanaInfo("Sho", KanaType.HIRAGANA, KanaRow.S_ROW_DIAGRAPH) },

            { "ザ", new KanaInfo("Za", KanaType.KATAKANA, KanaRow.Z_ROW) },
            { "ジ", new KanaInfo("Ji", KanaType.KATAKANA, KanaRow.Z_ROW) },
            { "ズ", new KanaInfo("Zu", KanaType.KATAKANA, KanaRow.Z_ROW) },
            { "ゼ", new KanaInfo("Ze", KanaType.KATAKANA, KanaRow.Z_ROW) },
            { "ゾ", new KanaInfo("Zo", KanaType.KATAKANA, KanaRow.Z_ROW) },
            { "ざ", new KanaInfo("Za", KanaType.HIRAGANA, KanaRow.Z_ROW) },
            { "じ", new KanaInfo("Ji", KanaType.HIRAGANA, KanaRow.Z_ROW) },
            { "ず", new KanaInfo("Zu", KanaType.HIRAGANA, KanaRow.Z_ROW) },
            { "ぜ", new KanaInfo("Ze", KanaType.HIRAGANA, KanaRow.Z_ROW) },
            { "ぞ", new KanaInfo("Zo", KanaType.HIRAGANA, KanaRow.Z_ROW) },

            { "ジャ", new KanaInfo("Ja", KanaType.KATAKANA, KanaRow.Z_ROW_DIAGRAPH) },
            { "ジュ", new KanaInfo("Ju", KanaType.KATAKANA, KanaRow.Z_ROW_DIAGRAPH) },
            { "ジョ", new KanaInfo("Jo", KanaType.KATAKANA, KanaRow.Z_ROW_DIAGRAPH) },
            { "じゃ", new KanaInfo("Ja", KanaType.HIRAGANA, KanaRow.Z_ROW_DIAGRAPH) },
            { "じゅ", new KanaInfo("Ju", KanaType.HIRAGANA, KanaRow.Z_ROW_DIAGRAPH) },
            { "じょ", new KanaInfo("Jo", KanaType.HIRAGANA, KanaRow.Z_ROW_DIAGRAPH) },

            { "タ", new KanaInfo("Ta", KanaType.KATAKANA, KanaRow.T_ROW) },
            { "チ", new KanaInfo("Chi", KanaType.KATAKANA, KanaRow.T_ROW) },
            { "ツ", new KanaInfo("Tsu", KanaType.KATAKANA, KanaRow.T_ROW) },
            { "テ", new KanaInfo("Te", KanaType.KATAKANA, KanaRow.T_ROW) },
            { "ト", new KanaInfo("To", KanaType.KATAKANA, KanaRow.T_ROW) },
            { "た", new KanaInfo("Ta", KanaType.HIRAGANA, KanaRow.T_ROW) },
            { "ち", new KanaInfo("Chi", KanaType.HIRAGANA, KanaRow.T_ROW) },
            { "つ", new KanaInfo("Tsu", KanaType.HIRAGANA, KanaRow.T_ROW) },
            { "て", new KanaInfo("Te", KanaType.HIRAGANA, KanaRow.T_ROW) },
            { "と", new KanaInfo("To", KanaType.HIRAGANA, KanaRow.T_ROW) },

            { "チャ", new KanaInfo("Cha", KanaType.KATAKANA, KanaRow.T_ROW_DIAGRAPH) },
            { "チュ", new KanaInfo("Chu", KanaType.KATAKANA, KanaRow.T_ROW_DIAGRAPH) },
            { "チョ", new KanaInfo("Cho", KanaType.KATAKANA, KanaRow.T_ROW_DIAGRAPH) },
            { "ちゃ", new KanaInfo("Cha", KanaType.HIRAGANA, KanaRow.T_ROW_DIAGRAPH) },
            { "ちゅ", new KanaInfo("Chu", KanaType.HIRAGANA, KanaRow.T_ROW_DIAGRAPH) },
            { "ちょ", new KanaInfo("Cho", KanaType.HIRAGANA, KanaRow.T_ROW_DIAGRAPH) },

            { "ダ", new KanaInfo("Da", KanaType.KATAKANA, KanaRow.D_ROW) },
            { "ヂ", new KanaInfo("Ji", KanaType.KATAKANA, KanaRow.D_ROW) },
            { "ヅ", new KanaInfo("Zu", KanaType.KATAKANA, KanaRow.D_ROW) },
            { "デ", new KanaInfo("De", KanaType.KATAKANA, KanaRow.D_ROW) },
            { "ド", new KanaInfo("Do", KanaType.KATAKANA, KanaRow.D_ROW) },
            { "だ", new KanaInfo("Da", KanaType.HIRAGANA, KanaRow.D_ROW) },
            { "ぢ", new KanaInfo("Ji", KanaType.HIRAGANA, KanaRow.D_ROW) },
            { "づ", new KanaInfo("Zu", KanaType.HIRAGANA, KanaRow.D_ROW) },
            { "で", new KanaInfo("De", KanaType.HIRAGANA, KanaRow.D_ROW) },
            { "ど", new KanaInfo("Do", KanaType.HIRAGANA, KanaRow.D_ROW) },

            { "ヂャ", new KanaInfo("Ja", KanaType.KATAKANA, KanaRow.D_ROW_DIAGRAPH) },
            { "ヂュ", new KanaInfo("Ju", KanaType.KATAKANA, KanaRow.D_ROW_DIAGRAPH) },
            { "ヂョ", new KanaInfo("Jo", KanaType.KATAKANA, KanaRow.D_ROW_DIAGRAPH) },
            { "ぢゃ", new KanaInfo("Ja", KanaType.HIRAGANA, KanaRow.D_ROW_DIAGRAPH) },
            { "ぢゅ", new KanaInfo("Ju", KanaType.HIRAGANA, KanaRow.D_ROW_DIAGRAPH) },
            { "ぢょ", new KanaInfo("Jo", KanaType.HIRAGANA, KanaRow.D_ROW_DIAGRAPH) },

            { "ナ", new KanaInfo("Na", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "ニ", new KanaInfo("Ni", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "ヌ", new KanaInfo("Nu", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "ネ", new KanaInfo("Ne", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "ノ", new KanaInfo("No", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "ン", new KanaInfo("N", KanaType.KATAKANA, KanaRow.N_ROW) },
            { "な", new KanaInfo("Na", KanaType.HIRAGANA, KanaRow.N_ROW) },
            { "に", new KanaInfo("Ni", KanaType.HIRAGANA, KanaRow.N_ROW) },
            { "ぬ", new KanaInfo("Nu", KanaType.HIRAGANA, KanaRow.N_ROW) },
            { "ね", new KanaInfo("Ne", KanaType.HIRAGANA, KanaRow.N_ROW) },
            { "の", new KanaInfo("No", KanaType.HIRAGANA, KanaRow.N_ROW) },
            { "ん", new KanaInfo("N", KanaType.HIRAGANA, KanaRow.N_ROW) },

            { "ニャ", new KanaInfo("Nya", KanaType.KATAKANA, KanaRow.N_ROW_DIAGRAPH) },
            { "ニュ", new KanaInfo("Nyu", KanaType.KATAKANA, KanaRow.N_ROW_DIAGRAPH) },
            { "ニョ", new KanaInfo("Nyo", KanaType.KATAKANA, KanaRow.N_ROW_DIAGRAPH) },
            { "にゃ", new KanaInfo("Nya", KanaType.HIRAGANA, KanaRow.N_ROW_DIAGRAPH) },
            { "にゅ", new KanaInfo("Nyu", KanaType.HIRAGANA, KanaRow.N_ROW_DIAGRAPH) },
            { "にょ", new KanaInfo("Nyo", KanaType.HIRAGANA, KanaRow.N_ROW_DIAGRAPH) },

            { "ハ", new KanaInfo("Ha", KanaType.KATAKANA, KanaRow.H_ROW) },
            { "ヒ", new KanaInfo("Hi", KanaType.KATAKANA, KanaRow.H_ROW) },
            { "フ", new KanaInfo("Fu", KanaType.KATAKANA, KanaRow.H_ROW) },
            { "ヘ", new KanaInfo("He", KanaType.KATAKANA, KanaRow.H_ROW) },
            { "ホ", new KanaInfo("Ho", KanaType.KATAKANA, KanaRow.H_ROW) },
            { "は", new KanaInfo("Ha", KanaType.HIRAGANA, KanaRow.H_ROW) },
            { "ひ", new KanaInfo("Hi", KanaType.HIRAGANA, KanaRow.H_ROW) },
            { "ふ", new KanaInfo("Fu", KanaType.HIRAGANA, KanaRow.H_ROW) },
            { "へ", new KanaInfo("He", KanaType.HIRAGANA, KanaRow.H_ROW) },
            { "ほ", new KanaInfo("Ho", KanaType.HIRAGANA, KanaRow.H_ROW) },

            { "ヒャ", new KanaInfo("Hya", KanaType.KATAKANA, KanaRow.H_ROW_DIAGRAPH) },
            { "ヒュ", new KanaInfo("Hyu", KanaType.KATAKANA, KanaRow.H_ROW_DIAGRAPH) },
            { "ヒョ", new KanaInfo("Hyo", KanaType.KATAKANA, KanaRow.H_ROW_DIAGRAPH) },
            { "ひゃ", new KanaInfo("Hya", KanaType.HIRAGANA, KanaRow.H_ROW_DIAGRAPH) },
            { "ひゅ", new KanaInfo("Hyu", KanaType.HIRAGANA, KanaRow.H_ROW_DIAGRAPH) },
            { "ひょ", new KanaInfo("Hyo", KanaType.HIRAGANA, KanaRow.H_ROW_DIAGRAPH) },

            { "バ", new KanaInfo("Ba", KanaType.KATAKANA, KanaRow.B_ROW) },
            { "ビ", new KanaInfo("Bi", KanaType.KATAKANA, KanaRow.B_ROW) },
            { "ブ", new KanaInfo("Bu", KanaType.KATAKANA, KanaRow.B_ROW) },
            { "ベ", new KanaInfo("Be", KanaType.KATAKANA, KanaRow.B_ROW) },
            { "ボ", new KanaInfo("Bo", KanaType.KATAKANA, KanaRow.B_ROW) },
            { "ば", new KanaInfo("Ba", KanaType.HIRAGANA, KanaRow.B_ROW) },
            { "び", new KanaInfo("Bi", KanaType.HIRAGANA, KanaRow.B_ROW) },
            { "ぶ", new KanaInfo("Bu", KanaType.HIRAGANA, KanaRow.B_ROW) },
            { "べ", new KanaInfo("Be", KanaType.HIRAGANA, KanaRow.B_ROW) },
            { "ぼ", new KanaInfo("Bo", KanaType.HIRAGANA, KanaRow.B_ROW) },

            { "ビャ", new KanaInfo("Bya", KanaType.KATAKANA, KanaRow.B_ROW_DIAGRAPH) },
            { "ビュ", new KanaInfo("Byu", KanaType.KATAKANA, KanaRow.B_ROW_DIAGRAPH) },
            { "ビョ", new KanaInfo("Byo", KanaType.KATAKANA, KanaRow.B_ROW_DIAGRAPH) },
            { "びゃ", new KanaInfo("Bya", KanaType.HIRAGANA, KanaRow.B_ROW_DIAGRAPH) },
            { "びゅ", new KanaInfo("Byu", KanaType.HIRAGANA, KanaRow.B_ROW_DIAGRAPH) },
            { "びょ", new KanaInfo("Byo", KanaType.HIRAGANA, KanaRow.B_ROW_DIAGRAPH) },

            { "パ", new KanaInfo("Pa", KanaType.KATAKANA, KanaRow.P_ROW) },
            { "ピ", new KanaInfo("Pi", KanaType.KATAKANA, KanaRow.P_ROW) },
            { "プ", new KanaInfo("Pu", KanaType.KATAKANA, KanaRow.P_ROW) },
            { "ペ", new KanaInfo("Pe", KanaType.KATAKANA, KanaRow.P_ROW) },
            { "ポ", new KanaInfo("Po", KanaType.KATAKANA, KanaRow.P_ROW) },
            { "ぱ", new KanaInfo("Pa", KanaType.HIRAGANA, KanaRow.P_ROW) },
            { "ぴ", new KanaInfo("Pi", KanaType.HIRAGANA, KanaRow.P_ROW) },
            { "ぷ", new KanaInfo("Pu", KanaType.HIRAGANA, KanaRow.P_ROW) },
            { "ぺ", new KanaInfo("Pe", KanaType.HIRAGANA, KanaRow.P_ROW) },
            { "ぽ", new KanaInfo("Po", KanaType.HIRAGANA, KanaRow.P_ROW) },

            { "ピャ", new KanaInfo("Pya", KanaType.KATAKANA, KanaRow.P_ROW_DIAGRAPH) },
            { "ピュ", new KanaInfo("Pyu", KanaType.KATAKANA, KanaRow.P_ROW_DIAGRAPH) },
            { "ピョ", new KanaInfo("Pyo", KanaType.KATAKANA, KanaRow.P_ROW_DIAGRAPH) },
            { "ぴゃ", new KanaInfo("Pya", KanaType.HIRAGANA, KanaRow.P_ROW_DIAGRAPH) },
            { "ぴゅ", new KanaInfo("Pyu", KanaType.HIRAGANA, KanaRow.P_ROW_DIAGRAPH) },
            { "ぴょ", new KanaInfo("Pyo", KanaType.HIRAGANA, KanaRow.P_ROW_DIAGRAPH) },

            { "マ", new KanaInfo("Ma", KanaType.KATAKANA, KanaRow.M_ROW) },
            { "ミ", new KanaInfo("Mi", KanaType.KATAKANA, KanaRow.M_ROW) },
            { "ム", new KanaInfo("Mu", KanaType.KATAKANA, KanaRow.M_ROW) },
            { "メ", new KanaInfo("Me", KanaType.KATAKANA, KanaRow.M_ROW) },
            { "モ", new KanaInfo("Mo", KanaType.KATAKANA, KanaRow.M_ROW) },
            { "ま", new KanaInfo("Ma", KanaType.HIRAGANA, KanaRow.M_ROW) },
            { "み", new KanaInfo("Mi", KanaType.HIRAGANA, KanaRow.M_ROW) },
            { "む", new KanaInfo("Mu", KanaType.HIRAGANA, KanaRow.M_ROW) },
            { "め", new KanaInfo("Me", KanaType.HIRAGANA, KanaRow.M_ROW) },
            { "も", new KanaInfo("Mo", KanaType.HIRAGANA, KanaRow.M_ROW) },

            { "ミャ", new KanaInfo("Mya", KanaType.KATAKANA, KanaRow.M_ROW_DIAGRAPH) },
            { "ミュ", new KanaInfo("Myu", KanaType.KATAKANA, KanaRow.M_ROW_DIAGRAPH) },
            { "ミョ", new KanaInfo("Myo", KanaType.KATAKANA, KanaRow.M_ROW_DIAGRAPH) },
            { "みゃ", new KanaInfo("Mya", KanaType.HIRAGANA, KanaRow.M_ROW_DIAGRAPH) },
            { "みゅ", new KanaInfo("Myu", KanaType.HIRAGANA, KanaRow.M_ROW_DIAGRAPH) },
            { "みょ", new KanaInfo("Myo", KanaType.HIRAGANA, KanaRow.M_ROW_DIAGRAPH) },

            { "ラ", new KanaInfo("Ra", KanaType.KATAKANA, KanaRow.R_ROW) },
            { "リ", new KanaInfo("Ri", KanaType.KATAKANA, KanaRow.R_ROW) },
            { "ル", new KanaInfo("Ru", KanaType.KATAKANA, KanaRow.R_ROW) },
            { "レ", new KanaInfo("Re", KanaType.KATAKANA, KanaRow.R_ROW) },
            { "ロ", new KanaInfo("Ro", KanaType.KATAKANA, KanaRow.R_ROW) },
            { "ら", new KanaInfo("Ra", KanaType.HIRAGANA, KanaRow.R_ROW) },
            { "り", new KanaInfo("Ri", KanaType.HIRAGANA, KanaRow.R_ROW) },
            { "る", new KanaInfo("Ru", KanaType.HIRAGANA, KanaRow.R_ROW) },
            { "れ", new KanaInfo("Re", KanaType.HIRAGANA, KanaRow.R_ROW) },
            { "ろ", new KanaInfo("Ro", KanaType.HIRAGANA, KanaRow.R_ROW) },

            { "リャ", new KanaInfo("Rya", KanaType.KATAKANA, KanaRow.R_ROW_DIAGRAPH) },
            { "リュ", new KanaInfo("Ryu", KanaType.KATAKANA, KanaRow.R_ROW_DIAGRAPH) },
            { "リョ", new KanaInfo("Ryo", KanaType.KATAKANA, KanaRow.R_ROW_DIAGRAPH) },
            { "りゃ", new KanaInfo("Rya", KanaType.HIRAGANA, KanaRow.R_ROW_DIAGRAPH) },
            { "りゅ", new KanaInfo("Ryu", KanaType.HIRAGANA, KanaRow.R_ROW_DIAGRAPH) },
            { "りょ", new KanaInfo("Ryo", KanaType.HIRAGANA, KanaRow.R_ROW_DIAGRAPH) },

            { "ヤ", new KanaInfo("Ya", KanaType.KATAKANA, KanaRow.Y_ROW) },
            { "ユ", new KanaInfo("Yu", KanaType.KATAKANA, KanaRow.Y_ROW) },
            { "ヨ", new KanaInfo("Yo", KanaType.KATAKANA, KanaRow.Y_ROW) },
            { "や", new KanaInfo("Ya", KanaType.HIRAGANA, KanaRow.Y_ROW) },
            { "ゆ", new KanaInfo("Yu", KanaType.HIRAGANA, KanaRow.Y_ROW) },
            { "よ", new KanaInfo("Yo", KanaType.HIRAGANA, KanaRow.Y_ROW) },

            { "ワ", new KanaInfo("Wa", KanaType.KATAKANA, KanaRow.W_ROW) },
            { "ヲ", new KanaInfo("Wo", KanaType.KATAKANA, KanaRow.W_ROW) },
            { "わ", new KanaInfo("Wa", KanaType.HIRAGANA, KanaRow.W_ROW) },
            { "を", new KanaInfo("Wo", KanaType.HIRAGANA, KanaRow.W_ROW) },
        };
    }
}