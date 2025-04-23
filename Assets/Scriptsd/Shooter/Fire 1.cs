using UnityEngine;

public class Fire : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public KeyCode shoot;
   public GameObject Bullet;
   public GameObject BulletSpawn;
   public AudioSource bullet;

    // Update is called once per frame
    void Update()
    {
        Transform tf = transform;

        if (Input.GetKeyDown(shoot))
        {
            

            Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
            bullet.Play();
        }
    }
}
