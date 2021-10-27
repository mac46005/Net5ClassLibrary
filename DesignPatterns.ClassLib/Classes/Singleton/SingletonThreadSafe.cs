namespace DesignPatterns.ClassLib.Classes.Singleton{
    /// <summary>
    /// Thread safe version of a Singleton
    /// </summary>
    public sealed class SingletonThreadSafe{
        private static SingletonThreadSafe _instance = null;
        private static readonly object _lock = new object();
        SingletonThreadSafe(){}
        public static SingletonThreadSafe SingleInstance{
            get{
                //The lock will allow only one thread at a time to access the block of code inside it.
                // If there is alread a thread accessing the block of code inside the lock, the other threads
                // will hold at this point until the first thread finishes her business inside that block
                lock(_lock){
                    if(_instance == null){
                        _instance = new SingletonThreadSafe();
                    }
                    return _instance;
                }
            }
        }
    }
}