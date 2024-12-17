using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> zeminler = new List<GameObject>();

    [SerializeField] Transform OyuncuKonum;

    float levelUzunlugu = 106.3f;

    int count = 4;

 

    void Start()
    {
        Instantiate(zeminler[0], transform.forward, transform.rotation);
        for (int i = 0; i < count ; i++)
        {
            ZeminUretme();
        }

    }

    public void OyunuYenidenBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void ZeminUretme()
    {
        Instantiate(zeminler[Random.Range(0, zeminler.Count)], transform.forward * levelUzunlugu, transform.rotation);
        levelUzunlugu += 106.3f;
    }


    // Update is called once per frame
    void Update()
    {
        if (OyuncuKonum.position.z > levelUzunlugu - 106.3f * count)
        {
            ZeminUretme();
        }
    }
}
