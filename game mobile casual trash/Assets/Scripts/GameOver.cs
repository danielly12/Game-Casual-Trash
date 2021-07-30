using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    float timer = 0;
    // Update is called once per frame
    void Update()
    { 
        timer += Time.deltaTime;  // waktu melebihi 2 detik 
        if (timer > 2)
        {
            Data.Score = 0;
            SceneManager.LoadScene("Gameplay");
            // game akan mereset dan mengembalikannya ke semula
        }
    }
}