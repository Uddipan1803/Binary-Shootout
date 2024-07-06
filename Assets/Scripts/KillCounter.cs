using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int requiredEnemiesToKill = 8;
    int kills;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showKills();
        if(kills == requiredEnemiesToKill)
        {
            Endlevel();
        }
    }

    private void showKills(){
        counterText.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
    }

    void Endlevel()
    {
        SceneManager.LoadScene("Endgame");
    }

}
