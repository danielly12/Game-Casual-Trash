using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f; // Digunakan untuk  jeda  berapa lama object sampah akan dimunculkan
   
    float timer; // berguna sebagai penyimpan waktu
    public GameObject[] obyekSampah; // untuk menyimpan sampah yang akan ditampilkan
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if (timer > jeda)
        // berguna untuk memproses waktu jeda yang telah ditentukan 
        {

            int random = Random.Range(0, obyekSampah.Length); // berguna untuk menentukan object sampah yang telah ditentukan 
            Instantiate(obyekSampah[random], transform.position, transform.rotation); // untuk memunculkan object sampah yang telah ditentukan dengan 
            // posisi dan rotasi yang ada pada script ini
            timer = 0; // untuk mengembalikkan waktu ke seperti semula 
        }
    }
}
