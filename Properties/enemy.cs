using System;

public class Enemy
{
    public int Hp { get; set; }


    public string Name { get; private set; }


    private int xp;

    public int Xp
    {
        get
        {
            return xp;
        }
        set
        {
            xp = value;
            if (xp < 0)
            {
                xp = 0;
            }
        }
    }



    private int hp = 100;

    // public int GetHp()
    // {
    //     return hp;
    // }

    public void SetHp(int value)
    {

        hp = value;
        if (hp < 0)
        {
            hp = 0;
        }

    }

}