using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayManager : Singleton<GameplayManager>
{

    [Tooltip("Enemy start position")]
    public Vector3 EnemyStartPoint = new Vector3(8, 1, -1);
    public Transform Enemy;

    [Header("Text")]
    public Text FinishText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Enemy, EnemyStartPoint, Enemy.rotation);
    }

    public void SpawnNewEnemy()
    {
        Instantiate(Enemy, EnemyStartPoint, Enemy.rotation);
    }

    public void DestroyEnemy(GameObject gameObject)
    {
        Wait(2f, () =>
        {
            Destroy(gameObject, 0f);
            SpawnNewEnemy();
        });
    }

    public void FinishGame(bool isWinner)
    {
        if (isWinner)
        {
            FinishText.color = Color.green;
            FinishText.text = "YOU WIN!";          
        }
        else
        {
            FinishText.color = Color.red;
            FinishText.text = "YOU LOSE";
        }

        
        Wait(2f, () =>
        {
            SceneManager.LoadScene("MainScene");
        });
    }


}
