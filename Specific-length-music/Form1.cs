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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specific_length_music
{
    public partial class Form1 : Form
    {
        const string VLC_Path = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        int vital = 182;
        List<CPlaylist> selection = new List<CPlaylist>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Play(List<CPlaylist> list)
        {
            string s_playlist = "";
            foreach (CPlaylist song in list)
            {
                s_playlist += " \"" + song.path + "\"";
            }
            Process.Start(VLC_Path, s_playlist);
        }

        private void FilesToList()
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                String[] l_files = OFD.FileNames;
                foreach (String path in l_files)
                {
                    selection.Add(new CPlaylist(Path.GetFileName(path), path));
                }
                selectionToTB_List(selection);
            }
        }

        private void selectionToTB_List(List<CPlaylist> list)
        {
            string s_playlist = "";
            foreach (CPlaylist song in list)
            {
                s_playlist += TimeSpan.FromMilliseconds(song.duration).ToString(@"hh\:mm\:ss") + "\t";
                s_playlist += song.name + "\r\n";
                //s_playlist += " \"" + song.path + "\"";
                //totalTime += song.duration;
            }
            TB_Liste.Text = s_playlist;
        }

        /// <summary>
        /// Generate 
        /// l'algorytme au coeur de l'attribution des musique selon un temps donné
        /// </summary>
        private List<CPlaylist> shuffleList(List<CPlaylist> list)
        {
            //Shuffle
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                CPlaylist value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        private List<CPlaylist> generate(List<CPlaylist> list, double d)
        {
            list = shuffleList(list);
            List<CPlaylist> playlist = new List<CPlaylist>();

            return list;
        }

        private void BTN_FilesSelector_Click(object sender, EventArgs e)
        {
            FilesToList();

            //Play(selection);
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            //selectionToTB_List();
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            //Get le temps voulu
            double timeSpace = 0; //Milliseconde total
            timeSpace = (double)NUD_H.Value * 3600000;
            timeSpace += (double)NUD_M.Value * 60000;
            timeSpace += (double)NUD_S.Value * 1000;

            double totalTimeDuration = 0;
            foreach (CPlaylist song in selection)
            {
                totalTimeDuration += song.duration;
            }

            if (timeSpace <= 0)
                MessageBox.Show("La période de temps à combler doit être suppérieur à 0");
            else if (timeSpace > totalTimeDuration) // si pas assez de musique pour combler le temps
                MessageBox.Show("Pas assez de musique sélectionn pour comblé la périod voulu");
            else
            {
                selectionToTB_List( generate(selection, timeSpace)); //On génère le tout

            }
        }
    }
}
