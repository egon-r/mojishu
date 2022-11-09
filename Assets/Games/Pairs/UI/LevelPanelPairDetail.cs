using TMPro;
using UnityEngine;

public class LevelPanelPairDetail : MonoBehaviour
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
