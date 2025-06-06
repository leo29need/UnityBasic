using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // �ý��� ��ȹ ���� �Ѵٰ� �����Ͻð�

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar; 
    // Image UI�� ����������Ѵ�.

    public int maxHP;
    float nowHP;
    // �ּ� ü���� 0

    int Damage;
    int Healpoint;

    void Awake() // ���� ���� �Ǵ°� 
    {
        nowHP = maxHP;
        Initialized();
    }

    void Initialized() // �ʱ�ȭ
    {
        // nowHP = maxHP; // Awake �� ������ �ֱ� ������ ���⼭�� ���� �ȴ�.
        RefreshUI();
    }
    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5 , 21); // 5~20 �� ������ �������� ����ǰ� �����

        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0 ���� �������� 0���� �����Ѵ�. 
        {
            nowHP = 0;
        }

        Txt_Text.text = $"{Damage}�� �������� �Ծ���.";

        // Img_HPbar.fillAmount = nowHP / maxHP;
        // (float) int�� ������ float �� �ٲٴ� ��� 
        RefreshUI();
    }
    public void OnClickHeal() // ȸ��
    {
        Healpoint = Random.Range(5, 21);

        nowHP += Healpoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }

        Txt_Text.text = $"{Healpoint}�� ȸ���� �Ͽ���.";

      //  Img_HPbar.fillAmount = nowHP / maxHP;
        RefreshUI(); // UI �����ϱ�
    }
    void RefreshUI() // UI �����ϴ� �Լ� ������ 
    {
        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}"; // nowHP / MaxHP : ���� ���� HP ǥ�� ���ִ°� 50 / 100
        // Txt_HP.text = nowHP + "/" + maxHP; // �������� �Ʒ��� ���� �ƹ��ų� ����ص� ��
    }
    // Start is called before the first frame update
    void Start()
    {
        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
