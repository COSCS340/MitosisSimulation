﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    private int index;

    public Text extra;
    public Text dialogueText;

    //Text Box Pop Up
    public Text boxE;
    public Text boxText;

    public Animator animator;
    public Animator animator2;

    //private Queue<string> sentences;
    private List<string> sentences2;

    public GameObject backButton; //backButton gameojbect
    public ScriptManager myScriptManager;

	// Use this for initialization
	void Start () {
        index = -1;
        backButton.SetActive(false);
        //sentences = new Queue<string>();
        sentences2 = new List<string>();
    }

    //########################################################
    public void DisplayOneSentence(Dialogue dialogue)
    {
        boxE.text = dialogue.name;
        foreach (string sentence in dialogue.sentences)
        {
            StartCoroutine(TypeSentence2(sentence, boxText));
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        //Debug.Log("Starting conversation with " + dialogue.name);

        //Extra and unused
        extra.text = dialogue.name;

        //sentences.Clear();
        sentences2.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            //sentences.Enqueue(sentence);
            sentences2.Add(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (index >= 0)
        {
            if (!backButton.activeSelf) {
                backButton.SetActive(true);
            }
        }

        //if (sentences.Count == 0)
        if (index >= sentences2.Count -1)
        {
            EndDialogue();
            return;
        }

        //string sentence = sentences.Dequeue();
        index += 1;
        string sentence = sentences2[index];

        //Debug.Log(sentence);

        //Simply displays text
        //dialogueText.text = sentence;

        //Displays sentence char by char
        StopAllCoroutines(); //makes sure we don't animate muitple sentences
        StartCoroutine(TypeSentence(sentence));
        myScriptManager.InvokeFunction(index);
    }

    public void DisplayPreviousSentence()
    {
        index -= 1;
        string sentence = sentences2[index];
        
        //Displays sentence char by char
        StopAllCoroutines(); //makes sure we don't animate muitple sentences
        StartCoroutine(TypeSentence(sentence));

        if (index == 0)
        {
            Debug.Log("Need to disable the back button.");
            backButton.SetActive(false);
            return;
        }
    }

    //Used to display a sentence char by char
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    //Used to display a sentence char by char
    IEnumerator TypeSentence2(string sentence, Text myText)
    {
        myText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            myText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
        animator.SetBool("IsOpen", false);
    }

}
