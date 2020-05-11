using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = HiddenFieldFrontEnd();
            var deserialized = JsonConvert.DeserializeObject<Test>(input);// hidden input json produced by front-end


            Console.WriteLine("Hello World!");
        }

        static string HiddenFieldFrontEnd()
        {
            var someObject = new Test
            {
                A = 1,
                Items = new List<Item>
                {
                    new Item { B = 2, C="Sample string" },
                    new Item { B = 3, C="Sample string" },
                    new Item { B = 4, C="Sample string" },
                    new Item { B = 5, C="Sample string" }
                }
            };

            string serialized = JsonConvert.SerializeObject(someObject); // like JSON.stringnified(...)
            return serialized;
        }
    }

    public class Test
    {
        public int A { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public int B { get; set; }

        public string C { get; set; }
    }
}
