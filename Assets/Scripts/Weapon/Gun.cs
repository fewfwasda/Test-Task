using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform spawnBullet;
    [SerializeField] private float shootForce;
    [SerializeField] private float spread;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 targetPoint;
    private Vector3 dirWithoutSpread;
    private GameObject currentBullet;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) Shoot();
    }

    private void Shoot()
    {
        ray = camera.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        if (Physics.Raycast(ray, out hit)) targetPoint = hit.point;
        else targetPoint = ray.GetPoint(75);
        dirWithoutSpread = targetPoint - spawnBullet.position;
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);
        dirWithoutSpread = dirWithoutSpread + new Vector3(x, y, 0);
        currentBullet = Instantiate(bullet, spawnBullet.position, Quaternion.identity);
        currentBullet.GetComponent<Rigidbody>().AddForce(dirWithoutSpread.normalized*shootForce,ForceMode.Impulse);
    }
}