using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNAudio
{
    public partial class frmMusicPlayer : Form
    {
        private WaveOutEvent m_outputDevice;
        private AudioFileReader m_audioFile;
        private bool m_close = false;

        public frmMusicPlayer()
        {
            InitializeComponent();

            m_outputDevice = new WaveOutEvent();
            this.DoubleBuffered = true;
        }

        ~frmMusicPlayer()
        {
            m_outputDevice.Dispose();
            m_outputDevice = null;

            if(m_audioFile != null)
            {
                m_audioFile.Dispose();
                m_audioFile = null;
            }
        }

        private void btnAddDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Add2Playlist(Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.mp3"));
            }
        }

        private void Add2Playlist(string[] fileNames)
        {
            if(fileNames==null || fileNames.Length<=0)
            {
                return;
            }

            foreach (string file in fileNames)
            {
                using(TagLib.File tagFile = TagLib.File.Create(file))
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(lstMusicFiles.Items.Count + 1));
                    item.SubItems.Add(Path.GetFileNameWithoutExtension(tagFile.Name));
                    item.SubItems.Add(tagFile.Properties.Duration.ToString(@"hh\:mm\:ss"));
                    item.SubItems.Add(tagFile.Tag.FirstPerformer);
                    item.SubItems.Add(tagFile.Tag.Album);
                    
                    item.Tag = file;
                    lstMusicFiles.Items.Add(item);
                }
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "mp3|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Add2Playlist(openFileDialog.FileNames);                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstMusicFiles.Items.Clear();
            GC.Collect();
        }

        private void lstMusicFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMusicFiles.SelectedItems.Count>0)
            {
                string totalTime = lstMusicFiles.SelectedItems[0].SubItems[2].Text;
                lblTime.Text = totalTime;
                tbTime.Maximum = Convert.ToInt32(TimeSpan.Parse(totalTime).TotalSeconds);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstMusicFiles.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请在播放列表中选择要播放的音乐文件");
                return;
            }
            
            if (m_audioFile != null)
            {
                m_audioFile.Dispose();
                m_audioFile = null;
            }

            timer1.Start();

            m_close = false;
            m_audioFile = new AudioFileReader(Convert.ToString(lstMusicFiles.SelectedItems[0].Tag));
            m_outputDevice.Init(m_audioFile);
            m_outputDevice.Play();            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (m_outputDevice.PlaybackState == PlaybackState.Paused)
            {
                m_outputDevice.Play();
                btnPause.Text = "暂  停";
            }
            else
            {
                m_outputDevice.Pause();
                btnPause.Text = "继  续";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_close = true;
            m_outputDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbTime.Value = Convert.ToInt32(m_audioFile.CurrentTime.TotalSeconds);
            lblTime.Text = m_audioFile.CurrentTime.ToString(@"hh\:mm\:ss");

            if (m_outputDevice.PlaybackState == PlaybackState.Stopped)
            {
                timer1.Stop();
                return;
            }
        }
    }
}
