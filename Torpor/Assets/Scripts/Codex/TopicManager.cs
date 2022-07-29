using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicManager : MonoBehaviour
{
    public GameObject topicOptions;
    public TopicData topicChosen;

    public void OnTopicChosen(TopicData topicData) {

        this.topicChosen = topicData;

        //Reset topic list
        for (int i = 0; i < topicOptions.transform.childCount; i++)
        {
            topicOptions.transform.GetChild(i).gameObject.SetActive(false);
        }

        //Show topic and tell the option manager to change info 
        for (int i = 0; i < topicChosen.topicOptions.Length; i++)
        {
            topicOptions.transform.GetChild(i).gameObject.SetActive(true);
            topicOptions.transform.GetChild(i).GetComponent<OptionsManager>().OnOptionCreated(topicChosen.topicOptions[i]);
        }
    }
}
