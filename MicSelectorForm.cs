using System;
using System.Windows.Forms;

namespace MicMute
{
    public partial class MicSelectorForm : Form
    {
        public MicSelectorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MicSelectorForm_Shown(object sender, EventArgs e)
        {
        }

        private void MicSelectorForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string deviceId { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
