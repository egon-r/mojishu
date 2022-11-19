using System;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Shared.Prefabs
{
    public class LoadingSpinner : MonoBehaviour
    {
        public Image ForegroundImg;
        public Image BackgroundImg;

        // Update is called once per frame
        void Update()
        {
            if (gameObject.activeSelf)
            {
                ForegroundImg.gameObject.transform.Rotate(0.0f, 0.0f, 360.0f * Time.deltaTime *
                                                                      ((float)Math.Sin(Time.timeSinceLevelLoad) + 2f));
            }
        }
    }
}
