using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    public GameObject bugPrefab;
    public int maxBug = 20; // the max count of bugs
    private List<GameObject> bugList = new List<GameObject>(); // manage the bugs

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (bugList.Count < maxBug)
        {
            SpawnBug(); 
        }
    }

    void SpawnBug()
    {
        Vector2 pos = Random.insideUnitCircle * 4f;  //make the bug's location random
        GameObject bug = Instantiate(bugPrefab, pos, Quaternion.identity);//spawn the bugs
        bugList.Add(bug);
    }


}
