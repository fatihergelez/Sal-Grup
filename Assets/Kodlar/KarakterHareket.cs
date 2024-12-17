using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    [SerializeField] Rigidbody rigitbody;
    [SerializeField] float H�z;

    [SerializeField] int Z�plamaH�z;

    int OyuncuYas = 18;

    [SerializeField] Animator OyuncuAnimasyonlar�;

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



    private void FixedUpdate()//Fiziksel i�lerde kullan�l�yor.
    {
        if (!OyunBittiMi) //Oyun bitmediyse ileri hareket et.
        {
            rigitbody.MovePosition(transform.position + transform.forward * H�z * Time.deltaTime);
        }
        
    }


    void Start()
    {
        if (OyuncuYas == 18)
        {
            print("Oyuncu 18 ya��ndad�r.");
        }

        if (OyuncuYas > 17)
        {
            print("Oyuncu 17'den b�y�k.");
        }
     
    }

    //Her karede �al���r...
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
                rigitbody.AddForce(transform.up * Z�plamaH�z, ForceMode.Impulse);
            }

            if (rigitbody.velocity.y > 0)
            {
                OyuncuAnimasyonlar�.SetBool("Jump", true);
            }

            if (rigitbody.velocity.y == 0)
            {
                OyuncuAnimasyonlar�.SetBool("Jump", false);
            }
        }


      


    }
}
