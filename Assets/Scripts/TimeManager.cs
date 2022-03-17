using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public float oyunBitirmeSüresi;
    public bool oyunBitti;
    
    public bool gameOver;

    [SerializeField] private Text timeText;

    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(gameOver == false && oyunBitti == false)
        {

            UpdateTheTimer();

        }



        oyunBitirmeSüresi = 8f;

        if(Time.timeSinceLevelLoad > oyunBitirmeSüresi && !gameOver)
        {
            oyunBitti = true;
            print("Oyun bitti" + oyunBitti);
            winPanel.gameObject.SetActive(true);
            losePanel.gameObject.SetActive(false);

            foreach (GameObject allObjects in GameObject.FindGameObjectsWithTag("Coin"))
            {
                Destroy(allObjects);
            }
            
        }
        if(gameOver)
        {
            print("Restart");
            losePanel.gameObject.SetActive(true);
            winPanel.gameObject.SetActive(false);
        }
        
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;
    }

}
