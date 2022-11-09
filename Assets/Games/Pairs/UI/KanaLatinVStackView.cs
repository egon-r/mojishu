using TMPro;
using UnityEngine;

namespace Games.Pairs.UI
{
    /// <summary>
    /// A vertical stack usually displaying kana above latin text.  
    /// </summary>
    public class KanaLatinVStackView : MonoBehaviour
    {
        public string Upper;
        public string Lower;
        public TextMeshProUGUI UpperText;
        public TextMeshProUGUI LowerText;

        public void SetDetailTexts(string upper, string lower)
        {
            Upper = upper;
            Lower = lower;
            UpperText.text = Upper;
            LowerText.text = Lower;
        }
    }
}
