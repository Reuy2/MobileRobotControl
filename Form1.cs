using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace _5sem_Lab1UDP
{
    public partial class Form1 : Form
    {
        ConsoleDriver console;

        UdpHelper? udp;

        Dictionary<string, int> responseDict = new Dictionary<string, int>();

        System.Windows.Forms.Timer receivedAndTranslateRefreshTimer = new System.Windows.Forms.Timer();

        System.Windows.Forms.Timer autoModeTimer = new System.Windows.Forms.Timer();

        CheckBox[] checks;

        Bitmap visualMap = new Bitmap(400, 400);

        Graphics graf;

        Robot rob = new Robot();

        int count = 0;

        public Form1()
        {
            InitializeComponent();

            console = new ConsoleDriver(consoleBox);

            autoModeTimer.Interval = 50;
            autoModeTimer.Enabled = true;
            autoModeTimer.Tick += AutoModeTimer_Tick;

            receivedAndTranslateRefreshTimer.Interval = 50;
            receivedAndTranslateRefreshTimer.Tick += ReceivedAndTranslateRefreshTimer_Tick;
            receivedAndTranslateRefreshTimer.Enabled = true;

            checks = new[] { autoModeCheck, autoWallCheck, checkBox1, autoModeLine };

            graf = Graphics.FromImage(rob.bitmap);


        }

        private void AutoModeTimer_Tick(object? sender, EventArgs e)
        {


            if (responseDict.Count == 0) return;

            int F = 100;
            int B = 0;

            //if (autoModeCheck.Checked)
            //{
            //    if (responseDict["d7"] < 150 && responseDict["d0"] > 100)
            //    {
            //        B = -20;
            //    }
            //    else if (responseDict["d0"] > 100) B = 20;
            //    else B = 0;

            //    if (responseDict["b"] == 1) { F = 0; B = 0; console.Log("Робот столкнулся"); autoWallCheck.Checked = false; }

            //    udp?.TrySendCommand(F, B, 0);
            //}

            if (autoWallCheck.Checked)
            {
                if (responseDict["d0"] > 50) F = 100;
                if (responseDict["d0"] < 50 && responseDict["d0"] > 15) F = 20; B = 0;
                if (responseDict["d0"] <= 15) F = 0; B = 0;

                if (responseDict["d1"] < 100 && responseDict["d0"] > 50)
                {
                    B = 20;
                }
                else if (responseDict["d0"] > 50) B = -20;
                B = responseDict["d7"] < 100 && responseDict["d0"] > 50 ? -20 : responseDict["d0"] > 50 ? 20 : 0;
                udp?.TrySendCommand(F, B, 0);
            }

            if (checkBox1.Checked || autoModeCheck.Checked)
            {
                if (responseDict["b"] == 1 || responseDict["d0"] < 20)
                {
                    F = -100;
                    B = -50;
                }
                else if (responseDict["d7"] < 100 && responseDict["d0"] < 20)
                {
                    F = 0;
                    B = -50;
                }
                else if (responseDict["d7"] < 100 && responseDict["d0"] > 20)
                {
                    F = 100;
                    B = -40;
                }
                else if (responseDict["d7"] > 100 && responseDict["d0"] > 30)
                {
                    F = 100;
                    B = 40;
                }

                udp?.TrySendCommand(F, B, 0);
            }

            if (autoModeLine.Checked)
            {
                if (rob is null)
                {
                    rob = new Robot();
                }

                rob.UpdatePos(responseDict["le"], responseDict["re"]);
                float koef = 2.8f;
                rob.Draw(new List<float>() {
                    responseDict["d0"]/koef,
                    responseDict["d1"]/koef,
                    responseDict["d2"]/koef,
                    responseDict["d3"]/koef,
                    responseDict["d4"]/koef,
                    responseDict["d5"]/koef,
                    responseDict["d6"]/koef,
                    responseDict["d7"]/koef, });

                rob.SavePositionAndRects();

                pictureBox1.Image = rob.bitmap;
                label23.Text = rob.position.X.ToString();
                label24.Text = rob.position.Y.ToString();
                label25.Text = rob.orientation.ToString();

                if (count < 30)
                {
                    udp?.TrySendCommand(50, -35, 0);
                    count++;
                    return;
                }
                else if (responseDict["c"] == 0 && count < 32)
                {
                    udp?.TrySendCommand(100, 0, 0);
                    return;
                }
                else if (count < 70)
                {
                    udp?.TrySendCommand(50, 75, 0);
                    count++;
                    return;
                }

                if (responseDict["l4"] == 0 && responseDict["l3"] == 0)
                {
                    udp?.TrySendCommand(80, 0, 0);
                    return;
                }
                else if (responseDict["l4"] == 100 && responseDict["l3"] == 0)
                {
                    udp?.TrySendCommand(80, 50, 0);
                    return;
                }
                else if (responseDict["l4"] == 0 && responseDict["l3"] == 100)
                {
                    udp?.TrySendCommand(80, -50, 0);
                    return;
                }
                else if (responseDict["l2"] == 0 && responseDict["l1"] == 0)
                {
                    udp?.TrySendCommand(80, 0, 0);
                    return;
                }
                else if (responseDict["l2"] == 100 && responseDict["l1"] == 0)
                {
                    udp?.TrySendCommand(80, 10, 0);
                    return;
                }
                else if (responseDict["l2"] == 0 && responseDict["l1"] == 100)
                {
                    udp?.TrySendCommand(80, -10, 0);
                    return;
                }
                else
                {
                    udp?.TrySendCommand(80, 0, 0);
                    return;
                }
            }
        }

        private void ReceivedAndTranslateRefreshTimer_Tick(object? sender, EventArgs e)
        {
            try
            {
                if (udp is not null)
                {
                    string res = udp.NewReceivedMessage;
                    string trans = udp.NewTranslatedMessage;

                    if (res.Length != 0)
                    {
                        ResBox.Items.Insert(0, res);
                        udp.NewReceivedMessage = "";
                        responseDict = TryToParseDictionary(jsonToDictionary(res!));
                        DictionaryToTextBoxs(responseDict);
                    }
                    if (trans.Length != 0) { TransBox.Items.Insert(0, trans); udp.NewTranslatedMessage = ""; }
                }
            }
            catch { }
        }

        private Dictionary<string, int> TryToParseDictionary(Dictionary<string, string> dictionary)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                dict.Add(pair.Key, int.Parse(pair.Value));
            }

            dictionary = new Dictionary<string, string>();
            return dict;
        }

        private void DictionaryToTextBoxs(Dictionary<string, int> responseDict)
        {
            lEnc.Text = responseDict["le"].ToString();
            rEnc.Text = responseDict["re"].ToString();
            bump.Text = responseDict["b"].ToString();
            d0.Text = responseDict["d0"].ToString();
            d1.Text = responseDict["d1"].ToString();
            d2.Text = responseDict["d2"].ToString();
            d3.Text = responseDict["d3"].ToString();
            d4.Text = responseDict["d4"].ToString();
            d5.Text = responseDict["d5"].ToString();
            d6.Text = responseDict["d6"].ToString();
            d7.Text = responseDict["d7"].ToString();
        }
#nullable disable
        private Dictionary<string, string> jsonToDictionary(string res)
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(res);
        }
#nullable restore
        private void startServerBut_Click(object sender, EventArgs e)
        {
            if (udp is not null) return;
            udp = new UdpHelper(IPAddress.Parse(ipBox.Text), (int)serverPort.Value, (int)clientPort.Value);

            console.Log("Сервер успешно запущен");
            udp.StartRecievingMessage();
        }

        private void sendBut_Click(object sender, EventArgs e)
        {
            if (udp is null) return;
            udp.TrySendCommand((int)fNum.Value, (int)bNum.Value, 0);
        }

        private void closeServerBut_Click(object sender, EventArgs e)
        {
            if (udp is null) return;
            udp.Dispose();
            udp = null;
            console.Log("Сервер выключен");
        }

        private void autoModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) DisableAllCheksExeptOne(checks, (CheckBox)sender);
        }

        private void DisableAllCheksExeptOne(CheckBox[] checks, CheckBox checkBox)
        {
            foreach (CheckBox check in checks)
            {
                if (!check.Equals(checkBox)) check.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            udp?.TrySendCommand(0, 0, 0);
        }
    }
}