using Unity.Cinemachine;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 3;

    public GameObject[] hearts;
    private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            Debug.Log("we are dead");
        }
    }
    public void TakeDamage(int d)
    {

        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.FindGameObjectsWithTag("enemy");
        if(other.tag == "enemy")
        {
           TakeDamage(1);
        }
    }
   




}
