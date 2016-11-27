using System;
using System.Collections;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security.Principal;
using System.Net;
using System.IO;


// Source code designed by Alireza shirazi
// www.ShiraziOnline.net
// year 2007
// This source code is absolutely FREE ! Do whatever you want to do with it ;)



namespace GetHardwareInfo
{
    public partial class frmMain : Form
    {

        Process NewProcess = new Process();
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        int sec = 0;
        //////////
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);
        public frmMain()
        {
            NewProcess.StartInfo.UseShellExecute = false;
            NewProcess.StartInfo.CreateNoWindow = true;
            NewProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            InitializeComponent();
            cmbxOption.SelectedItem = "Win32_Processor";
            cmbxMemory.SelectedItem = "Win32_MemoryDevice";


        }
        //ส่วนของ WiFi *
        public bool isUerAdmin()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.AccountOperator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
        public void StopBroadcasting()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    SetWlanDetail();

                }
            }
            catch
            {

            }
        }
        public void SetWlanDetail()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan set hostednetwork mode=allow ssid=" + textBox5.Text + " key=" + textBox6.Text;
            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    StartBroadcasting();
                }
            }
            catch
            {

            }
        }
        public void StartBroadcasting()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan start hostednetwork";
            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    button10.Text = "Stop";
                }
            }
            catch
            {

            }
        }
        public void StopProcess()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                }
            }
            catch
            {

            }
        }
        //

        private void InsertInfo(string Key, ref ListView lst, bool DontInsertNull)
        {
            lst.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);

            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;
                    try
                    {
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.WhiteSmoke;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No Information available");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }
                }
            }


            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void RemoveNullValue(ref ListView lst)
        {
            foreach (ListViewItem item in lst.Items)
                if (item.SubItems[1].Text == "No Information available")
                    item.Remove();
        }


        #region Control events ...

        private void cmbxMemory_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertInfo(cmbxMemory.SelectedItem.ToString(), ref lstMemory, chkMemory.Checked);
        }

        private void chkHardware_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHardware.Checked)
                RemoveNullValue(ref lstDisplayHardware);
            else
                InsertInfo(cmbxOption.SelectedItem.ToString(), ref lstDisplayHardware, chkHardware.Checked);
        }

        private void cmbxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertInfo(cmbxOption.SelectedItem.ToString(), ref lstDisplayHardware, chkHardware.Checked);
        }

        private void chkMemory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMemory.Checked)
                RemoveNullValue(ref lstMemory);

        }
        #endregion

       
        // shutdown count time
        private void button1_Click(object sender, EventArgs e)
        {
            string u = this.textBox1.Text;
            string x = this.textBox2.Text;
            string y = this.textBox3.Text;
            int a = int.Parse(u);
            int b = int.Parse(x);
            int c = int.Parse(y);
            int sum = (c * 60) + (b * 60 * 60) + (a * 60 * 60 * 24);
            String count = "The computer will shut down in " + a + " Day " + b + " hour " + c + " minute";

            //ส่งline
            var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
            var postData = string.Format("message={0}", count);
            var data = Encoding.UTF8.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.Headers.Add("Authorization", "Bearer ykUnW8ZdWnjzAomkqViGZQlkmJBFHxUG1TPEgTLRgOs");

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //
            System.Diagnostics.Process.Start("shutdown", "/s /t " + sum);
            MessageBox.Show("set time turn off the computer Complete.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
            String cancel = "Cancel shutdown your PC";
            var postData = string.Format("message={0}", cancel);
            var data = Encoding.UTF8.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.Headers.Add("Authorization", "Bearer ykUnW8ZdWnjzAomkqViGZQlkmJBFHxUG1TPEgTLRgOs");

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            System.Diagnostics.Process.Start("shutdown", "-a");
            MessageBox.Show("Cancel set time turn off the computer Complete.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        //process
        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            Process p = Process.Start(text);
            loadProcessList();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadProcessList();
        }
        private void loadProcessList()
        {
            listView1.Items.Clear();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.ProcessName);
                item.Tag = process;
                listView1.Items.Add(item);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Process process = (Process)item.Tag;
            process.Kill();
            loadProcessList();
        }

        //volume up down mute
        private void button6_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        //Eject ถาด CD
        private void button9_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }

        //WiFi
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "Start WiFi")
            {
                StopBroadcasting();
                button10.Text = "Stop";
            }
            else
            {
                StopProcess();
                button10.Text = "Start WiFi";
            }
        }

        //ไม่ได้ใช้
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void lstStorage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstDisplayHardware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //

    }
}