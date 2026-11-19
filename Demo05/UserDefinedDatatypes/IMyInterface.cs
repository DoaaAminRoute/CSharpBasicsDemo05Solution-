namespace Demo05.UserDefinedDatatypes
{
    internal interface IMyInterface
    {
        ///1. Signature For Property => C# 7.0
		public int MyProperty { get; set; }

        ///2. Signature For Method => C# 7.0
        internal void MyFunction();
        // Can not Use Private As Access Modifier

        ///3. Default Implemented Method => C# 8.0 Feature .Net Core 3.1 [2019] 
        /// Can Use Private + private protected + protected + internal + internal protected +  public
        private void MyFunction02()
        {
            Console.WriteLine(MyProperty);
        }
    }
}
