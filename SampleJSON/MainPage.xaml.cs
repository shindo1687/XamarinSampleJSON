using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleJSON
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            String jsonData = GetJsonData("SampleJSON.Sample.json");
            System.Console.WriteLine("jsonData = " + jsonData);

            UserData userData = JsonSerializer.Deserialize<UserData>(jsonData);
            System.Console.WriteLine("userData = " + userData);

            String jsonString = JsonSerializer.Serialize(userData);
            System.Console.WriteLine("jsonString = " + jsonString);
        }

        private String GetJsonData(String jsonFileName)
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(jsonFileName);
            using (var reader = new System.IO.StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
