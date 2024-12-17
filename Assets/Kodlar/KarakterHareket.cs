using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    [SerializeField] Rigidbody rigitbody;
    [SerializeField] float Hýz;

    [SerializeField] int ZýplamaHýz;

    int OyuncuYas = 18;

    [SerializeField] Animator OyuncuAnimasyonlarý;

    [SerializeField] GameObject GameOverMenu;

    bool OyunBittiMi;

    [SerializeField] TMP_Text score;
    float roundScore;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            OyunBittiMi = true;
            GameOverMenu.SetActive(true);
        }
    }



    private void FixedUpdate()//Fiziksel iþlerde kullanýlýyor.
    {
        if (!OyunBittiMi) //Oyun bitmediyse ileri hareket et.
        {
            rigitbody.MovePosition(transform.position + transform.forward * Hýz * Time.deltaTime);
        }
        
    }


    void Start()
    {
        if (OyuncuYas == 18)
        {
            print("Oyuncu 18 yaþýndadýr.");
        }

        if (OyuncuYas > 17)
        {
            print("Oyuncu 17'den büyük.");
        }
     
    }

    //Her karede çalýþýr...
    void Update()
    {
        if (!OyunBittiMi) //Oyun bitmediyse hareket edebilir. 
        {
            roundScore += Time.deltaTime;
            score.text = "Score: " + roundScore.ToString("f1");



            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
            {
                transform.Translate(-9, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
            {
                transform.Translate(9, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigitbody.AddForce(transform.up * ZýplamaHýz, ForceMode.Impulse);
            }

            if (rigitbody.velocity.y > 0)
            {
                OyuncuAnimasyonlarý.SetBool("Jump", true);
            }

            if (rigitbody.velocity.y == 0)
            {
                OyuncuAnimasyonlarý.SetBool("Jump", false);
            }
        }


      


    }
}
