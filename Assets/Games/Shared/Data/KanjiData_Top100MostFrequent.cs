using System.Collections.Generic;

namespace Games.Shared.Data
{
    public class KanjiData_Top100MostFrequent
    {
        public static List<KanjiInfo> Kanji = new()
        {
            new KanjiInfo(
                "日",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニチ", "ジツ" },
                new string[] { "nichi", "jitsu" },
                new string[] { "ひ", "-び", "-か" },
                new string[] { "hi", "-bi", "-ka" },
                new string[] { "day", "sun", "Japan", "counter for days" }
            ),
            new KanjiInfo(
                "一",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "イチ" },
                new string[] { "ichi" },
                new string[] { "ひと(つ)" },
                new string[] { "hito(tsu)" },
                new string[] { "one" }
            ),
            new KanjiInfo(
                "国",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "くに" },
                new string[] { "kuni" },
                new string[] { "country" }
            ),
            new KanjiInfo(
                "会",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "あ(う)" },
                new string[] { "a(u)" },
                new string[] { "meeting; meet" }
            ),
            new KanjiInfo(
                "人",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジン、 ニン" },
                new string[] { "jin", "nin" },
                new string[] { "ひと" },
                new string[] { "hito" },
                new string[] { "person" }
            ),
            new KanjiInfo(
                "年",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ネン" },
                new string[] { "nen" },
                new string[] { "とし" },
                new string[] { "toshi" },
                new string[] { "year", "counter for years" }
            ),
            new KanjiInfo(
                "大",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ダイ、 タイ" },
                new string[] { "dai", "tai" },
                new string[] { "おお(きい)" },
                new string[] { "oo(kii)" },
                new string[] { "large", "big" }
            ),
            new KanjiInfo(
                "十",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジュウ" },
                new string[] { "juu" },
                new string[] { "とお、 と" },
                new string[] { "tou", "to" },
                new string[] { "ten", "10" }
            ),
            new KanjiInfo(
                "二",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニ、 ジ" },
                new string[] { "ni", "ji" },
                new string[] { "ふた(つ)" },
                new string[] { "futa(tsu)" },
                new string[] { "two", "2" }
            ),
            new KanjiInfo(
                "本",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ホン" },
                new string[] { "hon" },
                new string[] { "もと" },
                new string[] { "moto" },
                new string[] { "book", "present", "true", "counter for long cylindrical things" }
            ),
            new KanjiInfo(
                "中",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "なか、 うち、 あた(る)" },
                new string[] { "naka", "uchi", "ata(ru)" },
                new string[] { "in", "inside", "middle", "mean", "center" }
            ),
            new KanjiInfo(
                "長",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "なが(い)、 おさ" },
                new string[] { "naga(i)", "osa" },
                new string[] { "long", "leader", "superior", "senior" }
            ),
            new KanjiInfo(
                "出",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シュツ、 スイ" },
                new string[] { "shutsu", "sui" },
                new string[] { "で(る)、 だ(す)、 い(でる)" },
                new string[] { "de(ru)", "da(su)", "i(deru)" },
                new string[] { "exit", "leave", "go out" }
            ),
            new KanjiInfo(
                "三",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "サン" },
                new string[] { "san" },
                new string[] { "み(つ)" },
                new string[] { "mi(tsu)" },
                new string[] { "three", "3" }
            ),
            new KanjiInfo(
                "同",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "おな(じ)" },
                new string[] { "onaji" },
                new string[] { "same", "agree", "equal" }
            ),
            new KanjiInfo(
                "時",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "とき、 -どき" },
                new string[] { "toki", "doki" },
                new string[] { "time", "hour" }
            ),
            new KanjiInfo(
                "政",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セイ" },
                new string[] { "sei" },
                new string[] { "まつりごと" },
                new string[] { "matsurigoto" },
                new string[] { "politics", "government" }
            ),
            new KanjiInfo(
                "事",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジ" },
                new string[] { "ji" },
                new string[] { "こと" },
                new string[] { "koto" },
                new string[] { "matter", "thing", "fact", "business", "reason", "possibly" }
            ),
            new KanjiInfo(
                "自",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジ、 シ" },
                new string[] { "ji", "shi" },
                new string[] { "みずか(ら)" },
                new string[] { "mizuka(ra)" },
                new string[] { "oneself" }
            ),
            new KanjiInfo(
                "行",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コウ、 ギョウ、 アン" },
                new string[] { "kou", "gyou", "an" },
                new string[] { "い(く)、 ゆ(く)、 おこな(う)" },
                new string[] { "i(ku)", "yu(ku)", "okona(u)" },
                new string[] { "going", "journey", "carry out", "line", "row" }
            ),
            new KanjiInfo(
                "社",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "やしろ" },
                new string[] { "yashiro" },
                new string[] { "company", "firm", "office", "association", "shrine" }
            ),
            new KanjiInfo(
                "見",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ケン" },
                new string[] { "ken" },
                new string[] { "み(る)、 み(せる)" },
                new string[] { "mi(ru)", "mi(seru)" },
                new string[] { "see", "hopes", "chances", "idea", "opinion", "look at", "visible" }
            ),
            new KanjiInfo(
                "月",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゲツ、 ガツ" },
                new string[] { "getsu", "gatsu" },
                new string[] { "つき" },
                new string[] { "tsuki" },
                new string[] { "month", "moon" }
            ),
            new KanjiInfo(
                "分",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ブン、 フン、 ブ" },
                new string[] { "bun", "fun", "bu" },
                new string[] { "わ(ける)" },
                new string[] { "wa(keru)" },
                new string[] { "part", "minute of time", "understand" }
            ),
            new KanjiInfo(
                "議",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ギ" },
                new string[] { "gi" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "deliberation", "consultation", "debate" }
            ),
            new KanjiInfo(
                "後",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゴ、 コウ" },
                new string[] { "go", "kou" },
                new string[] { "のち、 うし(ろ)、 あと" },
                new string[] { "nochi", "ushi(ro)", "ato" },
                new string[] { "behind", "back", "later" }
            ),
            new KanjiInfo(
                "前",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゼン" },
                new string[] { "zen" },
                new string[] { "まえ" },
                new string[] { "mae" },
                new string[] { "in front", "before" }
            ),
            new KanjiInfo(
                "民",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ミン" },
                new string[] { "min" },
                new string[] { "たみ" },
                new string[] { "tami" },
                new string[] { "people", "nation", "subjects" }
            ),
            new KanjiInfo(
                "生",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "セイ、 ショウ" },
                new string[] { "sei", "shou" },
                new string[] { "い(きる)、 う(む)、 お(う)、 は(える)、 なま" },
                new string[] { "i(kiru)", "u(mu)", "o(u)", "ha(eru)", "nama" },
                new string[] { "life", "genuine", "birth" }
            ),
            new KanjiInfo(
                "連",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "レン" },
                new string[] { "ren" },
                new string[] { "つら(なる)、つ(れる)" },
                new string[] { "tsura(naru)", "tsu(reru)" },
                new string[] { "take along", "lead", "join", "connect" }
            ),
            new KanjiInfo(
                "五",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ゴ" },
                new string[] { "go" },
                new string[] { "いつ(つ)" },
                new string[] { "itsu(tsu)" },
                new string[] { "five", "5" }
            ),
            new KanjiInfo(
                "発",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ハツ、 ホツ" },
                new string[] { "hatsu", "hotsu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "departure", "discharge", "emit", "start from" }
            ),
            new KanjiInfo(
                "間",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "カン、 ケン" },
                new string[] { "kan", "ken" },
                new string[] { "あいだ、 ま、 あい" },
                new string[] { "aida", "ma", "ai" },
                new string[] { "interval", "space" }
            ),
            new KanjiInfo(
                "上",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ジョウ、 ショウ、 シャン" },
                new string[] { "jou", "shou", "shan" },
                new string[] { "うえ、 うわ-、 かみ、 あ(げる)、 のぼ(る)、 たてまつ(る)" },
                new string[] { "ue", "uwa", "kami", "a(geru)", "nobo(ru)", "tatematsu(ru)" },
                new string[] { "above", "up" }
            ),
            new KanjiInfo(
                "対",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "タイ、 ツイ" },
                new string[] { "tai", "tsui" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "opposite", "even", "equal", "versus", "anti-", "compare" }
            ),
            new KanjiInfo(
                "部",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ブ" },
                new string[] { "bu" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "section", "bureau", "dept", "class", "copy", "part", "portion" }
            ),
            new KanjiInfo(
                "東",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "ひがし" },
                new string[] { "higashi" },
                new string[] { "east" }
            ),
            new KanjiInfo(
                "者",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シャ" },
                new string[] { "sha" },
                new string[] { "もの" },
                new string[] { "mono" },
                new string[] { "someone", "person" }
            ),
            new KanjiInfo(
                "党",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N2 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "party", "faction", "clique" }
            ),
            new KanjiInfo(
                "地",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "チ、 ジ" },
                new string[] { "chi", "ji" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "ground", "earth" }
            ),
            new KanjiInfo(
                "合",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゴウ、 ガッ、 カッ" },
                new string[] { "gou", "ga", "ka" },
                new string[] { "あ(う)、あい" },
                new string[] { "a(u)", "ai" },
                new string[] { "fit", "suit", "join", "0.1" }
            ),
            new KanjiInfo(
                "市",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "いち" },
                new string[] { "ichi" },
                new string[] { "market", "city", "town" }
            ),
            new KanjiInfo(
                "業",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ギョウ" },
                new string[] { "gyou" },
                new string[] { "わざ" },
                new string[] { "waza" },
                new string[] { "business", "vocation", "arts", "performance" }
            ),
            new KanjiInfo(
                "内",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ナイ" },
                new string[] { "nai" },
                new string[] { "うち" },
                new string[] { "uchi" },
                new string[] { "inside", "within", "between", "among", "house", "home" }
            ),
            new KanjiInfo(
                "相",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ソウ、 ショウ" },
                new string[] { "sou", "shou" },
                new string[] { "あい" },
                new string[] { "ai" },
                new string[] { "inter-", "mutual", "together", "each other", "minister of state" }
            ),
            new KanjiInfo(
                "方",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "かた" },
                new string[] { "kata" },
                new string[] { "direction", "person", "alternative" }
            ),
            new KanjiInfo(
                "四",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "よ(つ)、 よん" },
                new string[] { "yo(tsu)", "yon" },
                new string[] { "four", "4" }
            ),
            new KanjiInfo(
                "定",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "テイ、 ジョウ" },
                new string[] { "tei", "jou" },
                new string[] { "さだ(める)" },
                new string[] { "sada(meru)" },
                new string[] { "determine", "fix", "establish", "decide" }
            ),
            new KanjiInfo(
                "今",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コン、 キン" },
                new string[] { "kon", "kin" },
                new string[] { "いま" },
                new string[] { "ima" },
                new string[] { "now; the present" }
            ),
            new KanjiInfo(
                "回",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "まわ(す)" },
                new string[] { "mawa(su)" },
                new string[] { "-times", "round", "revolve", "counter" }
            ),
            new KanjiInfo(
                "新",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シン" },
                new string[] { "shin" },
                new string[] { "あたら(しい)、 あら(た)" },
                new string[] { "atara(shii)", "ara(ta)" },
                new string[] { "new" }
            ),
            new KanjiInfo(
                "場",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ジョウ" },
                new string[] { "jou" },
                new string[] { "ば" },
                new string[] { "ba" },
                new string[] { "location", "place" }
            ),
            new KanjiInfo(
                "金",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "キン、 コン、 ゴン" },
                new string[] { "kin", "kon", "gon" },
                new string[] { "かね、 かな-、 -がね" },
                new string[] { "kane", "kana", "gane" },
                new string[] { "gold" }
            ),
            new KanjiInfo(
                "員",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "イン" },
                new string[] { "in" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "employee", "member", "number", "the one in charge" }
            ),
            new KanjiInfo(
                "九",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "キュウ、 ク" },
                new string[] { "kyuu", "ku" },
                new string[] { "ここの(つ)" },
                new string[] { "kokono(tsu)" },
                new string[] { "nine", "9" }
            ),
            new KanjiInfo(
                "入",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ニュウ" },
                new string[] { "nyuu" },
                new string[] { "い(る)、はい(る)" },
                new string[] { "i(ru)", "hai(ru)" },
                new string[] { "enter", "insert" }
            ),
            new KanjiInfo(
                "選",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "えら(ぶ)" },
                new string[] { "era(bu)" },
                new string[] { "elect", "select", "choose", "prefer" }
            ),
            new KanjiInfo(
                "立",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リツ" },
                new string[] { "ritsu" },
                new string[] { "た(つ)" },
                new string[] { "ta(tsu)" },
                new string[] { "stand up", "rise" }
            ),
            new KanjiInfo(
                "開",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "ひら(く)、 あ(ける)" },
                new string[] { "hira(ku)", "a(keru)" },
                new string[] { "open", "unfold", "unseal" }
            ),
            new KanjiInfo(
                "手",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "て" },
                new string[] { "te" },
                new string[] { "hand" }
            ),
            new KanjiInfo(
                "米",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ベイ、 マイ、 メエトル" },
                new string[] { "bei", "mai", "meetoru" },
                new string[] { "こめ" },
                new string[] { "kome" },
                new string[] { "rice", "USA", "meter" }
            ),
            new KanjiInfo(
                "力",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リョク、 リキ" },
                new string[] { "ryoku", "riki" },
                new string[] { "ちから" },
                new string[] { "chikara" },
                new string[] { "power", "strength", "strong", "strain", "bear up", "exert" }
            ),
            new KanjiInfo(
                "学",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ガク" },
                new string[] { "gaku" },
                new string[] { "まな(ぶ)" },
                new string[] { "mana(bu)" },
                new string[] { "study", "learning", "science" }
            ),
            new KanjiInfo(
                "問",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "モン" },
                new string[] { "mon" },
                new string[] { "と(う)" },
                new string[] { "to(u)" },
                new string[] { "question", "ask", "problem" }
            ),
            new KanjiInfo(
                "高",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "コウ" },
                new string[] { "kou" },
                new string[] { "たか(い)" },
                new string[] { "taka(i)" },
                new string[] { "tall", "high", "expensive" }
            ),
            new KanjiInfo(
                "代",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ダイ" },
                new string[] { "dai" },
                new string[] { "か(わり)" },
                new string[] { "ka(wari)" },
                new string[] { "substitute", "change", "convert", "replace", "period" }
            ),
            new KanjiInfo(
                "明",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "メイ、 ミョウ" },
                new string[] { "mei", "myou" },
                new string[] { "あか(るい)" },
                new string[] { "aka(rui)" },
                new string[] { "bright", "light" }
            ),
            new KanjiInfo(
                "実",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ジツ" },
                new string[] { "jitsu" },
                new string[] { "み、みの(る)" },
                new string[] { "mi", "mino(ru)" },
                new string[] { "reality", "truth" }
            ),
            new KanjiInfo(
                "円",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "エン" },
                new string[] { "en" },
                new string[] { "まる(い)" },
                new string[] { "maru(i)" },
                new string[] { "circle", "yen", "round" }
            ),
            new KanjiInfo(
                "関",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カン" },
                new string[] { "kan" },
                new string[] { "せき、 かか(わる)" },
                new string[] { "seki", "kaka(waru)" },
                new string[] { "connection", "barrier", "gateway", "involve", "concerning" }
            ),
            new KanjiInfo(
                "決",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ケツ" },
                new string[] { "ketsu" },
                new string[] { "き(める)" },
                new string[] { "ki(meru)" },
                new string[] { "decide", "fix", "agree upon", "appoint" }
            ),
            new KanjiInfo(
                "子",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "シ、 ス、 ツ" },
                new string[] { "shi", "su", "tsu" },
                new string[] { "こ、 ね" },
                new string[] { "ko", "ne" },
                new string[] { "child" }
            ),
            new KanjiInfo(
                "動",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ドウ" },
                new string[] { "dou" },
                new string[] { "うご(く)" },
                new string[] { "ugo(ku)" },
                new string[] { "move", "motion", "change" }
            ),
            new KanjiInfo(
                "京",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "キョウ、 ケイ、 キン" },
                new string[] { "kyou", "kei", "kin" },
                new string[] { "みやこ" },
                new string[] { "miyako" },
                new string[] { "capital" }
            ),
            new KanjiInfo(
                "全",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゼン" },
                new string[] { "zen" },
                new string[] { "まった(く)、 すべ(て)" },
                new string[] { "matta(ku)", "sube(te)" },
                new string[] { "whole", "entire", "all", "complete", "fulfill" }
            ),
            new KanjiInfo(
                "目",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "モク、 ボク" },
                new string[] { "moku", "boku" },
                new string[] { "め" },
                new string[] { "me" },
                new string[] { "eye", "class", "look", "insight", "experience" }
            ),
            new KanjiInfo(
                "表",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ヒョウ" },
                new string[] { "hyou" },
                new string[] { "おもて、 あらわ(す)" },
                new string[] { "omote", "arawa(su)" },
                new string[] { "surface", "table", "chart", "diagram" }
            ),
            new KanjiInfo(
                "戦",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "セン" },
                new string[] { "sen" },
                new string[] { "いくさ、 たたか(う)" },
                new string[] { "ikusa", "tataka(u)" },
                new string[] { "war", "battle", "match" }
            ),
            new KanjiInfo(
                "経",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ケイ" },
                new string[] { "kei" },
                new string[] { "へ(る)、 た(つ)" },
                new string[] { "he(ru)", "ta(tsu)" },
                new string[] { "longitude", "pass thru", "expire", "warp" }
            ),
            new KanjiInfo(
                "通",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ツウ" },
                new string[] { "tsuu" },
                new string[] { "とお(る)、かよ(う)" },
                new string[] { "too(ru)", "kayo(u)" },
                new string[] { "traffic", "pass through", "avenue", "commute" }
            ),
            new KanjiInfo(
                "外",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ガイ、 ゲ" },
                new string[] { "gai", "ge" },
                new string[] { "そと、 ほか、 はず(す)、 と-" },
                new string[] { "soto", "hoka", "hazu-", "to-" },
                new string[] { "outside" }
            ),
            new KanjiInfo(
                "最",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "サイ" },
                new string[] { "sai" },
                new string[] { "もっと(も)" },
                new string[] { "motto(mo)" },
                new string[] { "utmost", "most", "extreme" }
            ),
            new KanjiInfo(
                "言",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ゲン、 ゴン" },
                new string[] { "gen", "gon" },
                new string[] { "い（う）、 こと" },
                new string[] { "i(u)", "koto" },
                new string[] { "say", "word" }
            ),
            new KanjiInfo(
                "氏",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N1 },
                new string[] { "シ" },
                new string[] { "shi" },
                new string[] { "うじ" },
                new string[] { "uji" },
                new string[] { "family name", "surname", "clan" }
            ),
            new KanjiInfo(
                "現",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ゲン" },
                new string[] { "gen" },
                new string[] { "あらわ(れる)、 うつ(つ)" },
                new string[] { "arawa(reru)", "utsu(tsu)" },
                new string[] { "present", "existing", "actual" }
            ),
            new KanjiInfo(
                "理",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "リ" },
                new string[] { "ri" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "logic", "arrangement", "reason", "justice", "truth" }
            ),
            new KanjiInfo(
                "調",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "しら(べる)、ととの(う)" },
                new string[] { "shira(beru)", "tono(u)" },
                new string[] { "tune", "tone", "meter", "prepare", "investigate" }
            ),
            new KanjiInfo(
                "体",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "タイ" },
                new string[] { "tai" },
                new string[] { "からだ" },
                new string[] { "karada" },
                new string[] { "body", "substance", "object", "reality" }
            ),
            new KanjiInfo(
                "化",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "カ、 ケ" },
                new string[] { "ka", "ke" },
                new string[] { "ば(ける)、 ふ(ける)" },
                new string[] { "ba(keru)", "fu(keru)" },
                new string[] { "change", "take the form of", "influence", "enchant", "delude", "-ization" }
            ),
            new KanjiInfo(
                "田",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "デン" },
                new string[] { "den" },
                new string[] { "た" },
                new string[] { "ta" },
                new string[] { "rice field", "rice paddy" }
            ),
            new KanjiInfo(
                "当",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "トウ" },
                new string[] { "tou" },
                new string[] { "あ(たる)" },
                new string[] { "a(taru)" },
                new string[] { "hit", "right", "appropriate" }
            ),
            new KanjiInfo(
                "八",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ハチ" },
                new string[] { "hachi" },
                new string[] { "や(つ)、 よう" },
                new string[] { "ya(tsu)", "you" },
                new string[] { "eight", "8" }
            ),
            new KanjiInfo(
                "六",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "ロク" },
                new string[] { "roku" },
                new string[] { "む(つ)、 むい" },
                new string[] { "mu(tsu)", "mui" },
                new string[] { "six", "6" }
            ),
            new KanjiInfo(
                "約",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ヤク" },
                new string[] { "yaku" },
                new string[] { "つづ(まる)" },
                new string[] { "tsuzu(maru)" },
                new string[] { "promise", "approximately", "shrink" }
            ),
            new KanjiInfo(
                "主",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "ぬし、 おも" },
                new string[] { "nushi", "omo" },
                new string[] { "lord", "chief", "master", "main thing", "principal" }
            ),
            new KanjiInfo(
                "題",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "ダイ" },
                new string[] { "dai" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "topic", "subject" }
            ),
            new KanjiInfo(
                "下",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N5 },
                new string[] { "カ、 ゲ" },
                new string[] { "ka", "ge" },
                new string[] { "した、 しも、 もと、 さ(げる)、 くだ(る)、 お(ろす)" },
                new string[] { "shita", "shimo", "moto", "sa(geru)", "kuda(ru)", "o(rosu)" },
                new string[] { "below", "down", "descend", "give", "low", "inferior" }
            ),
            new KanjiInfo(
                "首",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "シュ" },
                new string[] { "shu" },
                new string[] { "くび" },
                new string[] { "kubi" },
                new string[] { "neck" }
            ),
            new KanjiInfo(
                "意",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N4 },
                new string[] { "イ" },
                new string[] { "i" },
                new string[] { "" },
                new string[] { "" },
                new string[] { "idea", "mind", "heart", "taste", "thought" }
            ),
            new KanjiInfo(
                "法",
                new KanjiSet[] { KanjiSet.TOP_100_MOST_FREQUENT, KanjiSet.JLPT_N3 },
                new string[] { "ホウ" },
                new string[] { "hou" },
                new string[] { "のり" },
                new string[] { "nori" },
                new string[] { "method", "law", "rule", "principle", "model", "system" }
            ),
        };
    }
}