using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTclientPautova
{
    public partial class cmdGo : Form
    {
        public cmdGo()
        {
            InitializeComponent();
        }

        private void TxtResponse_TextChanged(object sender, EventArgs e)
        {

        }
        
        #region UI Event Handlers

        private void Button1_Click(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = txtRestURL.Text;
            debugOutput("RESTClient Object created.");

            string strJSON = string.Empty;

            strJSON = rClient.makeRequest();

            debugOutput(strJSON);
        }

        #endregion
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
