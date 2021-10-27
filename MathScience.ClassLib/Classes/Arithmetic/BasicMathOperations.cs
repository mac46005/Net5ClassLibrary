namespace MathScience.ClassLib.Classes.Arithmetic{
    public class BasicMathOperations{
        public static T Add<T>(T x,T y){
            dynamic X = x;
            dynamic Y = y;
            return (T)(X + Y);
        }
        public static T Subtract<T>(T x,T y){
            dynamic X = x;
            dynamic Y = y;
            return (T)(X - Y);
        }
        public static T Multiply<T>(T x,T y){
            dynamic X = x;
            dynamic Y = y;
            return (T)(X * Y);
        }
        public static T Divide<T>(T x,T y){
            dynamic X = x;
            dynamic Y = y;
            return (T)(X / Y);
        }
    }
}