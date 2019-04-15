using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace AlgoProject_SoundsPacking_
{
    public partial class mainForm : Form
    {
        Point lastLoc;
        List<Audio> audiosList;
        public mainForm()
        {
            InitializeComponent();
        }
        private void generateAudios_Click(object sender, EventArgs e)
        {
            if (checkFolderSec(audiosList, Convert.ToInt32(secPerFolderLbl.Text)))
            {
                Thread t1 = new Thread(() =>
                    worstFitLinear(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                Thread t2 = new Thread(() =>
                    worstFitPriorityQueue(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                Thread t3 = new Thread(() =>
                    worstFitDecreasingLinear(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                Thread t4 = new Thread(() =>
                    worstFitDecreasingPriorityQueue(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                Thread t5 = new Thread(() =>
                    firstFitDecreasingLinear(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                Thread t6 = new Thread(() =>
                    folderFilling(audiosOutTxt.Text, Convert.ToInt32(secPerFolderLbl.Text), audiosTxt.Text, audiosList));
                
                t1.Start(); 
                t2.Start(); 
                t3.Start(); 
                t4.Start(); 
                t5.Start(); 
                t6.Start();

                generateAudios.Enabled = false;
                closeBtn.Enabled = false;
            }
            else
                MessageBox.Show("The folder size is too small to fit one audio file.", "Folder Size Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private List<Audio> getAudioDetails(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            List<Audio> audios = new List<Audio>();
            try
            {
                int numOfAudios = Convert.ToInt32(sr.ReadLine());
                Audio audio;
                while (sr.Peek() != -1)
                {

                    string audioDetailsLine = sr.ReadLine();
                    string[] audioDetails = audioDetailsLine.Split(' ');
                    string[] audioSecs = audioDetails[1].Split(':');
                    int totalSecs = (Convert.ToInt32(audioSecs[0]) * 60 * 60) + (Convert.ToInt32(audioSecs[1]) * 60) +
                        Convert.ToInt32(audioSecs[2]);

                    audio = new Audio();
                    audio.name = audioDetails[0];
                    audio.secDuration = totalSecs;
                    audios.Add(audio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read the selected file. \n" + ex.Message.ToString()+"\nPlease select the AudiosInfo.txt file",
                    "Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close();
            }

            return audios;
        }

        private void addFolder(ref List<Folder> foldersList, Audio audioFile)
        {
            Folder folder = new Folder();
            folder.name = 'F' + (foldersList.Count + 1).ToString();
            folder.secDuration += audioFile.secDuration;
            folder.audiosList.Add(audioFile);
            foldersList.Add(folder);
        }
        private void addFolder(ref PriorityQueue<Folder> foldersQueue, Audio audioFile)
        {
            Folder folder = new Folder();
            folder.name = 'F' + (foldersQueue.Count() + 1).ToString();
            folder.secDuration += audioFile.secDuration;
            folder.audiosList.Add(audioFile);
            foldersQueue.Enqueue(folder);
        }
        private void addFolder(ref List<Folder> foldersList, List<Audio> audiosList)
        {
            Folder folder = new Folder();
            folder.name = 'F' + (foldersList.Count() + 1).ToString();

            for (int i = 0; i < audiosList.Count; i++)
                folder.secDuration += audiosList[i].secDuration;

            folder.audiosList = audiosList;
            foldersList.Add(folder);
        }

        private void writeData(string mainFolderName, string outputPath, string inputPath, List<Folder> foldersList)
        {
            outputPath += mainFolderName + '\\';
            for (int i = 0; i < foldersList.Count; i++)
            {
                if (!Directory.Exists(outputPath + foldersList[i].name))
                    Directory.CreateDirectory(outputPath + foldersList[i].name);
                if (!File.Exists(outputPath + foldersList[i].name + "_METADATA.txt"))
                {
                    FileStream fs = new FileStream(outputPath + foldersList[i].name + "_METADATA.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(foldersList[i].name);

                    long allTime = 0;
                    for (int k = 0; k < foldersList[i].audiosList.Count; k++)
                    {
                        if (!File.Exists(outputPath + foldersList[i].name + "\\" + foldersList[i].audiosList[k].name))
                        {
                            File.Copy(inputPath + foldersList[i].audiosList[k].name,
                                    outputPath + foldersList[i].name + "\\" + foldersList[i].audiosList[k].name);

                            sw.WriteLine(foldersList[i].audiosList[k].name + " " +
                                TimeSpan.FromSeconds(foldersList[i].audiosList[k].secDuration).ToString());
                            allTime += foldersList[i].audiosList[k].secDuration;
                        }
                    }

                    sw.WriteLine(TimeSpan.FromSeconds(allTime).ToString());

                    sw.Close();
                }
            }
        }

        private bool checkAudioFiles(string audiosPath, List<Audio> audiosList)
        {
            if (audiosList.Count == 0)
                return false;

            foreach (Audio item in audiosList)
            {
                if (!File.Exists(audiosPath + item.name))
                    return false;
            }

            return true;
        }

        private void worstFitLinear(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            wfls.Text = "Running...";
            sw.Start();
            List<Folder> foldersList = new List<Folder>();

            for (int i = 0; i < audiosList.Count; i++) //O(N*M)
            {
                if (i == 0)
                    addFolder(ref foldersList, audiosList[i]); //O(1)
                else
                {
                    int miniINDEX = 0; //O(1)
                    for (int k = 1; k < foldersList.Count; k++) //O(M)
                        if (foldersList[k].secDuration < foldersList[miniINDEX].secDuration) //O(1)
                            miniINDEX = k; //O(1)

                    if (foldersList[miniINDEX].secDuration + audiosList[i].secDuration <= outputSecsFolder) //O(1)
                    {
                        foldersList[miniINDEX].secDuration += audiosList[i].secDuration; //O(1)
                        foldersList[miniINDEX].audiosList.Add(audiosList[i]); //O(1)
                    }
                    else
                        addFolder(ref foldersList, audiosList[i]); //O(1)
                }
            }
            writeData("[1]Worst-Fit Using Linear Search", outputPath, inputPath, foldersList);
            sw.Stop();
            wfls.Text = sw.Elapsed.ToString();
        }

        private void worstFitPriorityQueue(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            wfpq.Text = "Running...";
            sw.Start();
            PriorityQueue<Folder> foldersQueue = new PriorityQueue<Folder>();
            for (int i = 0; i < audiosList.Count; i++) //O(N*LOG(M))
            {
                if (i == 0)
                    addFolder(ref foldersQueue, audiosList[i]); //O(LOG(M))
                else
                {
                    if (foldersQueue.Peek().secDuration + audiosList[i].secDuration <= outputSecsFolder) //O(1)
                    {
                        foldersQueue.Peek().secDuration += audiosList[i].secDuration; //O(1)
                        foldersQueue.Peek().audiosList.Add(audiosList[i]); //O(1)
                        Folder temp = foldersQueue.Dequeue(); //O(LOG(M))
                        foldersQueue.Enqueue(temp); //O(LOG(M))
                    }
                    else
                        addFolder(ref foldersQueue, audiosList[i]); //O(LOG(M))
                }
            }
            List<Folder> foldersList = foldersQueue.ToList();
            writeData("[2]Worst-Fit Using Priority Queue", outputPath, inputPath, foldersList);
            sw.Stop();
            wfpq.Text = sw.Elapsed.ToString();
        }

        private void worstFitDecreasingLinear(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            wfdls.Text = "Running...";
            sw.Start();
            audiosList = audiosList.OrderByDescending(d => d.secDuration).ToList(); //O(N*LOG(N)) OR O(N^2)
            List<Folder> foldersList = new List<Folder>();

            for (int i = 0; i < audiosList.Count; i++) //O(N*M)
            {
                if (i == 0)
                    addFolder(ref foldersList, audiosList[i]); //O(1)
                else
                {
                    int miniINDEX = 0; //O(1)
                    for (int k = 1; k < foldersList.Count; k++) //O(M)
                        if (foldersList[k].secDuration < foldersList[miniINDEX].secDuration) //O(1)
                            miniINDEX = k; //O(1)

                    if (foldersList[miniINDEX].secDuration + audiosList[i].secDuration <= outputSecsFolder) //O(1)
                    {
                        foldersList[miniINDEX].secDuration += audiosList[i].secDuration; //O(1)
                        foldersList[miniINDEX].audiosList.Add(audiosList[i]); //O(1)
                    }
                    else
                        addFolder(ref foldersList, audiosList[i]); //O(1)
                }
            }
            writeData("[3]Worst-Fit Decreasing Using Linear Search", outputPath, inputPath, foldersList);
            sw.Stop();
            wfdls.Text = sw.Elapsed.ToString();
        }

        private void worstFitDecreasingPriorityQueue(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            wfdpq.Text = "Running...";
            sw.Start();
            audiosList = audiosList.OrderByDescending(d => d.secDuration).ToList(); //O(N*LOG(N))
            PriorityQueue<Folder> foldersQueue = new PriorityQueue<Folder>();

            for (int i = 0; i < audiosList.Count; i++) //O(N*LOG(M))
            {
                if (i == 0)
                    addFolder(ref foldersQueue, audiosList[i]); //O(LOG(M))
                else
                {
                    if (foldersQueue.Peek().secDuration + audiosList[i].secDuration <= outputSecsFolder) //O(1)
                    {
                        foldersQueue.Peek().secDuration += audiosList[i].secDuration; //O(1)
                        foldersQueue.Peek().audiosList.Add(audiosList[i]); //O(1)
                        Folder temp = foldersQueue.Dequeue(); //O(LOG(M))
                        foldersQueue.Enqueue(temp); //O(LOG(M))
                    }
                    else
                        addFolder(ref foldersQueue, audiosList[i]); //O(LOG(M))
                }
            }
            List<Folder> foldersList = foldersQueue.ToList();
            writeData("[4]Worst-Fit Decreasing Using Priority Queue", outputPath, inputPath, foldersList);
            sw.Stop();
            wfdpq.Text = sw.Elapsed.ToString();
        }

        private void firstFitDecreasingLinear(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            ffdls.Text = "Running...";
            sw.Start();
            audiosList = audiosList.OrderByDescending(d => d.secDuration).ToList(); //O(N*LOG(N)) OR O(N^2)
            List<Folder> foldersList = new List<Folder>();

            for (int i = 0; i < audiosList.Count; i++) //O(N*M)
            {
                if (i == 0)
                    addFolder(ref foldersList, audiosList[i]); //O(1)
                else
                {
                    bool flag = false; //O(1)
                    for (int k = 0; k < foldersList.Count; k++) //O(M)
                    {
                        if (foldersList[k].secDuration + audiosList[i].secDuration <= outputSecsFolder) //O(1)
                        {
                            foldersList[k].secDuration += audiosList[i].secDuration; //O(1)
                            foldersList[k].audiosList.Add(audiosList[i]); //O(1)
                            flag = true; //O(1)
                            break;
                        }
                    }
                    if (!flag)
                        addFolder(ref foldersList, audiosList[i]); //O(1)
                }

            }
            writeData("[5]First-Fit Decreasing Using Linear Search", outputPath, inputPath, foldersList);
            sw.Stop();
            ffdls.Text = sw.Elapsed.ToString();
        }

        private List<Audio> knapsack(int Weight, List<Audio> audiosList)
        {
            int n = audiosList.Count;
            int[,] k = new int[n + 1, Weight + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Weight; j++)
                {
                    if (i == 0 || j == 0)
                        k[i, j] = 0;
                    else if (audiosList[i - 1].secDuration <= j)
                        k[i, j] = Math.Max(audiosList[i - 1].secDuration + k[(i - 1), (j - audiosList[i - 1].secDuration)],
                            k[i - 1, j]);
                    else
                        k[i, j] = k[i - 1, j];
                }
            }

            int w = Weight;
            int res = k[n, Weight];
            List<Audio> temp = new List<Audio>();
            for (int m = audiosList.Count; m > 0 && res > 0; m--)
            {
                if (res == k[m - 1, w])
                    continue;
                else
                {
                    temp.Add(audiosList[m - 1]);
                    res -= audiosList[m - 1].secDuration;
                    w -= audiosList[m - 1].secDuration;
                }
            }

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = audiosList.Count - 1; j >= 0; j--)
                {
                    if (audiosList[j] == temp[i])
                    {
                        audiosList.RemoveAt(j);
                        break;
                    }
                }
            }

            return temp;
        }

        private void folderFilling(string outputPath, int outputSecsFolder, string inputPath, List<Audio> audiosList)
        {
            Stopwatch sw = new Stopwatch();
            ff.Text = "Running...";
            sw.Start();
            List<Folder> foldersList = new List<Folder>();

            while (audiosList.Count > 0)
                addFolder(ref foldersList, knapsack(outputSecsFolder, audiosList));

            writeData("[6]Folder Filling", outputPath, inputPath, foldersList);
            sw.Stop();
            ff.Text = sw.Elapsed.ToString();
        }

        private bool checkFolderSec(List<Audio> audiosList, long folderSec)
        {
            for (int i = 0; i < audiosList.Count; i++)
                if (audiosList[i].secDuration > folderSec)
                    return false;
            return true;
        }

        private void genTimer_Tick(object sender, EventArgs e)
        {
            if ((wfls.Text != "" && wfls.Text != "Running...") &&
                (wfpq.Text != "" && wfpq.Text != "Running...") &&
                (wfdls.Text != "" && wfdls.Text != "Running...") &&
                (wfdpq.Text != "" && wfdpq.Text != "Running...") &&
                (ffdls.Text != "" && ffdls.Text != "Running...") &&
                (ff.Text != "" && ff.Text != "Running..."))
            {
                generateAudios.Enabled = true;
                closeBtn.Enabled = true;
            }
        }

        #region GUI Events
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.DimGray;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.Firebrick;
        }

        private void audiosBtn_MouseEnter(object sender, EventArgs e)
        {
            audiosBtn.ForeColor = Color.Black;
        }

        private void audiosBtn_MouseLeave(object sender, EventArgs e)
        {
            audiosBtn.ForeColor = Color.DimGray;
        }

        private void textBtn_MouseEnter(object sender, EventArgs e)
        {
            textBtn.ForeColor = Color.Black;
        }

        private void textBtn_MouseLeave(object sender, EventArgs e)
        {
            textBtn.ForeColor = Color.DimGray;
        }

        private void controlLbl_MouseDown(object sender, MouseEventArgs e)
        {
            lastLoc = e.Location;
        }

        private void controlLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y);
            }
        }

        private void generateAudios_MouseEnter(object sender, EventArgs e)
        {
            generateAudios.ForeColor = Color.Firebrick;
        }

        private void generateAudios_MouseLeave(object sender, EventArgs e)
        {
            generateAudios.ForeColor = Color.DimGray;
        }

        private void miniBtn_MouseEnter(object sender, EventArgs e)
        {
            miniBtn.ForeColor = Color.Firebrick;
        }

        private void miniBtn_MouseLeave(object sender, EventArgs e)
        {
            miniBtn.ForeColor = Color.DimGray;
        }

        private void audiosTxt_TextChanged(object sender, EventArgs e)
        {
            if (audiosTxt.Text != "Please select the folder contain audio files" &&
                textTxt.Text != "Please select the text file contain audio files details" &&
                audiosOutTxt.Text != "Please select the folder to generate audio files" &&
                timePerFolderTxt.MaskCompleted)
                generateAudios.Enabled = true;

            else
            {
                generateAudios.Enabled = false;
                wfls.Text = "";
                wfpq.Text = "";
                wfdls.Text = "";
                wfdpq.Text = "";
                ffdls.Text = "";
                ff.Text = "";
            }

            textTxt.Text = "Please select the text file contain audio files details";
        }

        private void textTxt_TextChanged(object sender, EventArgs e)
        {
            if (textTxt.Text != "Please select the text file contain audio files details")
            {
                audiosList = getAudioDetails(textTxt.Text);
                if (audiosList.Count != 0)
                {
                    if (!checkAudioFiles(audiosTxt.Text, audiosList))
                    {
                        DialogResult res = MessageBox.Show("The folder does not contain the audio files.",
                            "Loading Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        audiosList.Clear();
                        if (res == DialogResult.Retry)
                        {
                            textTxt.Text = "Please select the text file contain audio files details";
                            audiosFolderBrowser.ShowNewFolderButton = false;
                            audiosFolderBrowser.ShowDialog();
                            if (audiosFolderBrowser.SelectedPath.ToString() != "")
                            {
                                audiosTxt.Text = audiosFolderBrowser.SelectedPath.ToString() + '\\';
                            }
                        }
                        else
                            textTxt.Text = "Please select the text file contain audio files details";
                    }
                    else
                        MessageBox.Show("File open successfully and stored the audio files details.", "File Open",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (audiosTxt.Text != "Please select the folder contain audio files" &&
                textTxt.Text != "Please select the text file contain audio files details" &&
                audiosOutTxt.Text != "Please select the folder to generate audio files" &&
                timePerFolderTxt.MaskCompleted)
                generateAudios.Enabled = true;
            else
            {
                generateAudios.Enabled = false;
                wfls.Text = "";
                wfpq.Text = "";
                wfdls.Text = "";
                wfdpq.Text = "";
                ffdls.Text = "";
                ff.Text = "";
            }
        }

        private void audiosOutTxt_TextChanged(object sender, EventArgs e)
        {
            if (audiosTxt.Text != "Please select the folder contain audio files" &&
                textTxt.Text != "Please select the text file contain audio files details" &&
                audiosOutTxt.Text != "Please select the folder to generate audio files" &&
                timePerFolderTxt.MaskCompleted)
                generateAudios.Enabled = true;
            else
            {
                generateAudios.Enabled = false;
                wfls.Text = "";
                wfpq.Text = "";
                wfdls.Text = "";
                wfdpq.Text = "";
                ffdls.Text = "";
                ff.Text = "";
            }
        }

        private void timePerFolderTxt_TextChanged(object sender, EventArgs e)
        {
            if (timePerFolderTxt.MaskCompleted)
            {
                string[] time = timePerFolderTxt.Text.Split(':');
                long totalSecs = (Convert.ToInt32(time[0]) * 60 * 60) + (Convert.ToInt32(time[1]) * 60) +
                        Convert.ToInt32(time[2]);
                secPerFolderLbl.Text = totalSecs.ToString();
            }
            else
                secPerFolderLbl.Text = "0";

            if (audiosTxt.Text != "Please select the folder contain audio files" &&
                textTxt.Text != "Please select the text file contain audio files details" &&
                audiosOutTxt.Text != "Please select the folder to generate audio files" &&
                timePerFolderTxt.MaskCompleted)
                generateAudios.Enabled = true;
            else
            {
                generateAudios.Enabled = false;
                wfls.Text = "";
                wfpq.Text = "";
                wfdls.Text = "";
                wfdpq.Text = "";
                ffdls.Text = "";
                ff.Text = "";
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void audiosBtn_Click(object sender, EventArgs e)
        {
            audiosFolderBrowser.ShowNewFolderButton = false;
            audiosFolderBrowser.ShowDialog();
            if (audiosFolderBrowser.SelectedPath.ToString() != "")
            {
                audiosTxt.Text = audiosFolderBrowser.SelectedPath.ToString() + '\\';
            }
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            if (audiosTxt.Text != "Please select the folder contain audio files")
            {
                textFileBrowser.FileName = "";
                textFileBrowser.ShowDialog();
                if (textFileBrowser.FileName.ToString() != "")
                {
                    textTxt.Text = textFileBrowser.FileName.ToString();
                }
                else
                    textTxt.Text = "Please select the text file contain audio files details";
            }
            else
                MessageBox.Show("Please select the audios folder first.", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void audiosOutBtn_Click(object sender, EventArgs e)
        {
            audiosFolderBrowser.ShowNewFolderButton = true;
            audiosFolderBrowser.ShowDialog();
            if (audiosFolderBrowser.SelectedPath.ToString() != "")
                audiosOutTxt.Text = audiosFolderBrowser.SelectedPath.ToString() + '\\';
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void audiosOutBtn_MouseEnter(object sender, EventArgs e)
        {
            audiosOutBtn.ForeColor = Color.Black;
        }

        private void audiosOutBtn_MouseLeave(object sender, EventArgs e)
        {
            audiosOutBtn.ForeColor = Color.DimGray;
        }
        #endregion
    }
}
