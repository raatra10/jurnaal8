using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300123
{
    internal class BankTransferConfig
    {
        public config config;
        public string filePath = @"bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                config = new config();
                config.lang = "en";
                config.transfer = new transfer(25000000, 6500, 15000);
                List<string> aa = new List<string>();
                aa.Add("RTO (real-time");
                aa.Add("SKN");
                aa.Add("BI FAST");
                config.methods = aa; 
                config.confirmation = new confirmation("yes", "ya");

                WriteNewConfigFile();
            }
        }


        private void ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<config>(configJsonData);

        }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
