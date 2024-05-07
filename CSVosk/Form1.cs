namespace CSVosk
{

    using NAudio.Wave;
    using Newtonsoft.Json;
    using Vosk;

    public partial class Form1 : Form
    {
        private VoskRecognizer recognizer;
        private WaveInEvent waveIn;

        public Form1()
        {
            InitializeComponent();
            InitializeVosk();
        }
        private void InitializeVosk()
        {
            Vosk.SetLogLevel(0); // Set log level to warning only
            Model model = new Model(".\\models\\vosk-model-ja-0.22");
            //Model model = new Model(".\\models\\vosk-model-small-ja-0.22");
            recognizer = new VoskRecognizer(model, 16000);
        }

        private void startStopButton1_Click(object sender, EventArgs e)
        {
            if (waveIn == null)
            {
                waveIn = new WaveInEvent();
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                waveIn.DataAvailable += WaveIn_DataAvailable;
                waveIn.StartRecording();
                startStopButton1.Text = "Stop";
            }
            else
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
                startStopButton1.Text = "Start";
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
            {
                UpdateResultTextBox(recognizer.Result());
            }
            else
            {
                UpdatePartialResultTextBox(recognizer.PartialResult());
            }
        }
        //{"text":"

        private void UpdateResultTextBox(string text)
        {
            Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
            try
            {
                string valueText = values["text"]; //.Replace(" ","");
                if (valueText != "")
                {

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            resultTextBox1.Text += valueText + "\r\n";
                            resultTextBox1.SelectionStart = resultTextBox1.Text.Length;
                            resultTextBox1.ScrollToCaret();
                        }));
                    }
                    else
                    {
                        resultTextBox1.Text += valueText + "\r\n";
                        resultTextBox1.SelectionStart = resultTextBox1.Text.Length;
                        resultTextBox1.ScrollToCaret();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }



        private void UpdatePartialResultTextBox(string text)
        {
            Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);

            try
            {
                string valueText = values["partial"];//.Replace(" ","");
                if (valueText != "")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            sttTextBox1.Text = valueText + "\r\n";
                            sttTextBox1.SelectionStart = sttTextBox1.Text.Length;
                            sttTextBox1.ScrollToCaret();
                        }));
                    }
                    else
                    {
                        sttTextBox1.Text = valueText + "\r\n";
                        sttTextBox1.SelectionStart = sttTextBox1.Text.Length;
                        sttTextBox1.ScrollToCaret();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            sttTextBox1.Text = "";
            resultTextBox1.Text = "";
        }
    }
}