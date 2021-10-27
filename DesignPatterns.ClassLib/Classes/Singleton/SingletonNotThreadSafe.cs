namespace DesignPatterns.ClassLib.Classes.Singleton{
    /// <summary>
    /// Not thread safe version of a Singleton
    /// </summary>
    public sealed class SingletonNotThreadSafe{
        private static SingletonNotThreadSafe _instance = null;
        private SingletonNotThreadSafe(){}
        public static SingletonNotThreadSafe SingleInstance{
            get{
                if(_instance == null){
                    // It is possible that two different threads reach this point at the same time,
                    // so more than one instance can be created in a situation like this, because both will
                    // pass the condition about _instance being null.
                    _instance = new SingletonNotThreadSafe();
                }
                return _instance;
            }
        }
    }
}