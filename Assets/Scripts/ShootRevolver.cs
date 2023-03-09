using System.Collections;
using UnityEngine;

public class ShootRevolver : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private Transform cam;
    public float shootForce;
    public GameObject revolver;
    private bool canShoot = true;
    private RaycastHit _out;
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            StartCoroutine(waitForShooting());
            revolver.GetComponent<AudioSource>().Play();
            revolver.GetComponent<Animator>().SetTrigger("shoot");
            particles.Play();
            if (Physics.Raycast(cam.position, cam.forward, out _out,30f))
            {
                if (_out.transform.GetComponent<IActivateable>() != null)
                {
                    _out.transform.GetComponent<IActivateable>().Activate();
                }
            }
        }
    }

    IEnumerator waitForShooting()
    {
        yield return new WaitForSeconds(0.7f);
        canShoot = true;
    }
}
