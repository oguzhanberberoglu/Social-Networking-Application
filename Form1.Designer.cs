namespace CS408_Project_Clients
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_friend_name = new System.Windows.Forms.TextBox();
            this.button_be_friend = new System.Windows.Forms.Button();
            this.button_invitiation = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_current = new System.Windows.Forms.Button();
            this.user_list = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_current_friend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2_private_message = new System.Windows.Forms.TextBox();
            this.send_private = new System.Windows.Forms.Button();
            this.checkedListBox2_current_friend = new System.Windows.Forms.CheckedListBox();
            this.button1_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(127, 235);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(83, 31);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Location = new System.Drawing.Point(216, 235);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(104, 29);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(127, 129);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(193, 22);
            this.textBox_port.TabIndex = 4;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(127, 80);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(193, 22);
            this.textBox_ip.TabIndex = 5;
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_ip_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(127, 181);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(193, 22);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(650, 36);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(346, 181);
            this.logs.TabIndex = 8;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(371, 80);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(230, 102);
            this.textBox_message.TabIndex = 9;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(371, 188);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(107, 29);
            this.button_send.TabIndex = 10;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name of User";
            // 
            // textBox_friend_name
            // 
            this.textBox_friend_name.Location = new System.Drawing.Point(113, 498);
            this.textBox_friend_name.Name = "textBox_friend_name";
            this.textBox_friend_name.Size = new System.Drawing.Size(126, 22);
            this.textBox_friend_name.TabIndex = 12;
            // 
            // button_be_friend
            // 
            this.button_be_friend.Location = new System.Drawing.Point(113, 526);
            this.button_be_friend.Name = "button_be_friend";
            this.button_be_friend.Size = new System.Drawing.Size(126, 23);
            this.button_be_friend.TabIndex = 13;
            this.button_be_friend.Text = "Be Friend";
            this.button_be_friend.UseVisualStyleBackColor = true;
            this.button_be_friend.Click += new System.EventHandler(this.button_be_friend_Click);
            // 
            // button_invitiation
            // 
            this.button_invitiation.Location = new System.Drawing.Point(371, 230);
            this.button_invitiation.Name = "button_invitiation";
            this.button_invitiation.Size = new System.Drawing.Size(119, 38);
            this.button_invitiation.TabIndex = 14;
            this.button_invitiation.Text = "Get Invitation";
            this.button_invitiation.UseVisualStyleBackColor = true;
            this.button_invitiation.Click += new System.EventHandler(this.button_invitiation_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(371, 386);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(90, 37);
            this.button_accept.TabIndex = 15;
            this.button_accept.Text = "Accept";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_reject
            // 
            this.button_reject.Location = new System.Drawing.Point(483, 386);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(88, 37);
            this.button_reject.TabIndex = 16;
            this.button_reject.Text = "Reject";
            this.button_reject.UseVisualStyleBackColor = true;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(371, 274);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 106);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button_current
            // 
            this.button_current.Location = new System.Drawing.Point(650, 405);
            this.button_current.Name = "button_current";
            this.button_current.Size = new System.Drawing.Size(125, 32);
            this.button_current.TabIndex = 18;
            this.button_current.Text = "Current Friends";
            this.button_current.UseVisualStyleBackColor = true;
            this.button_current.Click += new System.EventHandler(this.button_current_Click);
            // 
            // user_list
            // 
            this.user_list.Location = new System.Drawing.Point(15, 302);
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(224, 190);
            this.user_list.TabIndex = 21;
            this.user_list.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Send Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Incoming Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Private Texting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Name of Your Friend";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_current_friend
            // 
            this.textBox_current_friend.Location = new System.Drawing.Point(423, 455);
            this.textBox_current_friend.Name = "textBox_current_friend";
            this.textBox_current_friend.Size = new System.Drawing.Size(129, 22);
            this.textBox_current_friend.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Your Message";
            // 
            // textBox2_private_message
            // 
            this.textBox2_private_message.Location = new System.Drawing.Point(423, 483);
            this.textBox2_private_message.Multiline = true;
            this.textBox2_private_message.Name = "textBox2_private_message";
            this.textBox2_private_message.Size = new System.Drawing.Size(193, 68);
            this.textBox2_private_message.TabIndex = 28;
            // 
            // send_private
            // 
            this.send_private.Location = new System.Drawing.Point(423, 557);
            this.send_private.Name = "send_private";
            this.send_private.Size = new System.Drawing.Size(114, 23);
            this.send_private.TabIndex = 29;
            this.send_private.Text = "Send Private";
            this.send_private.UseVisualStyleBackColor = true;
            this.send_private.Click += new System.EventHandler(this.send_private_Click);
            // 
            // checkedListBox2_current_friend
            // 
            this.checkedListBox2_current_friend.FormattingEnabled = true;
            this.checkedListBox2_current_friend.Location = new System.Drawing.Point(650, 274);
            this.checkedListBox2_current_friend.Name = "checkedListBox2_current_friend";
            this.checkedListBox2_current_friend.Size = new System.Drawing.Size(270, 123);
            this.checkedListBox2_current_friend.TabIndex = 30;
            // 
            // button1_remove
            // 
            this.button1_remove.Location = new System.Drawing.Point(802, 405);
            this.button1_remove.Name = "button1_remove";
            this.button1_remove.Size = new System.Drawing.Size(118, 32);
            this.button1_remove.TabIndex = 31;
            this.button1_remove.Text = "Remove";
            this.button1_remove.UseVisualStyleBackColor = true;
            this.button1_remove.Click += new System.EventHandler(this.button1_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 583);
            this.Controls.Add(this.button1_remove);
            this.Controls.Add(this.checkedListBox2_current_friend);
            this.Controls.Add(this.send_private);
            this.Controls.Add(this.textBox2_private_message);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_current_friend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.button_current);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.button_invitiation);
            this.Controls.Add(this.button_be_friend);
            this.Controls.Add(this.textBox_friend_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_friend_name;
        private System.Windows.Forms.Button button_be_friend;
        private System.Windows.Forms.Button button_invitiation;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_reject;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button_current;
        private System.Windows.Forms.RichTextBox user_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_current_friend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2_private_message;
        private System.Windows.Forms.Button send_private;
        private System.Windows.Forms.CheckedListBox checkedListBox2_current_friend;
        private System.Windows.Forms.Button button1_remove;
    }
}

