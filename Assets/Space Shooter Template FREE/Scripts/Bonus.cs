using UnityEngine;

public class Bonus : MonoBehaviour {

    //when colliding with another object, if another objct is 'Player', sending command to the 'Player'
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player") 
        {
            if (PlayerShooting1.instance.weaponPower < PlayerShooting1.instance.maxweaponPower)
            {
                PlayerShooting1.instance.weaponPower++;
            }
            Destroy(gameObject);
        }
    }
}
