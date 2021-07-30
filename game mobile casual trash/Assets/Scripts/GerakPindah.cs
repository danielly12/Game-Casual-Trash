using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour
{
    float speed = 3f; // menyimpan nilai pecahan yang digunakan utnuk mengatur kecepatan dengan nilai awal 
    public Sprite[] sprites; // nilai tunggal array digunakan untuk menyimpan gambar berupa sprites
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, sprites.Length); // memebrikan nilai acak yang disesuaikan dengan batasan maksimal jumlah array sprite yang dimasukkan 
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index]; // mengganti gambar object sampah dari gambar sprite yang akan dimasukkan
    }
    // Update is called once per frame
    void Update()
    {
        float move = (speed * Time.deltaTime * -1f) + transform.position.x; 
        // menghitung pergerakan pada suatu object berdasarkan sumbu X
        transform.position = new Vector3(move, transform.position.y); // mengimplementasikan perubahan gerakan secara horizontal pada object
    }
    private Vector3 screenPoint; // digunakan untuk menyimpan x,y,z dan digunakan untuk menyimpan posisi object terhadap screen 
    private Vector3 offset; // untuk menyimpan posisi object dengan posisi mouse / touch
    private float firstY; // digunakan untuk menyimpaan posisi vertikal yang nantinnya akan dibuat kmebali seperti sebelumnya 
    void OnMouseDown()
    {
        firstY = transform.position.y;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // berguna untuk ketika mouse klik pada object yang memiliki collider
        offset = gameObject.transform.position - // akan berjalan iketika ada perintah dari mouse dgn mengkliknya kemudia akan merespon dan memberikan aksi
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, screenPoint.z)); // berguna untuk menjaankan code yang berfungsi untuk 
        // melakukan inisialisasi terhadap object dan mouse akan menilai tersebut akan digerakkan object tersebut 
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z); // digunakan ketika mouse klik tahan pada sebuah object yang memiliki collider 
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset; // berfungsi iuntuk menjalankan sampai klik mouse dilepaskan
        transform.position = curPosition; // digunakan untuk melakukan pemindahan posisi object berdasarkan mouse 
    }
    private void OnMouseUp()
    {
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z); // berguna untuk menjalankan ketika mouse melepaskan klik pada sebuah object
         // yang memiliki Collider. dan ini hanya sekali dijalankan ketika mouse / touch melepaskan klik
         // terhadap object tersebut. menjalankan kode yang berfungsi untuk mengembalikan posisi pada object ke posisi awal.
    }
}
    


