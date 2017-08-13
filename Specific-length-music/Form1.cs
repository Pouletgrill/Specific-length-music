/*/////////////////////////////
Specific Length Music selector
Par Xavier Brosseau
///////////////////////////////
Description: On entre une periode de temps a combler en musique et l'app essai
De remplir cette espace pile avec le plus de musique possible et randomiser le tout

///////////////////////////////
todo:
- Faire une classe avec titre(string) et path(string) et duration en milisecond
- L'algorythme au complet du créateur de playlist
- Un FileDialog pour choisir la musique a utiliser 
- Un Sous-menu pour choisir l'emplacement de l'exécutable de VLC
*//////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specific_length_music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string VLC_Path = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
            string Foldermusic = @"C:\Users\utilisateur\Music\iTunes\iTunes Media\Music\Pink Floyd\Animals\";
            string song2 = Foldermusic + "02 Dogs.m4a";
            string song1 = Foldermusic + "04 Sheep.m4a";
            /////////////////////////////////////////////////////
            //Comment créer une playlist VLC
            Process.Start(VLC_Path, " \"" + song1+"\"" + " \"" + song2 + "\"");
            /////////////////////////////////////////////////////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Foldermusic = @"C:\Users\utilisateur\Music\iTunes\iTunes Media\Music\Pink Floyd\Animals\";
            string song2 = Foldermusic + "02 Dogs.m4a";
            string song1 = Foldermusic + "04 Sheep.m4a";
            /////////////////////////////////////////////////////
            //Comment get la durée d'une chanson
            TagLib.File file = TagLib.File.Create(song1);
            var duration = file.Properties.Duration.TotalMilliseconds;
            MessageBox.Show("duration " + duration);
            /////////////////////////////////////////////////////
        }
    }
}
