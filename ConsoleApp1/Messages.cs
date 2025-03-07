namespace MyApp
{
    class Messages
    {
        public string defaultMessage;
        public Messages(string mainMessage){
            defaultMessage = mainMessage;
        }

        public void sendMessage(){
            Console.WriteLine("O método está rodando");
        }    
    }
}

