using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace configurationfile
{
    public partial class Form1 : Form
    {
        Configuration config;
        public Form1()
        {
            InitializeComponent();
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            // Read values from textboxes
            string hammerName = Hammer.Text;
            string accName = Accelerometer.Text;
            string licenseKey = Licence.Text;

            // Load the current configuration
            config = ConfigManager.LoadConfig();

            // Ensure config is not null
            if (config == null)
            {
                config = new Configuration();
            }

            // Add new values to the configuration
            List<string> newHammerNames = new List<string>(config.EncryptedHammerNames ?? Array.Empty<string>());
            newHammerNames.Add(hammerName);
            config.EncryptedHammerNames = newHammerNames.ToArray();

            List<string> newAccNames = new List<string>(config.EncryptedAccNames ?? Array.Empty<string>());
            newAccNames.Add(accName);
            config.EncryptedAccNames = newAccNames.ToArray();

            List<string> newLicenseKeys = new List<string>(config.EncryptedLicenseKey ?? Array.Empty<string>());
            newLicenseKeys.Add(licenseKey);
            config.EncryptedLicenseKey = newLicenseKeys.ToArray();

            // Save the modified configuration
            ConfigManager.SaveConfig(config);

            // Refresh the UI with the updated data
            filler();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            filler();
        }

        private void filler()
        {
            // Fill comboboxes with data source
            HammerBox.DataSource = config.EncryptedHammerNames;
            AccelerometerBox.DataSource = config.EncryptedAccNames;
            LicenceBox.DataSource = config.EncryptedLicenseKey;

            // Select the last available index for each combobox
            if (config.EncryptedHammerNames != null && config.EncryptedHammerNames.Length > 0)
            {
                HammerBox.SelectedIndex = config.EncryptedHammerNames.Length - 1;
            }

            if (config.EncryptedAccNames != null && config.EncryptedAccNames.Length > 0)
            {
                AccelerometerBox.SelectedIndex = config.EncryptedAccNames.Length - 1;
            }

            if (config.EncryptedLicenseKey != null && config.EncryptedLicenseKey.Length > 0)
            {
                LicenceBox.SelectedIndex = config.EncryptedLicenseKey.Length - 1;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            config = ConfigManager.LoadConfig();
            filler();

        }
    }


    public class Configuration
    {
        public string[] EncryptedHammerNames { get; set; }
        public string[] EncryptedAccNames { get; set; }
        public string[] EncryptedLicenseKey { get; set; }
    }

    public class ConfigManager
    {
        private static readonly string ConfigFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Digitap");
        private static readonly string ConfigFilePath = Path.Combine(ConfigFolderPath, "config.json");

        // Encryption key and initialization vector
        private static readonly byte[] Key = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 }; // 128-bit key
        private static readonly byte[] IV = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 }; // 128-bit key
 

        public static Configuration LoadConfig()
        {
            if (!Directory.Exists(ConfigFolderPath) || !File.Exists(ConfigFilePath))
            {

                return new Configuration();
            }

            string encryptedJson = File.ReadAllText(ConfigFilePath);
            string decryptedJson = DecryptStringFromBytes_Aes(Convert.FromBase64String(encryptedJson), Key, IV);

            return JsonConvert.DeserializeObject<Configuration>(decryptedJson);
        }

        public static void SaveConfig(Configuration config)
        {
            string json = JsonConvert.SerializeObject(config);
            byte[] encryptedBytes = EncryptStringToBytes_Aes(json, Key, IV);
            string encryptedString = Convert.ToBase64String(encryptedBytes);

            if (!Directory.Exists(ConfigFolderPath))
            {
                Directory.CreateDirectory(ConfigFolderPath);
            }

            File.WriteAllText(ConfigFilePath, encryptedString);
        }

        // AES encryption methods
        private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        private static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
