using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // 시스템 기획 연습 한다고 생각하시고

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar; 
    // Image UI로 설정해줘야한다.

    public int maxHP;
    float nowHP;
    // 최소 체력은 0

    int Damage;
    int Healpoint;

    void Awake() // 최초 실행 되는것 
    {
        nowHP = maxHP;
        Initialized();
    }

    void Initialized() // 초기화
    {
        // nowHP = maxHP; // Awake 에 내용이 있기 때문에 여기서는 빼도 된다.
        RefreshUI();
    }
    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5 , 21); // 5~20 의 랜덤한 데미지가 적용되게 만들기

        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0 보다 낮아지면 0으로 고정한다. 
        {
            nowHP = 0;
        }

        Txt_Text.text = $"{Damage}의 데미지를 입었다.";

        // Img_HPbar.fillAmount = nowHP / maxHP;
        // (float) int를 강제로 float 로 바꾸는 방법 
        RefreshUI();
    }
    public void OnClickHeal() // 회복
    {
        Healpoint = Random.Range(5, 21);

        nowHP += Healpoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }

        Txt_Text.text = $"{Healpoint}을 회복을 하였다.";

      //  Img_HPbar.fillAmount = nowHP / maxHP;
        RefreshUI(); // UI 갱신하기
    }
    void RefreshUI() // UI 갱신하는 함수 넣은것 
    {
        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}"; // nowHP / MaxHP : 현재 남은 HP 표기 해주는것 50 / 100
        // Txt_HP.text = nowHP + "/" + maxHP; // 위에꺼나 아래꺼 둘중 아무거나 사용해도 됨
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
