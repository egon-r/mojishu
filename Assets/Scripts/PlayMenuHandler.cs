using System.Collections;
using System.Collections.Generic;
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

    private void KanjiQuizGame_clicked()
    {
        SceneManager.LoadScene("Scenes/KanjiQuiz");
    }

    private void KanaPairsGame_clicked()
    {
        SceneManager.LoadScene("Scenes/PairsGame");
    }
}
