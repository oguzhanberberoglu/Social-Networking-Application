using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS408_Project_Clients
{
    public partial class Form1 : Form
    {
        static string filePath = @"C:\Users\asus\Downloads\user_db.txt";
        string[] ClientList = System.IO.File.ReadAllLines(filePath);
        bool terminating = false;
        bool connected = false;
        Socket clientSocket;
        string[] arr;
        int count = 0;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }
        
        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox_ip.Text;

            int portNum;
            if (Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    string nameMessage = textBox_name.Text;
                    if (nameMessage != "")
                        clientSocket.Connect(IP, portNum);
                    if (nameMessage.Length <= 128&&nameMessage !="")
                    {
                        Byte[] buffer = new Byte[128];
                        buffer = Encoding.Default.GetBytes(nameMessage);
                        clientSocket.Send(buffer);
                    }
                    if (nameMessage != "")
                    {
                        connected = true;
                        button_disconnect.Enabled = true;
                        button_connect.Enabled = false;
                        Thread receiveThread = new Thread(Receive);
                        receiveThread.Start();
                       for(int i=0;i<300;i++)
                        {
                            user_list.AppendText(ClientList[i] + "\n");
                        }
                    }

                }
                catch
                {
                    logs.AppendText("Could not connect to the server!\n");
                    button_disconnect.Enabled = false;
                    button_connect.Enabled = true;
                    user_list.Clear();
                }
            }
            else
            {
                logs.AppendText("Check the port\n");
                button_disconnect.Enabled = false;
                button_connect.Enabled = true;
            }

        }

        private void Receive()
        {
            while (connected && clientSocket.Connected) // try to delete bool
            {
                try
                {
                    Byte[] buffer = new Byte[128];
                    clientSocket.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    string[] split = incomingMessage.Split(' ');
                    if (incomingMessage != ""&&split[0]=="invitiation")
                    {
                        checkedListBox1.Items.Add(split[1]+" "+split[2]);
                        int index = checkedListBox1.Items.IndexOf(split[1] + " " + split[2]);
                        checkedListBox1.SetItemChecked(index,false);
                    }
                    else if (incomingMessage != ""&& split[0] =="current")
                    {
                        checkedListBox2_current_friend.Items.Add(split[1] + " " + split[2]);
                        int index = checkedListBox2_current_friend.Items.IndexOf(split[1] + " " + split[2]);
                        checkedListBox2_current_friend.SetItemChecked(index, false);
                    }
                    
                    else if (incomingMessage != "")
                    {
                        logs.AppendText(incomingMessage + "\n");
                    }
                   
                    
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected\n");

                    }
                    clientSocket.Close();
                    connected = false;
                }
                if (!clientSocket.Connected)
                {
                    connected = false;
                    clientSocket.Close();
                }
            }
            
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            string name = textBox_name.Text;
            logs.AppendText("Me: "+message+"\n");
            try
            {
                if (message != "" && message.Length <= 128&&name !=" ")
                {
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name + " : " + message);
                    clientSocket.Send(buffer);
                }
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
            
        }
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            connected = false;
            button_disconnect.Enabled = false;
            button_connect.Enabled = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox_message_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_be_friend_Click(object sender, EventArgs e)
        {
            string friend_name = textBox_friend_name.Text;
            string name = textBox_name.Text;
            try
            {
                if (friend_name != "" && friend_name.Length <= 128)
                {
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name+" : "+"befriend"+" "+friend_name);
                    clientSocket.Send(buffer);
                }
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }

        private void button_invitiation_Click(object sender, EventArgs e)//get invitation
        {
            string name = textBox_name.Text;
            checkedListBox1.Items.Clear();
            if (connected && clientSocket.Connected) // try to delete bool
            {
                try
                {
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name + " : " + "invitiation");
                    clientSocket.Send(buffer);
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected\n");

                    }
                    clientSocket.Close();
                    connected = false;
                }
                if (!clientSocket.Connected)
                {
                    connected = false;
                    clientSocket.Close();
                }
            }
        }

        private void button_accept_Click(object sender, EventArgs e)//accept
        {
            string name = textBox_name.Text;
            string message_accept = "Accept";
            try
            {
                string tmp = "";
                foreach (var item in checkedListBox1.SelectedItems)
                {
                    tmp=checkedListBox1.GetItemText(item);
                    tmp = tmp.Replace("\n",String.Empty);
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name + " : " + message_accept +" "+tmp);
                    int x = checkedListBox1.SelectedItems.IndexOf(item);
                    checkedListBox1.Items.RemoveAt(x);
                    clientSocket.Send(buffer);
                    if (checkedListBox1.SelectedItems.Count == 0)
                        break;           
                }
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_reject_Click(object sender, EventArgs e)//reject
        {
            string name = textBox_name.Text;
            string message_reject = "Reject";
            try
            {
                string tmp = "";
                foreach (var item in checkedListBox1.SelectedItems)
                {
                    tmp = checkedListBox1.GetItemText(item);
                    tmp = tmp.Replace("\n", String.Empty);
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name + " : " + message_reject + " " + tmp);
                    clientSocket.Send(buffer);
                    int x=checkedListBox1.SelectedItems.IndexOf(item);
                    checkedListBox1.Items.RemoveAt(x);
                    if (checkedListBox1.SelectedItems.Count == 0)
                        break;
                }
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }

        private void button_current_Click(object sender, EventArgs e)//show current friend
        {
            string name = textBox_name.Text;
            checkedListBox2_current_friend.Items.Clear();
            try
            {
                Byte[] buffer = new Byte[128];
                buffer = Encoding.Default.GetBytes(name + " : " + "current");
                clientSocket.Send(buffer);
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void send_private_Click(object sender, EventArgs e)//send private message
        {
            string name = textBox_name.Text;
            string current_friend = textBox_current_friend.Text;
            string message = textBox2_private_message.Text;
            try
            {
                Byte[] buffer = new Byte[128];
                buffer = Encoding.Default.GetBytes(name + " : " + "private" +" "+current_friend+" "+message);
                clientSocket.Send(buffer);
                logs.AppendText("Private with " + current_friend + ":\n" + "Me: " + message+"\n");
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }

        private void button1_remove_Click(object sender, EventArgs e)//remove friend
        {
            string name = textBox_name.Text;
            string message_remove = "Remove";
            try
            {
                string tmp = "";
                foreach (var item in checkedListBox2_current_friend.SelectedItems)
                {
                    tmp = checkedListBox2_current_friend.GetItemText(item);
                    tmp = tmp.Replace("\n", String.Empty);
                    Byte[] buffer = new Byte[128];
                    buffer = Encoding.Default.GetBytes(name + " : " + message_remove + " " + tmp);
                    int x = checkedListBox2_current_friend.SelectedItems.IndexOf(item);
                    checkedListBox2_current_friend.Items.RemoveAt(x);
                    clientSocket.Send(buffer);
                    if (checkedListBox2_current_friend.SelectedItems.Count == 0)
                        break;
                }
            }
            catch
            {
                if (!terminating)
                {
                    logs.AppendText("\nThe server has disconnected\n");

                }
                clientSocket.Close();
                connected = false;
            }
        }
    }
}
