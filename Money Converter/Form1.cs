using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Converter
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=1+tl+ka%C3%A7+dolar&sca_esv=cba130dcaf9ed102&sxsrf=ACQVn09zl59hk9V4MFatv0bTZtJjtH1Z7w%3A1710801581315&ei=rcL4ZYLxEp-Di-gPtMuVwAo&oq=1+tl+&gs_lp=Egxnd3Mtd2l6LXNlcnAiBTEgdGwgKgIIADIIEAAYgAQYywEyCBAAGIAEGMsBMggQABiABBjLATIIEAAYgAQYywEyCBAAGIAEGMsBMggQABiABBjLATIIEAAYgAQYywEyCBAAGIAEGMsBMggQABiABBjLATIIEAAYgAQYywFI2BlQsQRY8xNwBXgBkAEAmAGXAaAB1QeqAQMwLje4AQPIAQD4AQGYAgygAowIqAISwgIKEAAYRxjWBBiwA8ICBxAjGOoCGCfCAhQQABiABBjjBBjpBBjqAhi0AtgBAcICBBAjGCfCAgoQIxiABBiKBRgnwgILEAAYgAQYigUYkQLCAgUQABiABMICCxAuGIAEGMcBGNEDwgIKEAAYgAQYigUYQ8ICChAAGIAEGBQYhwLCAgcQABiABBgKwgIGEAAYFhgemAMKiAYBkAYIugYGCAEQARgBkgcDNS43oAf_Kg&sclient=gws-wiz-serp");
        }
    }
}
