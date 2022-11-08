using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayMenuHandler : MonoBehaviour
{
    public Button memoryGame;
    
    // Start is called before the first frame update
    void Start()
    {
        memoryGame.onClick.AddListener(memoryGame_clicked);
    }

    private void memoryGame_clicked()
    {
        Debug.Log("memory game");
        SceneManager.LoadScene("Scenes/PairsGame");
    }
}
