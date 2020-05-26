using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quispe.Fernando
{
    public partial class FrmVideos : Form
    {
        public FrmVideos()
        {
            InitializeComponent();
        }
        private void wmpVideos_Enter(object sender, EventArgs e)
        {
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.wmpVideos.Ctlcontrols.stop();
            this.Close();
        }

        /// <summary>
        /// se muestran los videos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBabyShark_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
        }
        private void btnPeppaPig_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/Silbar.mp4";
        }
        private void btnToyStory_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";
        }

        private void FrmVideos_Load(object sender, EventArgs e)
        {

        }
    }
}
