using System;
using System.Collections.Generic;

namespace MyTestCSharpProject1.Src.Model
{
    public class User
    {
        public string UserName { get; set; }
        public int Age { get; set; }
        public List<string> Languages;

        public User(string userName, int age, List<string> languages)
        {
            UserName = userName;
            Age = age;
            Languages = languages;
        }
    }

}
