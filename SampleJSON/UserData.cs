using System;
using System.Collections.Generic;

namespace SampleJSON
{
    public class UserData
    {
        public string updated { get; set; }
        public IList<User> users { get; set; }

        public override string ToString()
        {
            string ret = "{updated=" + updated + ", users=[";
            foreach(var user in users)
            {
                ret += user.ToString();
            }
            ret += "]}";
            return ret;
        }
    }

    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool delete { get; set; }

        public override string ToString()
        {
            return "{name=" + name + ", age=" + age + ", delete=" + delete + "}";
        }
    }
}
