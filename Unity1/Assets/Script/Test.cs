using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // int playerLevel = 10;
    // bool test = true;

    private string namea = "KMY";
    private int age = 30;
    private float height = 163.5f;
    private string mbti = "ENFP";
    private string Game = "�丣�ҳ� �ø���";
    private string drinkables = "Ŀ��";
    private string Occupation = "�ý��۱�ȹ";
    bool Dog = true;
    private string hobby = "������ ��å �� ������";
    private string season = "�ܿ�";

    private void Awake()
    // Awake - ���� 1ȸ ���� �ʱ� ����, ���� ���� ȣ��(����)�Ǵ°�
    // OnEnable - �˾�â �Ѽ� ������ ��Ű�� ������, Awake �������� ȣ�� ��
    // OnDisable - �˾�â�� Ȱ��ȭ���� ��Ȱ��ȭ �� �� ȣ��
    // OnDestroy - ������Ʈ�� �����ɶ�, ���ŵɶ� ȣ��, 1ȸ�� ���� ����
    {
        /* Debug.Log("���� �ѹ��� ����˴ϴ�."); */

    }

    private void OnEnable()
    {
        /* Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�.");*/

        /* Random.InitState(2); - �̷��� ������ �õ尪�� ������ �Ǿ ����ؼ� ���� 
        Debug.Log(Random.Range(1, 100));*/
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }
    // Start is called before the first frame update
    void Start()
    // Start - ó�� 1ȸ ���� �Ҷ�
    {
        /* Debug.Log("�ȳ��ϼ���.");
           Debug.Log("�ݰ����ϴ�.");
           Debug.Log("�ѹ��� ���� �˴ϴ�.");

           Debug.Log("���� ������ " + playerLevel + "�Դϴ�.");

           Debug.Log($"���� {test}�Դϴ�."); // !test = False �� ���. 
           // if (!test) - test == false ���ٴ� �ǹ��̴�. */

        SelfIntroduction(); // �⺻ �ڱ�Ұ� ȣ��
    }

    private void SelfIntroduction()
    {
        //throw new NotImplementedException();

        Debug.Log($"�ȳ��ϼ���, �� �̸��� {namea}�Դϴ�. ���̴� {age}���̰�, Ű�� {height}m�Դϴ�. �� MBTI�� {mbti}�Դϴ�.");
        Debug.Log($"�ݷ����� Ű��°� {Dog} �Դϴ�.");
        Debug.Log($"���� ��̴� {hobby} �Դϴ�.");
        Debug.Log($"�����ϴ� ������ {Game} �̰�,");
        Debug.Log($"�����ϴ� ������ {season} �Դϴ�. �ַ� ���� ���� ���ø鼭 ��ٽ����� ���� �λ� ������ {drinkables}�� �� �翡 �ְ��.");
        Debug.Log($"����ϴٰ� ������ �� ������{Occupation} �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    // Update - �Ź� ������ �ɶ�
    {
        // Debug.Log("�� �����Ӹ��� ������ ����˴ϴ�.");
    }
    /* int Sum(int value1, int value2)
     { return value1 + value2; } */

}
/*public class Player
{
private int playerLevel = 10;

public int Level()
{
return playerLevel;
}

public class Monster
{
private int monsterLevel;

public void SetLevel(int _playerLevel)
{
monsterLevel = _playerLevel;
}

public class Game
{
Player A;
Monster B;

void MonsterSpawn() // ����
{
B.SetLevel(A.Level());
}
}
*/
