using UnityEngine;
using System.Collections;


public struct Postion
{
    public int x;
    public int y;
}
public class sample1
{
    protected int life;
    Postion pos;

    public sample1(){

        pos = new Postion();
    }
    public void Move(int x, int y)
    {
        pos.x = x;
        pos.y = y;
    }


}