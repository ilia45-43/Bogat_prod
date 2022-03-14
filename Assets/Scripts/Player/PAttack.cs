using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject BuletPref;
    [SerializeField]
    private float delayForShoot;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private float impulse;
    [SerializeField]
    private GameObject[] massEnemys;

    private WaitForSeconds waitForSeconds;

    public enum PlayerWeapon
    {
        Sword,
        Shild,
        Axe
    }

    void Start()
    {
        waitForSeconds = new WaitForSeconds(delayForShoot);
        massEnemys = GameObject.FindGameObjectsWithTag("Enemy");
        StartCoroutine(Attack_IEnum());

    }

    private IEnumerator Attack_IEnum() // ������� ���� �����
    {
        while (true)
        {
            if (!Input.anyKey && LookAtEnemy() != null)
            {
                CreateAndShoot();

                yield return waitForSeconds;
            }
            else
            {
                yield return null;
            }
        }
    }

    /// <summary>
    /// ������� � ������� ����
    /// </summary>
    private void CreateAndShoot()
    {
        var enemyT = LookAtEnemy();
        transform.LookAt(enemyT.position);
        GameObject bulet = GameObject.Instantiate(BuletPref, firePoint.position, Quaternion.identity);
        bulet.GetComponent<Rigidbody>().AddForce(firePoint.forward * impulse, ForceMode.Impulse);
    }

    /// <summary>
    /// ������� ����������� �����
    /// </summary>
    /// <returns>Transform ����������� �������</returns>
    private Transform LookAtEnemy() // ������� ����������� �����
    {
        var min = 100f;
        float a;
        GameObject enemy = null;
        for (int i = 0; i < massEnemys.Length; i++)
        {
            if(massEnemys[i] != null)
            {
                a = Vector3.Distance(massEnemys[i].transform.position, firePoint.transform.position);
                if (a < min)
                {
                    min = a;
                    enemy = massEnemys[i];
                }
            }
        }

        if (enemy == null)
            return null;
        else
            return enemy.transform;
    }
}
