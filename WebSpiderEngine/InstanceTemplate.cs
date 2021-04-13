using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WebSpiderEngine
{
    // this is for a instance that requires keep refreshing data to make sure that the data is always new,
    // can be used as a monitor or you name it.
    public partial class InstanceTemplate : Form
    {
        private static string pattern = "";
        private static string url = "";
        private static int count = 0;
        private static int hitkey = 1;
        private static string data = "";
        private static Engine engine = new Engine();
        Thread threadref = new Thread(TUpdate);
        public InstanceTemplate(string Pattern, string Url, int Count, int HitKey)
        {
            InitializeComponent();
            pattern = Pattern;
            url = Url;
            count = Count;
            hitkey = HitKey;
        }
        public static void TUpdate()
        {
            // initalize
            Request r = engine.Requests.Get(url);
            string[] match = engine.Re.Find(pattern, r.Text(), count);
            data = match[hitkey];
            //data processing

            //end
            //logging

            //gc
            GC.Collect();
            Thread.Sleep(2000);
        }
    }
}
