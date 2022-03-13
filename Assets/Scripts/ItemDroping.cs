using UnityEngine;

public class ItemDroping : MonoBehaviour
{
    //private PStatistics playerStatistics;
    public GameObject moneyPrefab;
    public GameObject itemPrefab;

    [Header("���� ����� ����� �� ����� �������")]
    [SerializeField]
    public float countOfExp = 1f;

    [SerializeField]
    [Header("���� ����� XP �� ����� �������")]
    public float countOfMoney = 1f;

    private void Awake()
    {
        //playerStatistics = GetComponent<PStatistics>();
    }

    public void ItemDropMoney(Transform tf)
    {
        Instantiate(moneyPrefab, tf.position, Quaternion.identity);
    }
    public void ItemDropItem(Transform tf)
    {
        Instantiate(itemPrefab, tf.position, Quaternion.identity);
    }

    public void ItemDrop(Transform tf)
    {
        if(Random.Range(1,100) <= 2)
        {
            ItemDropItem(tf);
        }
        else
        {
            ItemDropMoney(tf);
        }
    }
}
