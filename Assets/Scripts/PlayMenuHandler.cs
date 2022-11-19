using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayMenuHandler : MonoBehaviour
{
    public Button KanaPairsGame;
    public Button KanjiQuizGame;
    
    // Start is called before the first frame update
    void Start()
    {
        KanaPairsGame.onClick.AddListener(KanaPairsGame_clicked);
        KanjiQuizGame.onClick.AddListener(KanjiQuizGame_clicked);
    }

    private IEnumerator LoadGameAsync(string scene, Action onComplete = null)
    {
        var asyncOp = SceneManager.LoadSceneAsync(scene);
        asyncOp.completed += _ => onComplete?.Invoke();
        yield return null;
    }

    private void LoadGameButtonClicked(Button button, string scene)
    {
        StopAllCoroutines();
        var loadingButton = button.GetComponent<LoadingButton>();
        loadingButton.Loading = true;
        StartCoroutine(LoadGameAsync(scene, () =>
        {
            loadingButton.Loading = false;
        }));
    }
    
    private void KanjiQuizGame_clicked()
    {
        LoadGameButtonClicked(KanjiQuizGame, "Scenes/KanjiQuiz");
    }

    private void KanaPairsGame_clicked()
    {
        LoadGameButtonClicked(KanaPairsGame, "Scenes/PairsGame");
    }
}
