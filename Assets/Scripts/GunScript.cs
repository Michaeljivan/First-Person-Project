using StarterAssets;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    private StarterAssetsInputs _input;
    
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject bulletPoint;

    [SerializeField]
    private float bulletSpeed = 5000;

    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        //Debug.Log("Shots fired!");
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
     
        Destroy(bullet, 2);

    }
}
