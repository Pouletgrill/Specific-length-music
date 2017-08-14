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
    chaque dossier selectionner ou fishier serait ajouter a une liste a chaque 
    confirmation de dialog (on peut selectionner plusieur dossier l'un après l'autre)
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
        const string VLC_Path = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        List<CPlaylist> selection = new List<CPlaylist>();
        List<CPlaylist> playlist = new List<CPlaylist>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Play(List<CPlaylist> list)
        {
            string s_playlist="";
            double totalTime=0;
            foreach(CPlaylist song in playlist)
            {
                s_playlist += " \"" +song.path + "\"";
                totalTime += song.duration;
            }

            Process.Start(VLC_Path, s_playlist);
            /*TimeSpan durationTotal = TimeSpan.FromMilliseconds(totalTime);
            MessageBox.Show(durationTotal.ToString());*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Foldermusic = @"C:\Users\utilisateur\Music\iTunes\iTunes Media\Music\Pink Floyd\Animals\";
            string song2 = "02 Dogs.m4a";
            string song1 = "04 Sheep.m4a";
            //Process.Start(VLC_Path, " \"" + song1+"\"" + " \"" + song2 + "\"");
            playlist.Add(new CPlaylist(song1, Foldermusic + song1));
            playlist.Add(new CPlaylist(song2, Foldermusic + song2));
            playlist.Add(new CPlaylist(song1, Foldermusic + song1));
            playlist.Add(new CPlaylist(song2, Foldermusic + song2));
            Play(playlist);
        }

    }
}
