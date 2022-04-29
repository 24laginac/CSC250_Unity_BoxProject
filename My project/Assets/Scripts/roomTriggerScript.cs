using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
    public GameObject roomGo;

    // Start is called before the first frame update

    void Awake()
    {
        //print("*************** Room trigger has started *************")
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
        CORE.addRoomTriggerGO(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer()); //lets the new room know about the player
            print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy()); //lets the new room know about the enemy
            print("Enemy now in room: " + this.thisRoom);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            CORE.destroyRoom(this.gameObject);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            CORE.destroyRoom(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}