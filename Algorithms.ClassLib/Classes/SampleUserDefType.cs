namespace Algorithms.ClassLib.Classes{
    public class SampleUserDefType{
        public string TextProperty { get; set; }
        public int IntProperty { get; set; }
        public override string ToString()
        {
            return $"{IntProperty}-{TextProperty}";
        }
    }
}