using UnityEngine;

namespace Games.Pairs.UI
{
    public static class PairsUtils
    {
        public static Color getHighscoreColor(int score100)
        {
            if (score100 == 100)
            {
                return new Color(0.0745f, 0.041f, 0.976f);
            } else if (score100 > 80)
            {
                return new Color(0.0745f, 0.741f, 0.176f);
            } else if (score100 > 40)
            {
                return new Color(0.741f, 0.682f, 0.094f);
            }
            else
            {
                return new Color(1.0f, 0.182f, 0.094f);
            }
        }
    }
}