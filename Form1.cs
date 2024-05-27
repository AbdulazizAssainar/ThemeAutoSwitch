using System;
using System.Windows.Forms;

namespace GridThemeAutoSwitch
{
    public partial class Form1 : Form
    {
        private bool isLightTheme = false;
        private bool isLightRowHeaderTheme = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridViewTheme(isLightTheme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isLightTheme = !isLightTheme;
            UpdateDataGridViewTheme(isLightTheme);
        }

        private void UpdateDataGridViewTheme(bool isLight)
        {
            Style.UpdateTheme(this, isLight);
        }
    }
}
