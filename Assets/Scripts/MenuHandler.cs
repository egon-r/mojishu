using System.Collections.Generic;
using DigitalRuby.Tween;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public List<CanvasGroup> childMenus = new List<CanvasGroup>();
    public CanvasGroup settingsMenu;
    public CanvasGroup playMenu;
    public CanvasGroup mainMenu;

    public Button playButton;
    public Button settingsButton;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        
        playButton.onClick.AddListener(Play_clicked);
        settingsButton.onClick.AddListener(Settings_clicked);

        childMenus.AddRange(GetChildMenus());
        ShowMenu(mainMenu);
    }

    private IEnumerable<CanvasGroup> GetChildMenus()
    {
        foreach (Transform t in transform)
        {
            CanvasGroup canvasGroup;
            if (t.gameObject.TryGetComponent(out canvasGroup))
            {
                Debug.Log($"Child Menu: {canvasGroup}");
                yield return canvasGroup;
            }
        }
    }

    private void ShowMenu(CanvasGroup menu)
    {
        foreach (var childMenu in childMenus)
        {
            childMenu.alpha = 0.0f;
            childMenu.gameObject.SetActive(false);
        }

        menu.gameObject.SetActive(true);
        menu.alpha = 1.0f;
    }

    private void Settings_clicked()
    {
        Debug.Log("Settings");
        System.Action<ITween<float>> rotate = (t) =>
        {
            settingsButton.transform.rotation = Quaternion.identity;
            settingsButton.transform.Rotate(transform.forward, t.CurrentValue);
        };
        System.Action<ITween<float>> rotateFinished = (t) => { ShowMenu(settingsMenu); };

        float startAngle = settingsButton.transform.rotation.eulerAngles.z;
        float endAngle = startAngle + 360.0f;

        settingsButton.gameObject.Tween(
            "Settings", startAngle, endAngle, 1.0f, TweenScaleFunctions.CubicEaseInOut,
            rotate, rotateFinished
        );
    }

    void Play_clicked()
    {
        Debug.Log("Play");
        ShowMenu(playMenu);
    }
}