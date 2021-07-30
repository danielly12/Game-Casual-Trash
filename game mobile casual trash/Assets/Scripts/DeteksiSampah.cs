using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // untuk menggunakan UI (Wajib menggunakan karena menggunakan UI jika tidak maka tidak akan terhubung) 

    
public class DeteksiSampah : MonoBehaviour
{
    public string nameTag; // Digunakan untuk menyimpan string namaTag yang nanti akan digunakan untuk filter
    // gameobject apa saja yang akan di proses.
    public AudioClip audioBenar; 
    public AudioClip audioSalah;
    // digunakan untuk menyimpan resource audio 
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    // digunakan untuk mengcontrol audio play, loop, pause dan stop 
    public Text textScore; // untuk menampilkan score yang telah didapat di dalam UI 

    // Use this for initialization
    void Start()
    {
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;    
        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
        // dapat digunkana untuk mengcontrol audio agar dapat dimodifikasi 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Data.Score += 10;
            textScore.text = Data.Score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.Score -= 15;
            textScore.text = Data.Score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
            // Jika tag object yang masuk ke area Trigger tidak sesuai dengan namaTag, maka
            // score akan dikurangi dan score akan ditampilkan ke textScore.setelah itu object tersebut
            // dihancurkan dan audio untuk salah dijalankan.
        }
    }
}