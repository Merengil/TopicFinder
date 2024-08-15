using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TopicFinder
{
    public partial class TopicFinderMain : Form
    {
        const string FILENAME = "listTopics.txt";
        List<string> listTopics = new List<string>();

        public TopicFinderMain()
        {
            InitializeComponent();
            listTopics = LoadTopicsFromFile();
        }

        private List<string> LoadTopicsFromFile()
        {
            if (!File.Exists(FILENAME))
                using (FileStream fs = File.Create(FILENAME))
                    using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Weather");
                    sw.WriteLine("Gaming");
                }

            string line = "";
            using (StreamReader reader = new StreamReader(FILENAME))
                while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                    listTopics.Add(line);

            return listTopics;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            topicIntro.Text = "Your next topic is:";
            topicText.Text = listTopics[rd.Next(listTopics.Count)];
        }
    }
}
