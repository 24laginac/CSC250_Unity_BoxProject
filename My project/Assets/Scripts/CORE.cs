using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("AddedRoom");
    }
    public static void display()
    {
        print("woot");
    }

    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            Transform newEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            newEnemy.Translate(Random.Range(-16,50), Random.Range(2,10), Random.Range(-13,30));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
