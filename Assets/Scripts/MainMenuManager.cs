using System.Collections.Generic;
using DigitalRuby.Tween;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public List<CanvasGroup> childMenus = new List<CanvasGroup>();
    public CanvasGroup settingsMenu;
    public CanvasGroup playMenu;
    public CanvasGroup mainMenu;

    public Button playButton;
    public Button playMenuBackButton;
    public Button settingsButton;
    public Button exitButton;

    public Image backgroundImage;
    public GameObject mainMenuRoot;
    public GameObject playMenuRoot;
    private Vector3 backgroundInitialScale;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("App version: " + Application.version);
        Application.targetFrameRate = 60;

        playButton.onClick.AddListener(Play_clicked);
        playMenuBackButton.onClick.AddListener(playMenuBackButton_clicked);
        settingsButton.onClick.AddListener(Settings_clicked);
        exitButton.onClick.AddListener(exitButton_clicked);

        childMenus.AddRange(GetChildMenus());
        ShowMenu(mainMenu);

        backgroundInitialScale = backgroundImage.transform.localScale;
    }

    private void playMenuBackButton_clicked()
    {
        playMenuBackButton.interactable = false;
        AnimateInPlayMenu(_ =>
        {
            playMenuBackButton.interactable = true;
            HideMenu(playMenu);
            AnimateOutMainMenu(_ => {}, reverse: true);
            ShowMenu(mainMenu);
        }, reverse: true);
    }

    private void exitButton_clicked()
    {
        Application.Quit();
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

    void Play_clicked()
    {
        Debug.Log("Play");
        playButton.interactable = false;
        AnimateOutMainMenu(_ =>
        {
            playButton.interactable = true;
            HideMenu(mainMenu);
            AnimateInPlayMenu(_ => { });
            ShowMenu(playMenu);
        });
    }

    private void Settings_clicked()
    {
        Debug.Log("Settings");
        /*
        System.Action<ITween<float>> rotate = (t) =>
        {
            settingsButton.transform.rotation = Quaternion.identity;
            settingsButton.transform.Rotate(transform.forward, t.CurrentValue);
        };
        System.Action<ITween<float>> rotateFinished = (t) =>
        {
            ShowMenu(settingsMenu);
        };

        float startAngle = settingsButton.transform.rotation.eulerAngles.z;
        float endAngle = startAngle + 360.0f;

        settingsButton.gameObject.Tween(
            "Settings", startAngle, endAngle, 1.0f, TweenScaleFunctions.CubicEaseInOut,
            rotate, rotateFinished
        );
        */
    }

    private void HideMenu(CanvasGroup menu)
    {
        menu.alpha = 0.0f;
        menu.gameObject.SetActive(false);
    }

    private void ShowMenu(CanvasGroup menu)
    {
        foreach (var childMenu in childMenus)
        {
            HideMenu(childMenu);
        }

        menu.gameObject.SetActive(true);
        menu.alpha = 1.0f;
    }

    private void ScaleInBackground(bool reverse = false)
    {
        System.Action<ITween<Vector3>> scaleInBackground = (t) =>
        {
            if (backgroundImage != null)
            {
                backgroundImage.transform.localScale = t.CurrentValue;
            }
        };
        var backgroundTargetScale = backgroundInitialScale + new Vector3(0.4f, 0.4f, 0.4f);
        backgroundImage.gameObject.Tween(
            scaleInBackground,
            reverse ? backgroundTargetScale : backgroundInitialScale,
            reverse ? backgroundInitialScale : backgroundTargetScale,
            1.5f,
            TweenScaleFunctions.CubicEaseOut,
            scaleInBackground
        );
    }
    
    private void AnimateOutMainMenu(System.Action<ITween> onAnimFinished, bool reverse = false)
    {
        if (!reverse)
        {
            ScaleInBackground();
        }
        
        System.Action<ITween<float>> fadeMainMenu = (t) =>
        {
            mainMenuRoot.GetComponent<CanvasGroup>().alpha = t.CurrentValue;
        };
        var fadeStart = 1.0f;
        var fadeEnd = 0.0f;
        mainMenuRoot.gameObject.Tween(
            fadeMainMenu,
            reverse ? fadeEnd : fadeStart,
            reverse ? fadeStart : fadeEnd,
            0.5f,
            reverse ? TweenScaleFunctions.CubicEaseOut : TweenScaleFunctions.CubicEaseIn,
            fadeMainMenu,
            onAnimFinished
        );

        System.Action<ITween<Vector3>> scaleMainMenu = (t) => { mainMenuRoot.transform.localScale = t.CurrentValue; };
        var scaleStart = new Vector3(1.0f, 1.0f, 1.0f);
        var scaleEnd = new Vector3(2.5f, 2.5f, 2.5f);
        mainMenuRoot.gameObject.Tween(
            scaleMainMenu,
            reverse ? scaleEnd : scaleStart,
            reverse ? scaleStart : scaleEnd,
            0.7f,
            TweenScaleFunctions.CubicEaseInOut,
            scaleMainMenu
        );
    }

    private void AnimateInPlayMenu(System.Action<ITween> onAnimFinished, bool reverse = false)
    {
        if (reverse)
        {
            ScaleInBackground(true);
        }
        
        System.Action<ITween<float>> fadeInPlayMenu = (t) =>
        {
            if (playMenuRoot != null)
            {
                playMenuRoot.GetComponent<CanvasGroup>().alpha = t.CurrentValue;
            }
        };
        var fadeStart = 0.0f;
        var fadeEnd = 1.0f;
        playMenu.gameObject.Tween(
            fadeInPlayMenu,
            reverse ? fadeEnd : fadeStart,
            reverse ? fadeStart : fadeEnd,
            0.5f,
            reverse ? TweenScaleFunctions.CubicEaseIn : TweenScaleFunctions.CubicEaseOut,
            fadeInPlayMenu
        );

        System.Action<ITween<Vector3>> scaleInPlayMenu = (t) => { playMenuRoot.transform.localScale = t.CurrentValue; };
        var scaleStart = new Vector3(0.7f, 0.7f, 0.7f);
        var scaleEnd = new Vector3(1.0f, 1.0f, 1.0f);
        playMenuRoot.gameObject.Tween(
            scaleInPlayMenu,
            reverse ? scaleEnd : scaleStart,
            reverse ? scaleStart : scaleEnd,
            0.5f,
            reverse ? TweenScaleFunctions.CubicEaseIn : TweenScaleFunctions.CubicEaseOut,
            scaleInPlayMenu,
            onAnimFinished
        );
    }
}