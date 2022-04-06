using System;
using System.Collections.Generic;

namespace MyTestCSharpProject1.Src.Model
{
    public class Admin : User
    {
        public Admin(string userName, int age, List<string> languages)
            : base(userName, age, languages)
        {
        }
    }
}
