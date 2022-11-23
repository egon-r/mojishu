using System.Collections.Generic;

namespace Games.Shared.Data
{
    public static partial class KanjiData
    {
        public static List<KanjiInfo> AllKanjiList = new()
        {
            new KanjiInfo(
                "舞",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ブ" },
                new string[] { "bu" },
                new string[] { "ま(う)、まい" },
                new string[] { "ma(u)", "mai" },
                new string[] { "dance", "circle" }
            ),
            new KanjiInfo(
                "逆",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ギャク" },
                new string[] { "gyaku" },
                new string[] { "さか(らう)" },
                new string[] { "saka(rau)" },
                new string[] { "inverted; reverse; opposite" }
            ),
            new KanjiInfo(
                "落",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ラク" },
                new string[] { "raku" },
                new string[] { "お(ちる)" },
                new string[] { "o(chiru)" },
                new string[] { "fall", "drop" }
            ),
            new KanjiInfo(
                "紅",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ、 ク" },
                new string[] { "kou", "ku" },
                new string[] { "べに、 くれない" },
                new string[] { "beni", "kurenai" },
                new string[] { "crimson; deep red" }
            ),
            new KanjiInfo(
                "療",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "heal; cure" }
            ),
            new KanjiInfo(
                "含",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "ふく(む)" },
                new string[] { "fuku(mu)" },
                new string[] { "contain; include" }
            ),
            new KanjiInfo(
                "兵",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヘイ、 ヒョウ" },
                new string[] { "hei", "hyou" },
                new string[] { "つわもの" },
                new string[] { "tsuwamono" },
                new string[] { "soldier; private; troops; army" }
            ),
            new KanjiInfo(
                "輸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ユ、 シュ" },
                new string[] { "yu", "shu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "transport", "send", "be inferior" }
            ),
            new KanjiInfo(
                "円",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "まる(い)" },
                new string[] { "maru(i)" },
                new string[] { "circle", "yen", "round" }
            ),
            new KanjiInfo(
                "全",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゼン" },
                new string[] { "zen" },
                new string[] { "まった(く)、 すべ(て)" },
                new string[] { "matta(ku)", "sube(te)" },
                new string[] { "whole", "entire", "all", "complete", "fulfill" }
            ),
            new KanjiInfo(
                "図",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ズ、 ト" },
                new string[] { "zu", "to" },
                new string[] { "はか(る)" },
                new string[] { "haka(ru)" },
                new string[] { "map", "drawing", "plan", "extraordinary" }
            ),
            new KanjiInfo(
                "栄",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "さか(える)" },
                new string[] { "saka(eru)" },
                new string[] { "flourish; prosperity; honor" }
            ),
            new KanjiInfo(
                "難",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ナン" },
                new string[] { "nan" },
                new string[] { "かた(い)、むずか(しい)、 にく(い)" },
                new string[] { "kata(i)", "muzuka(shii)", "niku(i)" },
                new string[] { "difficult", "trouble", "accident" }
            ),
            new KanjiInfo(
                "誌",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "document; records" }
            ),
            new KanjiInfo(
                "床",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "とこ、 ゆか" },
                new string[] { "toko", "yuka" },
                new string[] { "bed; counter for beds; floor; padding; tatami" }
            ),
            new KanjiInfo(
                "鼻",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ビ" },
                new string[] { "bi" },
                new string[] { "はな" },
                new string[] { "hana" },
                new string[] { "nose; snout" }
            ),
            new KanjiInfo(
                "順",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジュン" },
                new string[] { "jun" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "obey; order; turn; occasion" }
            ),
            new KanjiInfo(
                "戦",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "いくさ、 たたか(う)" },
                new string[] { "ikusa", "tataka(u)" },
                new string[] { "war", "battle", "match" }
            ),
            new KanjiInfo(
                "詞",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "part of speech; words" }
            ),
            new KanjiInfo(
                "首",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "くび" },
                new string[] { "kubi" },
                new string[] { "neck" }
            ),
            new KanjiInfo(
                "深",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "ふか(い)" },
                new string[] { "fuka(i)" },
                new string[] { "deep", "heighten" }
            ),
            new KanjiInfo(
                "病",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ビョウ" },
                new string[] { "byou" },
                new string[] { "や(む)" },
                new string[] { "ya(mu)" },
                new string[] { "ill", "sick" }
            ),
            new KanjiInfo(
                "更",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "さら(に)、ふ(ける)" },
                new string[] { "sara(ni)", "fu(keru)" },
                new string[] { "renew", "renovate", "again" }
            ),
            new KanjiInfo(
                "勇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ユウ" },
                new string[] { "yuu" },
                new string[] { "いさ(む)" },
                new string[] { "isa(mu)" },
                new string[] { "courage; cheer up; bravery; heroism" }
            ),
            new KanjiInfo(
                "叫",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "さけ(ぶ)" },
                new string[] { "sake(bu)" },
                new string[] { "shout; exclaim; yell" }
            ),
            new KanjiInfo(
                "籍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "enroll; register; membership" }
            ),
            new KanjiInfo(
                "包",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "つつ(む)、 くる(む)" },
                new string[] { "tsutsu(mu)", "kuru(mu)" },
                new string[] { "wrap; pack up; cover; conceal" }
            ),
            new KanjiInfo(
                "急",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "いそ(ぐ)" },
                new string[] { "iso(gu)" },
                new string[] { "hurry", "emergency", "sudden", "steep" }
            ),
            new KanjiInfo(
                "与",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨ" },
                new string[] { "yo" },
                new string[] { "あた(える)、 あずか(る)" },
                new string[] { "ata(eru)", "azuka(ru)" },
                new string[] { "give", "award" }
            ),
            new KanjiInfo(
                "計",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "はか(る)" },
                new string[] { "haka(ru)" },
                new string[] { "plot", "plan", "scheme", "measure" }
            ),
            new KanjiInfo(
                "赤",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "セキ、 シャク" },
                new string[] { "seki", "shaku" },
                new string[] { "あか(い)" },
                new string[] { "aka(i)" },
                new string[] { "red" }
            ),
            new KanjiInfo(
                "温",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オン" },
                new string[] { "on" },
                new string[] { "あたた(かい)、ぬく" },
                new string[] { "atata(kai)", "nuku" },
                new string[] { "warm" }
            ),
            new KanjiInfo(
                "今",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コン、 キン" },
                new string[] { "kon", "kin" },
                new string[] { "いま" },
                new string[] { "ima" },
                new string[] { "now; the present" }
            ),
            new KanjiInfo(
                "字",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "character", "letter", "word" }
            ),
            new KanjiInfo(
                "立",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リツ" },
                new string[] { "ritsu" },
                new string[] { "た(つ)" },
                new string[] { "ta(tsu)" },
                new string[] { "stand up", "rise" }
            ),
            new KanjiInfo(
                "治",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ、チ" },
                new string[] { "ji", "chi" },
                new string[] { "おさ(める)、なお(る)" },
                new string[] { "nasa(meru)", "nao(ru)" },
                new string[] { "reign", "cure", "heal" }
            ),
            new KanjiInfo(
                "委",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "ゆだ(ねる)" },
                new string[] { "yuda(neru)" },
                new string[] { "committee", "entrust to" }
            ),
            new KanjiInfo(
                "課",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "chapter", "lesson", "section", "department" }
            ),
            new KanjiInfo(
                "灯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ひ、とも(す)" },
                new string[] { "hi", "tomo(su)" },
                new string[] { "lamp; a light; counter for lights" }
            ),
            new KanjiInfo(
                "財",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザイ、 サイ、 ゾク" },
                new string[] { "zai", "sai", "zoku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "property", "money", "wealth", "assets" }
            ),
            new KanjiInfo(
                "科",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "department", "course", "section" }
            ),
            new KanjiInfo(
                "肌",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "はだ" },
                new string[] { "hada" },
                new string[] { "texture; skin; body; grain" }
            ),
            new KanjiInfo(
                "耳",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "みみ" },
                new string[] { "mimi" },
                new string[] { "ear" }
            ),
            new KanjiInfo(
                "皮",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "かわ" },
                new string[] { "kawa" },
                new string[] { "skin; hide; leather" }
            ),
            new KanjiInfo(
                "昨",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サク" },
                new string[] { "saku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "yesterday", "previous" }
            ),
            new KanjiInfo(
                "未",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ミ、ビ" },
                new string[] { "mi", "bi" },
                new string[] { "いま(だ)、ま(だ)" },
                new string[] { "ima(da)", "ma(da)" },
                new string[] { "un-", "not yet" }
            ),
            new KanjiInfo(
                "減",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゲン" },
                new string[] { "gen" },
                new string[] { "へ(る)" },
                new string[] { "he(ru)" },
                new string[] { "dwindle; decrease; reduce" }
            ),
            new KanjiInfo(
                "現",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゲン" },
                new string[] { "gen" },
                new string[] { "あらわ(れる)、 うつ(つ)" },
                new string[] { "arawa(reru)", "utsu(tsu)" },
                new string[] { "present", "existing", "actual" }
            ),
            new KanjiInfo(
                "際",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "きわ" },
                new string[] { "kiwa" },
                new string[] { "occasion", "time" }
            ),
            new KanjiInfo(
                "県",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "prefecture" }
            ),
            new KanjiInfo(
                "丸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "まる、まる(い)" },
                new string[] { "maru", "maru(i)" },
                new string[] { "round; full (month); perfection" }
            ),
            new KanjiInfo(
                "明",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "メイ、 ミョウ" },
                new string[] { "mei", "myou" },
                new string[] { "あか(るい)" },
                new string[] { "aka(rui)" },
                new string[] { "bright", "light" }
            ),
            new KanjiInfo(
                "弟",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "テイ、 ダイ、 デ" },
                new string[] { "tei", "dai", "de" },
                new string[] { "おとうと" },
                new string[] { "otouto" },
                new string[] { "younger brother" }
            ),
            new KanjiInfo(
                "困",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コン" },
                new string[] { "kon" },
                new string[] { "こま(る)" },
                new string[] { "koma(ru)" },
                new string[] { "quandary", "become distressed" }
            ),
            new KanjiInfo(
                "完",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "perfect", "completion" }
            ),
            new KanjiInfo(
                "婦",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "よめ" },
                new string[] { "yome" },
                new string[] { "lady", "woman", "wife" }
            ),
            new KanjiInfo(
                "蒸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジョウ、 セイ" },
                new string[] { "jou", "sei" },
                new string[] { "む(す)" },
                new string[] { "mu(su)" },
                new string[] { "steam; heat; foment" }
            ),
            new KanjiInfo(
                "積",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "つ(む)" },
                new string[] { "tsu(mu)" },
                new string[] { "volume", "contents", "pile up", "stack" }
            ),
            new KanjiInfo(
                "姓",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "surname" }
            ),
            new KanjiInfo(
                "炭",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タン" },
                new string[] { "tan" },
                new string[] { "すみ" },
                new string[] { "sumi" },
                new string[] { "charcoal; coal" }
            ),
            new KanjiInfo(
                "月",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゲツ、 ガツ" },
                new string[] { "getsu", "gatsu" },
                new string[] { "つき" },
                new string[] { "tsuki" },
                new string[] { "month", "moon" }
            ),
            new KanjiInfo(
                "葉",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "は" },
                new string[] { "ha" },
                new string[] { "leaf", "plane", "needle", "blade", "counter for flat things" }
            ),
            new KanjiInfo(
                "相",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ソウ、 ショウ" },
                new string[] { "sou", "shou" },
                new string[] { "あい" },
                new string[] { "ai" },
                new string[] { "inter-", "mutual", "together", "each other", "minister of state" }
            ),
            new KanjiInfo(
                "齢",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "よわい、 とし" },
                new string[] { "yowai", "toshi" },
                new string[] { "age" }
            ),
            new KanjiInfo(
                "再",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サイ、 サ" },
                new string[] { "sai", "sa" },
                new string[] { "ふたた(び)" },
                new string[] { "futata(bi)" },
                new string[] { "again", "twice", "second time" }
            ),
            new KanjiInfo(
                "金",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "キン、 コン、 ゴン" },
                new string[] { "kin", "kon", "gon" },
                new string[] { "かね、 かな-、 -がね" },
                new string[] { "kane", "kana", "gane" },
                new string[] { "gold" }
            ),
            new KanjiInfo(
                "適",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "テキ" },
                new string[] { "teki" },
                new string[] { "かな(う)" },
                new string[] { "kana(u)" },
                new string[] { "suitable", "occasional", "rare" }
            ),
            new KanjiInfo(
                "段",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ダン" },
                new string[] { "dan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "grade", "steps", "stairs" }
            ),
            new KanjiInfo(
                "薬",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヤク" },
                new string[] { "yaku" },
                new string[] { "くすり" },
                new string[] { "kusuri" },
                new string[] { "medicine", "chemical" }
            ),
            new KanjiInfo(
                "庁",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "やくしょ" },
                new string[] { "yakusho" },
                new string[] { "government office" }
            ),
            new KanjiInfo(
                "裏",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リ" },
                new string[] { "ri" },
                new string[] { "うら" },
                new string[] { "ura" },
                new string[] { "back; reverse; inside; rear" }
            ),
            new KanjiInfo(
                "依",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ、 エ" },
                new string[] { "i", "e" },
                new string[] { "よ(る)" },
                new string[] { "yo(ru)" },
                new string[] { "reliant; depend on; consequently; therefore; due to" }
            ),
            new KanjiInfo(
                "容",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "contain", "form" }
            ),
            new KanjiInfo(
                "館",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "やかた" },
                new string[] { "yakata" },
                new string[] { "building", "mansion", "large building", "palace" }
            ),
            new KanjiInfo(
                "兄",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キョウ、 ケイ" },
                new string[] { "kyou", "kei" },
                new string[] { "あに" },
                new string[] { "ani" },
                new string[] { "elder brother" }
            ),
            new KanjiInfo(
                "助",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョ" },
                new string[] { "jo" },
                new string[] { "たす(ける)" },
                new string[] { "tasu(keru)" },
                new string[] { "help", "rescue", "assist" }
            ),
            new KanjiInfo(
                "署",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "signature; govt office; police station" }
            ),
            new KanjiInfo(
                "逃",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "に(げる)、のが(す)" },
                new string[] { "ni(geru)", "noga(su)" },
                new string[] { "escape", "flee" }
            ),
            new KanjiInfo(
                "講",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "lecture; club; association" }
            ),
            new KanjiInfo(
                "灰",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "はい" },
                new string[] { "hai" },
                new string[] { "ashes; cremate" }
            ),
            new KanjiInfo(
                "界",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "world", "boundary" }
            ),
            new KanjiInfo(
                "甘",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "あま(い)" },
                new string[] { "ama(i)" },
                new string[] { "sweet; coax; pamper; sugary" }
            ),
            new KanjiInfo(
                "末",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "マツ" },
                new string[] { "matsu" },
                new string[] { "すえ" },
                new string[] { "sue" },
                new string[] { "end", "close", "tip" }
            ),
            new KanjiInfo(
                "刷",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サツ" },
                new string[] { "satsu" },
                new string[] { "す(る)、 は(く)" },
                new string[] { "su(ru)", "ha(ku)" },
                new string[] { "printing; print; brush" }
            ),
            new KanjiInfo(
                "案",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "アン" },
                new string[] { "an" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "plan", "suggestion", "draft" }
            ),
            new KanjiInfo(
                "集",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "あつ(める)" },
                new string[] { "atsu(meru)" },
                new string[] { "gather", "meet" }
            ),
            new KanjiInfo(
                "木",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ボク、 モク" },
                new string[] { "boku", "moku" },
                new string[] { "き、 こ-" },
                new string[] { "ki", "ko" },
                new string[] { "tree", "wood" }
            ),
            new KanjiInfo(
                "万",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "マン、 バン" },
                new string[] { "man", "ban" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ten thousand", "10", "000" }
            ),
            new KanjiInfo(
                "身",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "み" },
                new string[] { "mi" },
                new string[] { "somebody", "person" }
            ),
            new KanjiInfo(
                "光",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "ひか(る)、ひかり" },
                new string[] { "hika(ru)", "hikari" },
                new string[] { "ray", "light" }
            ),
            new KanjiInfo(
                "他",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タ" },
                new string[] { "ta" },
                new string[] { "ほか" },
                new string[] { "hoka" },
                new string[] { "other", "another" }
            ),
            new KanjiInfo(
                "要",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "い(る)、 かなめ" },
                new string[] { "i(ru)", "kaname" },
                new string[] { "need", "main point", "essence", "pivot" }
            ),
            new KanjiInfo(
                "疑",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ギ" },
                new string[] { "gi" },
                new string[] { "うたが(う)" },
                new string[] { "utaga(u)" },
                new string[] { "doubt", "distrust" }
            ),
            new KanjiInfo(
                "休",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "やす(む)" },
                new string[] { "yasu(mu)" },
                new string[] { "rest", "day off", "retire", "sleep" }
            ),
            new KanjiInfo(
                "馬",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "バ" },
                new string[] { "ba" },
                new string[] { "うま" },
                new string[] { "uma" },
                new string[] { "horse" }
            ),
            new KanjiInfo(
                "球",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "たま" },
                new string[] { "tama" },
                new string[] { "ball", "sphere" }
            ),
            new KanjiInfo(
                "準",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジュン" },
                new string[] { "jun" },
                new string[] { "じゅん(じる)、 なぞら(える)" },
                new string[] { "jun(jiru)", "nazora(eru)" },
                new string[] { "semi-; correspond to; imitate" }
            ),
            new KanjiInfo(
                "刻",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "きざ(む)" },
                new string[] { "kiza(mu)" },
                new string[] { "engrave", "cut fine", "chop" }
            ),
            new KanjiInfo(
                "郊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "outskirts", "suburbs", "rural area" }
            ),
            new KanjiInfo(
                "早",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ソウ、 サッ" },
                new string[] { "sou", "sa" },
                new string[] { "はや(い)" },
                new string[] { "haya(i)" },
                new string[] { "early", "fast" }
            ),
            new KanjiInfo(
                "煙",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "けむ(る)、けむり" },
                new string[] { "kemu(ru)", "kemuri" },
                new string[] { "smoke" }
            ),
            new KanjiInfo(
                "厚",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "あつ(い)" },
                new string[] { "atsu(i)" },
                new string[] { "thick; heavy; rich" }
            ),
            new KanjiInfo(
                "掘",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "クツ" },
                new string[] { "kutsu" },
                new string[] { "ほ(る)" },
                new string[] { "ho(ru)" },
                new string[] { "dig; delve; excavate" }
            ),
            new KanjiInfo(
                "辛",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "から(い)、 つら(い)" },
                new string[] { "kara(i)", "tsura(i)" },
                new string[] { "spicy; hot" }
            ),
            new KanjiInfo(
                "造",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "つく(る)" },
                new string[] { "tsuku(ru)" },
                new string[] { "create; make; structure; physique" }
            ),
            new KanjiInfo(
                "舟",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "ふね" },
                new string[] { "fune" },
                new string[] { "boat; ship" }
            ),
            new KanjiInfo(
                "沸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フツ" },
                new string[] { "futsu" },
                new string[] { "わ(く)" },
                new string[] { "wa(ku)" },
                new string[] { "seethe; boil; ferment" }
            ),
            new KanjiInfo(
                "板",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハン、 バン" },
                new string[] { "han", "ban" },
                new string[] { "いた" },
                new string[] { "ita" },
                new string[] { "plank; board; plate; stage" }
            ),
            new KanjiInfo(
                "消",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "き(える)、け(す)" },
                new string[] { "ki(eru)", "ke(su)" },
                new string[] { "extinguish", "turn off" }
            ),
            new KanjiInfo(
                "良",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "よ(い)、い(い)" },
                new string[] { "yo(i)", "i(i)" },
                new string[] { "good" }
            ),
            new KanjiInfo(
                "波",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハ" },
                new string[] { "ha" },
                new string[] { "なみ" },
                new string[] { "nami" },
                new string[] { "waves; billows" }
            ),
            new KanjiInfo(
                "著",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チョ、 チャク" },
                new string[] { "cho", "chaku" },
                new string[] { "あらわ(す)、 いちじる(しい)" },
                new string[] { "arawa(su)", "ichijiru(shii)" },
                new string[] { "renowned; publish; write" }
            ),
            new KanjiInfo(
                "園",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "その" },
                new string[] { "sono" },
                new string[] { "park", "garden", "yard" }
            ),
            new KanjiInfo(
                "当",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "あ(たる)" },
                new string[] { "a(taru)" },
                new string[] { "hit", "right", "appropriate" }
            ),
            new KanjiInfo(
                "牛",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ギュウ" },
                new string[] { "gyuu" },
                new string[] { "うし" },
                new string[] { "ushi" },
                new string[] { "cow" }
            ),
            new KanjiInfo(
                "成",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ、 ジョウ" },
                new string[] { "sei", "jou" },
                new string[] { "な(る)" },
                new string[] { "na(ru)" },
                new string[] { "turn into", "become", "get", "grow", "elapse" }
            ),
            new KanjiInfo(
                "占",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "し(める)、 うらな(う)" },
                new string[] { "shi(meru)", "urana(u)" },
                new string[] { "fortune-telling; divining; forecasting" }
            ),
            new KanjiInfo(
                "間",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "カン、 ケン" },
                new string[] { "kan", "ken" },
                new string[] { "あいだ、 ま、 あい" },
                new string[] { "aida", "ma", "ai" },
                new string[] { "interval", "space" }
            ),
            new KanjiInfo(
                "識",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シキ" },
                new string[] { "shiki" },
                new string[] { "し(る)" },
                new string[] { "shi(ru)" },
                new string[] { "know" }
            ),
            new KanjiInfo(
                "高",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "たか(い)" },
                new string[] { "taka(i)" },
                new string[] { "tall", "high", "expensive" }
            ),
            new KanjiInfo(
                "達",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タツ、 ダ" },
                new string[] { "tatsu", "da" },
                new string[] { "-たち" },
                new string[] { "-tachi" },
                new string[] { "accomplished", "reach", "arrive", "attain" }
            ),
            new KanjiInfo(
                "圧",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "アツ" },
                new string[] { "atsu" },
                new string[] { "お(す)" },
                new string[] { "o(su)" },
                new string[] { "pressure; push; overwhelm; oppress" }
            ),
            new KanjiInfo(
                "美",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ビ、 ミ" },
                new string[] { "bi", "mi" },
                new string[] { "うつく(しい)" },
                new string[] { "utsukushii" },
                new string[] { "beauty", "beautiful" }
            ),
            new KanjiInfo(
                "因",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "よ(る)、ちな(む)" },
                new string[] { "yo(ru)", "china(mu)" },
                new string[] { "cause", "factor", "depend on" }
            ),
            new KanjiInfo(
                "億",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オク" },
                new string[] { "oku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "hundred million; 10**8" }
            ),
            new KanjiInfo(
                "両",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "both" }
            ),
            new KanjiInfo(
                "死",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "し(ぬ)" },
                new string[] { "shi(nu)" },
                new string[] { "death", "die" }
            ),
            new KanjiInfo(
                "春",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュン" },
                new string[] { "shun" },
                new string[] { "はる" },
                new string[] { "haru" },
                new string[] { "spring" }
            ),
            new KanjiInfo(
                "歴",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レキ" },
                new string[] { "reki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "curriculum; continuation; passage of time" }
            ),
            new KanjiInfo(
                "注",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "そそ(ぐ)、 さ(す)、 つ(ぐ)" },
                new string[] { "soso(gu)", "sa(su)", "tsu(gu)" },
                new string[] { "pour", "irrigate", "shed (tears)", "flow into", "concentrate on" }
            ),
            new KanjiInfo(
                "匹",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒツ" },
                new string[] { "hitsu" },
                new string[] { "ひき" },
                new string[] { "hiki" },
                new string[] { "counter for small animals" }
            ),
            new KanjiInfo(
                "予",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨ、 シャ" },
                new string[] { "yo", "sha" },
                new string[] { "あらかじ(め)" },
                new string[] { "arakaji(me)" },
                new string[] { "beforehand", "previous", "myself", "I" }
            ),
            new KanjiInfo(
                "燃",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ネン" },
                new string[] { "nen" },
                new string[] { "も(える)" },
                new string[] { "mo(eru)" },
                new string[] { "burn; blaze; glow" }
            ),
            new KanjiInfo(
                "決",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ケツ" },
                new string[] { "ketsu" },
                new string[] { "き(める)" },
                new string[] { "ki(meru)" },
                new string[] { "decide", "fix", "agree upon", "appoint" }
            ),
            new KanjiInfo(
                "失",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シツ" },
                new string[] { "shitsu" },
                new string[] { "うしな(う)、 う(せる)" },
                new string[] { "ushina(u)", "u(seru)" },
                new string[] { "lose", "error", "fault", "disadvantage", "loss" }
            ),
            new KanjiInfo(
                "五",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "いつ(つ)" },
                new string[] { "itsu(tsu)" },
                new string[] { "five", "5" }
            ),
            new KanjiInfo(
                "黒",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "くろ" },
                new string[] { "kuro" },
                new string[] { "black" }
            ),
            new KanjiInfo(
                "対",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "タイ、 ツイ" },
                new string[] { "tai", "tsui" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "opposite", "even", "equal", "versus", "anti-", "compare" }
            ),
            new KanjiInfo(
                "季",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "seasons" }
            ),
            new KanjiInfo(
                "断",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ダン" },
                new string[] { "dan" },
                new string[] { "た(つ)、 ことわ(る)" },
                new string[] { "ta(tsu)", "kotowa(ru)" },
                new string[] { "severance", "decline", "refuse", "apologize" }
            ),
            new KanjiInfo(
                "退",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "しりぞ(く)、 ひ(く)、 の(ける)、 ど(く)" },
                new string[] { "shirizo(ku)", "hi(ku)", "no(keru)", "do(ku)" },
                new string[] { "retreat", "withdraw", "retire", "resign", "repel", "expel", "reject" }
            ),
            new KanjiInfo(
                "朝",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "あさ" },
                new string[] { "asa" },
                new string[] { "morning" }
            ),
            new KanjiInfo(
                "歩",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ホ、 ブ" },
                new string[] { "ho", "bu" },
                new string[] { "ある(く)、 あゆ(む)" },
                new string[] { "aru(ku)", "ayu(mu)" },
                new string[] { "walk", "counter for steps" }
            ),
            new KanjiInfo(
                "録",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ロク" },
                new string[] { "roku" },
                new string[] { "と(る)" },
                new string[] { "to(ru)" },
                new string[] { "record" }
            ),
            new KanjiInfo(
                "辺",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヘン" },
                new string[] { "hen" },
                new string[] { "あた(り)、 ほと(り)" },
                new string[] { "ata(ri)", "hoto(ri)" },
                new string[] { "environs; boundary; border; vicinity" }
            ),
            new KanjiInfo(
                "花",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カ、 ケ" },
                new string[] { "ka", "ke" },
                new string[] { "はな" },
                new string[] { "hana" },
                new string[] { "flower" }
            ),
            new KanjiInfo(
                "漁",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ギョ、 リョウ" },
                new string[] { "gyo", "ryou" },
                new string[] { "あさ(る)" },
                new string[] { "asa(ru)" },
                new string[] { "fishing; fishery" }
            ),
            new KanjiInfo(
                "土",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ド、 ト" },
                new string[] { "do", "to" },
                new string[] { "つち" },
                new string[] { "tsuchi" },
                new string[] { "soil", "earth", "ground" }
            ),
            new KanjiInfo(
                "承",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "うけたまわ(る)" },
                new string[] { "uketamawa(ru)" },
                new string[] { "hear; listen to; be informed; receive" }
            ),
            new KanjiInfo(
                "殿",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "デン" },
                new string[] { "den" },
                new string[] { "との、 どの" },
                new string[] { "tono", "dono" },
                new string[] { "Mr.; hall; mansion; palace; temple; lord" }
            ),
            new KanjiInfo(
                "夜",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヤ" },
                new string[] { "ya" },
                new string[] { "よ、 よる" },
                new string[] { "yo", "yoru" },
                new string[] { "night", "evening" }
            ),
            new KanjiInfo(
                "械",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "contraption; machine; instrument" }
            ),
            new KanjiInfo(
                "量",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "はか(る)" },
                new string[] { "haka(ru)" },
                new string[] { "quantity; measure; weight; amount" }
            ),
            new KanjiInfo(
                "捜",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "さが(す)" },
                new string[] { "saga(su)" },
                new string[] { "search; look for; locate" }
            ),
            new KanjiInfo(
                "貨",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "freight; goods; property" }
            ),
            new KanjiInfo(
                "涼",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "すず(しい)" },
                new string[] { "suzu(shii)" },
                new string[] { "refreshing; nice and cool" }
            ),
            new KanjiInfo(
                "層",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "stratum; social class; layer; story; floor" }
            ),
            new KanjiInfo(
                "薄",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハク" },
                new string[] { "haku" },
                new string[] { "うす(い)" },
                new string[] { "usu(i)" },
                new string[] { "dilute; thin; weak (tea)" }
            ),
            new KanjiInfo(
                "開",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "ひら(く)、 あ(ける)" },
                new string[] { "hira(ku)", "a(keru)" },
                new string[] { "open", "unfold", "unseal" }
            ),
            new KanjiInfo(
                "営",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "いとな(む)" },
                new string[] { "itona(mu)" },
                new string[] { "occupation; camp; perform; build; conduct (business)" }
            ),
            new KanjiInfo(
                "終",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "お(わる)" },
                new string[] { "o(waru)" },
                new string[] { "end", "finish" }
            ),
            new KanjiInfo(
                "濯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タク" },
                new string[] { "taku" },
                new string[] { "すす(ぐ)" },
                new string[] { "susu(gu)" },
                new string[] { "laundry; wash; rinse" }
            ),
            new KanjiInfo(
                "絶",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゼツ" },
                new string[] { "zetsu" },
                new string[] { "た(える)" },
                new string[] { "ta(eru)" },
                new string[] { "discontinue", "unparalleled" }
            ),
            new KanjiInfo(
                "毎",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "マイ" },
                new string[] { "mai" },
                new string[] { "ごと(に)" },
                new string[] { "goto(ni)" },
                new string[] { "every" }
            ),
            new KanjiInfo(
                "手",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "て" },
                new string[] { "te" },
                new string[] { "hand" }
            ),
            new KanjiInfo(
                "訪",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "おとず(れる)、たず(ねる)" },
                new string[] { "toozu(reru)", "tazu(neru)" },
                new string[] { "call on", "visit" }
            ),
            new KanjiInfo(
                "世",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "セイ、 セ" },
                new string[] { "sei", "se" },
                new string[] { "よ" },
                new string[] { "yo" },
                new string[] { "generation", "world", "society", "public" }
            ),
            new KanjiInfo(
                "任",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ニン" },
                new string[] { "nin" },
                new string[] { "まか(せる)" },
                new string[] { "maka(seru)" },
                new string[] { "responsibility", "duty" }
            ),
            new KanjiInfo(
                "派",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハ" },
                new string[] { "ha" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "faction", "group", "party" }
            ),
            new KanjiInfo(
                "杯",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハイ" },
                new string[] { "hai" },
                new string[] { "さかずき" },
                new string[] { "sakazuki" },
                new string[] { "glass", "cup" }
            ),
            new KanjiInfo(
                "八",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ハチ" },
                new string[] { "hachi" },
                new string[] { "や(つ)、 よう" },
                new string[] { "ya(tsu)", "you" },
                new string[] { "eight", "8" }
            ),
            new KanjiInfo(
                "配",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハイ" },
                new string[] { "hai" },
                new string[] { "くば(る)" },
                new string[] { "kuba(ru)" },
                new string[] { "distribute", "spouse" }
            ),
            new KanjiInfo(
                "湿",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シツ" },
                new string[] { "shitsu" },
                new string[] { "しめ(る)" },
                new string[] { "shime(ru)" },
                new string[] { "damp; wet; moist" }
            ),
            new KanjiInfo(
                "改",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "あらた(める)" },
                new string[] { "arata(meru)" },
                new string[] { "reformation", "change", "modify" }
            ),
            new KanjiInfo(
                "肉",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ニク" },
                new string[] { "niku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "meat" }
            ),
            new KanjiInfo(
                "年",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ネン" },
                new string[] { "nen" },
                new string[] { "とし" },
                new string[] { "toshi" },
                new string[] { "year", "counter for years" }
            ),
            new KanjiInfo(
                "程",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "テイ" },
                new string[] { "tei" },
                new string[] { "ほど" },
                new string[] { "hodo" },
                new string[] { "extent", "degree" }
            ),
            new KanjiInfo(
                "探",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タン" },
                new string[] { "tan" },
                new string[] { "さぐ(る)、さが(す)" },
                new string[] { "sagu(ru)", "saga(su)" },
                new string[] { "search", "look for" }
            ),
            new KanjiInfo(
                "乳",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ニュウ" },
                new string[] { "nyuu" },
                new string[] { "ちち、ち" },
                new string[] { "chichi", "chi" },
                new string[] { "milk", "breasts" }
            ),
            new KanjiInfo(
                "妹",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "マイ" },
                new string[] { "mai" },
                new string[] { "いもうと" },
                new string[] { "imouto" },
                new string[] { "younger sister" }
            ),
            new KanjiInfo(
                "社",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "やしろ" },
                new string[] { "yashiro" },
                new string[] { "company", "firm", "office", "association", "shrine" }
            ),
            new KanjiInfo(
                "偶",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "グウ" },
                new string[] { "guu" },
                new string[] { "たま" },
                new string[] { "tama" },
                new string[] { "accidentally", "even number" }
            ),
            new KanjiInfo(
                "校",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "school", "exam" }
            ),
            new KanjiInfo(
                "危",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "あぶ(ない)、あや(うい)" },
                new string[] { "abu(nai)", "aya(ui)" },
                new string[] { "dangerous", "fear", "uneasy" }
            ),
            new KanjiInfo(
                "央",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "center; middle" }
            ),
            new KanjiInfo(
                "悪",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "アク" },
                new string[] { "aku" },
                new string[] { "わる(い)" },
                new string[] { "waru(i)" },
                new string[] { "bad", "evil", "wrong" }
            ),
            new KanjiInfo(
                "北",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ホク" },
                new string[] { "hoku" },
                new string[] { "きた" },
                new string[] { "kita" },
                new string[] { "north" }
            ),
            new KanjiInfo(
                "御",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ギョ、ゴ" },
                new string[] { "gyo", "go" },
                new string[] { "おん、お" },
                new string[] { "on", "o" },
                new string[] { "honorable" }
            ),
            new KanjiInfo(
                "副",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "vice-; assistant; aide; duplicate; copy" }
            ),
            new KanjiInfo(
                "港",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "みなと" },
                new string[] { "minato" },
                new string[] { "harbor", "port" }
            ),
            new KanjiInfo(
                "下",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "カ、 ゲ" },
                new string[] { "ka", "ge" },
                new string[] { "した、 しも、 もと、 さ(げる)、 くだ(る)、 お(ろす)" },
                new string[] { "shita", "shimo", "moto", "sa(geru)", "kuda(ru)", "o(rosu)" },
                new string[] { "below", "down", "descend", "give", "low", "inferior" }
            ),
            new KanjiInfo(
                "熱",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ネツ" },
                new string[] { "netsu" },
                new string[] { "あつ(い)" },
                new string[] { "atsu(i)" },
                new string[] { "heat", "fever", "passion" }
            ),
            new KanjiInfo(
                "令",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "orders; command; decree" }
            ),
            new KanjiInfo(
                "永",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "なが(い)" },
                new string[] { "naga(i)" },
                new string[] { "eternity; long; lengthy" }
            ),
            new KanjiInfo(
                "庫",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ、 ク" },
                new string[] { "ko", "ku" },
                new string[] { "くら" },
                new string[] { "kura" },
                new string[] { "warehouse; storehouse" }
            ),
            new KanjiInfo(
                "封",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フウ、 ホウ" },
                new string[] { "fuu", "hou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "seal; closing" }
            ),
            new KanjiInfo(
                "寺",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "てら" },
                new string[] { "tera" },
                new string[] { "Buddhist temple" }
            ),
            new KanjiInfo(
                "凍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "こお(る)、 こご(える)" },
                new string[] { "koo(ru)", "kogo(eru)" },
                new string[] { "frozen; refrigerate" }
            ),
            new KanjiInfo(
                "畳",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジョウ、 チョウ" },
                new string[] { "jou", "chou" },
                new string[] { "たたみ" },
                new string[] { "tatami" },
                new string[] { "tatami mat; fold" }
            ),
            new KanjiInfo(
                "連",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "レン" },
                new string[] { "ren" },
                new string[] { "つら(なる)、つ(れる)" },
                new string[] { "tsura(naru)", "tsu(reru)" },
                new string[] { "take along", "lead", "join", "connect" }
            ),
            new KanjiInfo(
                "車",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "くるま" },
                new string[] { "kuruma" },
                new string[] { "car", "wheel" }
            ),
            new KanjiInfo(
                "太",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タイ、タ" },
                new string[] { "tai", "ta" },
                new string[] { "ふと(い)" },
                new string[] { "futo(i)" },
                new string[] { "plump", "thick", "big around" }
            ),
            new KanjiInfo(
                "西",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "セイ、 サイ" },
                new string[] { "sei", "sai" },
                new string[] { "にし" },
                new string[] { "nishi" },
                new string[] { "west" }
            ),
            new KanjiInfo(
                "豊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ホウ、 ブ" },
                new string[] { "hou", "bu" },
                new string[] { "ゆた(か)、 とよ" },
                new string[] { "yuta(ka)", "toyo" },
                new string[] { "bountiful; excellent; rich" }
            ),
            new KanjiInfo(
                "軟",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ナン" },
                new string[] { "nan" },
                new string[] { "やわ(らかい)" },
                new string[] { "yawa(rakai)" },
                new string[] { "soft" }
            ),
            new KanjiInfo(
                "保",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ホ、ホウ" },
                new string[] { "ho", "hou" },
                new string[] { "たも(つ)" },
                new string[] { "tamo(tsu)" },
                new string[] { "protect", "guarantee", "keep" }
            ),
            new KanjiInfo(
                "反",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "そ(る)" },
                new string[] { "so(ru)" },
                new string[] { "anti-" }
            ),
            new KanjiInfo(
                "晩",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "バン" },
                new string[] { "ban" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "nightfall", "night" }
            ),
            new KanjiInfo(
                "台",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ダイ、 タイ" },
                new string[] { "dai", "tai" },
                new string[] { "うてな" },
                new string[] { "utena" },
                new string[] { "pedestal", "a stand", "counter for machines and vehicles" }
            ),
            new KanjiInfo(
                "存",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソン、ゾン" },
                new string[] { "son", "zon" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "exist", "be aware of" }
            ),
            new KanjiInfo(
                "油",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ユ" },
                new string[] { "yu" },
                new string[] { "あぶら" },
                new string[] { "abura" },
                new string[] { "oil; fat" }
            ),
            new KanjiInfo(
                "泳",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "およ(ぐ)" },
                new string[] { "oyo(gu)" },
                new string[] { "swim" }
            ),
            new KanjiInfo(
                "線",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "line; track" }
            ),
            new KanjiInfo(
                "強",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キョウ、 ゴウ" },
                new string[] { "kyou", "gou" },
                new string[] { "つよ(い)" },
                new string[] { "tsuyo(i)" },
                new string[] { "strong" }
            ),
            new KanjiInfo(
                "誰",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "スイ" },
                new string[] { "sui" },
                new string[] { "だれ" },
                new string[] { "dare" },
                new string[] { "who", "someone", "somebody" }
            ),
            new KanjiInfo(
                "野",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヤ" },
                new string[] { "ya" },
                new string[] { "の" },
                new string[] { "no" },
                new string[] { "plains", "field", "rustic", "civilian life" }
            ),
            new KanjiInfo(
                "抱",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "だ(く)、いだ(く)、かか(える)" },
                new string[] { "da(ku)", "ida(ku)", "kaka(eru)" },
                new string[] { "embrace", "hug" }
            ),
            new KanjiInfo(
                "設",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セツ" },
                new string[] { "setsu" },
                new string[] { "もう(ける)" },
                new string[] { "mou(keru)" },
                new string[] { "establishment", "provision" }
            ),
            new KanjiInfo(
                "績",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "exploits; achievements" }
            ),
            new KanjiInfo(
                "遅",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "おく(れる)、 おそ(い)" },
                new string[] { "oku(reru)", "oso(i)" },
                new string[] { "slow", "late", "back", "later" }
            ),
            new KanjiInfo(
                "洗",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "あら(う)" },
                new string[] { "ara(u)" },
                new string[] { "wash" }
            ),
            new KanjiInfo(
                "週",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "week" }
            ),
            new KanjiInfo(
                "焼",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "や(く)" },
                new string[] { "ya(ku)" },
                new string[] { "bake; burning" }
            ),
            new KanjiInfo(
                "悩",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ノウ" },
                new string[] { "nou" },
                new string[] { "なや(む)" },
                new string[] { "naya(mu)" },
                new string[] { "trouble; worry; in pain; distress; illness" }
            ),
            new KanjiInfo(
                "南",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ナン、 ナ" },
                new string[] { "nan", "na" },
                new string[] { "みなみ" },
                new string[] { "minami" },
                new string[] { "south" }
            ),
            new KanjiInfo(
                "験",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "verification", "effect", "testing" }
            ),
            new KanjiInfo(
                "力",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リョク、 リキ" },
                new string[] { "ryoku", "riki" },
                new string[] { "ちから" },
                new string[] { "chikara" },
                new string[] { "power", "strength", "strong", "strain", "bear up", "exert" }
            ),
            new KanjiInfo(
                "覚",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カク" },
                new string[] { "kaku" },
                new string[] { "おぼ(える)、 さ(ます)" },
                new string[] { "obo(eru)", "sa(masu)" },
                new string[] { "memorize", "learn", "remember", "awake" }
            ),
            new KanjiInfo(
                "認",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ニン" },
                new string[] { "nin" },
                new string[] { "みと(める)、したた(める)" },
                new string[] { "mito(meru)", "shitata(meru)" },
                new string[] { "acknowledge", "witness", "recognize" }
            ),
            new KanjiInfo(
                "糸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "いと" },
                new string[] { "ito" },
                new string[] { "thread" }
            ),
            new KanjiInfo(
                "鳥",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "とり" },
                new string[] { "tori" },
                new string[] { "bird", "chicken" }
            ),
            new KanjiInfo(
                "疲",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "つか(れる)" },
                new string[] { "tsuka(reru)" },
                new string[] { "exhausted", "tire" }
            ),
            new KanjiInfo(
                "給",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "たま(う)、たも(う)" },
                new string[] { "tama(u)", "tamo(u)" },
                new string[] { "salary", "wage", "gift" }
            ),
            new KanjiInfo(
                "地",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "チ、 ジ" },
                new string[] { "chi", "ji" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ground", "earth" }
            ),
            new KanjiInfo(
                "腹",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "はら" },
                new string[] { "hara" },
                new string[] { "abdomen", "belly", "stomach" }
            ),
            new KanjiInfo(
                "跡",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "あと" },
                new string[] { "ato" },
                new string[] { "tracks; mark; print; impression" }
            ),
            new KanjiInfo(
                "笑",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "わら(う)、え(む)" },
                new string[] { "wara(u)", "e(mu)" },
                new string[] { "laugh" }
            ),
            new KanjiInfo(
                "察",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サツ" },
                new string[] { "satsu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "guess", "presume", "judge" }
            ),
            new KanjiInfo(
                "貧",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒン、ビン" },
                new string[] { "hin", "bin" },
                new string[] { "まず(しい)" },
                new string[] { "mazu(shii)" },
                new string[] { "poverty", "poor" }
            ),
            new KanjiInfo(
                "雪",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セツ" },
                new string[] { "setsu" },
                new string[] { "ゆき" },
                new string[] { "yuki" },
                new string[] { "snow" }
            ),
            new KanjiInfo(
                "泥",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "デイ" },
                new string[] { "dei" },
                new string[] { "どろ" },
                new string[] { "doro" },
                new string[] { "mud; adhere to; be attached to" }
            ),
            new KanjiInfo(
                "猫",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ビョウ" },
                new string[] { "byou" },
                new string[] { "ねこ" },
                new string[] { "neko" },
                new string[] { "cat" }
            ),
            new KanjiInfo(
                "部",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ブ" },
                new string[] { "bu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "section", "bureau", "dept", "class", "copy", "part", "portion" }
            ),
            new KanjiInfo(
                "午",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "うま" },
                new string[] { "uma" },
                new string[] { "noon", "sign of the horse" }
            ),
            new KanjiInfo(
                "割",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カツ" },
                new string[] { "katsu" },
                new string[] { "わ(る)、わり" },
                new string[] { "wa(ru)", "wari" },
                new string[] { "proportion", "divide", "cut", "separate" }
            ),
            new KanjiInfo(
                "満",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "マン" },
                new string[] { "man" },
                new string[] { "み(ちる)" },
                new string[] { "mi(chiru)" },
                new string[] { "full", "fullness", "enough", "satisfy" }
            ),
            new KanjiInfo(
                "被",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "こうむ(る)、  かぶ(る)" },
                new string[] { "koumu(ru)", "kabu(ru)" },
                new string[] { "incur; cover; shelter; wear; put on" }
            ),
            new KanjiInfo(
                "絵",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カイ、エ" },
                new string[] { "kai", "e" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "picture", "drawing" }
            ),
            new KanjiInfo(
                "化",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カ、 ケ" },
                new string[] { "ka", "ke" },
                new string[] { "ば(ける)、 ふ(ける)" },
                new string[] { "ba(keru)", "fu(keru)" },
                new string[] { "change", "take the form of", "influence", "enchant", "delude", "-ization" }
            ),
            new KanjiInfo(
                "湾",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ワン" },
                new string[] { "wan" },
                new string[] { "いりえ" },
                new string[] { "irie" },
                new string[] { "gulf; bay; inlet" }
            ),
            new KanjiInfo(
                "会",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "あ(う)" },
                new string[] { "a(u)" },
                new string[] { "meeting; meet" }
            ),
            new KanjiInfo(
                "記",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "しる(す)" },
                new string[] { "shiru(su)" },
                new string[] { "scribe", "account", "narrative" }
            ),
            new KanjiInfo(
                "額",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ガク" },
                new string[] { "gaku" },
                new string[] { "ひたい" },
                new string[] { "hitai" },
                new string[] { "forehead; tablet; framed picture; sum; amount; volume" }
            ),
            new KanjiInfo(
                "管",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "くだ" },
                new string[] { "kuda" },
                new string[] { "pipe; tube; wind instrument; control; jurisdiction" }
            ),
            new KanjiInfo(
                "分",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ブン、 フン、 ブ" },
                new string[] { "bun", "fun", "bu" },
                new string[] { "わ(ける)" },
                new string[] { "wa(keru)" },
                new string[] { "part", "minute of time", "understand" }
            ),
            new KanjiInfo(
                "飯",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "めし" },
                new string[] { "meshi" },
                new string[] { "meal", "rice" }
            ),
            new KanjiInfo(
                "降",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ、 ゴ" },
                new string[] { "kou", "go" },
                new string[] { "お(りる)、 ふ(る)" },
                new string[] { "o(riru)", "fu(ru)" },
                new string[] { "descend", "precipitate", "fall", "surrender" }
            ),
            new KanjiInfo(
                "枚",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "マイ、 バイ" },
                new string[] { "mai", "bai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "sheet of...; counter for flat thin objects" }
            ),
            new KanjiInfo(
                "細",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サイ" },
                new string[] { "sei" },
                new string[] { "ほそ(い)、 こま(かい)" },
                new string[] { "hoso(i)", "koma(kai)" },
                new string[] { "slender; narrow; detailed; precise" }
            ),
            new KanjiInfo(
                "紙",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "かみ" },
                new string[] { "kami" },
                new string[] { "paper" }
            ),
            new KanjiInfo(
                "協",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "co-", "cooperation" }
            ),
            new KanjiInfo(
                "作",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "サク、 サ" },
                new string[] { "saku", "sa" },
                new string[] { "つく(る)" },
                new string[] { "tsuku(ru)" },
                new string[] { "make", "production", "prepare", "build" }
            ),
            new KanjiInfo(
                "貸",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "か(す)、 かし" },
                new string[] { "ka(su)", "kashi" },
                new string[] { "lend" }
            ),
            new KanjiInfo(
                "結",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケツ" },
                new string[] { "ketsu" },
                new string[] { "むす(ぶ)、ゆ(う)" },
                new string[] { "musu(bu)", "yu(u)" },
                new string[] { "tie", "bind", "contract" }
            ),
            new KanjiInfo(
                "翌",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨク" },
                new string[] { "yoku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "the following; next" }
            ),
            new KanjiInfo(
                "犬",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "いぬ" },
                new string[] { "inu" },
                new string[] { "dog" }
            ),
            new KanjiInfo(
                "募",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボ" },
                new string[] { "bo" },
                new string[] { "つの(る)" },
                new string[] { "tsuno(ru)" },
                new string[] { "recruit; campaign" }
            ),
            new KanjiInfo(
                "掛",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "か(ける)" },
                new string[] { "ka(karu)" },
                new string[] { "hang", "suspend" }
            ),
            new KanjiInfo(
                "希",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "まれ、 こいねが(う)" },
                new string[] { "mare", "koinega(u)" },
                new string[] { "hope; beg; request; pray" }
            ),
            new KanjiInfo(
                "起",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "お(きる)、 おこ(す)" },
                new string[] { "o(kiru)", "oko(su)" },
                new string[] { "wake up", "get up; rouse" }
            ),
            new KanjiInfo(
                "面",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "メン" },
                new string[] { "men" },
                new string[] { "おも、おもて、つら" },
                new string[] { "omo", "omote", "tsura" },
                new string[] { "mask", "face", "features", "surface" }
            ),
            new KanjiInfo(
                "同",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "おな(じ)" },
                new string[] { "onaji" },
                new string[] { "same", "agree", "equal" }
            ),
            new KanjiInfo(
                "音",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "オン" },
                new string[] { "on" },
                new string[] { "おと、 ね" },
                new string[] { "oto", "ne" },
                new string[] { "sound", "noise" }
            ),
            new KanjiInfo(
                "負",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "ま(ける)、 お(う)" },
                new string[] { "ma(keru)", "o(u)" },
                new string[] { "defeat", "negative", "minus", "assume a responsibility" }
            ),
            new KanjiInfo(
                "飛",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "と(ぶ)" },
                new string[] { "to(bu)" },
                new string[] { "fly" }
            ),
            new KanjiInfo(
                "談",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ダン" },
                new string[] { "dan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "discuss", "talk" }
            ),
            new KanjiInfo(
                "省",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "かえり(みる)、 はぶ(く)" },
                new string[] { "kaeri(miru)", "habu(ku)" },
                new string[] { "focus; government ministry; conserve" }
            ),
            new KanjiInfo(
                "除",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョ、ジ" },
                new string[] { "jo", "ji" },
                new string[] { "のぞ(く)" },
                new string[] { "nozo(ku)" },
                new string[] { "exclude", "remove" }
            ),
            new KanjiInfo(
                "特",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "トク" },
                new string[] { "toku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "special" }
            ),
            new KanjiInfo(
                "門",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "モン" },
                new string[] { "mon" },
                new string[] { "かど、 と" },
                new string[] { "kado", "to" },
                new string[] { "gate" }
            ),
            new KanjiInfo(
                "銀",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ギン" },
                new string[] { "gin" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "silver" }
            ),
            new KanjiInfo(
                "森",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "もり" },
                new string[] { "mori" },
                new string[] { "forest", "woods" }
            ),
            new KanjiInfo(
                "届",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "とど(ける)" },
                new string[] { "todo(keru)" },
                new string[] { "deliver; reach; arrive; report" }
            ),
            new KanjiInfo(
                "流",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "リュウ、ル" },
                new string[] { "ryuu", "ru" },
                new string[] { "なが(れる)" },
                new string[] { "naga(reru)" },
                new string[] { "current", "flow" }
            ),
            new KanjiInfo(
                "男",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ダン、 ナン" },
                new string[] { "dan", "nan" },
                new string[] { "おとこ、 お" },
                new string[] { "otoko", "o" },
                new string[] { "male; man" }
            ),
            new KanjiInfo(
                "航",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "navigate; sail; cruise; fly" }
            ),
            new KanjiInfo(
                "過",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "す(ぎる)、よぎ(る)" },
                new string[] { "su(giru)", "yogi(ru)" },
                new string[] { "overdo", "exceed", "go beyond" }
            ),
            new KanjiInfo(
                "符",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "token; sign; mark" }
            ),
            new KanjiInfo(
                "坂",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "さか" },
                new string[] { "saka" },
                new string[] { "slope; incline; hill" }
            ),
            new KanjiInfo(
                "中",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "なか、 うち、 あた(る)" },
                new string[] { "naka", "uchi", "ata(ru)" },
                new string[] { "in", "inside", "middle", "mean", "center" }
            ),
            new KanjiInfo(
                "由",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ユ、ユウ" },
                new string[] { "yu", "yuu" },
                new string[] { "よし、よ(る)" },
                new string[] { "yoshi", "yo(ru)" },
                new string[] { "wherefore", "a reason" }
            ),
            new KanjiInfo(
                "呼",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "よ(ぶ)" },
                new string[] { "yo(bu)" },
                new string[] { "call", "invite" }
            ),
            new KanjiInfo(
                "捕",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ホ" },
                new string[] { "ho" },
                new string[] { "と(らえる)、つか(まえる)" },
                new string[] { "to(raeru)", "tsuka(maeru)" },
                new string[] { "catch", "capture" }
            ),
            new KanjiInfo(
                "忘",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "わす(れる)" },
                new string[] { "wasu(reru)" },
                new string[] { "forget" }
            ),
            new KanjiInfo(
                "編",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヘン" },
                new string[] { "hen" },
                new string[] { "あ(む)" },
                new string[] { "a(mu)" },
                new string[] { "compilation; knit; braid; twist; editing" }
            ),
            new KanjiInfo(
                "臣",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン、 ジン" },
                new string[] { "shin", "jin" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "retainer; subject" }
            ),
            new KanjiInfo(
                "京",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "キョウ、 ケイ、 キン" },
                new string[] { "kyou", "kei", "kin" },
                new string[] { "みやこ" },
                new string[] { "miyako" },
                new string[] { "capital" }
            ),
            new KanjiInfo(
                "借",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シャク" },
                new string[] { "shaku" },
                new string[] { "か(りる)" },
                new string[] { "ka(riru)" },
                new string[] { "borrow", "rent" }
            ),
            new KanjiInfo(
                "隻",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "vessels; counter for ships; fish; one of a pair" }
            ),
            new KanjiInfo(
                "局",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョク" },
                new string[] { "kyoku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "bureau", "board", "office" }
            ),
            new KanjiInfo(
                "巨",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョ" },
                new string[] { "kyo" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "gigantic; big; large; great" }
            ),
            new KanjiInfo(
                "無",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ム、 ブ" },
                new string[] { "mu", "bu" },
                new string[] { "な(い)" },
                new string[] { "na(i)" },
                new string[] { "nothingness", "none", "ain't", "nothing", "nil", "not" }
            ),
            new KanjiInfo(
                "黄",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ、 オウ" },
                new string[] { "kou", "ou" },
                new string[] { "き" },
                new string[] { "ki" },
                new string[] { "yellow" }
            ),
            new KanjiInfo(
                "帽",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "cap; headgear" }
            ),
            new KanjiInfo(
                "費",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "つい(やす)" },
                new string[] { "tsui(yasu)" },
                new string[] { "expense", "consume" }
            ),
            new KanjiInfo(
                "植",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショク" },
                new string[] { "shoku" },
                new string[] { "う(える)" },
                new string[] { "u(eru)" },
                new string[] { "plant" }
            ),
            new KanjiInfo(
                "憎",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "にく(む)" },
                new string[] { "niku(mu)" },
                new string[] { "hate; detest" }
            ),
            new KanjiInfo(
                "変",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヘン" },
                new string[] { "hen" },
                new string[] { "か(わる)" },
                new string[] { "ka(waru)" },
                new string[] { "unusual", "change", "strange" }
            ),
            new KanjiInfo(
                "願",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "ねが(う)" },
                new string[] { "nega(u)" },
                new string[] { "petition", "request", "wish" }
            ),
            new KanjiInfo(
                "菜",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "な" },
                new string[] { "na" },
                new string[] { "vegetable; side dish; greens" }
            ),
            new KanjiInfo(
                "法",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "のり" },
                new string[] { "nori" },
                new string[] { "method", "law", "rule", "principle", "model", "system" }
            ),
            new KanjiInfo(
                "九",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "キュウ、 ク" },
                new string[] { "kyuu", "ku" },
                new string[] { "ここの(つ)" },
                new string[] { "kokono(tsu)" },
                new string[] { "nine", "9" }
            ),
            new KanjiInfo(
                "務",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ム" },
                new string[] { "mu" },
                new string[] { "つと(める)" },
                new string[] { "tsuto(meru)" },
                new string[] { "task", "duties" }
            ),
            new KanjiInfo(
                "欠",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケツ、ケン" },
                new string[] { "ketsu", "ken" },
                new string[] { "か(ける)" },
                new string[] { "ka(keru)" },
                new string[] { "lack", "gap" }
            ),
            new KanjiInfo(
                "格",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カク、コウ、キャク" },
                new string[] { "kaku", "kou", "kyaku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "status", "rank", "capacity" }
            ),
            new KanjiInfo(
                "像",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "statue; picture; image; figure" }
            ),
            new KanjiInfo(
                "湖",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "みずうみ" },
                new string[] { "mizuumi" },
                new string[] { "lake" }
            ),
            new KanjiInfo(
                "別",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ベツ" },
                new string[] { "betsu" },
                new string[] { "わか(れる)、 わ(ける)" },
                new string[] { "waka(reru)", "wa(keru)" },
                new string[] { "separate", "branch off", "diverge" }
            ),
            new KanjiInfo(
                "右",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ウ、 ユウ" },
                new string[] { "u", "yuu" },
                new string[] { "みぎ" },
                new string[] { "migi" },
                new string[] { "right" }
            ),
            new KanjiInfo(
                "広",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "ひろ(い)" },
                new string[] { "hiro(i)" },
                new string[] { "wide", "broad", "spacious" }
            ),
            new KanjiInfo(
                "眠",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ミン" },
                new string[] { "min" },
                new string[] { "ねむ(る)" },
                new string[] { "nemu(ru)" },
                new string[] { "sleep" }
            ),
            new KanjiInfo(
                "禁",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キン" },
                new string[] { "kin" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "prohibition; ban; forbid" }
            ),
            new KanjiInfo(
                "質",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シツ、 シチ" },
                new string[] { "shitsu", "shichi" },
                new string[] { "たち、 ただ(す)" },
                new string[] { "tachi", "tada(su)" },
                new string[] { "substance", "quality", "matter", "temperament" }
            ),
            new KanjiInfo(
                "軽",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "かる(い)" },
                new string[] { "karu(i)" },
                new string[] { "lightly; trifling; unimportant" }
            ),
            new KanjiInfo(
                "口",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "くち" },
                new string[] { "kuchi" },
                new string[] { "mouth" }
            ),
            new KanjiInfo(
                "顔",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "かお" },
                new string[] { "kao" },
                new string[] { "face", "expression" }
            ),
            new KanjiInfo(
                "押",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "お(す)" },
                new string[] { "o(su)" },
                new string[] { "push" }
            ),
            new KanjiInfo(
                "蔵",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "くら" },
                new string[] { "kura" },
                new string[] { "storehouse; hide; own; have; possess" }
            ),
            new KanjiInfo(
                "章",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "badge; chapter; composition; poem" }
            ),
            new KanjiInfo(
                "机",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "つくえ" },
                new string[] { "tsukue" },
                new string[] { "desk; table" }
            ),
            new KanjiInfo(
                "駐",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "stop-over; reside in; resident" }
            ),
            new KanjiInfo(
                "帰",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "かえ(る)、 かえ(す)" },
                new string[] { "kae(ru)", "kae(su)" },
                new string[] { "homecoming", "arrive at", "lead to", "result in" }
            ),
            new KanjiInfo(
                "夫",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ、フウ" },
                new string[] { "fu", "fuu" },
                new string[] { "おっと" },
                new string[] { "otto" },
                new string[] { "husband", "man" }
            ),
            new KanjiInfo(
                "住",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ジュウ、 チュウ" },
                new string[] { "juu", "chuu" },
                new string[] { "す(む)" },
                new string[] { "su(mu)" },
                new string[] { "dwell", "reside", "live", "inhabit" }
            ),
            new KanjiInfo(
                "区",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ク" },
                new string[] { "ku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ward", "district" }
            ),
            new KanjiInfo(
                "止",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "と(まる)、 とど(まる)、 や(める)、 よ(す)" },
                new string[] { "to(maru)", "todo(maru)", "ya(meru)", "yo(su)" },
                new string[] { "stop", "halt" }
            ),
            new KanjiInfo(
                "飲",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "の(む)" },
                new string[] { "no(mu)" },
                new string[] { "drink" }
            ),
            new KanjiInfo(
                "望",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "のぞ(む)、 もち" },
                new string[] { "nozo(mu)", "mochi" },
                new string[] { "ambition", "full moon", "hope", "desire", "aspire to", "expect" }
            ),
            new KanjiInfo(
                "阪",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "さか" },
                new string[] { "saka" },
                new string[] { "heights", "slope" }
            ),
            new KanjiInfo(
                "針",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "はり" },
                new string[] { "hari" },
                new string[] { "needle; pin; staple; stinger" }
            ),
            new KanjiInfo(
                "児",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "こ" },
                new string[] { "ko" },
                new string[] { "newborn babe; child" }
            ),
            new KanjiInfo(
                "複",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "duplicate; double; compound; multiple" }
            ),
            new KanjiInfo(
                "怖",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "こわ(い)、お(じる)" },
                new string[] { "kowa(i)", "o(jiru)" },
                new string[] { "dreadful", "fearful" }
            ),
            new KanjiInfo(
                "景",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケイ、ケ" },
                new string[] { "kei", "ke" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "scenery", "view" }
            ),
            new KanjiInfo(
                "券",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ticket" }
            ),
            new KanjiInfo(
                "到",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "いた(る)" },
                new string[] { "ita(ru)" },
                new string[] { "arrival", "proceed", "reach" }
            ),
            new KanjiInfo(
                "絡",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ラク" },
                new string[] { "raku" },
                new string[] { "から(む)" },
                new string[] { "kara(mu)" },
                new string[] { "entwine; coil around; get caught in" }
            ),
            new KanjiInfo(
                "例",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "たと(えば)" },
                new string[] { "tato(eba)" },
                new string[] { "example" }
            ),
            new KanjiInfo(
                "兆",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "きざ(す)" },
                new string[] { "kiza(su)" },
                new string[] { "trillion; sign; omen; symptoms" }
            ),
            new KanjiInfo(
                "見",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "み(る)、 み(せる)" },
                new string[] { "mi(ru)", "mi(seru)" },
                new string[] { "see", "hopes", "chances", "idea", "opinion", "look at", "visible" }
            ),
            new KanjiInfo(
                "築",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チク" },
                new string[] { "chiku" },
                new string[] { "きず(く)" },
                new string[] { "kizu(ku)" },
                new string[] { "fabricate; build; construct" }
            ),
            new KanjiInfo(
                "輪",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リン" },
                new string[] { "rin" },
                new string[] { "わ" },
                new string[] { "wa" },
                new string[] { "wheel; ring; circle; link; loop; counter for wheels and flowers" }
            ),
            new KanjiInfo(
                "有",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ユウ、 ウ" },
                new string[] { "yuu", "u" },
                new string[] { "あ(る)" },
                new string[] { "a(ru)" },
                new string[] { "possess", "have", "exist", "happen" }
            ),
            new KanjiInfo(
                "生",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "い(きる)、 う(む)、 お(う)、 は(える)、 なま" },
                new string[] { "i(kiru)", "u(mu)", "o(u)", "ha(eru)", "nama" },
                new string[] { "life", "genuine", "birth" }
            ),
            new KanjiInfo(
                "咲",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "さ(く)" },
                new string[] { "sa(ku)" },
                new string[] { "blossom; bloom" }
            ),
            new KanjiInfo(
                "髪",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハツ" },
                new string[] { "hatsu" },
                new string[] { "かみ" },
                new string[] { "kami" },
                new string[] { "hair (on the head)" }
            ),
            new KanjiInfo(
                "責",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "せ(める)" },
                new string[] { "se(meru)" },
                new string[] { "blame", "condemn" }
            ),
            new KanjiInfo(
                "命",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "メイ、ミョウ" },
                new string[] { "mei", "myou" },
                new string[] { "いのち" },
                new string[] { "inochi" },
                new string[] { "fate", "command" }
            ),
            new KanjiInfo(
                "便",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ベン、 ビン" },
                new string[] { "ben", "bin" },
                new string[] { "たよ(り)" },
                new string[] { "tayo(ri)" },
                new string[] { "convenience", "facility" }
            ),
            new KanjiInfo(
                "冷",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "つめ(たい)、ひ(える)、さ(める)" },
                new string[] { "tsume(tai)", "hi(eru)", "sa(meru)" },
                new string[] { "cool", "cold", "chill" }
            ),
            new KanjiInfo(
                "迎",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゲイ" },
                new string[] { "gei" },
                new string[] { "むか(える)" },
                new string[] { "muka(eru)" },
                new string[] { "welcome", "meet", "greet" }
            ),
            new KanjiInfo(
                "布",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "ぬの、 し(く)" },
                new string[] { "nuno", "shi(ku)" },
                new string[] { "linen; cloth; spread; distribute" }
            ),
            new KanjiInfo(
                "靴",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "くつ" },
                new string[] { "kutsu" },
                new string[] { "shoes" }
            ),
            new KanjiInfo(
                "郵",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ユウ" },
                new string[] { "yuu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "mail; stagecoach stop" }
            ),
            new KanjiInfo(
                "向",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "む(く)、むか(い)" },
                new string[] { "mu(ku)", "muka(i)" },
                new string[] { "facing", "beyond" }
            ),
            new KanjiInfo(
                "塗",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ト" },
                new string[] { "to" },
                new string[] { "ぬ(る)、 ぬ(り)" },
                new string[] { "nu(ru)", "nu(ri)" },
                new string[] { "paint; smear; coating" }
            ),
            new KanjiInfo(
                "酒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "さけ" },
                new string[] { "sake" },
                new string[] { "sake", "alcohol" }
            ),
            new KanjiInfo(
                "倍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "バイ" },
                new string[] { "bai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "double; twice; times; fold" }
            ),
            new KanjiInfo(
                "導",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "みちび(く)" },
                new string[] { "michibi(ku)" },
                new string[] { "guidance; leading; conduct; usher" }
            ),
            new KanjiInfo(
                "得",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トク" },
                new string[] { "toku" },
                new string[] { "え(る)" },
                new string[] { "e(ru)" },
                new string[] { "gain", "get", "find", "earn", "acquire", "can", "may", "able to", "profit" }
            ),
            new KanjiInfo(
                "合",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゴウ、 ガッ、 カッ" },
                new string[] { "gou", "ga", "ka" },
                new string[] { "あ(う)、あい" },
                new string[] { "a(u)", "ai" },
                new string[] { "fit", "suit", "join", "0.1" }
            ),
            new KanjiInfo(
                "罪",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザイ" },
                new string[] { "zai" },
                new string[] { "つみ" },
                new string[] { "tsumi" },
                new string[] { "guilt", "sin", "crime" }
            ),
            new KanjiInfo(
                "期",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ、 ゴ" },
                new string[] { "ki", "go" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "period", "time", "date", "term" }
            ),
            new KanjiInfo(
                "幅",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "はば" },
                new string[] { "haba" },
                new string[] { "hanging scroll; width" }
            ),
            new KanjiInfo(
                "胃",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "stomach; crop" }
            ),
            new KanjiInfo(
                "防",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "ふせ(ぐ)" },
                new string[] { "fuse(gu)" },
                new string[] { "ward off; defend; protect; resist" }
            ),
            new KanjiInfo(
                "仲",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "なか" },
                new string[] { "naka" },
                new string[] { "go-between; relationship" }
            ),
            new KanjiInfo(
                "優",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ユウ、ウ" },
                new string[] { "yuu", "u" },
                new string[] { "やさ(しい)、すぐ(れる)" },
                new string[] { "yasa(shii)", "sugu(reru)" },
                new string[] { "tenderness", "kind", "actor" }
            ),
            new KanjiInfo(
                "痛",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ツウ" },
                new string[] { "tsuu" },
                new string[] { "いた(い)" },
                new string[] { "ita(i)" },
                new string[] { "pain", "hurt", "damage", "bruise" }
            ),
            new KanjiInfo(
                "守",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュ、ス" },
                new string[] { "shu", "su" },
                new string[] { "まも(る)、もり" },
                new string[] { "mamo(ru)", "mori" },
                new string[] { "guard", "protect", "obey" }
            ),
            new KanjiInfo(
                "主",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "ぬし、 おも" },
                new string[] { "nushi", "omo" },
                new string[] { "lord", "chief", "master", "main thing", "principal" }
            ),
            new KanjiInfo(
                "私",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "わたくし、 わたし" },
                new string[] { "watakushi", "watashi" },
                new string[] { "private", "I", "me" }
            ),
            new KanjiInfo(
                "緑",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョク、 ロク" },
                new string[] { "ryoku", "roku" },
                new string[] { "みどり" },
                new string[] { "midori" },
                new string[] { "green" }
            ),
            new KanjiInfo(
                "名",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "メイ、 ミョウ" },
                new string[] { "mei", "myou" },
                new string[] { "な" },
                new string[] { "na" },
                new string[] { "name", "noted", "distinguished", "reputation" }
            ),
            new KanjiInfo(
                "想",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソウ、ソ" },
                new string[] { "sou", "so" },
                new string[] { "おも(う)" },
                new string[] { "omo(u)" },
                new string[] { "concept", "think", "idea" }
            ),
            new KanjiInfo(
                "駅",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "エキ" },
                new string[] { "eki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "station" }
            ),
            new KanjiInfo(
                "血",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケツ" },
                new string[] { "ketsu" },
                new string[] { "ち" },
                new string[] { "chi" },
                new string[] { "blood" }
            ),
            new KanjiInfo(
                "活",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カツ" },
                new string[] { "katsu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "living" }
            ),
            new KanjiInfo(
                "行",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コウ、 ギョウ、 アン" },
                new string[] { "kou", "gyou", "an" },
                new string[] { "い(く)、 ゆ(く)、 おこな(う)" },
                new string[] { "i(ku)", "yu(ku)", "okona(u)" },
                new string[] { "going", "journey", "carry out", "line", "row" }
            ),
            new KanjiInfo(
                "番",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "バン" },
                new string[] { "ban" },
                new string[] { "つが(い)" },
                new string[] { "tsugai" },
                new string[] { "turn", "number in a series" }
            ),
            new KanjiInfo(
                "踊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "おど(る)" },
                new string[] { "odo(ru)" },
                new string[] { "jump; dance; leap; skip" }
            ),
            new KanjiInfo(
                "担",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タン" },
                new string[] { "tan" },
                new string[] { "かつ(ぐ)、 にな(う)" },
                new string[] { "katsu(gu)", "nina(u)" },
                new string[] { "shouldering; carry; raise; bear" }
            ),
            new KanjiInfo(
                "恐",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "おそ(れる)、こわ(い)" },
                new string[] { "oso(reru)", "kowa(i)" },
                new string[] { "fear", "dread" }
            ),
            new KanjiInfo(
                "拝",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハイ" },
                new string[] { "hai" },
                new string[] { "おが(む)" },
                new string[] { "oga(mu)" },
                new string[] { "worship; adore; pray to" }
            ),
            new KanjiInfo(
                "勝",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "か(つ)、 まさ(る)" },
                new string[] { "ka(tsu)", "masa(ru)" },
                new string[] { "victory", "win" }
            ),
            new KanjiInfo(
                "工",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コウ、 ク、 グ" },
                new string[] { "kou", "ku", "gu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "craft", "construction" }
            ),
            new KanjiInfo(
                "汚",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オ" },
                new string[] { "o" },
                new string[] { "よご(す)、 きたな(い)、 けが(す)" },
                new string[] { "yogo(su)", "kitana(i)", "kega(su)" },
                new string[] { "dirty; pollute; disgrace; defile" }
            ),
            new KanjiInfo(
                "損",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソン" },
                new string[] { "son" },
                new string[] { "そこ(なう)" },
                new string[] { "soko(nau)" },
                new string[] { "damage; loss; disadvantage; hurt; injure" }
            ),
            new KanjiInfo(
                "送",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "おく(る)" },
                new string[] { "oku(ru)" },
                new string[] { "escort", "send" }
            ),
            new KanjiInfo(
                "官",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "bureaucrat", "the government", "organ" }
            ),
            new KanjiInfo(
                "居",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョ、コ" },
                new string[] { "kyo", "ko" },
                new string[] { "い(る)、お(る)" },
                new string[] { "i(ru)", "o(ru)" },
                new string[] { "reside", "to be", "exist" }
            ),
            new KanjiInfo(
                "岸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "きし" },
                new string[] { "kishi" },
                new string[] { "beach" }
            ),
            new KanjiInfo(
                "術",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジュツ" },
                new string[] { "jutsu" },
                new string[] { "すべ" },
                new string[] { "sube" },
                new string[] { "art", "technique", "skill", "means", "trick" }
            ),
            new KanjiInfo(
                "印",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "しるし" },
                new string[] { "shirushi" },
                new string[] { "stamp; seal; mark; symbol; trademark" }
            ),
            new KanjiInfo(
                "了",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "complete; finish" }
            ),
            new KanjiInfo(
                "重",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ジュウ、 チョウ" },
                new string[] { "juu", "chou" },
                new string[] { "おも(い)、 かさ(ねる)" },
                new string[] { "omo(i)", "kasa(neru)" },
                new string[] { "heavy", "important", "esteem", "respect" }
            ),
            new KanjiInfo(
                "町",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "まち" },
                new string[] { "machi" },
                new string[] { "town", "village", "block", "street" }
            ),
            new KanjiInfo(
                "申",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "もう(す)、さる" },
                new string[] { "mou(su)", "saru" },
                new string[] { "have the honor to" }
            ),
            new KanjiInfo(
                "毛",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "モウ" },
                new string[] { "mou" },
                new string[] { "け" },
                new string[] { "ke" },
                new string[] { "fur; hair; feather" }
            ),
            new KanjiInfo(
                "幼",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "おさな(い)" },
                new string[] { "osana(i)" },
                new string[] { "infancy; childhood" }
            ),
            new KanjiInfo(
                "最",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "もっと(も)" },
                new string[] { "motto(mo)" },
                new string[] { "utmost", "most", "extreme" }
            ),
            new KanjiInfo(
                "上",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジョウ、 ショウ、 シャン" },
                new string[] { "jou", "shou", "shan" },
                new string[] { "うえ、 うわ-、 かみ、 あ(げる)、 のぼ(る)、 たてまつ(る)" },
                new string[] { "ue", "uwa", "kami", "a(geru)", "nobo(ru)", "tatematsu(ru)" },
                new string[] { "above", "up" }
            ),
            new KanjiInfo(
                "待",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "ま(つ)" },
                new string[] { "ma(tsu)" },
                new string[] { "wait", "depend on" }
            ),
            new KanjiInfo(
                "苦",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ク" },
                new string[] { "ku" },
                new string[] { "くる(しい)、にが(い)" },
                new string[] { "kuru(shii)", "niga(i)" },
                new string[] { "suffering", "bitter" }
            ),
            new KanjiInfo(
                "許",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョ" },
                new string[] { "kyo" },
                new string[] { "ゆる(す)" },
                new string[] { "yuru(su)" },
                new string[] { "permit", "approve" }
            ),
            new KanjiInfo(
                "城",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジョウ、 セイ" },
                new string[] { "jou", "sei" },
                new string[] { "しろ" },
                new string[] { "shiro" },
                new string[] { "castle" }
            ),
            new KanjiInfo(
                "根",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コン" },
                new string[] { "kon" },
                new string[] { "ね" },
                new string[] { "ne" },
                new string[] { "root; radical" }
            ),
            new KanjiInfo(
                "筒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "つつ" },
                new string[] { "tsutsu" },
                new string[] { "cylinder; pipe; tube" }
            ),
            new KanjiInfo(
                "付",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "つ(ける)" },
                new string[] { "tsu(keru)" },
                new string[] { "adhere", "attach", "refer to", "append" }
            ),
            new KanjiInfo(
                "日",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニチ", "ジツ" },
                new string[] { "nichi", "jitsu" },
                new string[] { "ひ", "-び", "-か" },
                new string[] { "hi", "-bi", "-ka" },
                new string[] { "day", "sun", "Japan", "counter for days" }
            ),
            new KanjiInfo(
                "持",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "も(つ)" },
                new string[] { "mo(tsu)" },
                new string[] { "hold", "have" }
            ),
            new KanjiInfo(
                "者",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "もの" },
                new string[] { "mono" },
                new string[] { "someone", "person" }
            ),
            new KanjiInfo(
                "族",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ゾク" },
                new string[] { "zoku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "tribe", "family" }
            ),
            new KanjiInfo(
                "放",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "はな(す)、ほう(る)" },
                new string[] { "hana(su)", "hou(ru)" },
                new string[] { "set free", "release" }
            ),
            new KanjiInfo(
                "残",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザン" },
                new string[] { "zan" },
                new string[] { "のこ(る)" },
                new string[] { "noko(ru)" },
                new string[] { "remainder", "balance" }
            ),
            new KanjiInfo(
                "二",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニ、 ジ" },
                new string[] { "ni", "ji" },
                new string[] { "ふた(つ)" },
                new string[] { "futa(tsu)" },
                new string[] { "two", "2" }
            ),
            new KanjiInfo(
                "農",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ノウ" },
                new string[] { "nou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "agriculture; farmers" }
            ),
            new KanjiInfo(
                "秒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ビョウ" },
                new string[] { "byou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "second" }
            ),
            new KanjiInfo(
                "脳",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ノウ" },
                new string[] { "nou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "brain; memory" }
            ),
            new KanjiInfo(
                "腰",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "こし" },
                new string[] { "koshi" },
                new string[] { "loins; hips; waist" }
            ),
            new KanjiInfo(
                "千",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "ち" },
                new string[] { "chi" },
                new string[] { "thousand" }
            ),
            new KanjiInfo(
                "礼",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "レイ、ライ" },
                new string[] { "rei", "rai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "salute", "bow", "ceremony", "thanks" }
            ),
            new KanjiInfo(
                "心",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "こころ" },
                new string[] { "kokoro" },
                new string[] { "heart", "mind", "spirit" }
            ),
            new KanjiInfo(
                "秋",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "あき" },
                new string[] { "aki" },
                new string[] { "autumn", "fall" }
            ),
            new KanjiInfo(
                "交",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "まじ(わる)、 ま(ぜる)、 か(わす)" },
                new string[] { "maji(waru)", "ma(zeru)", "ka(wasu)" },
                new string[] { "mingle", "mixing", "association", "coming & going" }
            ),
            new KanjiInfo(
                "院",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "institution", "temple", "mansion", "school" }
            ),
            new KanjiInfo(
                "堂",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "public chamber", "hall" }
            ),
            new KanjiInfo(
                "緒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "お" },
                new string[] { "o" },
                new string[] { "beginning", "end", "cord", "strap" }
            ),
            new KanjiInfo(
                "米",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ベイ、 マイ、 メエトル" },
                new string[] { "bei", "mai", "meetoru" },
                new string[] { "こめ" },
                new string[] { "kome" },
                new string[] { "rice", "USA", "meter" }
            ),
            new KanjiInfo(
                "半",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "なか(ば)" },
                new string[] { "naka(ba)" },
                new string[] { "half", "middle", "odd number", "semi-" }
            ),
            new KanjiInfo(
                "破",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハ" },
                new string[] { "ha" },
                new string[] { "やぶ(る)" },
                new string[] { "yabu(ru)" },
                new string[] { "rip", "tear", "break" }
            ),
            new KanjiInfo(
                "卵",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ラン" },
                new string[] { "ran" },
                new string[] { "たまご" },
                new string[] { "tamago" },
                new string[] { "egg" }
            ),
            new KanjiInfo(
                "員",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "employee", "member", "number", "the one in charge" }
            ),
            new KanjiInfo(
                "諸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "もろ" },
                new string[] { "moro" },
                new string[] { "various; many; several; together" }
            ),
            new KanjiInfo(
                "埋",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "マイ" },
                new string[] { "mai" },
                new string[] { "う(める)" },
                new string[] { "u(meru)" },
                new string[] { "bury; be filled up; embedded" }
            ),
            new KanjiInfo(
                "掃",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "は(く)" },
                new string[] { "ha(ku)" },
                new string[] { "sweep; brush" }
            ),
            new KanjiInfo(
                "戻",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "もど(る)" },
                new string[] { "modo(ru)" },
                new string[] { "re-", "return", "revert" }
            ),
            new KanjiInfo(
                "目",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "モク、 ボク" },
                new string[] { "moku", "boku" },
                new string[] { "め" },
                new string[] { "me" },
                new string[] { "eye", "class", "look", "insight", "experience" }
            ),
            new KanjiInfo(
                "処",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "dispose", "manage", "deal with" }
            ),
            new KanjiInfo(
                "論",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ロン" },
                new string[] { "ron" },
                new string[] { "あげつら(う)" },
                new string[] { "agetsura(u)" },
                new string[] { "argument", "discourse" }
            ),
            new KanjiInfo(
                "恋",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レン" },
                new string[] { "ren" },
                new string[] { "こい(しい)" },
                new string[] { "koi(shii)" },
                new string[] { "romance; in love; yearn for; miss" }
            ),
            new KanjiInfo(
                "好",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "この(む)、 す(く)" },
                new string[] { "kono(mu)", "su(ku)" },
                new string[] { "fond", "pleasing", "like something" }
            ),
            new KanjiInfo(
                "夕",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "(none)" },
                new string[] { "" },
                new string[] { "ゆう" },
                new string[] { "yuu" },
                new string[] { "evening" }
            ),
            new KanjiInfo(
                "混",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コン" },
                new string[] { "kon" },
                new string[] { "ま(じる)" },
                new string[] { "ma(jiru)" },
                new string[] { "mix; blend; confuse" }
            ),
            new KanjiInfo(
                "非",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "あら(ず)" },
                new string[] { "ara(zu)" },
                new string[] { "un-", "mistake", "negative" }
            ),
            new KanjiInfo(
                "珍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チン" },
                new string[] { "chin" },
                new string[] { "めずら(しい)" },
                new string[] { "mezura(shii)" },
                new string[] { "rare; curious; strange" }
            ),
            new KanjiInfo(
                "料",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "fee", "materials" }
            ),
            new KanjiInfo(
                "走",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "はし(る)" },
                new string[] { "hashi(ru)" },
                new string[] { "run" }
            ),
            new KanjiInfo(
                "片",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヘン" },
                new string[] { "hen" },
                new string[] { "かた" },
                new string[] { "kata" },
                new string[] { "one-sided; piece" }
            ),
            new KanjiInfo(
                "打",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ダ" },
                new string[] { "da" },
                new string[] { "う(つ)、ぶ(つ)" },
                new string[] { "u(tsu)", "bu(tsu)" },
                new string[] { "strike", "hit", "knock" }
            ),
            new KanjiInfo(
                "抜",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "バツ" },
                new string[] { "batsu" },
                new string[] { "ぬ(く)" },
                new string[] { "nu(ku)" },
                new string[] { "slip out", "extract", "pull out", "remove" }
            ),
            new KanjiInfo(
                "夢",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ム" },
                new string[] { "mu" },
                new string[] { "ゆめ" },
                new string[] { "yume" },
                new string[] { "dream", "vision" }
            ),
            new KanjiInfo(
                "定",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "テイ、 ジョウ" },
                new string[] { "tei", "jou" },
                new string[] { "さだ(める)" },
                new string[] { "sada(meru)" },
                new string[] { "determine", "fix", "establish", "decide" }
            ),
            new KanjiInfo(
                "師",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "expert", "teacher", "master" }
            ),
            new KanjiInfo(
                "思",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "おも(う)" },
                new string[] { "omo(u)" },
                new string[] { "think" }
            ),
            new KanjiInfo(
                "品",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヒン" },
                new string[] { "hin" },
                new string[] { "しな" },
                new string[] { "shina" },
                new string[] { "goods", "refinement", "dignity", "article" }
            ),
            new KanjiInfo(
                "労",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ロウ" },
                new string[] { "rou" },
                new string[] { "ろう(する)、いたわ(る)、ねぎら(う)" },
                new string[] { "rou(suru)", "itawa(ru)", "negira(u)" },
                new string[] { "labor", "thank for" }
            ),
            new KanjiInfo(
                "荷",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "に" },
                new string[] { "ni" },
                new string[] { "baggage; load; cargo; freight" }
            ),
            new KanjiInfo(
                "柔",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジュウ、 ニュウ" },
                new string[] { "juu", "nyuu" },
                new string[] { "やわ(らかい)" },
                new string[] { "yawa(rakai)" },
                new string[] { "tender; weakness; gentleness; softness" }
            ),
            new KanjiInfo(
                "互",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "たが(い)、かたみ(に)" },
                new string[] { "taga(i)", "katami(ni)" },
                new string[] { "mutually", "reciprocally", "together" }
            ),
            new KanjiInfo(
                "続",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゾク" },
                new string[] { "zoku" },
                new string[] { "つづ(く)" },
                new string[] { "tsuzuku" },
                new string[] { "continue", "series", "sequel" }
            ),
            new KanjiInfo(
                "村",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソン" },
                new string[] { "son" },
                new string[] { "むら" },
                new string[] { "mura" },
                new string[] { "village; town" }
            ),
            new KanjiInfo(
                "賛",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "approve", "praise" }
            ),
            new KanjiInfo(
                "確",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カク" },
                new string[] { "kaku" },
                new string[] { "たし(か)" },
                new string[] { "tashi(ka)" },
                new string[] { "assurance", "firm", "confirm" }
            ),
            new KanjiInfo(
                "客",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キャク、カク" },
                new string[] { "kyaku", "kaku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "guest", "visitor", "customer" }
            ),
            new KanjiInfo(
                "窓",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "まど" },
                new string[] { "mado" },
                new string[] { "window", "pane" }
            ),
            new KanjiInfo(
                "三",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "み(つ)" },
                new string[] { "mi(tsu)" },
                new string[] { "three", "3" }
            ),
            new KanjiInfo(
                "子",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シ、 ス、 ツ" },
                new string[] { "shi", "su", "tsu" },
                new string[] { "こ、 ね" },
                new string[] { "ko", "ne" },
                new string[] { "child" }
            ),
            new KanjiInfo(
                "宅",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タク" },
                new string[] { "taku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "home", "house", "residence" }
            ),
            new KanjiInfo(
                "戸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "と" },
                new string[] { "to" },
                new string[] { "door; counter for houses" }
            ),
            new KanjiInfo(
                "吸",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "す(う)" },
                new string[] { "su(u)" },
                new string[] { "suck", "inhale" }
            ),
            new KanjiInfo(
                "昇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "のぼ(る)" },
                new string[] { "nobo(ru)" },
                new string[] { "rise up" }
            ),
            new KanjiInfo(
                "商",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "あきな(う)" },
                new string[] { "akina(u)" },
                new string[] { "deal; selling; merchant" }
            ),
            new KanjiInfo(
                "個",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "individual; counter for articles" }
            ),
            new KanjiInfo(
                "卒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソツ" },
                new string[] { "sotsu" },
                new string[] { "そっ(する)" },
                new string[] { "so(ssuru)" },
                new string[] { "graduate; soldier; private; die" }
            ),
            new KanjiInfo(
                "箱",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "はこ" },
                new string[] { "hako" },
                new string[] { "box", "chest" }
            ),
            new KanjiInfo(
                "原",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゲン" },
                new string[] { "gen" },
                new string[] { "はら" },
                new string[] { "hara" },
                new string[] { "original", "primitive", "field" }
            ),
            new KanjiInfo(
                "曇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドン" },
                new string[] { "don" },
                new string[] { "くも(る)" },
                new string[] { "kumo(ru)" },
                new string[] { "cloudy weather" }
            ),
            new KanjiInfo(
                "召",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "め(す)" },
                new string[] { "me(su)" },
                new string[] { "call; send for; wear; buy", "to eat", "to drink" }
            ),
            new KanjiInfo(
                "係",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "かか(る)、かかり" },
                new string[] { "kaka(ru)", "kakari" },
                new string[] { "person in charge", "connection" }
            ),
            new KanjiInfo(
                "幸",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "さいわ(い)、さち、 しあわ(せ)" },
                new string[] { "saiwa(i)", "sara", "shiawa(se)" },
                new string[] { "happiness", "blessing", "fortune" }
            ),
            new KanjiInfo(
                "亡",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ボウ、モウ" },
                new string[] { "bou", "mou" },
                new string[] { "な(くなる)" },
                new string[] { "na(kunaru)" },
                new string[] { "deceased", "dying" }
            ),
            new KanjiInfo(
                "規",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "standard", "measure" }
            ),
            new KanjiInfo(
                "供",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョウ、ク、クウ" },
                new string[] { "kyou", "ku", "kuu" },
                new string[] { "そな(える)、とも" },
                new string[] { "sona(eru)", "tomo" },
                new string[] { "submit", "offer", "present", "accompany" }
            ),
            new KanjiInfo(
                "岩",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ガン" },
                new string[] { "gan" },
                new string[] { "いわ" },
                new string[] { "iwa" },
                new string[] { "boulder; rock; cliff" }
            ),
            new KanjiInfo(
                "旧",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "ふる(い)、 もと" },
                new string[] { "furu(i)", "moto" },
                new string[] { "old times; old things; former; ex-" }
            ),
            new KanjiInfo(
                "読",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ドク、 トク、 トウ" },
                new string[] { "doku", "toku", "tou" },
                new string[] { "よ(む)" },
                new string[] { "yo(mu)" },
                new string[] { "to read" }
            ),
            new KanjiInfo(
                "済",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サイ、セイ" },
                new string[] { "sai", "sei" },
                new string[] { "す(む)" },
                new string[] { "su(mu)" },
                new string[] { "settle", "relieve", "finish" }
            ),
            new KanjiInfo(
                "誤",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "あやま(る)" },
                new string[] { "ayama(ru)" },
                new string[] { "mistake" }
            ),
            new KanjiInfo(
                "具",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "グ" },
                new string[] { "gu" },
                new string[] { "そな(える)、つぶさ(に)" },
                new string[] { "sona(eru)", "tsubasa(ni)" },
                new string[] { "tool", "utensil" }
            ),
            new KanjiInfo(
                "船",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "ふね、ふな" },
                new string[] { "fune", "funa" },
                new string[] { "ship", "boat" }
            ),
            new KanjiInfo(
                "胸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "むね" },
                new string[] { "mune" },
                new string[] { "bosom; breast; chest; heart; feelings" }
            ),
            new KanjiInfo(
                "件",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "くだん" },
                new string[] { "kudan" },
                new string[] { "affair", "case", "matter" }
            ),
            new KanjiInfo(
                "尊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソン" },
                new string[] { "son" },
                new string[] { "とうと(い)" },
                new string[] { "touto(i)" },
                new string[] { "revered; valuable; precious; noble" }
            ),
            new KanjiInfo(
                "畜",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チク" },
                new string[] { "chiku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "livestock; domestic fowl and animals" }
            ),
            new KanjiInfo(
                "介",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "jammed in; shellfish; mediate" }
            ),
            new KanjiInfo(
                "切",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "セツ、 サイ" },
                new string[] { "setsu", "sai" },
                new string[] { "き(る)" },
                new string[] { "ki(ru)" },
                new string[] { "cut", "cutoff", "be sharp" }
            ),
            new KanjiInfo(
                "慣",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "な(れる)" },
                new string[] { "na(reru)" },
                new string[] { "accustomed", "get used to" }
            ),
            new KanjiInfo(
                "橋",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "はし" },
                new string[] { "hashi" },
                new string[] { "bridge" }
            ),
            new KanjiInfo(
                "倒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "たお(れる)" },
                new string[] { "tao(reru)" },
                new string[] { "overthrow", "fall", "collapse" }
            ),
            new KanjiInfo(
                "払",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "" },
                new string[] { "" },
                new string[] { "はら(う)" },
                new string[] { "hara(u)" },
                new string[] { "pay" }
            ),
            new KanjiInfo(
                "貯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チョ" },
                new string[] { "cho" },
                new string[] { "た(める)" },
                new string[] { "ta(meru)" },
                new string[] { "savings; store" }
            ),
            new KanjiInfo(
                "英",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "England", "English", "hero", "outstanding" }
            ),
            new KanjiInfo(
                "皆",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "" },
                new string[] { "" },
                new string[] { "みな、 みんな" },
                new string[] { "mina", "minna" },
                new string[] { "all", "everyone", "everybody" }
            ),
            new KanjiInfo(
                "帯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "お(びる)" },
                new string[] { "o(biru)" },
                new string[] { "sash; belt; obi; zone; region" }
            ),
            new KanjiInfo(
                "伝",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "デン" },
                new string[] { "den" },
                new string[] { "つた(わる)" },
                new string[] { "tsuta(waru)" },
                new string[]
                    { "transmit", "go along", "walk along", "follow", "report", "communicate", "legend", "tradition" }
            ),
            new KanjiInfo(
                "各",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カク" },
                new string[] { "kaku" },
                new string[] { "おのおの" },
                new string[] { "onoono" },
                new string[] { "each; every; either" }
            ),
            new KanjiInfo(
                "知",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "し(る)" },
                new string[] { "shi(ru)" },
                new string[] { "know", "wisdom" }
            ),
            new KanjiInfo(
                "入",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニュウ" },
                new string[] { "nyuu" },
                new string[] { "い(る)、はい(る)" },
                new string[] { "i(ru)", "hai(ru)" },
                new string[] { "enter", "insert" }
            ),
            new KanjiInfo(
                "腕",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ワン" },
                new string[] { "wan" },
                new string[] { "うで" },
                new string[] { "ude" },
                new string[] { "arm; ability; talent" }
            ),
            new KanjiInfo(
                "場",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジョウ" },
                new string[] { "jou" },
                new string[] { "ば" },
                new string[] { "ba" },
                new string[] { "location", "place" }
            ),
            new KanjiInfo(
                "意",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "idea", "mind", "heart", "taste", "thought" }
            ),
            new KanjiInfo(
                "換",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "か(える)" },
                new string[] { "ka(eru)" },
                new string[] { "interchange; period; change; convert; replace; renew" }
            ),
            new KanjiInfo(
                "正",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "ただ(しい)、 まさ(に)" },
                new string[] { "tada(shii)", "masa(ni)" },
                new string[] { "correct", "justice", "righteous" }
            ),
            new KanjiInfo(
                "聞",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ブン、 モン" },
                new string[] { "bun", "mon" },
                new string[] { "き(く)" },
                new string[] { "ki(ku)" },
                new string[] { "to hear; to listen; to ask" }
            ),
            new KanjiInfo(
                "祈",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "いの(る)" },
                new string[] { "ino(ru)" },
                new string[] { "pray; wish" }
            ),
            new KanjiInfo(
                "効",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "き(く)" },
                new string[] { "ki(ku)" },
                new string[] { "merit; efficacy; efficiency; benefit" }
            ),
            new KanjiInfo(
                "星",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "ほし" },
                new string[] { "hoshi" },
                new string[] { "star" }
            ),
            new KanjiInfo(
                "真",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "ま、 まこと" },
                new string[] { "ma", "makoto" },
                new string[] { "true", "reality", "Buddhist sect" }
            ),
            new KanjiInfo(
                "進",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "すす(む)" },
                new string[] { "susu(mu)" },
                new string[] { "advance", "proceed" }
            ),
            new KanjiInfo(
                "友",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ユウ" },
                new string[] { "yuu" },
                new string[] { "とも" },
                new string[] { "tomo" },
                new string[] { "friend" }
            ),
            new KanjiInfo(
                "去",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キョ、 コ" },
                new string[] { "kyo", "ko" },
                new string[] { "さ(る)" },
                new string[] { "sa(ru)" },
                new string[] { "gone", "past", "quit", "leave", "elapse", "eliminate" }
            ),
            new KanjiInfo(
                "職",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショク" },
                new string[] { "shoku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "post", "employment", "work" }
            ),
            new KanjiInfo(
                "増",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "ま(す)、 ふ(える)" },
                new string[] { "ma(su)", "fu(eru)" },
                new string[] { "increase", "add" }
            ),
            new KanjiInfo(
                "婚",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コン" },
                new string[] { "kon" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "marriage" }
            ),
            new KanjiInfo(
                "練",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レン" },
                new string[] { "ren" },
                new string[] { "ね(る)" },
                new string[] { "ne(ru)" },
                new string[] { "practice", "gloss", "train", "drill", "polish", "refine" }
            ),
            new KanjiInfo(
                "水",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "スイ" },
                new string[] { "sui" },
                new string[] { "みず" },
                new string[] { "mizu" },
                new string[] { "water" }
            ),
            new KanjiInfo(
                "追",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ツイ" },
                new string[] { "tsui" },
                new string[] { "お(う)" },
                new string[] { "o(u)" },
                new string[] { "chase", "drive away" }
            ),
            new KanjiInfo(
                "照",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "て(る)" },
                new string[] { "te(ru)" },
                new string[] { "illuminate; shine; compare" }
            ),
            new KanjiInfo(
                "王",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "king", "rule" }
            ),
            new KanjiInfo(
                "毒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドク" },
                new string[] { "doku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "poison; germ; harm" }
            ),
            new KanjiInfo(
                "常",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョウ" },
                new string[] { "jou" },
                new string[] { "つね" },
                new string[] { "tsune" },
                new string[] { "usual", "ordinary", "normal" }
            ),
            new KanjiInfo(
                "形",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケイ、ギョウ" },
                new string[] { "kei", "gyou" },
                new string[] { "かた、かたち、なり" },
                new string[] { "kata", "katachi", "nari" },
                new string[] { "shape", "form", "style" }
            ),
            new KanjiInfo(
                "時",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "とき、 -どき" },
                new string[] { "toki", "doki" },
                new string[] { "time", "hour" }
            ),
            new KanjiInfo(
                "途",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ト" },
                new string[] { "to" },
                new string[] { "みち" },
                new string[] { "michi" },
                new string[] { "route", "way", "road" }
            ),
            new KanjiInfo(
                "硬",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "かた(い)" },
                new string[] { "kata(i)" },
                new string[] { "stiff; hard" }
            ),
            new KanjiInfo(
                "福",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "blessing", "fortune", "luck", "wealth" }
            ),
            new KanjiInfo(
                "類",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ルイ" },
                new string[] { "rui" },
                new string[] { "たぐ(い)" },
                new string[] { "tagu(i)" },
                new string[] { "sort", "kind", "variety", "class", "genus" }
            ),
            new KanjiInfo(
                "氏",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N1 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "うじ" },
                new string[] { "uji" },
                new string[] { "family name", "surname", "clan" }
            ),
            new KanjiInfo(
                "頭",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ、ズ、ト" },
                new string[] { "tou", "zu", "to" },
                new string[] { "あたま、かしら" },
                new string[] { "atama", "kashira" },
                new string[] { "head" }
            ),
            new KanjiInfo(
                "店",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "テン" },
                new string[] { "ten" },
                new string[] { "みせ" },
                new string[] { "mise" },
                new string[] { "store", "shop" }
            ),
            new KanjiInfo(
                "近",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キン" },
                new string[] { "kin" },
                new string[] { "ちか(い)" },
                new string[] { "chika(i)" },
                new string[] { "near", "early", "akin", "tantamount" }
            ),
            new KanjiInfo(
                "席",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セキ" },
                new string[] { "seki" },
                new string[] { "むしろ" },
                new string[] { "mushiro" },
                new string[] { "seat" }
            ),
            new KanjiInfo(
                "乗",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョウ、 ショウ" },
                new string[] { "jou", "shou" },
                new string[] { "の(る)" },
                new string[] { "no(ru)" },
                new string[] { "ride" }
            ),
            new KanjiInfo(
                "吹",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "スイ" },
                new string[] { "sui" },
                new string[] { "ふ(く)" },
                new string[] { "fu(ku)" },
                new string[] { "blow", "breathe", "puff" }
            ),
            new KanjiInfo(
                "総",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "general", "whole", "all" }
            ),
            new KanjiInfo(
                "精",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ、ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "しら(げる)" },
                new string[] { "shira(geru)" },
                new string[] { "refined", "ghost", "fairy", "energy" }
            ),
            new KanjiInfo(
                "燥",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "はしゃ(ぐ)" },
                new string[] { "hasha(gu)" },
                new string[] { "parch; dry up" }
            ),
            new KanjiInfo(
                "般",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "carrier; carry; all; general; sort; kind" }
            ),
            new KanjiInfo(
                "底",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "テイ" },
                new string[] { "tei" },
                new string[] { "そこ" },
                new string[] { "soko" },
                new string[] { "bottom; sole; depth; bottom price" }
            ),
            new KanjiInfo(
                "用",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "もち(いる)" },
                new string[] { "mochi(iru)" },
                new string[] { "utilize", "business", "service", "use", "employ" }
            ),
            new KanjiInfo(
                "簡",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "えら(ぶ)" },
                new string[] { "era(bu)" },
                new string[] { "simplicity; brevity" }
            ),
            new KanjiInfo(
                "悲",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "かな(しい)" },
                new string[] { "kana(shii)" },
                new string[] { "grieve", "sad" }
            ),
            new KanjiInfo(
                "空",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "クウ" },
                new string[] { "kuu" },
                new string[] { "そら、 から、 あ(く)、 す(く)、 むな(しい)" },
                new string[] { "sora", "kara", "a(ku)", "su(ku)", "muna(shii)" },
                new string[] { "empty", "sky", "void", "vacant", "vacuum" }
            ),
            new KanjiInfo(
                "暮",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ボ" },
                new string[] { "bo" },
                new string[] { "く(らす)" },
                new string[] { "ku(rasu)" },
                new string[] { "evening", "livelihood" }
            ),
            new KanjiInfo(
                "冊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サツ" },
                new string[] { "satsu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "counter for books; volume" }
            ),
            new KanjiInfo(
                "文",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ブン、 モン" },
                new string[] { "bun", "mon" },
                new string[] { "ふみ" },
                new string[] { "fumi" },
                new string[] { "sentence", "literature", "style", "art" }
            ),
            new KanjiInfo(
                "度",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ド、 タク" },
                new string[] { "do", "taku" },
                new string[] { "たび、 た(い)" },
                new string[] { "tabi", "ta(i)" },
                new string[] { "degrees", "occurrence", "time", "counter for occurrences" }
            ),
            new KanjiInfo(
                "幾",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "いく(つ)" },
                new string[] { "iku(tsu)" },
                new string[] { "how many", "how much", "some" }
            ),
            new KanjiInfo(
                "況",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "まし(て)" },
                new string[] { "mashi(te)" },
                new string[] { "condition; situation" }
            ),
            new KanjiInfo(
                "値",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "ね、 あたい" },
                new string[] { "ne", "atai" },
                new string[] { "price", "cost", "value" }
            ),
            new KanjiInfo(
                "情",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョウ、セイ" },
                new string[] { "jou", "sei" },
                new string[] { "なさ(け)" },
                new string[] { "nasa(ke)" },
                new string[] { "feelings", "emotion", "passion" }
            ),
            new KanjiInfo(
                "参",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "まい(る)" },
                new string[] { "mai(ru)" },
                new string[] { "going", "coming", "participate" }
            ),
            new KanjiInfo(
                "魚",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ギョ" },
                new string[] { "gyo" },
                new string[] { "うお、 さかな" },
                new string[] { "uo", "sakana" },
                new string[] { "fish" }
            ),
            new KanjiInfo(
                "置",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "お(く)" },
                new string[] { "o(ku)" },
                new string[] { "placement", "put", "set", "deposit", "leave behind" }
            ),
            new KanjiInfo(
                "拾",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "ひろ(う)" },
                new string[] { "hiro(u)" },
                new string[] { "pick up; gather; find" }
            ),
            new KanjiInfo(
                "宿",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュク" },
                new string[] { "shuku" },
                new string[] { "やど" },
                new string[] { "yado" },
                new string[] { "inn", "lodging" }
            ),
            new KanjiInfo(
                "曲",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョク" },
                new string[] { "kyoku" },
                new string[] { "ま(がる)" },
                new string[] { "ma(garu)" },
                new string[] { "bend", "music", "melody" }
            ),
            new KanjiInfo(
                "込",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "" },
                new string[] { "" },
                new string[] { "こ(む)" },
                new string[] { "ko(mu)" },
                new string[] { "crowded", "mixture" }
            ),
            new KanjiInfo(
                "元",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ゲン、 ガン" },
                new string[] { "gen", "gan" },
                new string[] { "もと" },
                new string[] { "moto" },
                new string[] { "beginning", "former time", "origin" }
            ),
            new KanjiInfo(
                "動",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "うご(く)" },
                new string[] { "ugo(ku)" },
                new string[] { "move", "motion", "change" }
            ),
            new KanjiInfo(
                "隅",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "グウ" },
                new string[] { "guu" },
                new string[] { "すみ" },
                new string[] { "sumi" },
                new string[] { "corner; nook" }
            ),
            new KanjiInfo(
                "比",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "くら(べる)" },
                new string[] { "kura(beru)" },
                new string[] { "compare; race; ratio" }
            ),
            new KanjiInfo(
                "観",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "み(る)" },
                new string[] { "mi(ru)" },
                new string[] { "outlook", "appearance", "condition" }
            ),
            new KanjiInfo(
                "虫",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チュウ、 キ" },
                new string[] { "chuu", "ki" },
                new string[] { "むし" },
                new string[] { "mushi" },
                new string[] { "insect; bug" }
            ),
            new KanjiInfo(
                "始",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "はじ(める)" },
                new string[] { "haji(meru)" },
                new string[] { "commence", "begin" }
            ),
            new KanjiInfo(
                "旅",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "リョ" },
                new string[] { "ryo" },
                new string[] { "たび" },
                new string[] { "tabi" },
                new string[] { "trip", "travel" }
            ),
            new KanjiInfo(
                "草",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "くさ" },
                new string[] { "kusa" },
                new string[] { "grass", "weeds", "herbs" }
            ),
            new KanjiInfo(
                "経",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "へ(る)、 た(つ)" },
                new string[] { "he(ru)", "ta(tsu)" },
                new string[] { "longitude", "pass thru", "expire", "warp" }
            ),
            new KanjiInfo(
                "関",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "せき、 かか(わる)" },
                new string[] { "seki", "kaka(waru)" },
                new string[] { "connection", "barrier", "gateway", "involve", "concerning" }
            ),
            new KanjiInfo(
                "然",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゼン、ネン" },
                new string[] { "zen", "nen" },
                new string[] { "しか、さ" },
                new string[] { "shika", "sa" },
                new string[] { "sort of thing", "if so" }
            ),
            new KanjiInfo(
                "島",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "しま" },
                new string[] { "shima" },
                new string[] { "island" }
            ),
            new KanjiInfo(
                "多",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "タ" },
                new string[] { "ta" },
                new string[] { "おお(い)" },
                new string[] { "oo(i)" },
                new string[] { "many", "frequent", "much" }
            ),
            new KanjiInfo(
                "版",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "printing block; edition; impression; label" }
            ),
            new KanjiInfo(
                "声",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ、ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "こえ" },
                new string[] { "koe" },
                new string[] { "voice" }
            ),
            new KanjiInfo(
                "風",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "フウ、 フ" },
                new string[] { "fuu", "fu" },
                new string[] { "かぜ、 かざ-" },
                new string[] { "kaze", "kaza-" },
                new string[] { "wind", "air", "style", "manner" }
            ),
            new KanjiInfo(
                "解",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カイ、ゲ" },
                new string[] { "kai", "ge" },
                new string[] { "と(く)、ほど(く)" },
                new string[] { "to(ku)", "hodo(ku)" },
                new string[] { "unravel", "explanation" }
            ),
            new KanjiInfo(
                "気",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "キ、 ケ" },
                new string[] { "ki", "ke" },
                new string[] { "いき" },
                new string[] { "iki" },
                new string[] { "spirit", "mind", "air", "atmosphere", "mood" }
            ),
            new KanjiInfo(
                "演",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "performance", "act", "play", "render", "stage" }
            ),
            new KanjiInfo(
                "採",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "と(る)" },
                new string[] { "to(ru)" },
                new string[] { "pick; take; fetch; take up" }
            ),
            new KanjiInfo(
                "移",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "うつ(る)" },
                new string[] { "utsu(ru)" },
                new string[] { "shift", "move", "change" }
            ),
            new KanjiInfo(
                "以",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "もっ(て)" },
                new string[] { "mo(tte)" },
                new string[] { "by means of", "because", "in view of", "compared with" }
            ),
            new KanjiInfo(
                "湯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ゆ" },
                new string[] { "yu" },
                new string[] { "hot water; bath; hot spring" }
            ),
            new KanjiInfo(
                "害",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ガイ" },
                new string[] { "gai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "harm", "injury" }
            ),
            new KanjiInfo(
                "余",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨ" },
                new string[] { "yo" },
                new string[] { "あま(る)" },
                new string[] { "ama(ru)" },
                new string[] { "too much", "surplus" }
            ),
            new KanjiInfo(
                "和",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ワ、オ" },
                new string[] { "wa", "o" },
                new string[] { "やわ(らぐ)、なご(む)" },
                new string[] { "yawa(ragu)", "nago(mu)" },
                new string[] { "harmony", "Japanese style", "peace" }
            ),
            new KanjiInfo(
                "速",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "はや(い)" },
                new string[] { "haya(i)" },
                new string[] { "quick", "fast" }
            ),
            new KanjiInfo(
                "鉄",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "テツ" },
                new string[] { "tetsu" },
                new string[] { "くろがね" },
                new string[] { "kurogane" },
                new string[] { "iron" }
            ),
            new KanjiInfo(
                "巻",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "ま(く)、 まき" },
                new string[] { "ma(ku)", "maki" },
                new string[]
                    { "scroll; volume; book; part; roll up; wind up; coil; counter for texts (or book scrolls)" }
            ),
            new KanjiInfo(
                "贈",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "おく(る)" },
                new string[] { "oku(ru)" },
                new string[] { "presents; send; give to; award to" }
            ),
            new KanjiInfo(
                "市",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "いち" },
                new string[] { "ichi" },
                new string[] { "market", "city", "town" }
            ),
            new KanjiInfo(
                "安",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "アン" },
                new string[] { "an" },
                new string[] { "やす(い)" },
                new string[] { "yasu(i)" },
                new string[] { "safe", "peaceful", "cheap" }
            ),
            new KanjiInfo(
                "柱",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "はしら" },
                new string[] { "hashira" },
                new string[] { "pillar; post; cylinder; support" }
            ),
            new KanjiInfo(
                "袋",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "ふくろ" },
                new string[] { "fukuro" },
                new string[] { "sack; bag; pouch" }
            ),
            new KanjiInfo(
                "努",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ド" },
                new string[] { "do" },
                new string[] { "つと(める)" },
                new string[] { "tsuto(meru)" },
                new string[] { "toil", "diligent", "as much as possible" }
            ),
            new KanjiInfo(
                "第",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ダイ" },
                new string[] { "dai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "No.", "number" }
            ),
            new KanjiInfo(
                "女",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ジョ" },
                new string[] { "jo" },
                new string[] { "おんな、 め" },
                new string[] { "onnna", "me" },
                new string[] { "woman", "female" }
            ),
            new KanjiInfo(
                "階",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "stair; counter for building story" }
            ),
            new KanjiInfo(
                "沈",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チン、 ジン" },
                new string[] { "chin", "jin" },
                new string[] { "しず(む)" },
                new string[] { "shizu(mu)" },
                new string[] { "sink; be submerged; subside; be depressed" }
            ),
            new KanjiInfo(
                "不",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "フ、 ブ" },
                new string[] { "fu", "bu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "negative", "non-", "bad" }
            ),
            new KanjiInfo(
                "宝",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "たから" },
                new string[] { "takara" },
                new string[] { "treasure; wealth; valuables" }
            ),
            new KanjiInfo(
                "映",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "うつ(る)、 は(える)" },
                new string[] { "utsu(ru)", "ha(eru)" },
                new string[] { "reflect", "reflection", "projection" }
            ),
            new KanjiInfo(
                "静",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ、ジョウ" },
                new string[] { "sei", "jou" },
                new string[] { "しず(か)" },
                new string[] { "shizu(ka)" },
                new string[] { "quiet" }
            ),
            new KanjiInfo(
                "弱",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジャク" },
                new string[] { "jaku" },
                new string[] { "よわ(い)" },
                new string[] { "yowa(i)" },
                new string[] { "weak; frail" }
            ),
            new KanjiInfo(
                "単",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "タン" },
                new string[] { "tan" },
                new string[] { "ひとえ" },
                new string[] { "hitoe" },
                new string[] { "simple", "single" }
            ),
            new KanjiInfo(
                "州",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "す" },
                new string[] { "su" },
                new string[] { "state; province" }
            ),
            new KanjiInfo(
                "祝",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シュク" },
                new string[] { "shuku" },
                new string[] { "いわ(う)" },
                new string[] { "iwa(u)" },
                new string[] { "celebrate; congratulate" }
            ),
            new KanjiInfo(
                "税",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゼイ" },
                new string[] { "zei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "tax; duty" }
            ),
            new KanjiInfo(
                "宇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ウ" },
                new string[] { "u" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "eaves; roof; house; heaven" }
            ),
            new KanjiInfo(
                "干",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "ほ(す)、 ひ(る)" },
                new string[] { "ho(su)", "hi(ru)" },
                new string[] { "dry; parch" }
            ),
            new KanjiInfo(
                "海",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "うみ" },
                new string[] { "umi" },
                new string[] { "sea", "ocean" }
            ),
            new KanjiInfo(
                "母",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ボ" },
                new string[] { "bo" },
                new string[] { "はは、 かあ" },
                new string[] { "haha", "kaa" },
                new string[] { "mother" }
            ),
            new KanjiInfo(
                "羽",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ウ" },
                new string[] { "u" },
                new string[] { "は、 わ、 はね" },
                new string[] { "ha", "wa", "hane" },
                new string[] { "feathers; counter for birds", "rabbits" }
            ),
            new KanjiInfo(
                "液",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エキ" },
                new string[] { "eki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "fluid; liquid; juice; sap; secretion" }
            ),
            new KanjiInfo(
                "資",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "assets", "resources", "capital", "funds", "data", "be conducive to" }
            ),
            new KanjiInfo(
                "利",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "リ" },
                new string[] { "ri" },
                new string[] { "き(く)" },
                new string[] { "ki(ku)" },
                new string[] { "profit", "advantage", "benefit" }
            ),
            new KanjiInfo(
                "突",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トツ、カ" },
                new string[] { "totsu", "ka" },
                new string[] { "つ(く)" },
                new string[] { "tsu(ku)" },
                new string[] { "stab", "protruding", "thrust" }
            ),
            new KanjiInfo(
                "訓",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "クン" },
                new string[] { "kun" },
                new string[] { "よ(む)、くん(ずる)" },
                new string[] { "yo(mu)", "kun(zuru)" },
                new string[] { "instruction", "explanation", "read" }
            ),
            new KanjiInfo(
                "復",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "また" },
                new string[] { "mata" },
                new string[] { "restore", "return to", "revert" }
            ),
            new KanjiInfo(
                "百",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ヒャク、 ビャク" },
                new string[] { "hyaku", "byaku" },
                new string[] { "もも" },
                new string[] { "momo" },
                new string[] { "hundred" }
            ),
            new KanjiInfo(
                "険",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "けわ(しい)" },
                new string[] { "kewa(shii)" },
                new string[] { "precipitous", "inaccessible place" }
            ),
            new KanjiInfo(
                "涙",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ルイ" },
                new string[] { "rui" },
                new string[] { "なみだ" },
                new string[] { "namida" },
                new string[] { "tears; sympathy" }
            ),
            new KanjiInfo(
                "陸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リク、 ロク" },
                new string[] { "riku", "roku" },
                new string[] { "おか" },
                new string[] { "oka" },
                new string[] { "land; six" }
            ),
            new KanjiInfo(
                "浮",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "う(かぶ)" },
                new string[] { "u(kabu)" },
                new string[] { "float", "rise to surface" }
            ),
            new KanjiInfo(
                "事",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "こと" },
                new string[] { "koto" },
                new string[] { "matter", "thing", "fact", "business", "reason", "possibly" }
            ),
            new KanjiInfo(
                "並",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヘイ" },
                new string[] { "hei" },
                new string[] { "な(み)、なみ、なら(べる)" },
                new string[] { "na(mi)", "nami", "nara(beru)" },
                new string[] { "row", "and", "besides" }
            ),
            new KanjiInfo(
                "産",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "う(む)、 む(す)" },
                new string[] { "u(mu)", "mu(su)" },
                new string[] { "products", "bear", "give birth" }
            ),
            new KanjiInfo(
                "才",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "genius", "years old" }
            ),
            new KanjiInfo(
                "山",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "サン、 セン" },
                new string[] { "san", "sen" },
                new string[] { "やま" },
                new string[] { "yama" },
                new string[] { "mountain" }
            ),
            new KanjiInfo(
                "谷",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "たに、 きわ(まる)" },
                new string[] { "tani", "kiwa(maru)" },
                new string[] { "valley" }
            ),
            new KanjiInfo(
                "河",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "かわ" },
                new string[] { "kawa" },
                new string[] { "river" }
            ),
            new KanjiInfo(
                "短",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タン" },
                new string[] { "tan" },
                new string[] { "みじか(い)" },
                new string[] { "mijika(i)" },
                new string[] { "short; fault; defect; weak point" }
            ),
            new KanjiInfo(
                "耕",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "たがや(す)" },
                new string[] { "tagaya(su)" },
                new string[] { "till; plow; cultivate" }
            ),
            new KanjiInfo(
                "画",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ガ、 カク" },
                new string[] { "ga", "kaku" },
                new string[] { "かく(する)" },
                new string[] { "kaku(suru)" },
                new string[] { "brush-stroke", "picture" }
            ),
            new KanjiInfo(
                "粉",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フン" },
                new string[] { "fun" },
                new string[] { "こな" },
                new string[] { "kona" },
                new string[] { "flour; powder; dust" }
            ),
            new KanjiInfo(
                "役",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヤク、エキ" },
                new string[] { "yaku", "eki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "duty", "service", "role" }
            ),
            new KanjiInfo(
                "敗",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハイ" },
                new string[] { "hai" },
                new string[] { "やぶ(れる)" },
                new string[] { "yabu(reru)" },
                new string[] { "failure", "defeat" }
            ),
            new KanjiInfo(
                "挟",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "はさ(む)" },
                new string[] { "hasa(mu)" },
                new string[] { "pinch; between" }
            ),
            new KanjiInfo(
                "六",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ロク" },
                new string[] { "roku" },
                new string[] { "む(つ)、 むい" },
                new string[] { "mu(tsu)", "mui" },
                new string[] { "six", "6" }
            ),
            new KanjiInfo(
                "使",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "つか(う)" },
                new string[] { "tsuka(u)" },
                new string[] { "use", "order", "messenger", "ambassador" }
            ),
            new KanjiInfo(
                "坊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ、 ボッ" },
                new string[] { "bou", "bo" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "boy", "priest" }
            ),
            new KanjiInfo(
                "純",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジュン" },
                new string[] { "jun" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "genuine; purity; innocence" }
            ),
            new KanjiInfo(
                "後",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゴ、 コウ" },
                new string[] { "go", "kou" },
                new string[] { "のち、 うし(ろ)、 あと" },
                new string[] { "nochi", "ushi(ro)", "ato" },
                new string[] { "behind", "back", "later" }
            ),
            new KanjiInfo(
                "所",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "ところ" },
                new string[] { "tokoro" },
                new string[] { "place", "extent" }
            ),
            new KanjiInfo(
                "汗",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "あせ" },
                new string[] { "ase" },
                new string[] { "sweat; perspire" }
            ),
            new KanjiInfo(
                "茶",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チャ、 サ" },
                new string[] { "cha", "sa" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "tea" }
            ),
            new KanjiInfo(
                "浅",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "あさ(い)" },
                new string[] { "asa(i)" },
                new string[] { "shallow; superficial; frivolous" }
            ),
            new KanjiInfo(
                "大",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ダイ、 タイ" },
                new string[] { "dai", "tai" },
                new string[] { "おお(きい)" },
                new string[] { "oo(kii)" },
                new string[] { "large", "big" }
            ),
            new KanjiInfo(
                "転",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "テン" },
                new string[] { "ten" },
                new string[] { "ころ(がる)" },
                new string[] { "koro(garu)" },
                new string[] { "revolve", "turn around", "change" }
            ),
            new KanjiInfo(
                "共",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "とも" },
                new string[] { "tomo" },
                new string[] { "together", "both", "neither" }
            ),
            new KanjiInfo(
                "直",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チョク、 ジキ" },
                new string[] { "choku", "jiki" },
                new string[] { "ただ(ちに)、 す(ぐ)" },
                new string[] { "tada(chini)", "su(gu)" },
                new string[] { "straightaway", "honesty", "frankness", "fix", "repair" }
            ),
            new KanjiInfo(
                "浴",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨク" },
                new string[] { "yoku" },
                new string[] { "あ(びる)" },
                new string[] { "a(biru)" },
                new string[] { "bathe; be favored with; bask in" }
            ),
            new KanjiInfo(
                "群",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "グン" },
                new string[] { "gun" },
                new string[] { "む(れる)、 むら(がる)" },
                new string[] { "mu(reru)", "mura(garu)" },
                new string[] { "flock; group; crowd; herd" }
            ),
            new KanjiInfo(
                "殺",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サツ、サイ" },
                new string[] { "satsu", "sai" },
                new string[] { "ころ(す)" },
                new string[] { "koro(su)" },
                new string[] { "kill", "murder" }
            ),
            new KanjiInfo(
                "触",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショク" },
                new string[] { "shoku" },
                new string[] { "ふ(れる)、 さわ(る)" },
                new string[] { "fu(reru)", "sawa(ru)" },
                new string[] { "contact; touch; feel; hit; proclaim; announce" }
            ),
            new KanjiInfo(
                "姉",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "あね" },
                new string[] { "ane" },
                new string[] { "elder sister" }
            ),
            new KanjiInfo(
                "働",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "はたら(く)" },
                new string[] { "hatara(ku)" },
                new string[] { "work" }
            ),
            new KanjiInfo(
                "横",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "よこ" },
                new string[] { "yoko" },
                new string[] { "sideways", "side" }
            ),
            new KanjiInfo(
                "書",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "か(く)" },
                new string[] { "kaku" },
                new string[] { "write" }
            ),
            new KanjiInfo(
                "白",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ハク、 ビャク" },
                new string[] { "haku", "byaku" },
                new string[] { "しろ(い)" },
                new string[] { "shiro(i)" },
                new string[] { "white" }
            ),
            new KanjiInfo(
                "調",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "しら(べる)、ととの(う)" },
                new string[] { "shira(beru)", "tono(u)" },
                new string[] { "tune", "tone", "meter", "prepare", "investigate" }
            ),
            new KanjiInfo(
                "述",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ジュツ" },
                new string[] { "jutsu" },
                new string[] { "の(べる)" },
                new string[] { "no(beru)" },
                new string[] { "mention; state; speak" }
            ),
            new KanjiInfo(
                "菓",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "candy; cakes; fruit" }
            ),
            new KanjiInfo(
                "販",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "marketing", "sell", "trade" }
            ),
            new KanjiInfo(
                "伺",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "うかが(う)" },
                new string[] { "ukaga(u)" },
                new string[] { "visit; ask; inquire; question" }
            ),
            new KanjiInfo(
                "制",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "system", "law", "rule" }
            ),
            new KanjiInfo(
                "札",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サツ" },
                new string[] { "satsu" },
                new string[] { "ふだ" },
                new string[] { "fuda" },
                new string[] { "ticket; paper money; banknote; note" }
            ),
            new KanjiInfo(
                "詰",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キツ" },
                new string[] { "kitsu" },
                new string[] { "つ(める)" },
                new string[] { "tsu(meru)" },
                new string[] { "packed; close; rebuke; blame" }
            ),
            new KanjiInfo(
                "怒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ド" },
                new string[] { "do" },
                new string[] { "いか(る)、 おこ(る)" },
                new string[] { "ika(ru)", "oko(ru)" },
                new string[] { "angry", "be offended" }
            ),
            new KanjiInfo(
                "求",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "もと(める)" },
                new string[] { "moto(meru)" },
                new string[] { "request", "want", "demand" }
            ),
            new KanjiInfo(
                "寒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "さむ(い)" },
                new string[] { "samu(i)" },
                new string[] { "cold" }
            ),
            new KanjiInfo(
                "長",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "なが(い)、 おさ" },
                new string[] { "naga(i)", "osa" },
                new string[] { "long", "leader", "superior", "senior" }
            ),
            new KanjiInfo(
                "試",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "こころ(みる)、 ため(す)" },
                new string[] { "kokoro(miru)", "tame(su)" },
                new string[] { "test", "try", "attempt", "experiment" }
            ),
            new KanjiInfo(
                "散",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "ち(る)、ばら(ける)" },
                new string[] { "chi(ru)", "bara(keru)" },
                new string[] { "scatter", "disperse" }
            ),
            new KanjiInfo(
                "争",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "あらそ(う)" },
                new string[] { "araso(u)" },
                new string[] { "contend", "dispute", "argue" }
            ),
            new KanjiInfo(
                "塩",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "しお" },
                new string[] { "shio" },
                new string[] { "salt" }
            ),
            new KanjiInfo(
                "臓",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゾウ" },
                new string[] { "zou" },
                new string[] { "はらわた" },
                new string[] { "harawata" },
                new string[] { "entrails; viscera; bowels" }
            ),
            new KanjiInfo(
                "味",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ミ" },
                new string[] { "mi" },
                new string[] { "あじ" },
                new string[] { "aji" },
                new string[] { "flavor", "taste" }
            ),
            new KanjiInfo(
                "方",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "かた" },
                new string[] { "kata" },
                new string[] { "direction", "person", "alternative" }
            ),
            new KanjiInfo(
                "民",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ミン" },
                new string[] { "min" },
                new string[] { "たみ" },
                new string[] { "tami" },
                new string[] { "people", "nation", "subjects" }
            ),
            new KanjiInfo(
                "果",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "は(たす)" },
                new string[] { "ha(tasu)" },
                new string[] { "fruit", "reward", "carry out", "achieve", "complete" }
            ),
            new KanjiInfo(
                "権",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "authority", "power", "rights" }
            ),
            new KanjiInfo(
                "測",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "はか(る)" },
                new string[] { "haka(ru)" },
                new string[] { "fathom; plan; scheme; measure" }
            ),
            new KanjiInfo(
                "則",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "のっと(る)" },
                new string[] { "notto(ru)" },
                new string[] { "rule; follow; based on" }
            ),
            new KanjiInfo(
                "枝",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "えだ" },
                new string[] { "eda" },
                new string[] { "bough; branch; twig; limb; counter for branches" }
            ),
            new KanjiInfo(
                "缶",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "かま" },
                new string[] { "kama" },
                new string[] { "tin can; container" }
            ),
            new KanjiInfo(
                "娘",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョウ" },
                new string[] { "jou" },
                new string[] { "むすめ、こ" },
                new string[] { "musume", "ko" },
                new string[] { "daughter", "girl" }
            ),
            new KanjiInfo(
                "清",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "きよ(い)" },
                new string[] { "kiyo(i)" },
                new string[] { "pure; purify; cleanse" }
            ),
            new KanjiInfo(
                "遠",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エン" },
                new string[] { "en", "on" },
                new string[] { "とお(い)" },
                new string[] { "too(i)" },
                new string[] { "distant", "far" }
            ),
            new KanjiInfo(
                "点",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "テン" },
                new string[] { "ten" },
                new string[] { "つ(ける)" },
                new string[] { "tsu(keru)" },
                new string[] { "spot", "point", "mark" }
            ),
            new KanjiInfo(
                "勤",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キン、ゴン" },
                new string[] { "kin", "gon" },
                new string[] { "つと(める)" },
                new string[] { "tsuto(meru)" },
                new string[] { "diligence", "employed", "serve" }
            ),
            new KanjiInfo(
                "磨",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "マ" },
                new string[] { "ma" },
                new string[] { "みが(く)" },
                new string[] { "miga(ku)" },
                new string[] { "grind; polish; improve; brush (teeth)" }
            ),
            new KanjiInfo(
                "状",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジョウ" },
                new string[] { "jou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "conditions", "form", "appearance" }
            ),
            new KanjiInfo(
                "震",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "ふる(う)" },
                new string[] { "furu(u)" },
                new string[] { "quake; shake; tremble; quiver" }
            ),
            new KanjiInfo(
                "議",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ギ" },
                new string[] { "gi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "deliberation", "consultation", "debate" }
            ),
            new KanjiInfo(
                "双",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ" },
                new string[] { "sou" },
                new string[] { "ふた" },
                new string[] { "futa" },
                new string[] { "pair; set; comparison; counter for pairs" }
            ),
            new KanjiInfo(
                "領",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リョウ" },
                new string[] { "ryou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "jurisdiction", "dominion" }
            ),
            new KanjiInfo(
                "左",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "サ、 シャ" },
                new string[] { "sa", "sha" },
                new string[] { "ひだり" },
                new string[] { "hidari" },
                new string[] { "left" }
            ),
            new KanjiInfo(
                "体",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "からだ" },
                new string[] { "karada" },
                new string[] { "body", "substance", "object", "reality" }
            ),
            new KanjiInfo(
                "医",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "doctor", "medicine" }
            ),
            new KanjiInfo(
                "青",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "あお(い)" },
                new string[] { "ao(i)" },
                new string[] { "blue" }
            ),
            new KanjiInfo(
                "加",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "くわ(える)" },
                new string[] { "kuwa(eru)" },
                new string[] { "add", "addition", "increase", "join" }
            ),
            new KanjiInfo(
                "内",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ナイ" },
                new string[] { "nai" },
                new string[] { "うち" },
                new string[] { "uchi" },
                new string[] { "inside", "within", "between", "among", "house", "home" }
            ),
            new KanjiInfo(
                "四",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "よ(つ)、 よん" },
                new string[] { "yo(tsu)", "yon" },
                new string[] { "four", "4" }
            ),
            new KanjiInfo(
                "能",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ノウ" },
                new string[] { "nou" },
                new string[] { "あた(う)" },
                new string[] { "ata(u)" },
                new string[] { "ability", "talent", "skill", "capacity" }
            ),
            new KanjiInfo(
                "否",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "いな、いや" },
                new string[] { "ina", "iya" },
                new string[] { "negate", "no", "decline" }
            ),
            new KanjiInfo(
                "愛",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "アイ" },
                new string[] { "ai" },
                new string[] { "いと(しい)、まな" },
                new string[] { "ito(shii)", "mana" },
                new string[] { "love", "affection" }
            ),
            new KanjiInfo(
                "頂",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "いただ(く)" },
                new string[] { "itada(ku)" },
                new string[] { "receive", "top", "summit", "peak" }
            ),
            new KanjiInfo(
                "軍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "グン" },
                new string[] { "gun" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "army", "force", "troops" }
            ),
            new KanjiInfo(
                "暴",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ、 バク" },
                new string[] { "bou", "baku" },
                new string[] { "あば(く)" },
                new string[] { "aba(ku)" },
                new string[] { "outburst; force; violence" }
            ),
            new KanjiInfo(
                "替",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "か(わる)" },
                new string[] { "ka(waru)" },
                new string[] { "exchange", "spare", "substitute" }
            ),
            new KanjiInfo(
                "乾",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "かわ(く)" },
                new string[] { "kawa(ku)" },
                new string[] { "drought; dry; drink up; heaven" }
            ),
            new KanjiInfo(
                "銅",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "あかがね" },
                new string[] { "akagane" },
                new string[] { "copper" }
            ),
            new KanjiInfo(
                "辞",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "や(める)" },
                new string[] { "ya(meru)" },
                new string[] { "resign", "word", "term" }
            ),
            new KanjiInfo(
                "歯",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "は" },
                new string[] { "ha" },
                new string[] { "tooth", "cog" }
            ),
            new KanjiInfo(
                "数",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "スウ" },
                new string[] { "suu" },
                new string[] { "かず、 かぞ(える)" },
                new string[] { "kazu", "kazo(eru)" },
                new string[] { "number", "strength", "fate", "law", "figures" }
            ),
            new KanjiInfo(
                "技",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ギ" },
                new string[] { "gi" },
                new string[] { "わざ" },
                new string[] { "waza" },
                new string[] { "skill; art; craft; ability; vocation; arts" }
            ),
            new KanjiInfo(
                "売",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "バイ" },
                new string[] { "bai" },
                new string[] { "う(る)" },
                new string[] { "u(ru)" },
                new string[] { "sell" }
            ),
            new KanjiInfo(
                "次",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ、シ" },
                new string[] { "ji", "shi" },
                new string[] { "つ(ぐ)、つぎ" },
                new string[] { "tsu(gu)", "tsugi" },
                new string[] { "next", "order" }
            ),
            new KanjiInfo(
                "投",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "な(げる)" },
                new string[] { "na(geru)" },
                new string[] { "throw", "discard" }
            ),
            new KanjiInfo(
                "犯",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "おか(す)" },
                new string[] { "oka(su)" },
                new string[] { "crime", "sin", "offense" }
            ),
            new KanjiInfo(
                "祭",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "まつり" },
                new string[] { "matsuri" },
                new string[] { "ritual; offer prayers; celebrate" }
            ),
            new KanjiInfo(
                "雲",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ウン" },
                new string[] { "un" },
                new string[] { "くも" },
                new string[] { "kumo" },
                new string[] { "cloud" }
            ),
            new KanjiInfo(
                "奥",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "おく" },
                new string[] { "oku" },
                new string[] { "heart; interior" }
            ),
            new KanjiInfo(
                "衣",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ、 エ" },
                new string[] { "i", "e" },
                new string[] { "ころも、 きぬ" },
                new string[] { "koromo", "kinu" },
                new string[] { "garment; clothes; dressing" }
            ),
            new KanjiInfo(
                "歌",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "うた、 うた(う)" },
                new string[] { "uta", "uta(u)" },
                new string[] { "song", "sing" }
            ),
            new KanjiInfo(
                "石",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セキ、シャク、コク" },
                new string[] { "seki", "shaku", "koku" },
                new string[] { "いし" },
                new string[] { "ishi" },
                new string[] { "stone" }
            ),
            new KanjiInfo(
                "頼",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ライ" },
                new string[] { "rai" },
                new string[] { "たの(む)、 たよ(る)" },
                new string[] { "tano(mu)", "tayo(ru)" },
                new string[] { "trust", "request" }
            ),
            new KanjiInfo(
                "判",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハン" },
                new string[] { "han" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "judgement", "signature" }
            ),
            new KanjiInfo(
                "接",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セツ" },
                new string[] { "setsu" },
                new string[] { "つ(ぐ)" },
                new string[] { "tsu(gu)" },
                new string[] { "touch; contact; adjoin; piece together" }
            ),
            new KanjiInfo(
                "濃",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ノウ" },
                new string[] { "nou" },
                new string[] { "こ(い)" },
                new string[] { "ko(i)" },
                new string[] { "concentrated; thick; dark; undiluted" }
            ),
            new KanjiInfo(
                "問",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "モン" },
                new string[] { "mon" },
                new string[] { "と(う)" },
                new string[] { "to(u)" },
                new string[] { "question", "ask", "problem" }
            ),
            new KanjiInfo(
                "芸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゲイ" },
                new string[] { "gei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "technique; art; craft; performance; acting" }
            ),
            new KanjiInfo(
                "林",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リン" },
                new string[] { "rin" },
                new string[] { "はやし" },
                new string[] { "hayashi" },
                new string[] { "grove; forest" }
            ),
            new KanjiInfo(
                "約",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ヤク" },
                new string[] { "yaku" },
                new string[] { "つづ(まる)" },
                new string[] { "tsuzu(maru)" },
                new string[] { "promise", "approximately", "shrink" }
            ),
            new KanjiInfo(
                "雑",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザツ、ゾウ" },
                new string[] { "zatsu", "zou" },
                new string[] { "まじ(る)" },
                new string[] { "maji(ru)" },
                new string[] { "miscellaneous" }
            ),
            new KanjiInfo(
                "組",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソ" },
                new string[] { "so" },
                new string[] { "く(む)、くみ" },
                new string[] { "ku(mu)", "kumi" },
                new string[] { "association", "assemble", "unite" }
            ),
            new KanjiInfo(
                "屋",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "オク" },
                new string[] { "oku" },
                new string[] { "や" },
                new string[] { "ya" },
                new string[] { "roof", "house", "shop", "dealer", "seller" }
            ),
            new KanjiInfo(
                "公",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "public", "prince", "official", "governmental" }
            ),
            new KanjiInfo(
                "家",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "いえ、 や、 うち" },
                new string[] { "ie", "ya", "uchi" },
                new string[] { "house", "home", "family", "professional", "expert" }
            ),
            new KanjiInfo(
                "池",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "いけ" },
                new string[] { "ike" },
                new string[] { "pond; pool; reservoir" }
            ),
            new KanjiInfo(
                "実",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ジツ" },
                new string[] { "jitsu" },
                new string[] { "み、みの(る)" },
                new string[] { "mi", "mino(ru)" },
                new string[] { "reality", "truth" }
            ),
            new KanjiInfo(
                "夏",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カ、 ゲ" },
                new string[] { "ka", "ge" },
                new string[] { "なつ" },
                new string[] { "natsu" },
                new string[] { "summer" }
            ),
            new KanjiInfo(
                "初",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショ" },
                new string[] { "sho" },
                new string[] { "はじ(め)、はつ" },
                new string[] { "haji(me)", "hatsu" },
                new string[] { "first time", "beginning" }
            ),
            new KanjiInfo(
                "何",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "なに、 なん" },
                new string[] { "nani", "nan" },
                new string[] { "what" }
            ),
            new KanjiInfo(
                "盗",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ぬす(む)" },
                new string[] { "nusu(mu)" },
                new string[] { "steal", "rob" }
            ),
            new KanjiInfo(
                "昼",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "ひる" },
                new string[] { "hiru" },
                new string[] { "daytime", "noon" }
            ),
            new KanjiInfo(
                "学",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ガク" },
                new string[] { "gaku" },
                new string[] { "まな(ぶ)" },
                new string[] { "mana(bu)" },
                new string[] { "study", "learning", "science" }
            ),
            new KanjiInfo(
                "田",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "デン" },
                new string[] { "den" },
                new string[] { "た" },
                new string[] { "ta" },
                new string[] { "rice field", "rice paddy" }
            ),
            new KanjiInfo(
                "神",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン、 ジン" },
                new string[] { "shin", "jin" },
                new string[] { "かみ" },
                new string[] { "kami" },
                new string[] { "gods", "mind", "soul" }
            ),
            new KanjiInfo(
                "天",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "テン" },
                new string[] { "ten" },
                new string[] { "あまつ" },
                new string[] { "amatsu" },
                new string[] { "heavens", "sky", "imperial" }
            ),
            new KanjiInfo(
                "偉",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "えら(い)" },
                new string[] { "era(i)" },
                new string[] { "admirable", "greatness" }
            ),
            new KanjiInfo(
                "欧",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "オウ" },
                new string[] { "ou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "Europe" }
            ),
            new KanjiInfo(
                "火",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "カ" },
                new string[] { "ka" },
                new string[] { "ひ、 -び、 ほ-" },
                new string[] { "hi", "bi", "ho" },
                new string[] { "fire" }
            ),
            new KanjiInfo(
                "境",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "さかい" },
                new string[] { "sakai" },
                new string[] { "boundary", "border", "region" }
            ),
            new KanjiInfo(
                "粒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リュウ" },
                new string[] { "ryuu" },
                new string[] { "つぶ" },
                new string[] { "tsubu" },
                new string[] { "grains; drop; counter for tiny particles" }
            ),
            new KanjiInfo(
                "欲",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨク" },
                new string[] { "yoku" },
                new string[] { "ほ(しい)" },
                new string[] { "ho(shii)" },
                new string[] { "longing", "greed", "passion" }
            ),
            new KanjiInfo(
                "勉",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ベン" },
                new string[] { "ben" },
                new string[] { "つと(める)" },
                new string[] { "tsuto(meru)" },
                new string[] { "exertion", "endeavor", "effort" }
            ),
            new KanjiInfo(
                "膚",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "はだ" },
                new string[] { "hada" },
                new string[] { "skin; body; texture" }
            ),
            new KanjiInfo(
                "道",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "みち" },
                new string[] { "michi" },
                new string[] { "road-way", "street", "district", "journey", "course" }
            ),
            new KanjiInfo(
                "政",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "まつりごと" },
                new string[] { "matsurigoto" },
                new string[] { "politics", "government" }
            ),
            new KanjiInfo(
                "返",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヘン" },
                new string[] { "hen" },
                new string[] { "かえ(す)" },
                new string[] { "kae(su)" },
                new string[] { "return", "answer" }
            ),
            new KanjiInfo(
                "老",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ロウ" },
                new string[] { "rou" },
                new string[] { "お(いる)、ふ(ける)" },
                new string[] { "o(iru)", "fu(keru)" },
                new string[] { "old" }
            ),
            new KanjiInfo(
                "極",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョク、 ゴク" },
                new string[] { "kyoku", "goku" },
                new string[] { "きわ(める)" },
                new string[] { "kiwa(meru)" },
                new string[] { "poles; settlement; conclusion; end" }
            ),
            new KanjiInfo(
                "取",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "と(る)" },
                new string[] { "to(ru)" },
                new string[] { "take", "fetch" }
            ),
            new KanjiInfo(
                "冬",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ふゆ" },
                new string[] { "fuyu" },
                new string[] { "winter" }
            ),
            new KanjiInfo(
                "習",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "なら(う)" },
                new string[] { "nara(u)" },
                new string[] { "learn" }
            ),
            new KanjiInfo(
                "材",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ザイ" },
                new string[] { "zai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "lumber", "log", "timber", "wood" }
            ),
            new KanjiInfo(
                "川",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "かわ" },
                new string[] { "kawa" },
                new string[] { "river", "stream" }
            ),
            new KanjiInfo(
                "若",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジャク" },
                new string[] { "jaku" },
                new string[] { "わか(い)、も(し)" },
                new string[] { "waka(i)", "mo(shi)" },
                new string[] { "young" }
            ),
            new KanjiInfo(
                "先",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "さき、 ま(ず)" },
                new string[] { "saki", "ma(zu)" },
                new string[] { "before", "ahead", "previous", "future", "precedence" }
            ),
            new KanjiInfo(
                "棒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "rod; stick; cane; pole" }
            ),
            new KanjiInfo(
                "報",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "むく(いる)" },
                new string[] { "mukku(iru)" },
                new string[] { "report", "news", "reward" }
            ),
            new KanjiInfo(
                "本",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ホン" },
                new string[] { "hon" },
                new string[] { "もと" },
                new string[] { "moto" },
                new string[] { "book", "present", "true", "counter for long cylindrical things" }
            ),
            new KanjiInfo(
                "越",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エツ" },
                new string[] { "etsu" },
                new string[] { "こ(す)" },
                new string[] { "ko(su)" },
                new string[] { "surpass", "cross over", "move to", "exceed" }
            ),
            new KanjiInfo(
                "象",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ、 ゾウ" },
                new string[] { "shou", "zou" },
                new string[] { "かたど(る)" },
                new string[] { "katado(ru)" },
                new string[] { "elephant; pattern after; image; shape" }
            ),
            new KanjiInfo(
                "溶",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "と(ける)" },
                new string[] { "to(keru)" },
                new string[] { "melt; dissolve; thaw" }
            ),
            new KanjiInfo(
                "脂",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "あぶら" },
                new string[] { "abura" },
                new string[] { "fat; grease; lard" }
            ),
            new KanjiInfo(
                "閉",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヘイ" },
                new string[] { "hei" },
                new string[] { "と(じる)、し(める)" },
                new string[] { "to(jiru)", "shi(meru)" },
                new string[] { "closed", "shut" }
            ),
            new KanjiInfo(
                "究",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キュウ" },
                new string[] { "kyuu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "research", "study" }
            ),
            new KanjiInfo(
                "玉",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ギョク" },
                new string[] { "gyoku" },
                new string[] { "たま" },
                new string[] { "tama" },
                new string[] { "jewel; ball" }
            ),
            new KanjiInfo(
                "普",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "あまね(く)" },
                new string[] { "amane(ku)" },
                new string[] { "universal; generally" }
            ),
            new KanjiInfo(
                "超",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "こ(える)" },
                new string[] { "ko(eru)" },
                new string[] { "transcend; super-; ultra-" }
            ),
            new KanjiInfo(
                "肩",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "かた" },
                new string[] { "kata" },
                new string[] { "shoulder" }
            ),
            new KanjiInfo(
                "府",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "borough", "urban prefecture", "govt office" }
            ),
            new KanjiInfo(
                "角",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カク" },
                new string[] { "kaku" },
                new string[] { "かど、 つの" },
                new string[] { "kado", "tsuno" },
                new string[] { "angle; corner; square" }
            ),
            new KanjiInfo(
                "路",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ロ、ル" },
                new string[] { "ro", "ru" },
                new string[] { "みち" },
                new string[] { "michi" },
                new string[] { "path", "route", "road" }
            ),
            new KanjiInfo(
                "貿",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ボウ" },
                new string[] { "bou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "trade; exchange" }
            ),
            new KanjiInfo(
                "麦",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "バク" },
                new string[] { "baku" },
                new string[] { "むぎ" },
                new string[] { "mugi" },
                new string[] { "barley; wheat" }
            ),
            new KanjiInfo(
                "均",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キン" },
                new string[] { "kin" },
                new string[] { "なら(す)" },
                new string[] { "nara(su)" },
                new string[] { "level; average" }
            ),
            new KanjiInfo(
                "塔",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "pagoda; tower; steeple" }
            ),
            new KanjiInfo(
                "枯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "か(れる)" },
                new string[] { "ka(reru)" },
                new string[] { "wither; die; dry up; be seasoned" }
            ),
            new KanjiInfo(
                "候",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "そうろう" },
                new string[] { "sourou" },
                new string[] { "climate", "season", "weather" }
            ),
            new KanjiInfo(
                "伸",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "の(びる)" },
                new string[] { "no(biru)" },
                new string[] { "expand; stretch; extend" }
            ),
            new KanjiInfo(
                "暗",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "アン" },
                new string[] { "an" },
                new string[] { "くら(い)" },
                new string[] { "kura(i)" },
                new string[] { "darkness", "disappear", "shade", "informal" }
            ),
            new KanjiInfo(
                "表",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ヒョウ" },
                new string[] { "hyou" },
                new string[] { "おもて、 あらわ(す)" },
                new string[] { "omote", "arawa(su)" },
                new string[] { "surface", "table", "chart", "diagram" }
            ),
            new KanjiInfo(
                "鈍",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドン" },
                new string[] { "don" },
                new string[] { "にぶ(い)、 なまく(ら)" },
                new string[] { "nibu(i)", "namaku(ra)" },
                new string[] { "dull; slow; foolish; blunt" }
            ),
            new KanjiInfo(
                "竹",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "チク" },
                new string[] { "chiku" },
                new string[] { "たけ" },
                new string[] { "take" },
                new string[] { "bamboo" }
            ),
            new KanjiInfo(
                "東",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ひがし" },
                new string[] { "higashi" },
                new string[] { "east" }
            ),
            new KanjiInfo(
                "忙",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ボウ、モウ" },
                new string[] { "bou", "mou" },
                new string[] { "いそが(しい)" },
                new string[] { "isoga(shii)" },
                new string[] { "busy", "occupied" }
            ),
            new KanjiInfo(
                "違",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "ちが(う)、たが(う)" },
                new string[] { "chiga(u)", "taga(u)" },
                new string[] { "difference", "differ" }
            ),
            new KanjiInfo(
                "陽",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "ひ" },
                new string[] { "hi" },
                new string[] { "sunshine", "positive" }
            ),
            new KanjiInfo(
                "軒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "のき" },
                new string[] { "noki" },
                new string[] { "flats; counter for houses" }
            ),
            new KanjiInfo(
                "査",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サ" },
                new string[] { "sa" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "investigate" }
            ),
            new KanjiInfo(
                "側",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "がわ、そば" },
                new string[] { "gawa", "soba" },
                new string[] { "side", "lean", "oppose" }
            ),
            new KanjiInfo(
                "鋭",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エイ" },
                new string[] { "ei" },
                new string[] { "するど(い)" },
                new string[] { "surudo(i)" },
                new string[] { "pointed; sharpness; edge; weapon; sharp; violent" }
            ),
            new KanjiInfo(
                "革",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カク" },
                new string[] { "kaku" },
                new string[] { "かわ" },
                new string[] { "kawa" },
                new string[] { "leather; skin; reform; become serious" }
            ),
            new KanjiInfo(
                "様",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "さま、さん" },
                new string[] { "sama", "san" },
                new string[] { "manner", "situation", "polite suffix" }
            ),
            new KanjiInfo(
                "指",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "ゆび、さ(す)" },
                new string[] { "yubi", "sa(su)" },
                new string[] { "finger", "point to", "indicate" }
            ),
            new KanjiInfo(
                "歳",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サイ、セイ" },
                new string[] { "sai", "sei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "age", "year-end" }
            ),
            new KanjiInfo(
                "親",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "おや、 した(しい)" },
                new string[] { "oya", "shita(shii)" },
                new string[] { "parent", "intimacy", "relative", "familiarity" }
            ),
            new KanjiInfo(
                "綿",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "メン" },
                new string[] { "men" },
                new string[] { "わた" },
                new string[] { "wata" },
                new string[] { "cotton" }
            ),
            new KanjiInfo(
                "足",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "あし、 た(りる)" },
                new string[] { "ashi", "ta(riru)" },
                new string[] { "leg", "foot", "be sufficient" }
            ),
            new KanjiInfo(
                "昔",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セキ、シャク" },
                new string[] { "seki", "shaku" },
                new string[] { "むかし" },
                new string[] { "mukashi" },
                new string[] { "once upon a time", "old times" }
            ),
            new KanjiInfo(
                "感",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "emotion", "feeling", "sensation" }
            ),
            new KanjiInfo(
                "似",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ、ね" },
                new string[] { "ji", "ne" },
                new string[] { "に(る)" },
                new string[] { "ni(ru)" },
                new string[] { "becoming", "resemble", "imitate" }
            ),
            new KanjiInfo(
                "雇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "やと(う)" },
                new string[] { "yato(u)" },
                new string[] { "employ; hire" }
            ),
            new KanjiInfo(
                "招",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "まね(く)" },
                new string[] { "mane(ku)" },
                new string[] { "invite", "summon", "engage" }
            ),
            new KanjiInfo(
                "回",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "まわ(す)" },
                new string[] { "mawa(su)" },
                new string[] { "-times", "round", "revolve", "counter" }
            ),
            new KanjiInfo(
                "折",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セツ、シャク" },
                new string[] { "setsu", "shaku" },
                new string[] { "お(る)、おり" },
                new string[] { "o(ru)", "ori" },
                new string[] { "fold", "break", "fracture" }
            ),
            new KanjiInfo(
                "劇",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ゲキ" },
                new string[] { "geki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "drama; play" }
            ),
            new KanjiInfo(
                "徒",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ト" },
                new string[] { "to" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "on foot", "junior" }
            ),
            new KanjiInfo(
                "理",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リ" },
                new string[] { "ri" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "logic", "arrangement", "reason", "justice", "truth" }
            ),
            new KanjiInfo(
                "考",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "かんが(える)" },
                new string[] { "kanga(eru)" },
                new string[] { "consider", "think over" }
            ),
            new KanjiInfo(
                "電",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "デン" },
                new string[] { "den" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "electricity; electric powered" }
            ),
            new KanjiInfo(
                "少",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "すく(ない)、 すこ(し)" },
                new string[] { "suku(nai)", "suko(shi)" },
                new string[] { "few", "little" }
            ),
            new KanjiInfo(
                "父",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "フ" },
                new string[] { "fu" },
                new string[] { "ちち、 とう" },
                new string[] { "chichi", "tou" },
                new string[] { "father" }
            ),
            new KanjiInfo(
                "引",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "ひ(く)" },
                new string[] { "hi(ku)" },
                new string[] { "pull", "tug", "jerk" }
            ),
            new KanjiInfo(
                "鳴",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "メイ" },
                new string[] { "mei" },
                new string[] { "な(る)" },
                new string[] { "na(ru)" },
                new string[] { "chirp", "cry", "bark" }
            ),
            new KanjiInfo(
                "固",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "かた(める)" },
                new string[] { "kata(meru)" },
                new string[] { "harden; set; clot; curdle" }
            ),
            new KanjiInfo(
                "発",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ハツ、 ホツ" },
                new string[] { "hatsu", "hotsu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "departure", "discharge", "emit", "start from" }
            ),
            new KanjiInfo(
                "専",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "もっぱ(ら)" },
                new string[] { "moppa(ra)" },
                new string[] { "specialty; exclusive; mainly; solely" }
            ),
            new KanjiInfo(
                "都",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ト、ツ" },
                new string[] { "to", "tsu" },
                new string[] { "みやこ" },
                new string[] { "miyako" },
                new string[] { "metropolis", "capital" }
            ),
            new KanjiInfo(
                "泉",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "いずみ" },
                new string[] { "izumi" },
                new string[] { "spring; fountain" }
            ),
            new KanjiInfo(
                "香",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ、 キョウ" },
                new string[] { "kou", "kyou" },
                new string[] { "かお(り)" },
                new string[] { "kao(ri)" },
                new string[] { "incense; smell; perfume" }
            ),
            new KanjiInfo(
                "囲",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "かこ(む)" },
                new string[] { "kako(mu)" },
                new string[] { "surround; enclosure; preserve; keep" }
            ),
            new KanjiInfo(
                "将",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "まさ(に)、 はた" },
                new string[] { "masa(ni)", "hata" },
                new string[] { "leader; commander; general; admiral" }
            ),
            new KanjiInfo(
                "患",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "わずら(う)" },
                new string[] { "wazura(u)" },
                new string[] { "afflicted; disease; suffer from; be ill" }
            ),
            new KanjiInfo(
                "警",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "admonish", "commandment" }
            ),
            new KanjiInfo(
                "構",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "かま(う)" },
                new string[] { "kama(u)" },
                new string[] { "posture", "build", "pretend" }
            ),
            new KanjiInfo(
                "党",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "party", "faction", "clique" }
            ),
            new KanjiInfo(
                "業",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ギョウ" },
                new string[] { "gyou" },
                new string[] { "わざ" },
                new string[] { "waza" },
                new string[] { "business", "vocation", "arts", "performance" }
            ),
            new KanjiInfo(
                "紹",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "introduce; inherit; help" }
            ),
            new KanjiInfo(
                "小",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "ちい(さい)、 こ-、 お-、 さ-" },
                new string[] { "chii(sai)", "ko-", "o-", "sa-" },
                new string[] { "little", "small" }
            ),
            new KanjiInfo(
                "曜",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "weekday" }
            ),
            new KanjiInfo(
                "補",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ホ" },
                new string[] { "ho" },
                new string[] { "おぎな(う)" },
                new string[] { "ogina(u)" },
                new string[] { "supplement; supply; offset; compensate" }
            ),
            new KanjiInfo(
                "延",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "の(びる)" },
                new string[] { "no(biru)" },
                new string[] { "prolong; stretching" }
            ),
            new KanjiInfo(
                "式",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シキ" },
                new string[] { "shiki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "style", "ceremony" }
            ),
            new KanjiInfo(
                "運",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ウン" },
                new string[] { "un" },
                new string[] { "はこ(ぶ)" },
                new string[] { "hako(bu)" },
                new string[] { "carry", "luck", "destiny", "fate", "transport" }
            ),
            new KanjiInfo(
                "肯",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "がえんじ(る)" },
                new string[] { "gaenji(ru)" },
                new string[] { "agreement; consent; comply with" }
            ),
            new KanjiInfo(
                "十",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジュウ" },
                new string[] { "juu" },
                new string[] { "とお、 と" },
                new string[] { "tou", "to" },
                new string[] { "ten", "10" }
            ),
            new KanjiInfo(
                "建",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ケン、 コン" },
                new string[] { "ken", "kon" },
                new string[] { "た(てる)" },
                new string[] { "ta(teru)" },
                new string[] { "build" }
            ),
            new KanjiInfo(
                "来",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ライ、 タイ" },
                new string[] { "rai", "tai" },
                new string[] { "く.る、 きた.る、 き、 こ" },
                new string[] { "kuru", "kitaru", "ki", "ko" },
                new string[] { "come", "due", "next", "cause", "become" }
            ),
            new KanjiInfo(
                "富",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "フ、フウ" },
                new string[] { "fu", "fuu" },
                new string[] { "と(む)、 とみ" },
                new string[] { "to(mu)", "tomi" },
                new string[] { "wealth", "enrich", "abundant" }
            ),
            new KanjiInfo(
                "選",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "えら(ぶ)" },
                new string[] { "era(bu)" },
                new string[] { "elect", "select", "choose", "prefer" }
            ),
            new KanjiInfo(
                "的",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "テキ" },
                new string[] { "teki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "mark", "target", "object", "adjective ending" }
            ),
            new KanjiInfo(
                "位",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "くらい、 ぐらい" },
                new string[] { "kurai", "gurai" },
                new string[] { "rank", "grade", "about" }
            ),
            new KanjiInfo(
                "敬",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "うやま(う)" },
                new string[] { "uyama(u)" },
                new string[] { "awe; respect; honor; revere" }
            ),
            new KanjiInfo(
                "研",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "と(ぐ)" },
                new string[] { "to(gu)" },
                new string[] { "polish", "study of", "sharpen" }
            ),
            new KanjiInfo(
                "買",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "バイ" },
                new string[] { "bai" },
                new string[] { "か(う)" },
                new string[] { "ka(u)" },
                new string[] { "buy" }
            ),
            new KanjiInfo(
                "競",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キョウ、 ケイ" },
                new string[] { "kyou", "kei" },
                new string[] { "きそ(う)、 せ(る)" },
                new string[] { "kiso(u)", "se(ru)" },
                new string[] { "compete with; bid; contest; race" }
            ),
            new KanjiInfo(
                "差",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サ" },
                new string[] { "sa" },
                new string[] { "さ(す)" },
                new string[] { "sa(su)" },
                new string[] { "distinction", "difference", "variation" }
            ),
            new KanjiInfo(
                "筆",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒツ" },
                new string[] { "hitsu" },
                new string[] { "ふで" },
                new string[] { "fude" },
                new string[] { "writing brush; writing; painting brush; handwriting" }
            ),
            new KanjiInfo(
                "限",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゲン" },
                new string[] { "gen" },
                new string[] { "かぎ(る)" },
                new string[] { "kagi(ru)" },
                new string[] { "limit", "restrict" }
            ),
            new KanjiInfo(
                "背",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ハイ" },
                new string[] { "hai" },
                new string[] { "せ、せい" },
                new string[] { "se", "sei" },
                new string[] { "stature", "height", "back" }
            ),
            new KanjiInfo(
                "自",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジ、 シ" },
                new string[] { "ji", "shi" },
                new string[] { "みずか(ら)" },
                new string[] { "mizuka(ra)" },
                new string[] { "oneself" }
            ),
            new KanjiInfo(
                "祖",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソ" },
                new string[] { "so" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ancestor", "pioneer", "founder" }
            ),
            new KanjiInfo(
                "刊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "publish; carve; engrave" }
            ),
            new KanjiInfo(
                "古",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "コ" },
                new string[] { "ko" },
                new string[] { "ふる(い)" },
                new string[] { "furu(i)" },
                new string[] { "old" }
            ),
            new KanjiInfo(
                "通",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ツウ" },
                new string[] { "tsuu" },
                new string[] { "とお(る)、かよ(う)" },
                new string[] { "too(ru)", "kayo(u)" },
                new string[] { "traffic", "pass through", "avenue", "commute" }
            ),
            new KanjiInfo(
                "色",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ショク、 シキ" },
                new string[] { "shoku", "shiki" },
                new string[] { "いろ" },
                new string[] { "iro" },
                new string[] { "color" }
            ),
            new KanjiInfo(
                "彼",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒ" },
                new string[] { "hi" },
                new string[] { "かれ、 かの" },
                new string[] { "kare", "kano" },
                new string[] { "he", "him" }
            ),
            new KanjiInfo(
                "受",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジュ" },
                new string[] { "ju" },
                new string[] { "う(ける)" },
                new string[] { "u(keru)" },
                new string[] { "accept", "undergo", "answer (phone)", "take" }
            ),
            new KanjiInfo(
                "室",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シツ" },
                new string[] { "shitsu" },
                new string[] { "むろ" },
                new string[] { "muro" },
                new string[] { "room", "apartment", "chamber", "greenhouse", "cellar" }
            ),
            new KanjiInfo(
                "洋",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ヨウ" },
                new string[] { "you" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ocean", "sea", "foreign", "Western style" }
            ),
            new KanjiInfo(
                "服",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "フク" },
                new string[] { "fuku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "clothing", "admit", "obey" }
            ),
            new KanjiInfo(
                "平",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヘイ、ビョウ" },
                new string[] { "hei", "byou" },
                new string[] { "たい(ら)、ひら" },
                new string[] { "tai(ra)", "hira" },
                new string[] { "even", "flat", "peace" }
            ),
            new KanjiInfo(
                "育",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "イク" },
                new string[] { "iku" },
                new string[] { "そだ(つ)、はぐく(む)" },
                new string[] { "soda(tsu)", "haguku(mu)" },
                new string[] { "bring up", "grow up", "raise" }
            ),
            new KanjiInfo(
                "新",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "あたら(しい)、 あら(た)" },
                new string[] { "atara(shii)", "ara(ta)" },
                new string[] { "new" }
            ),
            new KanjiInfo(
                "告",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "つ(げる)" },
                new string[] { "tsu(geru)" },
                new string[] { "revelation", "inform" }
            ),
            new KanjiInfo(
                "装",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソウ、 ショウ" },
                new string[] { "sou", "shou" },
                new string[] { "よそお(う)" },
                new string[] { "yosoo(u)" },
                new string[] { "attire; dress; pretend; disguise" }
            ),
            new KanjiInfo(
                "説",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セツ、 ゼイ" },
                new string[] { "setsu", "zei" },
                new string[] { "と(く)" },
                new string[] { "to(ku)" },
                new string[] { "opinion", "theory", "explanation" }
            ),
            new KanjiInfo(
                "仏",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ブツ" },
                new string[] { "butsu" },
                new string[] { "ほとけ" },
                new string[] { "hotoke" },
                new string[] { "Buddha; the dead" }
            ),
            new KanjiInfo(
                "童",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "わらべ" },
                new string[] { "warabe" },
                new string[] { "juvenile; child" }
            ),
            new KanjiInfo(
                "型",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "かた" },
                new string[] { "kata" },
                new string[] { "type; model" }
            ),
            new KanjiInfo(
                "律",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リツ、 リチ" },
                new string[] { "ritsu", "richi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "rhythm; law; regulation; control" }
            ),
            new KanjiInfo(
                "捨",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "す(てる)" },
                new string[] { "su(teru)" },
                new string[] { "discard; throw away; abandon" }
            ),
            new KanjiInfo(
                "答",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "こた(える)" },
                new string[] { "kota(eru)" },
                new string[] { "solution", "answer" }
            ),
            new KanjiInfo(
                "登",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ、ト" },
                new string[] { "tou", "to" },
                new string[] { "のぼ(る)、あ(がる)" },
                new string[] { "nobo(ru)", "a(garu)" },
                new string[] { "ascend", "climb up" }
            ),
            new KanjiInfo(
                "低",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "テイ" },
                new string[] { "tei" },
                new string[] { "ひく(い)" },
                new string[] { "hiku(i)" },
                new string[] { "lower; short; humble" }
            ),
            new KanjiInfo(
                "語",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "かた(る)" },
                new string[] { "kata(ru)" },
                new string[] { "word", "speech", "language" }
            ),
            new KanjiInfo(
                "収",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "おさ(める)" },
                new string[] { "osa(meru)" },
                new string[] { "income", "obtain", "reap", "pay", "supply", "store" }
            ),
            new KanjiInfo(
                "号",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ゴウ" },
                new string[] { "gou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "number", "item" }
            ),
            new KanjiInfo(
                "写",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "うつ(る)" },
                new string[] { "utsuru" },
                new string[] { "copy", "be photographed", "describe" }
            ),
            new KanjiInfo(
                "人",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジン、 ニン" },
                new string[] { "jin", "nin" },
                new string[] { "ひと" },
                new string[] { "hito" },
                new string[] { "person" }
            ),
            new KanjiInfo(
                "仕",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "attend", "doing", "official", "serve" }
            ),
            new KanjiInfo(
                "雨",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ウ" },
                new string[] { "u" },
                new string[] { "あめ、 あま" },
                new string[] { "ame", "ama" },
                new string[] { "rain" }
            ),
            new KanjiInfo(
                "周",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シュウ" },
                new string[] { "shuu" },
                new string[] { "まわ(り)" },
                new string[] { "mawa(ri)" },
                new string[] { "circumference; circuit; lap" }
            ),
            new KanjiInfo(
                "砂",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サ、 シャ" },
                new string[] { "sa", "sha" },
                new string[] { "すな" },
                new string[] { "suna" },
                new string[] { "sand" }
            ),
            new KanjiInfo(
                "滴",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "テキ" },
                new string[] { "teki" },
                new string[] { "しずく、 したた(る)" },
                new string[] { "shizuku", "shitata(ru)" },
                new string[] { "drip; drop" }
            ),
            new KanjiInfo(
                "骨",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コツ" },
                new string[] { "kotsu" },
                new string[] { "ほね" },
                new string[] { "hone" },
                new string[] { "skeleton; bone; remains; frame" }
            ),
            new KanjiInfo(
                "列",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "レツ、レ" },
                new string[] { "retsu", "re" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "file", "row", "column" }
            ),
            new KanjiInfo(
                "着",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "チャク" },
                new string[] { "chaku" },
                new string[] { "き(る)、つ(く)" },
                new string[] { "ki(ru)", "tsu(ku)" },
                new string[] { "arrive", "wear", "counter for suits of clothing" }
            ),
            new KanjiInfo(
                "寄",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "よ(る)" },
                new string[] { "yo(ru)" },
                new string[] { "draw near", "gather" }
            ),
            new KanjiInfo(
                "備",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ビ" },
                new string[] { "bi" },
                new string[] { "そな(える)" },
                new string[] { "sona(eru)" },
                new string[] { "equip", "provision", "preparation" }
            ),
            new KanjiInfo(
                "遊",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ユウ" },
                new string[] { "yuu" },
                new string[] { "あそ(ぶ)" },
                new string[] { "aso(bu)" },
                new string[] { "play" }
            ),
            new KanjiInfo(
                "支",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "ささ(える)" },
                new string[] { "sasa(eru)" },
                new string[] { "branch", "support", "sustain" }
            ),
            new KanjiInfo(
                "束",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ソク" },
                new string[] { "soku" },
                new string[] { "たば、つか" },
                new string[] { "taba", "tsuka" },
                new string[] { "bundle", "manage" }
            ),
            new KanjiInfo(
                "団",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ダン、トン" },
                new string[] { "dan", "ton" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "group", "association" }
            ),
            new KanjiInfo(
                "恥",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "チ" },
                new string[] { "chi" },
                new string[] { "はじ、は(ずかしい)" },
                new string[] { "haji", "ha(zukashii)" },
                new string[] { "shame", "dishonor" }
            ),
            new KanjiInfo(
                "外",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ガイ、 ゲ" },
                new string[] { "gai", "ge" },
                new string[] { "そと、 ほか、 はず(す)、 と-" },
                new string[] { "soto", "hoka", "hazu-", "to-" },
                new string[] { "outside" }
            ),
            new KanjiInfo(
                "必",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ヒツ" },
                new string[] { "hitsu" },
                new string[] { "かなら(ず)" },
                new string[] { "kanara(zu)" },
                new string[] { "invariably", "certain", "inevitable" }
            ),
            new KanjiInfo(
                "久",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キュウ、 ク" },
                new string[] { "kyuu", "ku" },
                new string[] { "ひさ(しい)" },
                new string[] { "hisa(shii)" },
                new string[] { "long time; old story" }
            ),
            new KanjiInfo(
                "言",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ゲン、 ゴン" },
                new string[] { "gen", "gon" },
                new string[] { "い（う）、 こと" },
                new string[] { "i(u)", "koto" },
                new string[] { "say", "word" }
            ),
            new KanjiInfo(
                "傾",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "かたむ(く)" },
                new string[] { "katamu(ku)" },
                new string[] { "lean; incline; tilt; trend; bias" }
            ),
            new KanjiInfo(
                "喜",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "よろこ(ぶ)" },
                new string[] { "yoroko(bu)" },
                new string[] { "rejoice", "take pleasure in" }
            ),
            new KanjiInfo(
                "泊",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ハク" },
                new string[] { "haku" },
                new string[] { "と(まる)" },
                new string[] { "to(maru)" },
                new string[] { "overnight stay" }
            ),
            new KanjiInfo(
                "話",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ワ" },
                new string[] { "wa" },
                new string[] { "はな(す)、 はなし" },
                new string[] { "hana(su)", "hanashi" },
                new string[] { "tale", "talk" }
            ),
            new KanjiInfo(
                "種",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "たね、-ぐさ" },
                new string[] { "tane", "-gusa" },
                new string[] { "species", "kind", "class", "seed" }
            ),
            new KanjiInfo(
                "漢",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "China" }
            ),
            new KanjiInfo(
                "迷",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "メイ" },
                new string[] { "mei" },
                new string[] { "まよ(う)" },
                new string[] { "mayo(u)" },
                new string[] { "astray", "be perplexed", "in doubt", "lost" }
            ),
            new KanjiInfo(
                "機",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "キ" },
                new string[] { "ki" },
                new string[] { "はた" },
                new string[] { "hata" },
                new string[] { "machine", "airplane", "opportunity" }
            ),
            new KanjiInfo(
                "快",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "こころよ(い)" },
                new string[] { "kokoroyo(i)" },
                new string[] { "cheerful; pleasant; agreeable; comfortable" }
            ),
            new KanjiInfo(
                "刺",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "さ(す)、 さし、 とげ" },
                new string[] { "sa(su)", "toge" },
                new string[] { "thorn", "pierce", "stab", "prick", "sting" }
            ),
            new KanjiInfo(
                "晴",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "は(れる)" },
                new string[] { "ha(reru)" },
                new string[] { "clear up" }
            ),
            new KanjiInfo(
                "喫",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "キツ" },
                new string[] { "kitsu" },
                new string[] { "の(む)" },
                new string[] { "no(mu)" },
                new string[] { "consume", "eat", "drink", "smoke", "receive" }
            ),
            new KanjiInfo(
                "氷",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヒョウ" },
                new string[] { "hyou" },
                new string[] { "こおり、 ひ" },
                new string[] { "koori", "hi" },
                new string[] { "ice; hail; freeze" }
            ),
            new KanjiInfo(
                "前",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゼン" },
                new string[] { "zen" },
                new string[] { "まえ" },
                new string[] { "mae" },
                new string[] { "in front", "before" }
            ),
            new KanjiInfo(
                "示",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ジ、シ" },
                new string[] { "ji", "shi" },
                new string[] { "しめ(す)" },
                new string[] { "shime(su)" },
                new string[] { "show", "indicate", "display" }
            ),
            new KanjiInfo(
                "乱",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ラン" },
                new string[] { "ran" },
                new string[] { "みだ(れる)" },
                new string[] { "mida(reru)" },
                new string[] { "riot; war; disorder; disturb" }
            ),
            new KanjiInfo(
                "代",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ダイ" },
                new string[] { "dai" },
                new string[] { "か(わり)" },
                new string[] { "ka(wari)" },
                new string[] { "substitute", "change", "convert", "replace", "period" }
            ),
            new KanjiInfo(
                "君",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "クン" },
                new string[] { "kun" },
                new string[] { "きみ" },
                new string[] { "kimi" },
                new string[] { "you", "male name suffix" }
            ),
            new KanjiInfo(
                "停",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "テイ" },
                new string[] { "tei" },
                new string[] { "と(める)" },
                new string[] { "to(meru)" },
                new string[] { "halt; stopping" }
            ),
            new KanjiInfo(
                "貝",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "バイ" },
                new string[] { "bai" },
                new string[] { "かい" },
                new string[] { "kai" },
                new string[] { "shellfish" }
            ),
            new KanjiInfo(
                "信",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "faith", "truth", "trust" }
            ),
            new KanjiInfo(
                "等",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ひと(しい)、など" },
                new string[] { "hito(shii)", "nado" },
                new string[] { "etc.", "and so forth" }
            ),
            new KanjiInfo(
                "賢",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "かしこ(い)" },
                new string[] { "kashiko(i)" },
                new string[] { "intelligent; wise; wisdom; cleverness" }
            ),
            new KanjiInfo(
                "教",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "キョウ" },
                new string[] { "kyou" },
                new string[] { "おし(える)、 おそ(わる)" },
                new string[] { "oshi(eru)", "oso(waru)" },
                new string[] { "teach", "faith", "doctrine" }
            ),
            new KanjiInfo(
                "国",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "くに" },
                new string[] { "kuni" },
                new string[] { "country" }
            ),
            new KanjiInfo(
                "在",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザイ" },
                new string[] { "zai" },
                new string[] { "あ(る)" },
                new string[] { "a(ru)" },
                new string[] { "exist", "outskirts" }
            ),
            new KanjiInfo(
                "賞",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ショウ" },
                new string[] { "shou" },
                new string[] { "ほ(める)" },
                new string[] { "ho(meru)" },
                new string[] { "prize; reward; praise" }
            ),
            new KanjiInfo(
                "寝",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "ね(る)" },
                new string[] { "ne(ru)" },
                new string[] { "lie down", "sleep", "rest" }
            ),
            new KanjiInfo(
                "妻",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "つま" },
                new string[] { "tsuma" },
                new string[] { "wife", "spouse" }
            ),
            new KanjiInfo(
                "皿",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ベイ" },
                new string[] { "bei" },
                new string[] { "さら、 ざら" },
                new string[] { "sara", "zara" },
                new string[] { "dish; a helping; plate" }
            ),
            new KanjiInfo(
                "零",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "レイ" },
                new string[] { "rei" },
                new string[] { "ぜろ" },
                new string[] { "zero" },
                new string[] { "zero; spill; overflow; nothing" }
            ),
            new KanjiInfo(
                "留",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "リュウ、 ル" },
                new string[] { "ryuu", "ru" },
                new string[] { "と(まる)、 とど(める)" },
                new string[] { "to(maru)", "todo(meru)" },
                new string[] { "detain", "fasten", "halt", "stop" }
            ),
            new KanjiInfo(
                "一",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "イチ" },
                new string[] { "ichi" },
                new string[] { "ひと(つ)" },
                new string[] { "hito(tsu)" },
                new string[] { "one" }
            ),
            new KanjiInfo(
                "策",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サク" },
                new string[] { "saku" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "scheme", "plan", "policy" }
            ),
            new KanjiInfo(
                "七",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "シチ" },
                new string[] { "shichi" },
                new string[] { "なな(つ)、 なの" },
                new string[] { "nana(tsu)", "nano" },
                new string[] { "seven", "7" }
            ),
            new KanjiInfo(
                "爆",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "バク" },
                new string[] { "baku" },
                new string[] { "は(ぜる)" },
                new string[] { "ha(zeru)" },
                new string[] { "bomb; burst open" }
            ),
            new KanjiInfo(
                "略",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "リャク" },
                new string[] { "ryaku" },
                new string[] { "ほぼ" },
                new string[] { "hobo" },
                new string[] { "abbreviation; omission; outline; shorten" }
            ),
            new KanjiInfo(
                "預",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ヨ" },
                new string[] { "yo" },
                new string[] { "あず(ける)" },
                new string[] { "azu(keru)" },
                new string[] { "deposit; custody; leave with; entrust to" }
            ),
            new KanjiInfo(
                "勢",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "いきお(い)" },
                new string[] { "ikio(i)" },
                new string[] { "forces; energy; military strength" }
            ),
            new KanjiInfo(
                "題",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ダイ" },
                new string[] { "dai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "topic", "subject" }
            ),
            new KanjiInfo(
                "易",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "エキ、 イ" },
                new string[] { "eki", "i" },
                new string[] { "やさ(しい)、 やす(い)" },
                new string[] { "yasa(shii)", "yasu(i)" },
                new string[] { "easy", "ready to", "simple" }
            ),
            new KanjiInfo(
                "庭",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "テイ" },
                new string[] { "tei" },
                new string[] { "にわ" },
                new string[] { "niwa" },
                new string[] { "courtyard", "garden", "yard" }
            ),
            new KanjiInfo(
                "算",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "そろ" },
                new string[] { "soro" },
                new string[] { "calculate; divining; number; probability" }
            ),
            new KanjiInfo(
                "鉱",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "あらがね" },
                new string[] { "aragane" },
                new string[] { "mineral; ore" }
            ),
            new KanjiInfo(
                "楽",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ガク、 ラク" },
                new string[] { "gaku", "raku" },
                new string[] { "たの(しい)" },
                new string[] { "tano(shii)" },
                new string[] { "music", "comfort", "ease" }
            ),
            new KanjiInfo(
                "瓶",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ビン" },
                new string[] { "bin" },
                new string[] { "かめ、 へい" },
                new string[] { "kame", "hei" },
                new string[] { "bottle; jar; jug; urn" }
            ),
            new KanjiInfo(
                "性",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "sex", "gender", "nature" }
            ),
            new KanjiInfo(
                "武",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ブ、 ム" },
                new string[] { "bu", "mu" },
                new string[] { "たけ(し)" },
                new string[] { "take(shi)" },
                new string[] { "warrior; military; chivalry; arms" }
            ),
            new KanjiInfo(
                "荒",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "あら(い)、あ(れる)" },
                new string[] { "ara(i)", "a(reru)" },
                new string[] { "rough; wild" }
            ),
            new KanjiInfo(
                "物",
                new[] { KanjiSet.JLPT_N4 },
                new string[] { "ブツ、 モツ" },
                new string[] { "butsu", "motsu" },
                new string[] { "もの" },
                new string[] { "mono" },
                new string[] { "thing", "object", "matter" }
            ),
            new KanjiInfo(
                "渡",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ト" },
                new string[] { "to" },
                new string[] { "わた(る)" },
                new string[] { "wata(ru)" },
                new string[] { "transit", "ferry", "cross" }
            ),
            new KanjiInfo(
                "孫",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "ソン" },
                new string[] { "son" },
                new string[] { "まご" },
                new string[] { "mago" },
                new string[] { "grandchild; descendants" }
            ),
            new KanjiInfo(
                "出",
                new[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シュツ、 スイ" },
                new string[] { "shutsu", "sui" },
                new string[] { "で(る)、 だ(す)、 い(でる)" },
                new string[] { "de(ru)", "da(su)", "i(deru)" },
                new string[] { "exit", "leave", "go out" }
            ),
            new KanjiInfo(
                "食",
                new[] { KanjiSet.JLPT_N5 },
                new string[] { "ショク、 ジキ" },
                new string[] { "shoku", "jiki" },
                new string[] { "く(う)、 た(べる)、 は(む)" },
                new string[] { "k(u)", "ta(beru)", "ha(mu)" },
                new string[] { "eat", "food" }
            ),
            new KanjiInfo(
                "史",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "history; chronicle" }
            ),
            new KanjiInfo(
                "座",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ザ" },
                new string[] { "za" },
                new string[] { "すわ(る)" },
                new string[] { "suwa(ru)" },
                new string[] { "squat", "seat", "sit" }
            ),
            new KanjiInfo(
                "息",
                new[] { KanjiSet.JLPT_N3 },
                new string[] { "ムス、ソク" },
                new string[] { "musu", "soku" },
                new string[] { "いき" },
                new string[] { "iki" },
                new string[] { "breath", "son", "interest (on money)" }
            ),
            new KanjiInfo(
                "域",
                new[] { KanjiSet.JLPT_N2 },
                new string[] { "イキ" },
                new string[] { "iki" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "range; region; limits; stage; level" }
            ),
        };
    }
}