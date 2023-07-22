using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        [SerializeField] private InputField inputField;
        [SerializeField] private Button button;
        [SerializeField] private ScrollRect scroll;
        
        [SerializeField] private RectTransform sent;
        [SerializeField] private RectTransform received;
        public Canvas canvas;

        public GameObject objectA; 
        public GameObject objectB; 
        public GameObject objectC;
        public GameObject objectD;
        public GameObject objectE;
        public GameObject objectF;
        public GameObject objectG;


        private float height;
        private OpenAIApi openai = new OpenAIApi();
        //private string mensagem = "Algum texto";
        

        private List<ChatMessage> messages = new List<ChatMessage>();
        //private string prompt = "Act as a random stranger in a chat room and reply to the questions. Don't break character. Don't ever mention that you are an AI model.";

        
        
        private void Start()
        {
            button.onClick.AddListener(SendReply);
            if (canvas == null)
            {
                canvas = GetComponentInParent<Canvas>();
            }
            
        }

        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SendReply();
            }    

        }

        private void AppendMessage(ChatMessage message)
        {
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

            var item = Instantiate(message.Role == "user" ? sent : received, scroll.content);
            item.GetChild(0).GetChild(0).GetComponent<Text>().text = message.Content;
            item.anchoredPosition = new Vector2(0, -height);
            LayoutRebuilder.ForceRebuildLayoutImmediate(item);
            height += item.sizeDelta.y;
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
            scroll.verticalNormalizedPosition = 0;

            Debug.Log(message.Content);
        }

        private async void SendReply()
        {
            float distance = Vector3.Distance(objectA.transform.position, objectB.transform.position);
            float distance2 = Vector3.Distance(objectA.transform.position, objectC.transform.position);
            float distance3 = Vector3.Distance(objectA.transform.position, objectD.transform.position);
            float distance4 = Vector3.Distance(objectA.transform.position, objectE.transform.position);
            float distance5 = Vector3.Distance(objectA.transform.position, objectF.transform.position);
            float distance6 = Vector3.Distance(objectA.transform.position, objectG.transform.position);

            if(inputField.text != "" || inputField.text != " " || inputField.text != "  " || inputField.text != null){
            if(distance < 5f || distance2 < 5f  || distance3  < 5f || distance4 < 5f || distance5  < 5f || distance6 < 5f){
                messages = new List<ChatMessage>();
                var newMessage = new ChatMessage()
                {
                    Role = "user",
                    Content = inputField.text
                };
                
                AppendMessage(newMessage);
                if(distance < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Pegar maça, colher maça, pegar fruta"+ "\n" + "3. Sou velho, moro aqui desde sempre "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                    if (messages.Count >= 2 && messages.Count < 5000) newMessage.Content = "só números na pergunta: " + inputField.text; 
                }

                if(distance2 < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Pegar maça, colher maça, pegar fruta"+ "\n" + "3. Sou velho, moro aqui desde sempre "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                }
                if(distance3 < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Pegar maça, colher maça, pegar fruta"+ "\n" + "3. Sou velho, moro aqui desde sempre "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                }
                if(distance4 < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Pegar maça, colher maça, pegar fruta"+ "\n" + "3. Sou velho, moro aqui desde sempre "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                }
                if(distance5 < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Pegar maça, colher maça, pegar fruta"+ "\n" + "3. Sou velho, moro aqui desde sempre "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                }
                if(distance6 < 5f){
                    if (messages.Count != 5000) newMessage.Content = "Essa mensagem se repetirá várias vezes e sempre deve responder apenas com números: Duas pessoas estão jogando, uma fala em texto e a outra só responde números, as respostas de números estão a seguir:" + "\n" + "  1. Meu nome é Brian, pode me chamar assim, meu apelido é esse"+ "\n" + " 2. Não, o culpado não é nenhum desses que você falou, o culpado é o Hobbit."+ "\n" + "3. Sim, o assassino é o Hobbit. "+ "\n" + "4. Colher banana"+ "\n" + "5. eu estava dormindo" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "7. O culpado é o João"+ "\n" + "8. Não sei"+ "\n" + "Baseado nisso, se uma pessoa falar" + "\n" + inputField.text + "\n" + " a outra deve responder o que? analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto."; 
                }
                
                //" +  inputField.text +":"+ "\n" + "Baseado nesse texto como resposta, analise esse texto escolha  necessáriamente apenas um número das opções numéricas que mais se adequa com o texto e nada mais, sem nenhum texto. Sua resposta deve conter apenas número:"+ "\n" + "  1. Brian"+ "\n" + " 2. Pegar maça "+ "\n" + "3. Pegar pedaço de madeira "+ "\n" + "4. Colher banana"+ "\n" + "5. nenhuma resposta" + "\n" + "6. Eu trabalho com carpinteiro" + "\n" + "12. O culpado é o joao"; 
                
                messages.Add(newMessage);
                
                button.enabled = false;
                inputField.text = "";
                inputField.enabled = false;
                
                // Complete the instruction
                var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
                {
                    Model = "gpt-3.5-turbo-0301",
                    Messages = messages
                });

                if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
                {
                    if(distance < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "Sam: Eu me chamo Sam, mas costumam me chamar de Tio Sam";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "Sam: Claro, posso pegar pra você, mas não sou um bom coletor";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                            GlobalVariables.myGlobalVariable = GameObject.FindGameObjectWithTag("applesam").transform.position;
                        }
                        if(message.Content.Trim().Contains("6"))
                        {
                            message.Content = "Sam: Eu trabalho numa mina de carvão.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("7"))
                        {
                            message.Content = "Sam: Eu ouvi falar que o Paladino é o culpado.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                    }
                    if(distance2 < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "Paladino: Você parece um garoto esperto, por isso vou falar meu nome, sou o Paladino.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "Paladino: Acabei de chegar de uma caçada, mas posso fazer isso por você garoto, vou coletar e deixar no meu Baú";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                            GlobalVariables.myGlobalVariable = GameObject.FindGameObjectWithTag("applesam").transform.position;
                        }
                        if(message.Content.Trim().Contains("6"))
                        {
                            message.Content = "Paladino: Luto para a defesa de nossa cidade garoto, quem sabe um dia você não tenha tanto prestigio quanto eu.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("7"))
                        {
                            message.Content = "Paladino: Não costumo passar muito tempo aqui, mas com certeza aquele velho que não faz nada tem a ver com isso.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                    }
                    if(distance3 < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "Hobbit: O que te interessa garoto.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "Hobbit: Claro, posso pegar e tacar na sua cabeça.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                            GlobalVariables.myGlobalVariable = GameObject.FindGameObjectWithTag("applesam").transform.position;
                        }
                        if(message.Content.Trim().Contains("6"))
                        {
                            message.Content = "Hobbit: Você tá questinando demais, vai caçar o que fazer.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("7"))
                        {
                            message.Content = "Hobbit: Se eu tivesse que colocar a culpa em alguém, seria na Rosa, ela vive pintando as paisagens, sempre de  olho na vila. Qualquer hora... Deixa pra lá.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                    }
                    if(distance4 < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "Rosa: Eu me chamo Rosa.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "Rosa: Claro, posso pegar pra você, mas minha mão está suja de tinta.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                            GlobalVariables.Rosa = GameObject.FindGameObjectWithTag("applerosa").transform.position;
                        }
                        if(message.Content.Trim().Contains("6"))
                        {
                            message.Content = "Rosa: Sou uma artista, costumo pintar vários quadros.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("7"))
                        {
                            message.Content = "Rosa: Eu acho que é o Tio Sam, ele estava sumido no dia do crime.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                    }
                    if(distance5 < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "João: João, pra que essa curiosidade toda garoto?.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "João: Eu to velho garoto, não vou ficar pegando fruta pra você, pode colher você mesmo se quiser.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("6"))
                        {
                            message.Content = "João: Sou aposentado, só fico aqui fumando e vendo minha teve rapaz.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("7"))
                        {
                            message.Content = "João: Bem, a casa pegou fogo no dia que o paladino voltou da batalha.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                    }
                    if(distance6 < 5f){
                        var message = completionResponse.Choices[0].Message;
                        message.Content = message.Content.Trim();
                        Global.mensagem = message.Content;  
                        Debug.Log(message.Content);

                        if(message.Content.Trim().Contains("1"))
                        {
                            message.Content = "Policial: Sou o policial, é tudo que você precisa saber.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        
                        if(message.Content.Trim().Contains("2"))
                        {
                            message.Content = "Policial: Precisa recolher provas para incriminar ele.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);       
                        }
                        if(message.Content.Trim().Contains("3"))
                        {
                            message.Content = "Policial: Você está certo, ele é o criminoso, você conseguiu.";
                            Debug.Log(message.Content);
                            messages.Add(message);         
                            AppendMessage(message);     
                            canvas.enabled = true;  

                        }
                    }

                }
                else
                {
                    Debug.LogWarning("No text was generated from this prompt.");
                }

                button.enabled = true;
                inputField.enabled = true;
            }
            }
        }
    }
}
