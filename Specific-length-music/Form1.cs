﻿/*/////////////////////////////
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
        List<CPlaylist> selection = new List<CPlaylist>();
        List<CPlaylist> playlist_true = new List<CPlaylist>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Play(ref List<CPlaylist> list)
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
                playlist_true = selection;
            }
        }

        private void selectionToTB_List(/*ref*/ List<CPlaylist> list)
        {
            string s_playlist = "";
            foreach (CPlaylist song in list)
            {
                s_playlist += TimeSpan.FromMilliseconds(song.duration).ToString(@"hh\:mm\:ss") + "\t";
                s_playlist += song.name + "\r\n";

            }
            TB_Liste.Text = s_playlist;
        }

        private double GetListDuration(ref List<CPlaylist> list)
        {
            double totalTimeDuration = 0;
            foreach (CPlaylist song in list)
            {
                totalTimeDuration += song.duration;
            }
            return totalTimeDuration;
        }

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

        private List<CPlaylist> generate(List<CPlaylist> list, double duration, int iteration)
        {
            List<CPlaylist> playlist_best = null;
            double tempsResiduel_min = duration + 1;

            for (int i=0; i<iteration;i++)
            {
                List<CPlaylist> tempo_list = new List<CPlaylist>();
                double tempsResiduel_temp = duration;

                list = shuffleList(list);

                for (int k = 0; k < list.Count(); k++)
                {
                    if(list[k].duration <= tempsResiduel_temp)
                    {
                        tempo_list.Add(list[k]);
                        tempsResiduel_temp -= list[k].duration;
                    }
                }

                if(tempsResiduel_temp < tempsResiduel_min)
                {
                    playlist_best = tempo_list;
                    tempsResiduel_min = tempsResiduel_temp;
                }
            }

            LB_label.Text = "Temps risiduel: " + TimeSpan.FromMilliseconds(tempsResiduel_min).ToString(/*@"hh\:mm\:ss"*/);

            return playlist_best;
        }

        ///////////////////////////////////////////////////////////////////
        ////////////////////////EVENT//////////////////////////////////////
        ///////////////////////////////////////////////////////////////////

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
                playlist_true = generate(selection, timeSpace, (int)NUD_iteration.Value);//On génère le tout
                selectionToTB_List(playlist_true); 

            }
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            Play(ref playlist_true);
        }
    }
}
