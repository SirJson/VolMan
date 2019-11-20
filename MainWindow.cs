using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Diagnostics;

namespace VolControl
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void controlBnt_Click(object sender, EventArgs e)
        {
            var answer = WriteMessage("CHKVOL");
            if (int.TryParse(ParseAnswer(answer)[1], out var vol))
            {
                volumeBar.Value = vol;
                volumeBar.Enabled = true;
                ipBox.Enabled = false;
                controlBnt.Enabled = false;
            }
            else
            {
                _ = MessageBox.Show($"Failed to parse answer: {answer}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string[] ParseAnswer(string input)
        {
            if(input == "ERR")
            {
                return new string[] { input, input };
            }
            else
            {
                return input.Split(';');
            }
        }

        private string WriteMessage(string message)
        {
            var responseData = string.Empty;
            try
            {
                var port = 5055;
                var client = new TcpClient(ipBox.Text, port);
                var data = System.Text.Encoding.ASCII.GetBytes(message);
                var stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Debug.WriteLine($"Sent: {message}");
                data = new byte[1024];
                var bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Debug.WriteLine($"Received: {responseData}");
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException ae)
            {
                _ = MessageBox.Show($"ArgumentNullException: {ae}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException se)
            {
                _ = MessageBox.Show($"SocketException: {se}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return responseData;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"Volume should now be: {volumeBar.Value}");
            var answer = WriteMessage($"VOL;{volumeBar.Value}");
            if (int.TryParse(ParseAnswer(answer)[1], out var vol))
            {
                volumeBar.Value = vol;
            }
            else
            {
                _ = MessageBox.Show($"Failed to parse answer: {answer}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
