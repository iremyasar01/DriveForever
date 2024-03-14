using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public float verticalSpeed,horizontalSpeed,defaultSpeed;
    private float verticalMove, horizontalMove;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //oyun başladığında rigibody2d componentimi rb değişkenime ata.
    }

    void FixedUpdate()
    {
        verticalMove = Input.GetAxis("Vertical");
        //unity'nin yukarı (w ve yukarı tuşunu), aşağı için( s ve aşağı tuşunu) barındırdığı hazır paketi.
        horizontalMove = Input.GetAxis("Horizontal");
        //unity'nin sağ için (d e sağ tuşunu),
        rb.velocity = new Vector3(rb.velocity.x, defaultSpeed + verticalMove * 50 * verticalSpeed * Time.deltaTime);
        //x'in değeri neyse onu ata.
        //y için ise hep hareket etsin ama ben w ya da yukarı tuşuna bastığımda hızlansın.
        //y değerini 50 ile çarpma nedenimiz unity'de vereceğimiz hız değerine küçük sayılar vermek.
        //Time.deltaTime tüm cihazlarda aynı performansı verebilmesi için.
    }
}
