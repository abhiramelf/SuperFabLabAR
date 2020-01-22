using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject overlayPanel;
    public GameObject instructionPanel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstructionPanel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator InstructionPanel()
    {
        yield return new WaitForSeconds(4.0f);

        overlayPanel.SetActive(false);
        instructionPanel.SetActive(false);
    }

    public void InstructionPop()
    {
        overlayPanel.SetActive(true);
        instructionPanel.SetActive(true);

        StartCoroutine(InstructionPanel());
    }
}
