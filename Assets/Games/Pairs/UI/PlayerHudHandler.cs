using System.Collections;
using System.Collections.Generic;
using Games.Pairs.UI;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHudHandler : MonoBehaviour
{
    public PairsMenuManager menuManager;
    public Button pause;

    // Start is called before the first frame update
    void Start()
    {
        pause.onClick.AddListener(pause_clicked);
    }
    
    private void pause_clicked()
    {
        Time.timeScale = 0;
        menuManager.ShowMenu(menuManager.pauseMenu.gameObject);
    }
}
