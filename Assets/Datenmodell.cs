using System.Data;
using UnityEngine;

public class Datenmodell : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool[] Eingabezeile = new bool[7];
    public bool[,] Raster = new bool[10,7];
    void Start()
    {
        for(int i = 0; i < 7; i++)
        {
            Eingabezeile[i] = false;
        }
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Raster[i,j] = false;
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
