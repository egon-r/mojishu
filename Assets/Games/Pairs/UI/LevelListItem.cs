using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    public class LevelListItem : MonoBehaviour
    {
        private bool expanded = false;
        public int ExpandedHeight = 500;
        public int ShrinkedHeight = 190;
        public Button Info;
        public Button Play;
        public GameObject PairDetails;
        public KanaLatinVStackView KanaLatinVStackViewPrefab;
        public TextMeshProUGUI LevelNameText;
        public TextMeshProUGUI DetailTitleText;
        public PairsGameInitData GameInitData;
        public TextMeshProUGUI HighscoreText;
    
        public delegate void PlayClickedEvent();
        public event PlayClickedEvent PlayClicked;
    
        // Start is called before the first frame update
        void Start()
        {
            Info.onClick.AddListener(info_clicked);
            Play.onClick.AddListener(play_clicked);

            if (!expanded)
            {
                Shrink();
            }
        }

        private void play_clicked()
        {
            RaisePlayClicked();
        }

        public void AddPairDetail(string upper, string lower)
        {
            var pairDetail = Instantiate(KanaLatinVStackViewPrefab, PairDetails.transform);
            pairDetail.SetDetailTexts(upper, lower);
        }

        public void SetHighscore(int score100)
        {
            HighscoreText.text = score100 + "%";
            if (score100 == 100)
            {
                HighscoreText.color = new Color(0.0745f, 0.041f, 0.976f);
            } else if (score100 > 80)
            {
                HighscoreText.color = new Color(0.0745f, 0.741f, 0.176f);
            } else if (score100 > 40)
            {
                HighscoreText.color = new Color(0.741f, 0.682f, 0.094f);
            }
            else
            {
                HighscoreText.color = new Color(1.0f, 0.182f, 0.094f);
            }
        }

        private void info_clicked()
        {
            if (expanded)
            {
                Shrink();
            }
            else
            {
                Expand();
            }
            expanded = !expanded;
        }

        public void Expand()
        {
            GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, ExpandedHeight);
        }

        public void Shrink()
        {
            GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, ShrinkedHeight);
        }

        protected virtual void RaisePlayClicked()
        {
            PlayClicked?.Invoke();
        }
    }
}
