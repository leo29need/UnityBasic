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

        for (int i = 1; i <= 5; i++) // i+1 ����
        {
            Debug.Log("�ȳ�?");
        }

        while (number < 10) // �������ִ� ����, 10���� ������ 0~9 ������ �־���. true ����
            // ���ǿ��� ��ħǥ ���� �ʴ´�.
            // number 10ȸ Ȯ�� ���� 
        {
            int randomValue = UnityEngine.Random.Range(1, 101);

            /* if (randomValue <= 10) // 1 ~ 10 -> 10% Ȯ�� ���� �޾Ƴ����� 
            {
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }
            number++; // 10���� �̱� */

            if ( 7 <= count ) // count = õâ�̶�� �����ϰ�, õ���� ���� ���� 
            {
                Debug.Log("Ȯ������ �����Ӹ��� �̾Ҵ�.");
                count = 0; // õ��̱� ������ ����
            }

            else if (randomValue <= 10) // 1 ~ 10 -> 10% Ȯ�� ���� �޾Ƴ����� 
            {
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }
            number++;
            count++;
        }



            /*  int randomValue = Random.Range(1, 101); // 1~100 ���� �� Ȯ��(�����)

              int selectNumbe = 0; // ��ȯ�ϴ°� ������ 1��, �ʱⰪ ���� 

              switch(selectNumbe)
              {
                  case 0:

                      {
                      if (randomValue <= 10) // 1~10 -> 10% 10�̶�� Ȱ�� ����ؼ� ����.
                      {
                      Debug.Log("��û�� �̾Ҵ�."); //"''" 10%Ȯ�� ��û �̴°�
                      }
                      else if (randomValue <= 30)
                      {
                      Debug.Log("�𳪸� �̾Ҵ�."); // 11~30 20%Ȯ�� �� �̴°�
                      }
                      else
                      {
                      Debug.Log("ġġ�� �̾Ҵ�.");
                      } // ���� ����
              }
             break; */
        
    }
                // Update is called once per frame
    public void GachaSwitch()
    {

        int randomValue = UnityEngine.Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }

void Update()
    {
        
    }
}
