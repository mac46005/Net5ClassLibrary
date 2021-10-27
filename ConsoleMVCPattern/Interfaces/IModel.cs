namespace ConsoleMVCPattern.Interfaces{
    public interface IModel{
        int Id {get;set;}
        int GenerateId(int id);
    }
}