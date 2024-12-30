using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoooting : MonoBehaviour
{
    //
    public GameObject bulletPrefab;
    // xac dinh khoang time giua cac lan ban
    public float shootingInterval;

    //tinh toan giua lan ban truoc va lan ban hien tai
    private float lastBulletTime;

    //
    public Vector3 bulletOffset; 


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // kiem tra nguoi dung nhan chuot trai hay khong, tra ve true neu duoc nhan xuong
        if (Input.GetMouseButtonDown(0))
        {
            UpdateFiring();
        }
    }
    private void ShooBullet()
    {
        //Instantiate tao ra mot ban sao cua Prefab hoac GameOj trong tro choi
        // doi tuong duoc nhan ban bulletPrefab
        // vi tri cua vien dan la vi tri cua nguoi choi  transform.position
        // Goc xoay cua vien dan khop voi huong cua nguoi choi
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }

    private void UpdateFiring()
    {
        // Time.time - lastBulleTime tinhs khoang time da troi qua tu lan ban truoc
        // neu khoang time nay > shootingInterval cho phep ban vien dan tiep theo
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShooBullet();
            lastBulletTime = Time.time;
        }

    }


}

