
using AutoItX3Lib;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Tool_list_handmade
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private List<string> patchOtherImages;
        private IWebDriver driver;
        private Thread myThead;
        public Form1()
        {
            InitializeComponent();
            string dirPath = @"profile";
            if (!Directory.Exists(dirPath))
            {
                btn_create_profile.Visible = true;
                Directory.CreateDirectory(dirPath);
            }
            else
            {
                btn_create_profile.Visible = false;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(@"user-data-dir=profile");
                driver = new ChromeDriver(options);
            }
            dirPath = @"done";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            if (!File.Exists("settings.json"))
            {
                Setting setting = new Setting();
                string result = JsonConvert.SerializeObject(setting);
                File.WriteAllText("settings.json", result);
            }
            LoadCache();
            LoadOtherImages();
            LoadProducts();
        }
        private void LoadCache()
        {
            string json = File.ReadAllText("settings.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            tb_asin_clone.Text = (string)jsonObj["asin"];
            tb_sku_clone.Text = (string)jsonObj["sku"];
            tb_market_id.Text = (string)jsonObj["marketId"];
        }
        private void Btn_create_profile_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=profile");
            driver = new ChromeDriver(options);
        }
      

        private void UpdateCache(string key, string value)
        {
            string json = File.ReadAllText("settings.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[key] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("settings.json", output);
        }

        private void LoadOtherImages()
        {
            patchOtherImages = new List<string>();
            string dirPath = @"other_images";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            DirectoryInfo d = new DirectoryInfo(@"other_images");
            FileInfo[] Files = d.GetFiles("*");
            foreach (FileInfo file in Files)
            {
                patchOtherImages.Add(file.FullName);
            }
            lb_other_images.Text = "Có " + patchOtherImages.Count + " ảnh phụ";
        }
        private void LoadProducts()
        {
            products = new List<Product>();
            string dirPath = @"images";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            DirectoryInfo d = new DirectoryInfo(@"images");
            FileInfo[] Files = d.GetFiles("*");
            foreach (FileInfo file in Files)
            {
                Product product = new Product(file.FullName, Path.GetFileNameWithoutExtension(file.Name),file.Name);
                products.Add(product);
            }
            lb_products.Text = "Có " + products.Count + " sản phẩm";

        }
       
        private void moveFile(string fileName)
        {
            File.Move(@"images/"+@fileName, @"done/"+@fileName);
        }
        private void Run()
        {
            UpdateCache("asin", tb_asin_clone.Text);
            UpdateCache("sku", tb_sku_clone.Text);
            UpdateCache("marketId", tb_market_id.Text);

            for (int i = 0; i < products.Count; i++)
            {
                driver.Url = "https://sellercentral.amazon.com/products/clone?marketplaceID=" + tb_market_id.Text + "&ref=xx_myiclone_cont_myifba&sku=" + tb_sku_clone.Text + "&asin=" + tb_asin_clone.Text + "&productType=GUILD_APPAREL#product";
                Thread.Sleep(5000);
                //item_name
                
                driver.FindElement(By.Id("item_name")).Clear();
                driver.FindElement(By.Id("item_name")).SendKeys(products[i].name);
                Thread.Sleep(2000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('hub-spoke-image-menu-item').click()");
                Thread.Sleep(2000);
                IReadOnlyList<IWebElement> imagesUpload = driver.FindElements(By.ClassName("ilui-image-select-container"));
                Thread.Sleep(2000);
                imagesUpload[1].Click();
                Thread.Sleep(2000);

                AutoItX3 autoItX3 = new AutoItX3();
                autoItX3.WinActive("Open");
                autoItX3.Send(products[i].patch);
                Thread.Sleep(2000);
                autoItX3.Send("{ENTER}");
                Thread.Sleep(2000);
                for (int j = 2; j <imagesUpload.Count && j <= patchOtherImages.Count + 1; j++)
                {
                    imagesUpload[j].Click();
                    Thread.Sleep(1000);
                    AutoItX3 autoItX3Temp = new AutoItX3();
                    autoItX3Temp.WinActive("Open");
                    autoItX3Temp.Send(patchOtherImages[j - 2]);
                    Thread.Sleep(2000);
                    autoItX3Temp.Send("{ENTER}");
                    Thread.Sleep(2000);
                }
                Thread.Sleep(1000);
                moveFile(products[i].fullName);
                try
                {
                    js.ExecuteScript("document.getElementById('ilui-publish-button-announce').click()");
                }catch(Exception e)
                {
                    continue;
                }
                Thread.Sleep(4000);
            }

        }

       
        private void Btn_start_Click(object sender, EventArgs e)
        {
            myThead = new Thread(Run);
            myThead.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
            if (myThead != null)
            {
                myThead.Abort();
            }

        }
    }

}
