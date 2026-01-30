using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class PixelGrid : MonoBehaviour
{
    public Transform grid;

    public Transform Q;
    private GameObject[,] pixels;
    private GameObject[] Qs;

    private int rows;
    private int cols;

    private int nQs;

    void Start()
    {
        rows = grid.childCount;
        cols = grid.GetChild(0).childCount;

        pixels = new GameObject[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            Transform row = grid.GetChild(r);

            for (int c = 0; c < cols; c++)
            {
                pixels[r, c] = row.GetChild(c).gameObject;
                Image img = pixels[r, c].GetComponent<Image>();
                img.color = Color.black;
            }
        }

        nQs = Q.childCount;
        Qs = new GameObject[nQs];
        for(int i = 0; i < nQs; i++)
        {
            Qs[i] = Q.GetChild(i).gameObject;
            Image img = Qs[i].GetComponent<Image>();
            img.color = Color.black;
        }
    }


}
