using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject start_pos;

    private GameObject[,] grid; 

    public int levelLength;

    public int levelHeight;

	// Use this for initialization
	void Start () {
        grid = new GameObject[levelHeight, levelLength];
        MakePath();
        FillAreaBelowPath();
        GeneratePath();
	}
	
	void MakePath()
    {
        int start_y = levelHeight/2;
        for (int i = 0; i < levelLength; i++)
        {
            Debug.Log(i);
            if (i == 0)
            {
                grid[start_y, i] = (GameObject)Resources.Load("Tiles/GrassMid");
                continue;
            }
            int pattern = Random.Range(1, 4);

            if (pattern == 1)
            {
                grid[start_y, i] = (GameObject)Resources.Load("Tiles/GrassHillLeft2");
                grid[start_y + 1, i] = (GameObject)Resources.Load("Tiles/GrassHillLeft");
                start_y += 1;
            } else if (pattern == 2)
            {
                grid[start_y, i] = (GameObject)Resources.Load("Tiles/GrassHillRight");
                grid[start_y - 1, i] = (GameObject)Resources.Load("Tiles/GrassHillRight2");
                start_y -= 1;
            } else
            {
                grid[start_y, i] = (GameObject)Resources.Load("Tiles/GrassMid");
            }

        }
    }

    void FillAreaBelowPath()
    {
        for (int i = 0; i < levelHeight; i++)
        {
            for (int j = 0; j < levelLength; j++)
            {

                if (grid[i,j] != null)
                {
                    for (int k = i-1; k > 0; k--)
                    {
                        //Debug.Log(k);
                        if (grid[k, j] == null)
                        {
                            grid[k, j] = (GameObject)Resources.Load("Tiles/Dirt");
                        }
                        

                    }
                }
               }

            }
        }
    

    void GeneratePath()
    {
        for (int i = 0; i < levelHeight; i++)
        {
            for (int j = 0; j < levelLength; j++)
            {
                if (grid[i,j] != null)
                {
                    Instantiate(grid[i, j], start_pos.transform.position + new Vector3(j * 2.56f, (i - levelHeight / 2) * 2.56f, 0), Quaternion.identity);
                }
                
            }
        }
    }
}
