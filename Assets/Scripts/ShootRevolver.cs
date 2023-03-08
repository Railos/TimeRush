using System.Collections;
using UnityEngine;

public class ShootRevolver : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform attackPoint;
    public float shootForce;
    public GameObject revolver;
    public LayerMask aimMask;
    private bool canShoot = true;
    void Update()
    {
        // float screenX = Screen.width / 2;
        // float screenY = Screen.height / 2;
        //
        // RaycastHit hit;
        // Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(screenX, screenY));
        //
        // if (Physics.Raycast(ray, out hit, 100f, aimMask))
        // {
        //     revolver.transform.LookAt(hit.point, Vector3.back);
        // }
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            StartCoroutine(waitForShooting());
            GameObject obj = Instantiate(bullet, attackPoint.position,Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(attackPoint.transform.forward * shootForce);
            revolver.GetComponent<Animator>().SetTrigger("shoot");
        }
    }

    IEnumerator waitForShooting()
    {
        yield return new WaitForSeconds(0.7f);
        canShoot = true;
    }
}
