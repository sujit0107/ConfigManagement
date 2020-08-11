using ConfigManagement.DataValidations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace ConfigManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataProvider obj = new DataProvider();
           

            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            var config = builder.Build();
            var path = config.GetSection("ValidationDetails").Get<ValidationDetails>();

            using (var fileStream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), path.Filename), FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(validations));
                obj.ValidationConfigs = (validations)serializer.Deserialize(fileStream);

                var asmNames = DependencyContext.Default.GetDefaultAssemblyNames();
                var type = typeof(DataValidator);

                var allvalidations = asmNames.Select(Assembly.Load)
                    .SelectMany(t => t.GetTypes())
                    .Where(p => p.GetTypeInfo().IsSubclassOf(type));

                var validationstoExecute = obj.ValidationConfigs.OrderFileValidations.Validation;


                foreach (var validation in validationstoExecute.Where(s=>s.IsEnabled=true))
                {
                    var validatorclass = allvalidations.Where(d => d.Name.Equals(validation.Key)).FirstOrDefault();

                    var validationobj = Activator.CreateInstance(validatorclass) as DataValidator;
                    bool result= validationobj.Validate();
                    if(!result)
                    {
                        obj.ErrroList.Add(obj.ValidationConfigs.ErrorMessages.Where(s => s.Key.Equals(validation.ErrorKey)).Select(s => s.ErrorMessage).FirstOrDefault());
                    }

                }

                foreach(var error in obj.ErrroList)
                {
                    Console.WriteLine(error);
                }

                Console.ReadLine();

            }



        }

    }
}
