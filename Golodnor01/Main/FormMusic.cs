using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace Golodnor01
{
    public partial class FormMusic : Form
    {
        public FormMusic()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void ChangeVolume(AxWMPLib.AxWindowsMediaPlayer ax)
        {
            if (trackBarMusic.Value == 0)
            {
                ax.Ctlcontrols.pause();
                
            }
            else
            {
                ax.Ctlcontrols.play();
                ax.settings.volume = trackBarMusic.Value;
            }
        }

        private void FormMusic_Load(object sender, EventArgs e)
        {
            // Apply font
            buttonOk.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);

            this.Location = new Point((int)SystemParameters.PrimaryScreenWidth/2 + 183, 
                (int)SystemParameters.PrimaryScreenHeight/2 - 319);
        }

        private void trackBarMusic_Scroll(object sender, EventArgs e)
        {
            // Check which track is playing
            if (GlobalVars.isIntroPlaying)
            {
                ChangeVolume(axIntro);
            }
            else if (GlobalVars.is1Playing)
            {
                ChangeVolume(axLevel1);
            }
            else if (GlobalVars.is2Playing)
            {
                ChangeVolume(axLevel2);
            }
            else if (GlobalVars.is3Playing)
            {
                ChangeVolume(axLevel3);
            }
            else
            {
                ChangeVolume(axLevel4);
            }
        }
    }
}
