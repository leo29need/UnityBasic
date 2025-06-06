using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public TextMeshProUGUI Txt_text; // 텍스트를 넣는 곳
    [SerializeField] TMP_InputField Input_Text; // 어디 텍스트를 가지고 올지
    public void OnClickButton()
    {
        Txt_text.text = Input_Text.text;
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
