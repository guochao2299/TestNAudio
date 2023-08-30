using NAudio.Wave;

namespace TestNAudio
{
    public partial class frmMain : Form
    {
        private WaveOutEvent m_outputDevice;
        private AudioFileReader m_audioFile;
        private bool m_close = false;

        public frmMain()
        {
            InitializeComponent();

            m_outputDevice = new WaveOutEvent();
            m_outputDevice.PlaybackStopped += OnPlaybackStopped;
            m_waveInEvent = new WaveInEvent();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if(!m_close)
            {
                return;
            }

            m_outputDevice.Dispose();
            m_outputDevice = null;
            m_audioFile.Dispose();
            m_audioFile = null;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtsoundfile.Text = openFileDialog.FileName;
            }
        }

        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(m_audioFile != null)
            {
                m_audioFile.Dispose();
            }

            m_close = false;
            m_audioFile = new AudioFileReader(txtsoundfile.Text);
            m_outputDevice.Init(m_audioFile);
            m_outputDevice.Play();            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(m_outputDevice.PlaybackState== PlaybackState.Paused)
            {
                m_outputDevice.Play();
                btnPause.Text = "ÔÝ  Í£";
            }
            else
            {
                m_outputDevice.Pause();
                btnPause.Text = "¼Ì  Ðø";
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_close = true;
            m_outputDevice.Stop();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private WaveInEvent m_waveInEvent;
        private WaveFileWriter m_waveFileWriter;
        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            m_waveFileWriter = new WaveFileWriter(Path.Combine(txtOutputDir.Text, String.Format("{0}.wav", txtOutputFileName.Text)), m_waveInEvent.WaveFormat);
            m_waveInEvent.DataAvailable += (s, a) =>
            {
                m_waveFileWriter.Write(a.Buffer, 0, a.BytesRecorded);
                if (m_waveFileWriter.Position > m_waveInEvent.WaveFormat.AverageBytesPerSecond * 30)
                {
                    m_waveInEvent.StopRecording();
                }
            };
            m_waveInEvent.StartRecording();
        }

        private void btnEndRecord_Click(object sender, EventArgs e)
        {
            m_waveInEvent.StopRecording();
            m_waveFileWriter.Flush();
            //m_waveFileWriter.Dispose();
            //m_waveInEvent.Dispose();
        }
    }
}