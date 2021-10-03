using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNDSpawner : MonoBehaviour
{
    public CountDown countDown;
    // the tag of the prefabs to spawn
    public string spawnPointTag = "SomeTagHere";
    //false for less
    public bool alwaysSpawn = true;
    public bool isNeededToSpawn = false;
    //the list of prefabs
    public List<GameObject> prefabsToSpwan;

   

    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);

        //foreach (GameObject spawnPoint in spawnPoints)
        //{

        //    int randomPrefab = Random.Range(0, prefabsToSpwan.Count);

        //    if (alwaysSpawn)
        //    {
        //        GameObject pts = Instantiate(prefabsToSpwan[randomPrefab]);
        //        pts.transform.position = spawnPoint.transform.position;
        //    }
        //    else
        //    {
        //        int spawnOrNot = Random.Range(0, 2);
        //        if (spawnOrNot == 0)
        //        {
        //            GameObject pts = Instantiate(prefabsToSpwan[randomPrefab]);
        //            pts.transform.position = spawnPoint.transform.position;
        //        }
        //    }
        //}

        Spawning();
    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 10, 100, 50), "Spawning!"))
    //    {
    //        Spawning();
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if (countDown.itsTimeToSpawn)
        {
            Spawning();
            //isNeededToSpawn = false;
        }
    }

    void Spawning()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);

        foreach (GameObject spawnPoint in spawnPoints)
        {

            int randomPrefab = Random.Range(0, prefabsToSpwan.Count);

            if (alwaysSpawn)
            {
                GameObject pts = Instantiate(prefabsToSpwan[randomPrefab]);
                pts.transform.position = spawnPoint.transform.position;
            }
            else
            {
                int spawnOrNot = Random.Range(0, 6);
                if (spawnOrNot == 0)
                {
                    GameObject pts = Instantiate(prefabsToSpwan[randomPrefab]);
                    pts.transform.position = spawnPoint.transform.position;
                }
            }
        }
    }
}
