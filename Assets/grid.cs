using UnityEngine;

public class PixelGrid : MonoBehaviour
{
    public Transform grid;

    public GameObject[,] pixels = new GameObject[7,10];

    private int rows = 10;
    private int cols = 7;

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
            }
        }
    }
}
