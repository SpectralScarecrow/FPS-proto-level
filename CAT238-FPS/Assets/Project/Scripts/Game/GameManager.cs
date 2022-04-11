using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Game")]
    public Player player;
    public GameObject enemySpawner;

    [Header("UI")]
    public Text ammoText;
    public Text healthText;
    public Text enemyText;
    public Text infotext;
    public Text losetext;

    // Start is called before the first frame update
    void Start()
    {
        infotext.gameObject.SetActive(false);
        losetext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = "Ammo: " + player.Ammo;
        healthText.text = "Health: " + player.Health;
        

        int killedEnemies = 0;
        foreach (Enemy enemy in enemySpawner.GetComponentsInChildren<Enemy>())
        {
            //We are going to iterate over every enemies
            if(enemy.Killed == false)
            {
                killedEnemies++;
            }
        }
        enemyText.text = "Enemies: " + killedEnemies;
        if (killedEnemies == 0)
        {
            infotext.gameObject.SetActive(true);
        }
        if (player.Killed == true)
        {
            losetext.gameObject.SetActive(true);
        }
    }
}
