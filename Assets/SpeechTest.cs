using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechTest : MonoBehaviour
{

    //音声コマンドのキーワード
    private string[] m_Keywords = { "あかあげて", "しろあげて", "あかさげて", "しろさげて" };

    private KeywordRecognizer m_Recognizer;
    // Start is called before the first frame update
    void Start()
    {
        //Speech recognition is not supported on this machine.
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        //ログ出力
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());

        //認識したキーワードで処理判定
        switch (args.text)
        {
            case "あかあげて":
                AkaAgete();
                break;
            case "しろあげて":
                ShiroAgete();
                break;
            case "あかさげて":
                AkaSagete();
                break;
            case "しろさげて":
                ShiroSagete();
                break;
        }
    }

    private void AkaAgete()
    {
        Debug.Log("あかあげて");
        //RightHandTarget.transform.position = RightHandUpPos;
    }
    private void ShiroAgete()
    {
        //LeftHandTarget.transform.position = LeftHandUpPos;
    }

    private void AkaSagete()
    {
        //RightHandTarget.transform.position = RightHandDownPos;
    }

    private void ShiroSagete()
    {
        //LeftHandTarget.transform.position = LeftHandDownPos;
    }


}
