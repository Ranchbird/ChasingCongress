using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;

    private void Start()
    {
            life = hearts.Length;
    }

    void Update()
    {
       if(dead == true)
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
   
 }