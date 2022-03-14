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

    [SerializeField]
    [Header("���� �� ��������� �����")]
    private float chanceMoney = .90f;

    [SerializeField]
    [Header("���� �� ��������� ��������")]
    private float chanceItem = .02f;

    public void DropMoney(Transform tf)
    {
        Instantiate(moneyPrefab, tf.position, Quaternion.identity);
    }
    public void DropItem(Transform tf)
    {
        Instantiate(itemPrefab, tf.position, Quaternion.identity);
    }

    public void ItemDrop(Transform tf)
    {
        if(Random.Range(1,100) <= (chanceMoney * 100))
        {
            DropMoney(tf);
            return;
        }
        if(Random.Range(1,100) <= (chanceItem * 100))
        {
            DropItem(tf);
        }
        else
        {
            DropMoney(tf);
            return;
        }
    }
}
