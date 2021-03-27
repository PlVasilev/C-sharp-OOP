using System.Reflection;

namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = typeof(HarvestingFields);

            string input = Console.ReadLine();
            var privateFields = type.GetFields((BindingFlags)62);
            while (true)
            {
                switch (input)
                {
                    case "private":
                        foreach (var privateField in privateFields)
                        {
                            if (privateField.IsPrivate)
                            {
                                Console.WriteLine($"private {privateField.FieldType.Name} {privateField.Name}");
                            }
                        }

                        break;
                    case "protected":
                        foreach (var privateField in privateFields)
                        {
                            if (privateField.IsFamily)
                            {
                                Console.WriteLine($"protected {privateField.FieldType.Name} {privateField.Name}");
                            }
                        }

                        break;
                    case "public":
                        foreach (var privateField in privateFields)
                        {
                            if (privateField.IsPublic)
                            {
                                Console.WriteLine($"public {privateField.FieldType.Name} {privateField.Name}");
                            }
                        }

                        break;
                    case "all":
                        foreach (var privateField in privateFields)
                        {

                            Console.WriteLine(
                                $"{privateField.Attributes.ToString().ToLower().Replace("family", "protected")} {privateField.FieldType.Name} {privateField.Name}");

                        }

                        break;
                    case "HARVEST":
                        return;

                }

                input = Console.ReadLine();
            }
        }
    }
}
