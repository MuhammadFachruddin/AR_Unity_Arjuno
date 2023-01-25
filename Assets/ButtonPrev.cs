using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptPrev : MonoBehaviour
{
    public int _number;
    public TextMeshProUGUI _textNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonPrev()
    {
        _number--;
        _textNumber.text = _number.ToString();
    }
}
