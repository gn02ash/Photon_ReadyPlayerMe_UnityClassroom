using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
public class ChatManager : MonoBehaviour
{
    public TMP_InputField Chatinput;
    public TextMeshProUGUI Chattext;
    private PhotonView _photon;
    private List<string> _messages=new List<string>();
    private float buildDelay=0.5f;
    private int MaximumMessages=12;
    void Start()
    {
        _photon=GetComponent<PhotonView>();
    }
[PunRPC]
void RPC_AddMessage(string msg){
    _messages.Add(msg);
}
public void SendChat(string msg){
    string NewMessage=PhotonNetwork.NickName+": "+msg;
    _photon.RPC("RPC_AddMessage",RpcTarget.All,NewMessage);
}
public void SubmitMsg(){
    string BlankCHeck=Chatinput.text;
    if(BlankCHeck==""){
    Chatinput.ActivateInputField();
    Chatinput.text="";
    return;
    }
    SendChat(Chatinput.text);
    Chatinput.ActivateInputField();
    Chatinput.text="";
}
void buildChat(){
    string NewChat="";
    foreach (string s in _messages)
    {
        NewChat+=s+"\n";
    }
    Chattext.text=NewChat;
}
    void Update()
    {
        if(PhotonNetwork.InRoom){
            Chattext.maxVisibleLines =MaximumMessages;
            if(_messages.Count>MaximumMessages){
                _messages.RemoveAt(0);
            }
            if(buildDelay<Time.time){
                buildChat();
                buildDelay=Time.time+0.2f;
            }
        }else if(_messages.Count>0){
            _messages.Clear();
            Chattext.text="";
        }
        
    }
}
