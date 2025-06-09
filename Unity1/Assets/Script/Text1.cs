using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Text1 : MonoBehaviour
{
    int count;

    // Start is called before the first frame update
    void Start()
    {
        int number = 0;

        for (int i = 1; i <= 5; i++) // i+1 증가
        {
            Debug.Log("안녕?");
        }

        while (number < 10) // 지정해주는 숫자, 10보다 작을때 0~9 조건을 넣어줌. true 지정
            // 조건에는 맞침표 찍지 않는다.
            // number 10회 확률 변수 
        {
            int randomValue = UnityEngine.Random.Range(1, 101);

            /* if (randomValue <= 10) // 1 ~ 10 -> 10% 확률 조건 달아놓은거 
            {
                Debug.Log("'은색 머리'을 뽑았다!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'모나'을 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }
            number++; // 10연차 뽑기 */

            if ( 7 <= count ) // count = 천창이라고 생각하고, 천장을 위한 변수 
            {
                Debug.Log("확정으로 은색머리를 뽑았다.");
                count = 0; // 천장뽑기 뽑으면 리셋
            }

            else if (randomValue <= 10) // 1 ~ 10 -> 10% 확률 조건 달아놓은거 
            {
                Debug.Log("'은색 머리'을 뽑았다!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'모나'을 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }
            number++;
            count++;
        }



            /*  int randomValue = Random.Range(1, 101); // 1~100 랜덤 값 확률(백분율)

              int selectNumbe = 0; // 전환하는거 기준점 1번, 초기값 설정 

              switch(selectNumbe)
              {
                  case 0:

                      {
                      if (randomValue <= 10) // 1~10 -> 10% 10이라는 활당 사용해서 못씀.
                      {
                      Debug.Log("각청을 뽑았다."); //"''" 10%확률 각청 뽑는것
                      }
                      else if (randomValue <= 30)
                      {
                      Debug.Log("모나를 뽑았다."); // 11~30 20%확률 모나 뽑는것
                      }
                      else
                      {
                      Debug.Log("치치를 뽑았다.");
                      } // 단차 구현
              }
             break; */
        
    }
                // Update is called once per frame
    public void GachaSwitch()
    {

        int randomValue = UnityEngine.Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
                        // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }

void Update()
    {
        
    }
}
