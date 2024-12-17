using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListelerOrnek : MonoBehaviour
{
    int KarakterCan;
    float KarakterHýz = 5.5f;
    string Oyuncuisim;

    [SerializeField] List<string> Sýnýf  = new List<string>();

    void Start()
    {
        Sýnýf.Add("Yaser");
        Sýnýf.Add("Fatih");
        Sýnýf.Add("Gökçe");
        Sýnýf.Add("Ayþe");
        print(Sýnýf[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
