using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public class Model : IModel{
        public int GenerateId(int id){
            id = id * 10;
            return id;
        }
        
    }
}