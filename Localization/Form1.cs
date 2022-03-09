using Localization.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Localization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string language = Settings.Default.Language;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "tr";
            Settings.Default.Save();
            Application.Restart();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "en";
            Settings.Default.Save();
            Application.Restart();
        }
    }
}
