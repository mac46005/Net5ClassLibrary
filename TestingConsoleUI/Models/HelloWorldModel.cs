namespace TestingConsoleUI.Models{
    public class HelloWorldModel{
        public string Message { get; set; }
        public string PrintHelloWorld(){
            return $"Hello World\nThis is a message from {this.GetType().FullName}\nMessageProp=\"{Message}\"";
        }
    }
}