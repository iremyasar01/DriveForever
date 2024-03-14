using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool wayDone = false;

   void OnTriggerEnter2D(Collider2D contact)
    {
        if (contact.gameObject.tag == "mainCar" && wayDone == false)
        {
            Vector3 spawnLocation = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawnLocation, Quaternion.identity);
            //Instantiate komutu herhangi bir nesneyi spawnlama komutudur.
            //spawnlanacak şey, spawnlacak lokasyon, 90 derece eğik mi nasıl spawnlayayım? (nasılsam öyle spawnla)
            wayDone = true;
            Destroy(this.gameObject, 4f);
            //4 saniye sonra yolu yok et.Sonsuza kadar oluşan yollar kalmasın diye.
        }
    }
}
