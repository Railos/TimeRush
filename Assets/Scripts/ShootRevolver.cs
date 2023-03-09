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
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            StartCoroutine(waitForShooting());
            revolver.GetComponent<AudioSource>().Play();
            revolver.GetComponent<Animator>().SetTrigger("shoot");
            if (Physics.Raycast(cam.position, cam.forward, out _out,30f))
            {
                if (_out.transform.GetComponent<ButtonShoot>())
                {
                    _out.transform.GetComponent<MeshRenderer>().material =
                        _out.transform.GetComponent<ButtonShoot>().activatedMat;
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
