namespace Demo05.UserDefinedDatatypes
{
    internal struct MyStruct
    {
        int myAttribute01;  //  Attribute With Private Access Modifier [Default]
        public int myAttribute02;  // Attribute With public Access Modifier 
        void MyFunction01() // Method  With Private Access Modifier [Default]
        {

        }
        internal void MyFunction02() // Method With internal Access Modifier 
        {

        }
        public void MyFunction03() // Method With public Access Modifier 
        {

        }
        int MyProperty { get; set; } // Property With Private Access Modifier [Default]

        // Same As Class 
    }
}
