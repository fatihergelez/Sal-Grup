using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListelerOrnek : MonoBehaviour
{
    int KarakterCan;
    float KarakterH�z = 5.5f;
    string Oyuncuisim;

    [SerializeField] List<string> S�n�f  = new List<string>();

    void Start()
    {
        S�n�f.Add("Yaser");
        S�n�f.Add("Fatih");
        S�n�f.Add("G�k�e");
        S�n�f.Add("Ay�e");
        print(S�n�f[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
