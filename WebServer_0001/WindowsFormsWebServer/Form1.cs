using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWebServer.Model;

namespace WindowsFormsWebServer
{

    public partial class Form1 : Form
    {
        static string uri = "http://jsonplaceholder.typicode.com";
        WebRequest request = WebRequest.Create(uri);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_cep.Text))
            {
                _ = getAllInfo(txtBox_cep.Text);

            }
        }

        public async Task getAllInfo(string id)
        {
            string url = string.Format(uri + "/posts/{0}", id);

            var req = WebRequest.CreateHttp(url);
            req.Method = "GET";
            req.UserAgent = "url";

            using (var response = req.GetResponse())
            {
                Stream strDates = response.GetResponseStream();
                StreamReader strReader = new StreamReader(strDates);
                object objResponse = strReader.ReadToEnd();

                Post post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());

                txtBoxResponse.Text = objResponse.ToString();
                strReader.Close();
                response.Close();
            }
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            string lineOk = null;
            lineOk += string.IsNullOrEmpty(txtBoxUserId.Text)   ? "\nPlease, enter the User Id" : null;
            lineOk += string.IsNullOrEmpty(txtBoxTitle.Text)    ? "\nPlease, enter the Title"   : null;
            lineOk += string.IsNullOrEmpty(txtBoxBoby.Text)     ? "\nPlease, enter the Body"    : null;

            if (lineOk != null && lineOk != "") {
                MessageBox.Show(lineOk);
            }
            else
            {
                _ = sendRequest(new Post(Convert.ToInt32(txtBoxUserId.Text), txtBoxTitle.Text, txtBoxBoby.Text));
            }

        }

        public async Task sendRequest(Post date)
        {
            string param = string.Format("title={0}&body={1}&userId={2}", date.title, date.body, date.userId) ;
            var dt = Encoding.UTF8.GetBytes(param);
            string url = uri + "/posts/";

            var req = WebRequest.CreateHttp(url);
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = dt.Length;
            req.Method = "POST";
            req.UserAgent = "url";

            try
            {
                using (var stream = req.GetRequestStream())
                {
                    stream.Write(dt, 0 , dt.Length);
                    stream.Close();
                }

                using (var response =  req.GetResponse())
                {
                    Stream strDates = response.GetResponseStream();
                    StreamReader strReader = new StreamReader(strDates);
                    object objResponse = strReader.ReadToEnd();
                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                    txtBoxResponse.Text = objResponse.ToString();
                    strDates.Close();
                    response.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
