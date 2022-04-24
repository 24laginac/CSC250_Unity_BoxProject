using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string name;
    private Room currentRoom;

    public Enemy(string name)
    {
       this.name = name; 
    }

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }

    public string getName()
    {
        return this.name;
    }
}
