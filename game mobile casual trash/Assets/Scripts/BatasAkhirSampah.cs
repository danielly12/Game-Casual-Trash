using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision) // digunakan ketika sebuah object masuk ke area trigger 
    {
        Destroy(collision.gameObject); // untuk menghancurkan object tersebut
        SceneManager.LoadScene("GameOver"); // Baris Ini akan digunakan pada submodul GameOver

    }
}