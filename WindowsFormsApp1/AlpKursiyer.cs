using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.IO;
using static System.Net.WebRequestMethods;

using OfficeOpenXml;
using System.Diagnostics;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Keys = OpenQA.Selenium.Keys;
using OpenQA.Selenium.DevTools;

namespace WindowsFormsApp1
{
    
    public partial class AlpKursiyer : Form
    {
        IWebDriver driver;
        string userName = "";
        string password = "";
        string capch = "";
        string url = "https://e-yaygin.meb.gov.tr";
        bool yeniMiBasliyor = true;
        string[] tc, dtar, tel;
        int level = 100;

        public AlpKursiyer()
        {
            InitializeComponent();
           
           
        }

        void sendTabKey(string input)//tab tuşuna basıyoruz içinde değer varsa değer giriyoruz.
        {
            Actions builder = new Actions(driver);
            if (string.IsNullOrEmpty(input))
            builder.SendKeys(OpenQA.Selenium.Keys.Tab).Build().Perform();
            else
            builder.SendKeys(input).Build().Perform();
        }
        void sendEnterKey()// enter tuşuna basılma durumu
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
        }

        void sendDownKey()// aşağı yön tuşu
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(OpenQA.Selenium.Keys.Down).Build().Perform();
        }

       

        

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader("user.txt");
            //string satir = "";
            //int index = 0;
           // driver = new ChromeDriver(Application.StartupPath + "\\driver\\");
           // driver.Url="https://web.whatsapp.com/";

            //while (true)
            //{
            //    satir = sr.ReadLine();
            //    //MessageBox.Show(satir);
            //    if (satir == null)
            //    {
            //        break;
            //    }
            //    if (index == 0) userName = satir;
            //    if (index == 1) password = satir;
            //    index++;
            //}

           /////// Console.ReadKey();


        }


        
        //open browser click
        private void button2_Click(object sender, EventArgs e)
        {
         
           
        }

        void openUrl(String url)
        {
            string bs = "https://wa.me/90";
            int tamamlanan = 0;
            int hatali = 0;
            int gonderimSuresi = 4 * trackBar1.Value*1000;

                //  driver = new EdgeDriver();
                for (int i = 0; i < tel.Length; i++)
                {
                driver.Url = bs + tel[i].ToString().Trim();
                //driver.FindElement(By.Id("MebbisSSO")).Click();
                if (i == 0)
                {
                    MessageBox.Show("Web tarayıcısında Sohbete başla düğmesine tıklayıp bu diyalog penceresindeki TAMAM düğmesine basınız. ");
                    driver.FindElement(By.XPath("//*[@id=\"fallback_block\"]/div/div/h4[2]/a/span")).Click();
                }
                else
                {
                    driver.FindElement(By.Id("action-button")).Click();
                    Thread.Sleep(gonderimSuresi/4);//2 saniye bekle
                    driver.FindElement(By.XPath("//*[@id=\"fallback_block\"]/div/div/h4[2]/a/span")).Click();
                }

               

                Thread.Sleep(gonderimSuresi);//gönderim süresi kadar bekle
                bool telefonYok = false;
                try
                {
                    var hataVarmi = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/span[2]/div/span/div/div/div/div/div/div[1]"));
                    
                    if (hataVarmi.Text.Contains("URL yoluyla paylaşılan telefon numarası"))
                    {
                        hatali++;
                        telefonYok = true;
                        rchBulunamadi.Text+=tel[i].ToString().Trim()+" telefonun whatsup kaydı yok\n";

                    }
                }
                catch 
                {
                    
                  
                }

                driver.SwitchTo().ActiveElement().SendKeys(rchMesaj.Text);
                
                sendEnterKey();





                Thread.Sleep(gonderimSuresi/4);//2 saniye bekle
               

                //var element =driver.FindElement(By.LinkText(rchMesaj.Text));
                //Console.WriteLine(element);

            }
                
             


          

        }

        //capcha tuşu click
        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        

        

      
       
        void bilgileriAl()
        {
             //tc = richTextBox1.Text.Split('\n');
             //dtar = richTextBox2.Text.Split('\n');
             tel = richTextBox3.Text.Split('\n');
        }

        void queryTc(int i) // tc kimlik sorgulama hareketi
        {
            bilgileriAl();
           // Thread.Sleep(2000);//2 saniye bekle
            sendTabKey("");
            sendTabKey(tc[i]);//tc

            sendTabKey("");//dtar
            sendTabKey(dtar[i].Trim());

            sendEnterKey();
        }
        void setPhones(int k) // telefon numaraları girme hareketi
        {
            for (int i = 0; i < 10; i++)
            {
                //Thread.Sleep(100);
                sendTabKey("");

            }
            //Thread.Sleep(100);//telefon numarası için 
            sendTabKey(tel[k].Trim());
            for (int i = 0; i < 7; i++)// kaydet düğmesine kadar döngü
            {
                sendTabKey("");
                if (i == 0) //iş telefonu
                {
                    sendTabKey(tel[k].Trim() + "0");
                }
                if (i == 3) //eğitim durumu
                {
                    for (int m = 1; m < 6; m++) //ilse için 6 ilerde kodlanabilir
                    {
                        sendDownKey();
                    }
                    sendEnterKey();
                }

            }
        }




        // otomatik giriş 
        private void button4_Click(object sender, EventArgs e)
        {
           





           
        }

      

        void textboxRemove()
        {
            //bilgileriAl();
            //richTextBox1.Text = null;
            //richTextBox2.Text = null;
            //richTextBox3.Text = null;
            //for (int i = 1; i < tc.Length; i++)
            //{
            //    richTextBox1.Text+=tc[i]+"\n";
            //    richTextBox2.Text += dtar[i] + "\n";
            //    richTextBox3.Text += tel[i] + "\n";
            //}
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bntYeni_Click(object sender, EventArgs e)
        {
          
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            bilgileriAl();
            url = @"https://wa.me/905054774994";
            openUrl(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!=null)
            {
                try
                {
                    FileInfo file = new FileInfo(openFileDialog1.FileName);
                    ExcelPackage exc = new ExcelPackage(file);
                    ExcelWorksheet ws = exc.Workbook.Worksheets[1];
                    for (int i = 3; i < 500; i++)
                    {


                        if (ws.Cells[i, 4].Value == "" || ws.Cells[i, 4].Value == null) break;

                        if (telefonKontrol(ws.Cells[i, 4].Value.ToString()))
                        {

                            richTextBox3.Text += ws.Cells[i, 4].Value + "\n";
                        }
                        else
                        {
                            rchBulunamadi.Text += ws.Cells[i, 2].Value + " nolu kişinin telefonu hatalı\n\n";
                        }

                        if (i == 200)
                        {
                            var m = ws.Cells[i, 4].Value;
                        }
                    }
                    rchBulunamadi.Text += "====================\n";

                }
                catch 
                {

                    MessageBox.Show("Dosyayı açamadık. Dosyanın arkaplanda açık olmadığını kontrol edin.");
                }
                
            }


        }

        private bool telefonKontrol(String value)
        {
              return value.Length == 10;
        }
        void openWeb()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Chrome.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            startInfo.UseShellExecute = true;

            startInfo.Verb = "runas";

            startInfo.Arguments = "https://chromedriver.chromium.org/downloads";

            Process.Start(startInfo);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Açılacak web sayfasında mesaj gönderecek telefondan whatsup oturumu açınız");
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\ayarlar.txt");
                string yol = sr.ReadLine();

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("test-type");
                options.AddArgument("--ignore-certificate-errors");
                options.AddArgument("no-sandbox");
                options.AddArgument("disable-infobars");
                //options.AddArgument("--headless"); //hide browser
                options.AddArgument("--start-maximized");
               // options.PageLoadStrategy = PageLoadStrategy.Normal;
                //options.AddArgument("--window-size=1100,300");
                //options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);

                // Profile [Change:User name]
                options.AddArgument(@"user-data-dir="+yol);

                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                service.SuppressInitialDiagnosticInformation = true; 
                driver = new ChromeDriver(Application.StartupPath + "\\driver\\",options);
                //driver.Url = "https://web.whatsapp.com/";
                driver.Navigate().GoToUrl("https://www.leagueoflegends.com/tr-tr/");
            //driver.Url = "https://www.leagueoflegends.com/tr-tr/";
            // Zoom(level);

        }
            catch(Exception ex) 
            {
               var result = MessageBox.Show("Bilgisayarınızda Chrome web tarayıcısı yüklü olmalıdır. Chrome yüklü olmasına rağmen program açılmıyorsa güncel chromedriver programını programın yüklü olduğu klasörde driver klasörüne yüklemeniz gerekir. Chromedriver indirmek istermisiniz? hata:"+ex.ToString(), "Dikkat", MessageBoxButtons.YesNo);
        Debug.Print(ex.ToString());
                if (result == DialogResult.Yes)
                {
                    openWeb();
    }
}
        }
        bool birdahaGosterme = false;
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int katsayi = 4;
            lblSure.Text= "Gönderim Süresi "+(trackBar1.Value*katsayi).ToString()+"sn";
            if (trackBar1.Value < 3&& !birdahaGosterme) {
                MessageBox.Show("İnternetinizin hız durumuna göre gönderim süresi seçiniz. İnternetiniz yavaş ise 16 sn ve üzeri süre seçiniz","Dikkat");
                birdahaGosterme=true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = opentext.FileName;
                rchMesaj.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rchMesaj.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           string xpath = textBox1.Text;
           var element= driver.FindElement(By.XPath(xpath));
           TakeScreenshot1(driver,element);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void TakeScreenshot1(IWebDriver driver, IWebElement element)
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";
            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            Rectangle croppedImage ;
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            int value = Convert.ToInt32(executor.ExecuteScript("return window.pageYOffset;"));


            using (Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray)))
            {
                // Do something with the Bitmap object
                 croppedImage = new Rectangle((element.Location.X*level)/100, ((element.Location.Y*level)/100)-(value*level)/100, (element.Size.Width*level)/100, (element.Size.Height*level)/100);
                screenshot.Clone(croppedImage, screenshot.PixelFormat).Save(String.Format(fileName, ImageFormat.Jpeg));
                //screenshot.Save(String.Format(fileName, ImageFormat.Jpeg));
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            level = 80;
            Zoom(level);
            driver.Navigate().GoToUrl("https://www.leagueoflegends.com/tr-tr/");
        }

       

            private void Zoom(int level)
            {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(string.Format("document.body.style.zoom='{0}%'", level));
            }
        

        public void ZoomOut()
        {
            new Actions(driver)
                .SendKeys(Keys.Control).SendKeys(Keys.Subtract)
                .Perform();
        }



    }
}
