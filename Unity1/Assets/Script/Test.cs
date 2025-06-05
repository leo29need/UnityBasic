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
    private string Game = "페르소나 시리즈";
    private string drinkables = "커피";
    private string Occupation = "시스템기획";
    bool Dog = true;
    private string hobby = "강아지 산책 반 강제적";
    private string season = "겨울";

    private void Awake()
    // Awake - 최초 1회 실행 초기 셋팅, 가장 먼저 호출(동작)되는것
    // OnEnable - 팝업창 켜서 동작을 시키고 싶을때, Awake 다음으로 호출 됨
    // OnDisable - 팝업창이 활성화에서 비활성화 될 때 호출
    // OnDestroy - 오브젝트가 삭제될때, 제거될때 호출, 1회만 실행 가능
    {
        /* Debug.Log("최초 한번만 실행됩니다."); */

    }

    private void OnEnable()
    {
        /* Debug.Log("활성화 될 때 실행됩니다.");*/

        /* Random.InitState(2); - 이렇게 넣으면 시드값이 고정이 되어서 출력해서 나옴 
        Debug.Log(Random.Range(1, 100));*/
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }
    // Start is called before the first frame update
    void Start()
    // Start - 처음 1회 실행 할때
    {
        /* Debug.Log("안녕하세요.");
           Debug.Log("반갑습니다.");
           Debug.Log("한번만 실행 됩니다.");

           Debug.Log("나의 레벨은 " + playerLevel + "입니다.");

           Debug.Log($"값은 {test}입니다."); // !test = False 로 뜬다. 
           // if (!test) - test == false 같다는 의미이다. */

        SelfIntroduction(); // 기본 자기소개 호출
    }

    private void SelfIntroduction()
    {
        //throw new NotImplementedException();

        Debug.Log($"안녕하세요, 제 이름은 {namea}입니다. 나이는 {age}세이고, 키는 {height}m입니다. 제 MBTI는 {mbti}입니다.");
        Debug.Log($"반려동물 키우는건 {Dog} 입니다.");
        Debug.Log($"저의 취미는 {hobby} 입니다.");
        Debug.Log($"좋아하는 게임은 {Game} 이고,");
        Debug.Log($"좋아하는 계절은 {season} 입니다. 주로 거의 매일 마시면서 살다시피한 저의 인생 동반자 {drinkables}가 늘 곁에 있고요.");
        Debug.Log($"고민하다가 결정된 갈 직종은{Occupation} 입니다.");
    }

    // Update is called once per frame
    void Update()
    // Update - 매번 실행이 될때
    {
        // Debug.Log("매 프레임마다 여러번 실행됩니다.");
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

void MonsterSpawn() // 몬스터
{
B.SetLevel(A.Level());
}
}
*/
