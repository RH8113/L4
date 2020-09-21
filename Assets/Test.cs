using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    void Start()
    {
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }

        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic(5);
        lastboss.ougi(20);
    }
}

   
public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int ultimate = 100;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた。");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた。");
        this.hp -= damage;
    }

    public void Magic(int consumption)
    {
        int spare = this.mp -= consumption;
        Debug.Log("魔法攻撃をした。残りのMPは" + spare);

        for(int mp = 0; mp < 10; mp++)
        {
            if(mp < 1)
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    public void ougi(int risk)
    {
        Debug.Log(risk + "MPをけずり" + ultimate + "のダメージを与えた。");
        this.hp -= risk;
    }
}
